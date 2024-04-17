import React, { useState, useEffect } from 'react';
import { useParams, Link } from 'react-router-dom';

const Blog = () => {
    const { id } = useParams();
    const [blog, setBlog] = useState(null);
    const [isLoading, setIsLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        fetch(`http://localhost:5073/api/Blogs/${id}`)
            .then((response) => response.json())
            .then((data) => {
                setBlog(data);
                setIsLoading(false);
            })
            .catch((error) => {
                console.error('Error fetching blog:', error);
                setError(error);
                setIsLoading(false);
            });
    }, [id]);
 
    if (isLoading) return <div>Loading...</div>;
    if (error) return <div>Error: {error.message}</div>;
    return (
        <div>
            <nav className="navbar navbar-expand-lg navbar-dark bg-primary">
                <div className="container">
                    <Link className="navbar-brand" to="/">Blogs Website</Link>
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
            <div className="card bg-primary container mt-5 text-light " style={{padding:'20px'}}>
                {blog && (
                    <div>
                        <h2 style={{ textAlign: 'center' }}>{blog.Title}</h2><hr/>
                        <p>{blog.Description}</p>
                    </div>
                )}
            </div>
        </div>
    );
};

export default Blog;
