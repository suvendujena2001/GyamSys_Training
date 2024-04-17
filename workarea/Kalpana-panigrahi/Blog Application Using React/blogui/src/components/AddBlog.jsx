import React, { useState } from 'react';
import { Link } from 'react-router-dom';

const AddBlog = () => {
    const [title, setTitle] = useState('');
    const [description, setDescription] = useState('');

    const send = () => {
        fetch('http://localhost:5073/api/Blogs', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({
                Title: title,
                Description: description,
            }),
        })
            .then((response) => response.json())
            .then((data) => {
                console.log(data);  
                window.location.href = '/';
            })
            .catch((error) => {
                console.error('Error:', error);
            });
    };

    return (
        <div>
            <nav className="navbar navbar-expand-lg navbar-dark bg-primary">
                <div className="container">
                    <Link className="navbar-brand" to="/">BlogCraft</Link>
                    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className="collapse navbar-collapse" id="navbarNav">
                        <ul className="navbar-nav ms-auto">
                            <li className="nav-item">
                                <Link className="nav-link" to="/">Home</Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/add">Add Blog</Link>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
            <div className="container mt-5">
                <div className="row justify-content-center">
                    <div className="col-md-6">
                        <div className="card bg-primary">
                            <div className="card-header bg-primary text-light justify-content-center">Add New Blog</div>
                            <div className="card-body text-light">
                                <div className="">
                                    <label htmlFor="title" className="form-label"><i className="bi bi-pencil-square"></i> Title</label>
                                    <input
                                        type="text"
                                        className="form-control"
                                        id="title"
                                        value={title}
                                        onChange={(e) => setTitle(e.target.value)}
                                        style={{ backgroundColor: 'white' }}
                                    />
                                </div>
                                <div className="mt-3">
                                    <label htmlFor="description" className="form-label"><i className="bi bi-card-text"></i> Description</label>
                                    <textarea
                                        className="form-control"
                                        id="description"
                                        value={description}
                                        onChange={(e) => setDescription(e.target.value)}
                                        style={{ backgroundColor: 'white' }}
                                    ></textarea>
                                </div>
                                <button type="button" className="btn btn-light mt-3" onClick={send}>Submit</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default AddBlog;