import Modal from 'react-modal';
import { useState, useEffect } from "react";
import axios from "axios";
function NavBar() {
  // State to manage modal visibility and input values
  const [modalIsOpen, setModalIsOpen] = useState(false);
  const [posts, setPosts] = useState([]);
  const [title, setTitle] = useState('');
  const [description, setDescription] = useState('');

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

  const handleAddPost = async (e) => {
    e.preventDefault();
    console.log("Adding post...");
    
    if (!title || !description) {
      alert("Title or description missing");
      return;
    } else {    
      try {
        const response = await axios.post("http://localhost:5007/api/BlogsApi", {
          title,
          description,
        });
        console.log("Post added successfully:", response.data);
        setPosts([...posts, response.data]);
        setTitle('');
        setDescription('');
        fetchPosts();
        window.location.reload();
        toggleModal();
      } catch (error) {
        console.error("Error adding post:", error);
      }
    }
  };


  // Function to handle modal open/close
  const toggleModal = () => {
    setModalIsOpen(!modalIsOpen);
  };

  // Function to handle form submission
  // const handleSubmit = () => {
  //   // Perform actions to submit data (e.g., send API request)
  //   console.log("Title:", title);
  //   console.log("Description:", description);

  //   // Reset input fields
  //   setTitle('');
  //   setDescription('');

  //   // Close modal
  //   toggleModal();
  // };

  // Function to handle cancel button click
  const handleCancel = () => {
    // Reset input fields
    setTitle('');
    setDescription('');

    // Close modal
    toggleModal();
  };

  return (
    <nav className="navbar navbar-expand-lg bg-custom" style={{ position: 'sticky', top: '2px'}}>
      <div className="container-fluid d-flex justify-content-between align-items-center">
        <a className="navbar-brand" href="/">Home</a>
        <div className="navbar-title">
          <h1 className="navbar-title-text">Suv's BLOG</h1>
        </div>
        <div className="position-relative">
          {/* Button to add new blog post */}
          <button className="btn btn-primary" onClick={toggleModal}>Add New</button>

          {/* Modal for creating a new blog post */}
          <Modal isOpen={modalIsOpen} onRequestClose={toggleModal}>
            <h2>Create New Blog Post</h2>
            {/* Form for creating a new blog post */}
            <form>
              <div className="mb-3">
                <label htmlFor="title" className="form-label">Title:</label>
                <input type="text" className="form-control" id="title" value={title} onChange={e => setTitle(e.target.value)} />
              </div>
              <div className="mb-3">
                <label htmlFor="description" className="form-label">Description:</label>
                <textarea className="form-control" id="description" value={description} onChange={e => setDescription(e.target.value)} />
              </div>
              {/* Buttons to submit changes or cancel */}
              <div className="d-flex justify-content-end">
                <button type="button" className="btn btn-primary me-2" onClick={handleAddPost}>Submit</button>
                <button type="button" className="btn btn-secondary" onClick={handleCancel}>Cancel</button>
              </div>
            </form>
          </Modal>
        </div>
      </div>

      {/* CSS styles for zoom in and out transition effect */}
      <style>
        {`
          .navbar {
            background-color: rgba(0,0,0,0.4); /* Change the navbar background color */
          }

          .navbar-brand {
            padding: 8px 16px;
            border: 2px solid white; /* Add border to navbar-brand */
            border-radius: 5px; /* Add border radius */
            font-weight: bold; /* Make the text bold */
            color: white; /* Text color */
            transition: transform 0.3s ease; /* Define the transition properties */
          }

          .navbar-brand:hover {
            transform: scale(1.1); /* Zoom in effect on hover */
          }

          /* Change font color of "Add Blogs" button to white */
          .navbar-nav .nav-item .nav-link {
            color: white;
          }

          .position-relative {
            position: relative;
          }

          /* Positioning the button */
          .position-relative button {
            position: relative;
            top: 0;
            right: 0;
            margin: 8px; /* Add margin for spacing */
  
          }
          .navbar-title {
            text-align: center; /* Center align the title */
            
          }
          .navbar-title-text {
            color: beige; /* Beige color */
            text-transform: uppercase; /* All caps */
            margin: 0; /* Remove default margin */
          }
        `}
      </style>
    </nav>
  );
}

export default NavBar;
