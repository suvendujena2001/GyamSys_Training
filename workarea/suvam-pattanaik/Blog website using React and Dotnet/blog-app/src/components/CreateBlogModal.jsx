

// import React, { useState } from 'react';
// import '../App.css'; 
// import { Link, useParams } from 'react-router-dom';
// function CreateBlogModal({ onAddBlog }) {
//   const [title, setTitle] = useState('');
//   const [description, setDescription] = useState('');
//   const [message ,setMessage] = useState('');

//   const handleSubmit = async (e) => {
//     e.preventDefault();
//     try {
//       const response = await fetch('http://localhost:5174/api/Blog', {
//         method: 'POST',
//         headers: {
//           'Content-Type': 'application/json',
//         },
//         body: JSON.stringify({ title, description }),
//       });
//       if (!response.ok) {
//         throw new Error('Failed to create blog');
//       }
//       const data = await response.json();
//       onAddBlog(data);
//       setTitle('');
//       setDescription('');
//       setMessage('Blog created successfully');
//     } catch (error) {
//       console.error('Error creating blog:', error);
//     }
//   };

//   return (
//     <div className="container form-container">
//       <h2>Create New Blog</h2>
//       <Link to="/" className="btn btn-secondary mb-3">Back</Link> {/* Back button */}
//       <form onSubmit={handleSubmit}>
//         <label>
//           Title:
//           <input type="text" value={title} onChange={e => setTitle(e.target.value)} />
//         </label>
//         <label>
//           Description:
//           <textarea value={description} onChange={e => setDescription(e.target.value)} />
//         </label>
//         <button type="submit">Submit</button>
//         {message && <p className='message'>{message}</p>}
//       </form>
//     </div>
//   );
// }

// export default CreateBlogModal;


import React, { useState } from 'react';
import '../App.css'; 
import { Link, useParams } from 'react-router-dom';

function CreateBlogModal({ onAddBlog }) {
  const [title, setTitle] = useState('');
  const [description, setDescription] = useState('');
  const [message ,setMessage] = useState('');

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const response = await fetch('http://localhost:5174/api/Blog', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify({ title, description }),
      });
      if (!response.ok) {
        throw new Error('Failed to create blog');
      }
      const data = await response.json();
      onAddBlog(data);
      setTitle('');
      setDescription('');
      setMessage('Blog created successfully');
    } catch (error) {
      console.error('Error creating blog:', error);
    }
  };

  return (
    <div className="container form-container">
      <h2>Create New Blog</h2>
      <Link to="/" className="btn btn-secondary mb-3">Back</Link> {/* Back button */}
      <form onSubmit={handleSubmit}>
        <label className="input-label">
          Title:
          <input type="text" className="input-field" value={title} onChange={e => setTitle(e.target.value)} />
        </label>
        <label className="input-label">
          Description:
          <textarea className="textarea-field" value={description} onChange={e => setDescription(e.target.value)} />
        </label>
        <button type="submit">Create</button>
        {message && <p className='message'>{message}</p>}
      </form>
    </div>
  );
}

export default CreateBlogModal;

