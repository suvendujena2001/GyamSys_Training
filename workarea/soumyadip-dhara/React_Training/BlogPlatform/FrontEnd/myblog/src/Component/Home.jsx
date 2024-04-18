import './Home.css'
import React, { useEffect, useState } from "react";
import axios from "axios";
import { useParams } from 'react-router-dom';
function Home() {
    const [blogs, setBlogs] = useState([]);
    const {id}=useParams();

    useEffect(() => {
        axios
          .get("https://localhost:7192/api/Blogs")
          .then((response) => setBlogs(response.data))
          .catch((error) => console.error("Error fetching data", error));
      }, []);

      function handledelete(id){
        if (window.confirm("Are you sure you want to delete this blog?")){
        axios.delete(`https://localhost:7192/api/Blogs/${id}`)
        .then(() => {
            setBlogs(blogs.filter(blog => blog.id !== id));
        })
        .catch((error) => console.error("Error fetching data", error));

      }
    }

    return (
        
      <div>

        <div className="navigation">
            <div className="App-header">
                <img src="https://i.pinimg.com/564x/fb/af/3a/fbaf3a7a128b388ab2626aa0aad02651.jpg" className="App-logo" alt="logo" />
                <h3 class="name">My Blog</h3>
                <div class="navbar">
                    <a class="nav-item" href='/'>Home</a>
                    <a class="nav-item" href='createnew'>Craete New</a>
                </div> 
            </div>
        </div>
        <div className="blogs">
        {blogs.map((blog, i) => (
        <div key={i} className='blog-items'>
            <div className='image'>
                <img src={blog.image} alt="image"/>
            </div>
            <div className='contents'>
                <a href={`/details/${blog.id}`} className="link"><h2>{blog.title}</h2></a>
                <p>{blog.description.substring(0, 100)}...<a className="link" href={`/details/${blog.id}`}>Read More</a></p>
                <button className="delete" onClick={() => handledelete(blog.id)}>Delete</button>
            </div> 
        </div>
        ))}
        </div>
      </div>
      
    );
  }
  
  export default Home;