// import React, { useState, useEffect } from "react";
// import axios from "axios";
// //import { Link } from "react-router-dom";

// function Blog() {
//   const [posts, setPosts] = useState([]);

//   // Fetch existing posts from the backend when the component mounts
//   useEffect(() => {
//     fetchPosts();
//   }, []);

//   const fetchPosts = async () => {
//     try {
//       const response = await axios.get("http://localhost:5007/api/BlogsApi");
//       setPosts(response.data);
//     } catch (error) {
//       console.error("Error fetching posts:", error);
//     }
//   };

//   const handleDeletePost = async (id) => {
//     try {
//       await axios.delete(`http://localhost:5007/api/BlogsApi/${id}`);
//       setPosts(posts.filter(post => post.id !== id));
//     } catch (error) {
//       console.error("Error deleting post:", error);
//     }
//   };

//   return (
//     <div className="container mt-5" style={{backgroundColor:'transparent'}}>
//   <h1 className="mb-4" style={{ textAlign:'center'}}><b style={{ color:'#E0E0E0', backgroundColor:'rgba(0,0,0,0.5'}}>My Blog Page:</b></h1>
//   <div style={{marginBottom: '10px', border: '6px solid indigo', padding:'10px', borderRadius:'5px'}}>
//   <h2 style={{color:'beige'}}><span style={{backgroundColor: 'rgba(51, 51, 51, 0.7)'}}>Available Blogs:</span></h2>
//     <ul className="list-group mb-4">
//       {posts.map(post => (
//         <li key={post.id} className="list-group-item d-flex justify-content-between align-items-center" style={{color:'orchid', backgroundColor:'rgba(0, 0, 0, 0.5)'}}>
//           <div className="post-content">
//             <h3 className="mb-1">{post.title}</h3>
//             {/* <p className="mb-0">{post.description}</p> */}
//           </div>
//           <div className="post-actions">
//             <button className="btn btn-danger me-2 btn-sm" onClick={() => handleDeletePost(post.id)}>Delete</button>
//             {/* Add edit button here */}
//             {/* <button className="btn btn-primary me-2 btn-sm" >Edit</button> */}
//           </div>
//         </li>
//       ))}
//     </ul>
//   </div>
// </div>



//   );
  
// }
// <style>
// {`
//     /* Custom styles */
//     .list-group-item {
//       border: none;
//       border-radius: 10px;
//       padding: 20px;
//       margin-bottom: 15px; /* Adjust margin-bottom for gap between items */
//       box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
//     }

//     .post-content {
//       margin-bottom: 10px; /* Add margin between each div */
//     }

//     .post-actions .btn {
//       white-space: nowrap; /* Prevent button text from wrapping */
//     }
//   `}
// </style>
// export default Blog;

import React, { useState, useEffect } from "react";
import axios from "axios";
import { BrowserRouter as Router, Link, Route, Routes } from "react-router-dom";
import BlogDetails from "./BlogDetails";
function Blog() {
  const [posts, setPosts] = useState([]);

  // Fetch existing posts from the backend when the component mounts
  useEffect(() => {
    fetchPosts();
  }, []);

  const fetchPosts = async () => {
    try {
      const response = await axios.get("http://localhost:5007/api/BlogsApi");
      setPosts(response.data);
    } catch (error) {
      console.error("Error fetching posts:", error);
    }
  };

  const handleDeletePost = async (id) => {
    try {
      await axios.delete(`http://localhost:5007/api/BlogsApi/${id}`);
      setPosts(posts.filter(post => post.id !== id));
    } catch (error) {
      console.error("Error deleting post:", error);
    }
  };

  return (
    <Router>
      <div className="container mt-5" style={{backgroundColor:'transparent'}}>
        <h1 className="mb-4" style={{ textAlign:'center'}}><b style={{ color:'#E0E0E0', backgroundColor:'rgba(0,0,0,0.5'}}>My Blog Page:</b></h1>
        <div style={{marginBottom: '10px', border: '6px solid indigo', padding:'10px', borderRadius:'5px'}}>
          <h2 style={{color:'beige'}}><span style={{backgroundColor: 'rgba(51, 51, 51, 0.7)'}}>Available Blogs:</span></h2>
          <ul className="list-group mb-4">
            {posts.map(post => (
              <li key={post.id} className="list-group-item d-flex justify-content-between align-items-center" style={{color:'orchid', backgroundColor:'rgba(0, 0, 0, 0.5)'}}>
                <div className="post-content">
                  <Link to={`/BlogDetails/${post.id}`} style={{ textDecoration: 'none', color: 'inherit' }}>
                    <h3 className="mb-1">{post.title}</h3>
                  </Link>
                  {/* <p className="mb-0">{post.description}</p> */}
                </div>
                <div className="post-actions">
                  <button className="btn btn-danger me-2 btn-sm" onClick={() => handleDeletePost(post.id)}>Delete</button>
                  {/* Add edit button here */}
                  {/* <button className="btn btn-primary me-2 btn-sm" >Edit</button> */}
                </div>
              </li>
            ))}
          </ul>
        </div>
      </div>

      {/* Define routes for blog details */}
      <Routes>
        <Route path="/BlogDetails/:id" element={<BlogDetails/>} />
      </Routes>
    </Router>
  );
}

export default Blog;