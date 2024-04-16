import React from 'react'
import axios from 'axios';
import { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';

function Single() {
  const[blog,setBlog] =useState(null);
  const {id} = useParams();
  
  useEffect(() => {
    axios.get(`https://localhost:7189/api/Blogs/${id}`)
        .then(response => setBlog(response.data))
        .catch(error => console.error('Error fetching data', error));
}, []);
    
if (!blog) {
    return <div>Loading...</div>;
}
  return (
    <div className='blog-detail'>
            <h1>{blog.title}</h1>
            <p>{blog.description}</p>
        </div>
  )
}

export default Single

