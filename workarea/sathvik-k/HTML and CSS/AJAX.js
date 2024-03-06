function fetchDataWithAjax(url, callback) {
  const xhr = new XMLHttpRequest();

  xhr.onreadystatechange = function () {
    if (xhr.readyState === 4) {
      if (xhr.status === 200) {
        const data = JSON.parse(xhr.responseText);
        callback(null, data);
      } else {
        callback(new Error(`Failed to fetch data. Status code: ${xhr.status}`));
      }
    }
  };

  xhr.open("GET", url, true);
  xhr.send();
}


const apiUrl = "https://jsonplaceholder.typicode.com/todos/1";
fetchDataWithAjax(apiUrl, (error, data) => {
  if (error) {
    console.error("Error:", error);
  } else {
    console.log("Data:", data);
  }
});
