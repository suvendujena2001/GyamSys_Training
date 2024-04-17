import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Link } from 'react-router-dom';
import Modal from 'react-modal';
import { blogUrl } from '../endpoints';
import '../App.css';

Modal.setAppElement('#root');

const HomePage = () => {
  const [blogs, setBlogs] = useState([]);
  const [modalIsOpen, setModalIsOpen] = useState(false);
  const [newBlog, setNewBlog] = useState({ title: '', description: '' });

  useEffect(() => {
    axios.get(blogUrl)
      .then(response => {
        setBlogs(response.data);
      })
      .catch(error => {
        console.error('Error fetching blogs:', error);
      });
  }, []);

  const deleteBlog = (id) => {
    axios.delete(`${blogUrl}/${id}`)
      .then(() => {
        setBlogs(blogs.filter(blog => blog.id !== id));
      })
      .catch(error => {
        console.error('Error deleting blog:', error);
      });
  };

  const addBlog = () => {
    axios.post(blogUrl, newBlog)
      .then(() => {
        axios.get(blogUrl)
          .then(response => {
            setBlogs(response.data);
            setModalIsOpen(false);
            setNewBlog({ title: '', description: '' });
          })
          .catch(error => {
            console.error('Error fetching blogs after adding new blog:', error);
          });
      })
      .catch(error => {
        console.error('Error adding blog:', error);
      });
  };

  return (
    <div>
      <div className="page-heading">
        <h1 className="blog-title">Blog World!</h1>
        <button className="add-blog-button" onClick={() => setModalIsOpen(true)}>+ Add new blog</button>
      </div>
      <div className="title-body">
        <ul className="bullet-list">
          {blogs.map(blog => (
            <li key={blog.id} className="blog-box">
              <div className="blog-content">
                <h3 className="content-title">{blog.title}</h3>
                <p className="content-description">{blog.description}</p>
                <div className="button-container">
                  <Link to={`/blogs/${blog.id}`}>Read More</Link>
                  <button className="delete-button" onClick={() => deleteBlog(blog.id)}>Delete</button>
                </div>
              </div>
            </li>
          ))}
        </ul>
      </div>
      <Modal isOpen={modalIsOpen} onRequestClose={() => setModalIsOpen(false)}>
        <div className="add-blog-container">
          <h2>Add New Blog</h2>
          <div className="input-group">
            <label>Title:</label>
            <input type="text" placeholder="Title" value={newBlog.title} onChange={e => setNewBlog({ ...newBlog, title: e.target.value })} />
          </div>
          <div className="input-group">
            <label>Description:</label>
            <textarea placeholder="Description" value={newBlog.description} onChange={e => setNewBlog({ ...newBlog, description: e.target.value })}></textarea>
          </div>
          <button className="submit-button" onClick={addBlog}>Submit</button>
          <button onClick={() => setModalIsOpen(false)}>Close</button>
        </div>
      </Modal>
    </div>
  );
};

export default HomePage;
