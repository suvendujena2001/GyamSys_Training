import React, { useState, useEffect } from 'react';

const Home = () => {
    const [blogs, setBlogs] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        fetch('http://localhost:5073/api/Blogs')
            .then(response => response.json())
            .then(data => {
                setBlogs(data);
                setIsLoading(false);
            })
            .catch(error => {
                console.error('Error fetching blogs:', error);
                setError(error);
                setIsLoading(false);
            });
    }, []);

    const handleDelete = async (blogId) => {
        try {
            await fetch(`http://localhost:5073/api/Blogs/${blogId}`, {
                method: 'DELETE'
            });
            setBlogs(blogs.filter(blog => blog.Id !== blogId));
        } catch (error) {
            console.error('Error deleting blog:', error);
        }
    };

    if (isLoading) return <div>Loading...</div>;
    if (error) return <div>Error: {error.message}</div>;

    return (
        <div>
            <nav className="navbar navbar-expand-lg navbar-dark bg-primary">
                <div className="container">
                    <a className="navbar-brand" href="/">BlogCraft</a>
                    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className="collapse navbar-collapse" id="navbarNav">
                        <ul className="navbar-nav ms-auto">
                            <li className="nav-item">
                                <a className="nav-link" href="/">Home</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="/add">Add Blog</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>

            <div className="container mt-5 mb-5">
                <h2 className="text-center mb-5">Craft Your Narrative: BlogCraft Invites Your Wordsmithing</h2>
                <div className="row">
                    {blogs.map(blog => (
                        <div key={blog.Id} className="col-md-4 mb-4">
                            <div className="card h-100 shadow bg-light" style={{ borderRadius: '15px' }}>
                                <div className="card-body">
                                    <div className="d-flex align-items-center justify-content-center">
                                        <div className="line"></div>
                                        <h3 className="card-title text-dark fw-bold">{blog.Title}</h3>
                                        <div className="line"></div>
                                    </div>
                                    <p className="card-text">{blog.Description.split('\n')[0]}</p>
                                </div>
                                <div className="card-footer bg-light d-flex justify-content-between align-items-center">
                                    <button className="btn btn-danger" onClick={() => handleDelete(blog.Id)}>Delete</button>
                                    <a href={`/blogs/${blog.Id}`} className="btn btn-primary">Read More</a>
                                </div>
                            </div>
                        </div>
                    ))}
                </div>
            </div>
        </div>
    );
};

export default Home;
