async function fetchDataWithAsyncAwait(url) {
  try {
    const response = await fetch(url);
    if (!response.ok) {
      throw new Error(`Failed to fetch data. Status code: ${response.status}`);
    }
    const data = await response.json();
    return data;
  } catch (error) {
    throw new Error(`Error: ${error.message}`);
  }
}


const apiUrlAsync = "https://jsonplaceholder.typicode.com/todos/1";
(async () => {
  try {
    const data = await fetchDataWithAsyncAwait(apiUrlAsync);
    console.log("Data:", data);
  } catch (error) {
    console.error("Error:", error.message);
  }
})();
