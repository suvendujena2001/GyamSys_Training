import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Link, useParams } from 'react-router-dom';
import { blogUrl } from '../endpoints';
import '../App.css';

const BlogPage = () => {
  const [blog, setBlog] = useState({});
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);
  const { id } = useParams();

  useEffect(() => {
    fetchBlog();
  }, []); 

  const fetchBlog = () => {
    axios.get(`${blogUrl}/${id}`)
      .then(response => {
        setBlog(response.data);
        setLoading(false);
      })
      .catch(error => {
        console.error('Error fetching blog:', error);
        setError('Error fetching blog. Please try again later.');
        setLoading(false);
      });
  };

  if (loading) {
    return <div>Loading...</div>;
  }

  if (error) {
    return <div>{error}</div>;
  }

  return (
    <div className="blog-container">
      <h1 className="blog-title">{blog.title}</h1>
      <p className="blog-description">{blog.description}</p>
      <Link to="/" className="blog-button">Go Back</Link>
    </div>
  );
};

export default BlogPage;
