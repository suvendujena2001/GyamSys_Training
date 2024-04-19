import React, { useEffect } from 'react';
import axios from 'axios';
import './App.css';
import NavBar from './Components/NavBar';
import Blog from './Components/Blog';
function App() {
  useEffect(() => {
    axios.get('http://localhost:5007/api/BlogsApi')
      .then(response => {
        console.log(response.data);
      })
      .catch(error => {
        console.error('Error fetching data:', error);
      });
  }, []);
 
  return (
    <>
    <NavBar />
    <Blog />
    </>
  );
}
 
export default App;