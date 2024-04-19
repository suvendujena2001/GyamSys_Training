import React, { useState } from 'react';
import axios from 'axios';
import Modal from 'react-modal';
import backgroundImage from './reactP2.jpg'; // Import the image file

function CreateBlogModal() {
  const [modalIsOpen, setModalIsOpen] = useState(false);
  const [title, setTitle] = useState('');
  const [description, setDescription] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    axios.post('http://localhost:5291/api/Blogs', { title, description })
      .then(response => {
        console.log('Blog created:', response.data);
        handleCloseModal();
      })
      .catch(error => {
        console.error('Error creating blog:', error);
      });
  };

  const handleCloseModal = () => {
    setModalIsOpen(false);
    setTitle('');
    setDescription('');
  };

  return (
    <div style={{
      backgroundImage: `url(${backgroundImage})`, // Set the background image
      backgroundSize: 'cover', // Ensure the image covers the entire background
      display: 'flex',
      flexDirection: 'column',
      justifyContent: 'center',
      alignItems: 'center',
      height: '100vh', // Set the height to full viewport height
    }}>
      <h1>To add content, click on the button below!</h1>
      <div style={{ marginTop: '20px' }}>
        <button onClick={() => setModalIsOpen(true)} style={{
    backgroundColor: '#4CAF50', // Light green color
    color: 'white',
    padding: '14px 20px',
    margin: '20px 0', // Add margin to the top
    border: 'none',
    borderRadius: '4px',
    cursor: 'pointer',
    width: '100%',
    fontSize: '16px',
    border: '3px solid black'
  }}>Create a Blog</button>
      </div>
      <Modal isOpen={modalIsOpen} onRequestClose={handleCloseModal}>
        <h2 style={{ marginBottom: '20px' }}>Create Blog</h2>
        <form onSubmit={handleSubmit}>
          <input
            type="text"
            value={title}
            onChange={(e) => setTitle(e.target.value)}
            placeholder="Title"
            style={{ marginBottom: '10px', width: '100%', padding: '8px', borderRadius: '4px', border: '1px solid #ccc' }}
          />
          <textarea
            value={description}
            onChange={(e) => setDescription(e.target.value)}
            placeholder="Description"
            style={{ marginBottom: '10px', width: '100%', padding: '8px', borderRadius: '4px', border: '1px solid #ccc' }}
          />
          <button
            type="submit"
            style={{ marginRight: '10px', padding: '8px 16px', backgroundColor: '#2ecc71', color: '#fff', border: 'none', borderRadius: '4px', cursor: 'pointer' }}
          >
            Submit
          </button>
          <button
            onClick={handleCloseModal}
            style={{ padding: '8px 16px', backgroundColor: '#e74c3c', color: '#fff', border: 'none', borderRadius: '4px', cursor: 'pointer' }}
          >
            Cancel
          </button>
        </form>
      </Modal>
    </div>
  );
}

export default CreateBlogModal;
