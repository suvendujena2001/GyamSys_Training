
// // Navbar.js
// import React from 'react';
// import { Link } from 'react-router-dom';

// function Navbar() {
//   return (
//   <nav className="navbar navbar-expand-lg navbar-light bg-light">
//     <div className="container">
//       <Link className="navbar-brand" to="/">My Blog Website....</Link>
//       <div className="collapse navbar-collapse" id="navbarNav">
//         <ul className="navbar-nav mr-auto">
//           <li className="nav-item">
//             <Link className="nav-link" to="/">Home</Link>
//           </li>
//           <li className="nav-item">
//             <Link className="nav-link" to="/blogs">Blogs</Link>
//           </li>
//         </ul>
//       </div>
//       <div className="d-flex align-items-center"> {/* Use flexbox to align items vertically */}
//         <Link className="btn btn-primary" to="/create">Create</Link>
//       </div>
//     </div>
//   </nav>
// );

// }

// export default Navbar;


import React from 'react';
import { Link } from 'react-router-dom';
import '../App.css'; // Import your custom CSS file

function Navbar() {
  return (
    <nav className="navbar navbar-expand-lg navbar-custom">
      <div className="container">
        <Link className="navbar-brand nav-link" to="/">My Blog Website....</Link>
        <div className="collapse navbar-collapse" id="navbarNav">
          <ul className="navbar-nav mr-auto">
            <li className="nav-item ">
              <Link className="nav-link nav-hover" to="/">Home</Link> {/* Add nav-hover class */}
            </li>
            <li className="nav-item ">
              <Link className="nav-link nav-hover" to="/blogs">Blogs</Link> {/* Add nav-hover class */}
            </li>
          </ul>
        </div>
        <div className="d-flex align-items-center"> {/* Use flexbox to align items vertically */}
          <Link className="btn btn-primary" to="/create">Create</Link>
        </div>
      </div>
    </nav>
  );
}

export default Navbar;
