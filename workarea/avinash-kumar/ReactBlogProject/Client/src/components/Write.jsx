import { useState } from 'react';

import axios from 'axios';
import NavBar from '../NavBar';

export default function Write() {
    const [title, setTitle] = useState('');
    const [description, setDescription] = useState('');

    const handleTitleChange = (event) => {
        setTitle(event.target.value);
    };

    const handleDescriptionChange = (event) => {
        setDescription(event.target.value);
    };

    function redirectTo(url) {
        window.location.href = url;
    }

    const handleSubmit = async (event) => {
        event.preventDefault();

        try {
            await axios.post('https://localhost:7071/api/Blogs', {
                title: title,
                description: description
            });

            console.log('Blog post created');
            setTitle('');
            setDescription('');

            redirectTo("/");

        } catch (error) {
            console.error('Error creating blog post:', error);
        }
    };

    return (
        <div> <NavBar />
            <div className="Container">
                <div className='container text-center CreateBlog'>
                    <h1>Exploring the Uncharted: Unveiling the Mysteries of Your Mind</h1>
                    <form onSubmit={handleSubmit}>
                        <div className="form-group">
                            <label htmlFor="title">What You Want to Give the Title For Your Blog</label>
                            <input placeholder='Title' required
                                type="text"
                                id="title"
                                className="form-control"
                                value={title}
                                onChange={handleTitleChange}
                            />
                        </div>
                        <div className="form-group">
                            <label htmlFor="description">Describe Your Blog</label>
                            <textarea placeholder='Start Writing...' required
                                id="description"
                                className="form-control"
                                rows="4"
                                value={description}
                                onChange={handleDescriptionChange}
                            ></textarea>
                        </div>
                        <button type="submit" className="btn btn-primary createBtn">Post the Blog</button>
                    </form>
                </div>
            </div>
        </div>
    );
}
