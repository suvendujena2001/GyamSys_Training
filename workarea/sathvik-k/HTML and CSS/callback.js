function fetchData(callback) {
  
  setTimeout(() => {
    const data = { message: "Data fetched successfully!" };
    callback(null, data); 
  }, 2000);
}


fetchData((error, data) => {
  if (error) {
    console.error("Error:", error);
  } else {
    console.log("Data:", data);
  }
});
