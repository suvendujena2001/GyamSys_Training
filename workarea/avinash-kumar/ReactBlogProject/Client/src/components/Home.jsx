import '../styles/Home.style.css';
import img from '../images/backgraound.jpg'
import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Link } from 'react-router-dom';
import NavBar from '../NavBar';

export default function Home() {
    const [blogs, setBlogs] = useState([]);

    useEffect(() => {

        (async () => {
            try {
                const blogsResponse = await axios.get('https://localhost:7071/api/Blogs')
                setBlogs(blogsResponse.data);
            } catch (err) {
                console.log('Error occured when fetching blogs');
            }
        })();
    }, []);

    console.log(blogs);
    return (

        <div>
            <NavBar />
            <div className="Container">
                <div className='innerDiv1'>
                    <img className='backgroundImage' src={img} alt="" />
                    <br /><br /><br />
                    <p>*Scroll down to read Latest Blog</p>

                </div>
                <div className='innerDiv2'>
                    <p>Write your <span>blog</span> here </p>
                    <Link className='createBtn btn btn-primary createBtn' to="/write">Write Your Blog</Link>
                </div>
            </div>

            <table className="table text-center">
                <thead>
                    <tr>
                        <th>Blog No.</th>
                        <th>Title</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    {blogs.map((blog, i) => (
                        <tr key={blog.id}>
                            <td>{i + 1}</td>
                            <td>{blog.title}</td>
                            <td>
                                <Link to={`/blogs/${blog.id}`} className='btn btn-primary createBtn'>Read More</Link>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>

        </div >
    );
}