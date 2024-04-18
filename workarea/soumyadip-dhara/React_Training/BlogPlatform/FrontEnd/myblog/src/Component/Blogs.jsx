import React from 'react'
import './Blogs.css'
import axios from 'axios';
import { useState } from 'react';


const Blogs = () => {
    const [title, setTitle] = useState('');
    const [description, setDescription] = useState('');
    const [image, setImage] = useState('');
    const handlePublish = async () => {
        try {
          await axios.post("https://localhost:7192/api/Blogs", {
            title,
            image,
            description
          });
          // Optionally, you can clear the input fields after successful submission
          setTitle('');
          setDescription('');
          setImage('');
          window.location.href = '/';
        } catch (error) {
          console.log("Error while posting");
        }
      };
  return (

    <div className='box'>
      <h2 className='heading'>Create New Blog</h2>

      <form className='input'>

      <label htmlFor='title' className='input-label'>Title: </label>
        <div className='input-items'>
          <input id='title' type='text' value={title} onChange={e => setTitle(e.target.value)} />
        </div>

        <label htmlFor='Image' className='input-label'>Image Url:</label>
        <div className='input-items'>
          <textarea rows="2" cols="40" id='image' value={image} onChange={e => setImage(e.target.value)} />
        </div>

        <label htmlFor='description' className='input-label'>Description: </label>
        <div className='input-items'>
          <textarea rows="10" cols="40" id='description' value={description} onChange={e => setDescription(e.target.value)} className='textarea-field' />
        </div>

        <button type='button' onClick={handlePublish} className='button'>Add</button>
      </form>
    </div>
  )
}

export default Blogs;
 