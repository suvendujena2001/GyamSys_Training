import React, { useEffect, useState } from "react";
import axios from "axios";
import { useParams } from 'react-router-dom';
import './Details.css'

const Details = () => {
    const [blog, setBlog] = useState(null);
    const { id } = useParams();
    
    useEffect(() => {
        axios
          .get(`https://localhost:7192/api/Blogs/${id}`)
          .then((response) => setBlog(response.data))
          .catch((error) => console.error("Error fetching data", error));
      }, [id]);
    
    if (!blog) {
        return <div>Loading...</div>; // Render loading message while data is being fetched
    }
    
    return (
        <div className='blog-detail'>
            <h1 className="detail-title">{blog.title}</h1>
            <img className="details-image" src={blog.image} alt={blog.title} />
            <p className="detail-description">{blog.description}</p>

            
        </div>
    );
}

export default Details;
