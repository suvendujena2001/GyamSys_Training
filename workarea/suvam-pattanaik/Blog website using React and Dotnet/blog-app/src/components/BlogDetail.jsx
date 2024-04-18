
// BlogDetail.js
import React, { useState, useEffect } from 'react';
import { Link, useParams } from 'react-router-dom';
import '../App.css'; // Import the CSS file for blog detail styling

function BlogDetail() {
  const { id } = useParams();
  const [blog, setBlog] = useState(null);

  useEffect(() => {
    fetchBlog();
  }, []);

  const fetchBlog = async () => {
    try {
      const response = await fetch(`http://localhost:5174/api/Blog/${id}`);
      if (!response.ok) {
        throw new Error('Failed to fetch blog');
      }
      const data = await response.json();
      setBlog(data);
    } catch (error) {
      console.error('Error fetching blog:', error);
    }
  };

  const handleDelete = async () => {
    try {
      const response = await fetch(`http://localhost:5174/api/Blog/${id}`, {
        method: 'DELETE',
      });
      if (!response.ok) {
        throw new Error('Failed to delete blog');
      }
      // Redirect to home page after deletion
      window.location.href = '/';
    } catch (error) {
      console.error('Error deleting blog:', error);
    }
  };

  return (
    <div className="container blog-detail-container">
      <h1 className="blog-title">Blog Detail</h1>
      <Link to="/" className="btn btn-secondary mb-3">Back</Link> {/* Back button */}
      {blog && (
        <div className="card">
          <div className="card-body">
            <h2 className="card-title">{blog.title}</h2>
            <p className="card-text blog-description">{blog.description}</p>
            <div className="action-buttons">
              <Link to={`/blogs/${id}/edit`} className="btn btn-primary">Edit</Link>
              <button onClick={handleDelete} className="btn btn-danger">Delete</button>
            </div>
          </div>
        </div>
      )}
    </div>
  );
}

export default BlogDetail;
