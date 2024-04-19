import React from 'react';
import { Link } from 'react-router-dom';

function NavBar() {
  return (
    <nav>
      <ul style={{ display: 'flex', gap: '20px' }}>
        <li>
          <Link to="/">Home</Link>
        </li>
        <li>
          <Link to="/blogs">Blogs</Link>
        </li>
        <li>
          <Link to="/create">Create a Blog</Link>
        </li>
      </ul>
    </nav>
  );
}

export default NavBar;
