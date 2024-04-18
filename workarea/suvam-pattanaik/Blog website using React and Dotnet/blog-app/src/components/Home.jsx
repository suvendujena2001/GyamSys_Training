
// Home.js
import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import '../App.css'; // Import the CSS file for blog detail styling

function Home() {
  const [blogs, setBlogs] = useState([]);

  useEffect(() => {
    fetchBlogs();
  }, []);

  const fetchBlogs = async () => {
    try {
      const response = await fetch('http://localhost:5174/api/Blog');
      if (!response.ok) {
        throw new Error('Failed to fetch blogs');
      }
      const data = await response.json();
      setBlogs(data);
    } catch (error) {
      console.error('Error fetching blogs:', error);
    }
  };

  return (
    <div className="container">
      <h1>Home Page</h1>
      <div className="card-container">
        {blogs.map(blog => (
          <div key={blog.id} className="blog-card">
            <div className="card-body">
              <h3 className="blog-title">{blog.title}</h3>
              <div className="read-more-container">
                <Link to={`/blogs/${blog.id}`} className="read-more">Read More</Link>
              </div>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
}

export default Home;
