import axios from 'axios';
import React from 'react';
import { useState } from 'react';
import "./Write.css";
import blog1 from "../blog-1.jpg";

function Write() {
  const [title, setTitle] = useState('');
  const [description, setDescription] = useState('');

  const handlePublish = async () => {
    try {
      await axios.post("https://localhost:7189/api/Blogs", {
        title,
        description
      });
      // Optionally, you can clear the input fields after successful submission
      setTitle('');
      setDescription('');
    } catch (error) {
      console.log("Error while posting");
    }
  };

  return (
    <>
    
    <div className='post-container'>
      <h2 className='post-heading'>Create New Blog</h2>
      <form className='post-form'>
        <div className='input-group'>
          <label htmlFor='title' className='input-label'>Title: </label>
          <input id='title' type='text' value={title} onChange={e => setTitle(e.target.value)} className='input-field' />
        </div>

        <div className='input-group'>
          <label htmlFor='description' className='input-label'>Description: </label>
          <textarea id='description' value={description} onChange={e => setDescription(e.target.value)} className='textarea-field' />
        </div>

        <button type='button' onClick={handlePublish} className='publish-button'>Publish</button>
      </form>
    </div>
    </>
   
  )
}

export default Write;
