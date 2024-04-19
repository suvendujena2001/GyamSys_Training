import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Link } from 'react-router-dom';

function BlogList() {
  const [blogs, setBlogs] = useState([]);

  useEffect(() => {
    fetchBlogs();
  }, []);

  const fetchBlogs = () => {
    axios.get('http://localhost:5291/api/Blogs')
      .then(response => {
        setBlogs(response.data);
      })
      .catch(error => {
        console.error('Error fetching blogs:', error);
      });
  };

  const handleDelete = (id) => {
    axios.delete(`http://localhost:5291/api/Blogs/${id}`)
      .then(response => {
        console.log('Blog deleted:', response.data);
        // Remove the deleted blog from the UI
        setBlogs(blogs.filter(blog => blog.id !== id));
      })
      .catch(error => {
        console.error('Error deleting blog:', error);
      });
  };

  return (
    <div>
      <h2>All Blogs</h2>
      <ul style={{ listStyleType: 'none', fontFamily: 'cursive', fontSize: '18px' }}>
        {blogs.map(blog => (
          <li
            key={blog.id}
            style={{ border: '1px solid #ccc', borderRadius: '5px', marginBottom: '10px', padding: '10px' }}
          >
            <Link to={`/blogs/${blog.id}`} style={{ textDecoration: 'none', color: 'inherit' }}>
              <h3>{blog.title}</h3>
            </Link>
            {/* Render only the first two lines of the description */}
            <p>{blog.description.split('\n').slice(0, 2).join('\n')}</p>
            {/* Link to the full blog */}
            <Link to={`/blogs/${blog.id}`} style={{ textDecoration: 'none', color: 'blue', marginBottom: '5px', display: 'block' }}>
              Read more...
            </Link>
            {/* Delete button */}
            <button
              onClick={() => handleDelete(blog.id)}
              style={{ padding: '5px 10px', fontSize: '14px', backgroundColor: '#2ecc71', color: '#fff', border: 'none', borderRadius: '4px', cursor: 'pointer' }}
            >
              Delete
            </button>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default BlogList;
