import React from 'react';
import { Link } from 'react-router-dom';
import backgroundImage from './reactP.jpg'; 

function HomePage() {
  const divStyle = {
    backgroundImage: `url(${backgroundImage})`, 
    backgroundSize: 'cover', 
    height: '100vh', 
    display: 'flex',
    flexDirection: 'column',
    justifyContent: 'center',
    alignItems: 'center',
    color: 'white', 
    textAlign: 'center', 
    backgroundColor: 'transparent', 
    padding: '20px', 
    borderRadius: '10px', 
    boxShadow: '0 4px 8px rgba(0, 0, 0, 0.5)', 
  };

  return (
    <div style={divStyle} className='Home'>
      <h1>Welcome to My Blog!</h1>
      <Link to="/blogs">Get in</Link>
      <p>Click here to access the content!</p>
    </div>
  );
}

export default HomePage;
