
// BlogsPage.js
import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import '../App.css'; // Import the CSS file for blog detail styling
function BlogsPage() {
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
    <div className="container blogs-container">
      <h1>Blogs Page</h1>
      <div>
        {blogs.map(blog => (
          <div key={blog.id} className="blog-item">
            <h3 className="blog-title">{blog.title}</h3>
            <p className="blog-description">{blog.description}</p>
          </div>
        ))}
      </div>
    </div>
  );
}

export default BlogsPage;
