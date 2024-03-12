async function fetchUsers() {
    try {
      const response = await fetch("https://jsonplaceholder.typicode.com/users");
      const data = await response.json();
      return data;
    } catch (error) {
      console.error("Error: ", error);
    }
  }
  
  async function fetchUserDetails(userId) {
    try {
      const response = await fetch(`https://jsonplaceholder.typicode.com/users/${userId}`);
      const data = await response.json();
      return data;
    } catch (error) {
      console.error("Error: ", error);
    }
  }
  
  async function main() {
    const users = await fetchUsers();
    users.forEach(user => {
      fetchUserDetails(user.id).then(userDetails => {
        console.log(userDetails);
      });
    });
  }
  
  main();