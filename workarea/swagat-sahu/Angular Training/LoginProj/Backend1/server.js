const express = require("express");
const nodemailer = require("nodemailer");
const sql = require("mssql");
var bodyParser = require("body-parser");
require("dotenv").config();
const cors = require("cors");

const app = express();
app.use(cors());

app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

//Connection String
const pool = {
  user: "sa",
  password: "sa",
  server: "IN-CVF3NX3",
  database: "userdata",
  options: {
    encrypt: true,
    trustServerCertificate: true,
  },
};

//Email config
let config = {
  host: "smtp.gmail.com",
  port: 587,
  auth: {
    user: "dev.ashwinalexander@gmail.com",
    pass: "fsqxginpqingrcnn",
  },
};

let transporter = nodemailer.createTransport(config);
transporter.verify().then(console.log).catch(console.error);

app.get("/", (re, res) => {
  return res.json("From BAckend Side");
});

async function executeSelect(query) {
  try {
    console.log(query);
    await sql.connect(pool);
    console.log("Connected to SQL Server");

    const result = await sql.query(query);
    console.log("Result : ", result);

    await sql.close();
    console.log("Connection closed");
    return result.recordsets[0];
  } catch (error) {
    console.error("Error:", error.message);
  }
}

async function executeQuery(query) {
  try {
    console.log(query);
    await sql.connect(pool);
    console.log("Connected to SQL Server");

    const result = await sql.query(query);
    console.log("Result : ", result);

    await sql.close();
    console.log("Connection closed");
    return { affectedRows: result.rowsAffected[0] };
  } catch (error) {
    console.error("Error:", error.message);
  }
}

app.get("/users", async (req, res) => {
  const result = await executeSelect("select * from users");
  return res.status(201).json(result);
});

app.post("/login", async (req, res) => {
  const username = req.body.username;
  const password = req.body.password;

  
  const result = await executeSelect(
    `SELECT TOP 1 * FROM users WHERE username = '${username}' AND password = '${password}'`
  );

  if (result.length > 0) {
    return res.status(200).json({ success: true, message: "Login successful", user: result[0] });
  } else {
    return res.status(401).json({ success: false, message: "Invalid username or password" });
  }
});


app.post("/saveuser", async (req, res) => {
  console.log(req.body);
  const result = await executeQuery(
    "insert into users (username,email,password,verify) values ('" +
      req.body.username +
      "','" +
      req.body.email +
      "','" +
      req.body.password +
      "',0);"
  );
  return res.status(201).json(result);
});

app.post("/verifyuser", async (req, res) => {
  console.log(req.body);
  const result = await executeQuery(
    "Update users set verify = 1 where userid = " + req.body.userid + ";"
  );
  console.log(result);
  if (result.affectedRows <= 0) {
    return res.json(result);
  } else {
    let message = {
      from: "dev.ashwinalexander@gmail.com",
      to: req.body.email,
      subject: "Welcome to ABC Website!",
      html:
        "<b>Your Email is Verified !!! <br>" +
        "username : " +
        req.body.username +
        "<br>password : " +
        req.body.password +
        "<br><a href='http://localhost:4200/login' target='_blank'> Login</a>" +
        " </br>",
    };
    transporter
      .sendMail(message)
      .then((info) => {
        return res.status(201).json({
          msg: "Email sent",
          info: info.messageId,
          preview: nodemailer.getTestMessageUrl(info),
        });
      })
      .catch((err) => {
        return res.status(500).json({ msg: err });
      });
  }
});

app.listen(8081, () => {
  console.log("listening");
});
