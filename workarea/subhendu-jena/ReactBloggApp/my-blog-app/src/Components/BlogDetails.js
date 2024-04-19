// import React, { useState, useEffect } from "react";
// import axios from "axios";
// import { useParams } from "react-router-dom";

// function BlogDetails() {
//     const { id } = useParams();
//     const [post, setPost] = useState(null);
  
//     useEffect(() => {
//       const fetchPost = async () => {
//         try {
//           const response = await axios.get(`http://localhost:5007/api/BlogsApi/${id}`);
//           setPost(response.data);
//         } catch (error) {
//           console.error("Error fetching post details:", error);
//         }
//       };
//       fetchPost();
//     }, [id]);
  
//     if (!post) {
//       return <div>Loading...</div>;
//     }
//     // const handleDeletePost = async (id) => {
//     //     try {
//     //       await axios.delete(`http://localhost:5007/api/BlogsApi/${id}`);
//     //       setPost(post.filter(post => post.id !== id));

//     //     } catch (error) {
//     //       console.error("Error deleting post:", error);
//     //     }
//     //   };
//     return (
//       <div className="container mt-5">
//         <h2>{post.title}</h2>
//         <p style={{backgroundColor:'rgba(0,0,0,0.5)', color:'beige'}}>{post.description}</p>
//         {/* Add delete and edit buttons here */}
//         {/* <button className="btn btn-danger me-2 btn-sm" onClick={() => handleDeletePost(post.id)}>Delete</button> */}
//         {/* <button className="btn btn-primary me-2 btn-sm" >Edit</button> */}
//       </div>
//     );
//   }
  
//   export default BlogDetails;


import React, { useState, useEffect } from "react";
import axios from "axios";
import { useParams } from "react-router-dom";

function BlogDetails() {
    const { id } = useParams();
    const [post, setPost] = useState(null);
    const [showModal, setShowModal] = useState(false);
  
    useEffect(() => {
      const fetchPost = async () => {
        try {
          const response = await axios.get(`http://localhost:5007/api/BlogsApi/${id}`);
          setPost(response.data);
        } catch (error) {
          console.error("Error fetching post details:", error);
        }
      };
      fetchPost();
    }, [id]);
  
    if (!post) {
      return <div>Loading...</div>;
    }

    const handleToggleModal = () => {
      setShowModal(!showModal);
    };
  
    const handleRefreshPage = () => {

        window.location.reload();
      };
  
    return (
      <div className="container mt-5" >
        <div style={{backgroundColor:'rgba(0,0,0,0.5)', color:'beige'}}>
        <h2 style={{color:'beige'}}>{post.title}</h2>
        {/* Render only the first 30 characters of the description */}
        <p>
          {post.description.slice(0, 50)} {/* Show only the first 30 characters */}
          {post.description.length > 30 && (
            <span>
              {" "}
              {/* Add a button to toggle modal */}
              <button className="btn btn-link p-0" onClick={handleToggleModal}>Read more...</button>
              <button className="btn btn-link" onClick={handleRefreshPage}><a href="/">Close</a></button>
            </span>
          )}
        </p>
</div>
        {/* Modal */}
        <div className={`modal fade ${showModal ? 'show' : ''}`} style={{ display: showModal ? 'block' : 'none' }} tabIndex="-1" role="dialog">
          <div className="modal-dialog modal-dialog-centered" role="document">
            <div className="modal-content">
              <div className="modal-header">
                <h5 className="modal-title">{post.title}</h5>
                <button type="button" className="close" onClick={handleToggleModal}>
                  <span aria-hidden="true">&times;</span>
                </button>
              </div>
              <div className="modal-body">
                <p>{post.description}</p>
              </div>
              <div className="modal-footer">
                <button type="button" className="btn btn-secondary" onClick={handleToggleModal}>Close</button>
              </div>
            </div>
          </div>
        </div>
      </div>
    );
}

export default BlogDetails;


