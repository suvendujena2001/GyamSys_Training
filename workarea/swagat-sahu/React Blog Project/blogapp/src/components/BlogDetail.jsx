import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { useParams } from 'react-router-dom';

function BlogDetail() {
  const { id } = useParams();
  const [blog, setBlog] = useState(null);

  useEffect(() => {
    axios.get(`http://localhost:5291/api/Blogs/${id}`)
      .then(response => {
        setBlog(response.data);
      })
      .catch(error => {
        console.error('Error fetching blog:', error);
      });
  }, [id]);

  return (
    <div>
      {blog ? (
        <div>
          <h2>{blog.title}</h2>
          <p>{blog.description}</p>
        </div>
      ) : (
        <p>Loading...</p>
      )}
    </div>
  );
}

export default BlogDetail;
