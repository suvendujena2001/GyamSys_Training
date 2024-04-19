import React from 'react';
import { Link } from 'react-router-dom';
import backgroundImage from './reactP.jpg'; // Import the image file

function HomePage() {
  const divStyle = {
    backgroundImage: `url(${backgroundImage})`, // Set the background image
    backgroundSize: 'cover', // Ensure the image covers the entire background
    height: '100vh', // Set the height to full viewport height
    display: 'flex',
    flexDirection: 'column',
    justifyContent: 'center',
    alignItems: 'center',
    color: 'white', // Text color
    textAlign: 'center', // Center align the text
    backgroundColor: 'transparent', // Transparent background
    padding: '20px', // Add padding to the box
    borderRadius: '10px', // Add border radius for rounded corners
    boxShadow: '0 4px 8px rgba(0, 0, 0, 0.5)', // Add box shadow
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
