const express = require("express");
const nodemailer = require("nodemailer");
const sql = require("mssql");
const bodyParser = require("body-parser");
const cors = require("cors");

const app = express();
app.use(cors());
app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

// Email config
// const transporter = nodemailer.createTransport({
//   host: "smtp.gmail.com",
//   port: 587,
//   auth: {
//     user: "dev.ashwinalexander@gmail.com",
//     pass: "your_email_password_here",
//   },
// });

// Connection String
const pool = {
  user: "sa",
  password: "sa",
  server: "IN-7WF3NX3",
  database: "userdata",
  options: {
    encrypt: true,
    trustServerCertificate: true,
  },
};

//transporter.verify().then(console.log).catch(console.error);
app.get("/", (req, res) => {
  return res.json("From Backend Side");
});

async function executeSelect(query) {
  try {
    console.log(query);
    const poolConnection = await sql.connect(pool);
    console.log("Connected to SQL Server");

    const result = await poolConnection.request().query(query);
    console.log("Result : ", result.recordset);

    await poolConnection.close();
    console.log("Connection closed");
    return result.recordset;
  } catch (error) {
    console.error("Error:", error.message);
  }
}

async function executeQuery(query) {
  try {
    console.log(query);
    const poolConnection = await sql.connect(pool);
    console.log("Connected to SQL Server");

    const result = await poolConnection.request().query(query);
    console.log("Result : ", result.rowsAffected);

    await poolConnection.close();
    console.log("Connection closed");
    return { affectedRows: result.rowsAffected[0] };
  } catch (error) {
    console.error("Error:", error.message);
  }
}

app.get("/users", async (req, res) => {
  const result = await executeSelect("select * from users");
  console.log(result);
  return res.status(200).json(result);
});

app.post("/login", async (req, res) => {
  const { username, password } = req.body;

  try {
    const poolConnection = await sql.connect(pool);
    const request = poolConnection.request();

    request.input('username', sql.NVarChar, username);
    request.input('password', sql.NVarChar, password);

    const result = await request.query(`
      SELECT TOP 1 * FROM users WHERE username = @username AND password = @password
    `);

    await poolConnection.close();

    if (result.recordset.length > 0) {
      return res.status(200).json(result.recordset[0]);
    } else {
      return res.status(401).json({ error: "Invalid username or password" });
    }
  } catch (error) {
    console.error("Error:", error.message);
    return res.status(500).json({ error: "Internal server error" });
  }
});


app.post("/saveuser", async (req, res) => {
  const { username, email, password } = req.body;
  console.log(req.body);
  const result = await executeQuery(
    `insert into users (username, email, password, verify) values ('${username}', '${email}', '${password}', 0)`
  );
  return res.status(201).json(result);
});

app.post("/verifyuser", async (req, res) => {
  const { userid, username, email, password } = req.body;
  console.log(req.body);
  const result = await executeQuery(
    `Update users set verify = 1 where userid = ${userid}`
  );
  console.log(result);
  // if (result.affectedRows <= 0) {
  //   return res.json(result);
  // } else {
  //   const message = {
  //     from: "dev.ashwinalexander@gmail.com",
  //     to: email,
  //     subject: "Welcome to ABC Website!",
  //     html: `<b>Your Email is Verified !!! <br>username : ${username}<br>password : ${password}<br><a href='http://localhost:3000/login' target='_blank'> Login</a></br>`,
  //   };
  //   transporter
  //     .sendMail(message)
  //     .then((info) => {
  //       return res.status(201).json({
  //         msg: "Email sent",
  //         info: info.messageId,
  //         preview: nodemailer.getTestMessageUrl(info),
  //       });
  //     })
  //     .catch((err) => {
  //       return res.status(500).json({ msg: err });
  //     });
  // }
});

const PORT = process.env.PORT || 8081;
app.listen(PORT, () => {
  console.log(`Server is listening on port ${PORT}`);
});




//Appointment details

// Add appointment endpoint
const moment = require('moment');

app.post("/addappointment", async (req, res) => {
  const { name, datetime, acceptance } = req.body;
  const formattedDatetime = moment(datetime).format('YYYY-MM-DD HH:mm:ss'); // Format datetime string
  console.log(req.body);
  const result = await executeQuery(
    `INSERT INTO appointments (pname, appointmentDate, acceptance) VALUES ('${name}', '${formattedDatetime}','0')`
  );
  return res.status(201).json(result);
});


// Get appointments endpoint
app.get("/appointments", async (req, res) => {
  const result = await executeSelect("SELECT * FROM appointments");
  console.log(result);
  return res.status(200).json(result);
});

// Update appointment acceptance endpoint
app.post("/updateacceptance", async (req, res) => {
  const { id, acceptance } = req.body;
  console.log(req.body);
  const result = await executeQuery( 
    `UPDATE appointments SET acceptance = 1 WHERE id = ${id}`
  );
  console.log(result);
});