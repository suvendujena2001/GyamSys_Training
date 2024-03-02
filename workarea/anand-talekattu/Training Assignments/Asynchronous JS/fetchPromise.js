function fetchUsers(callback) {
    fetch("https://jsonplaceholder.typicode.com/users")
      .then(response => response.json())
      .then(data => callback(data))
      .catch(error => console.error("Error: ", error));
  }
  
function fetchUserDetails(userId, callback) {
    fetch(`https://jsonplaceholder.typicode.com/users/${userId}`)
      .then(response => response.json())
      .then(data => callback(data))
      .catch(error => console.error("Error: ", error));
  }
  
fetchUsers(users => {
    users.forEach(user => {
      fetchUserDetails(user.id, userDetails => {
        console.log(userDetails);
      });
    });
  });