import React, { useEffect, useState } from "react";
import axios from "axios";
import "./Home.css";
import { Link } from "react-router-dom";
import blog1 from "../blog-1.jpg";

function Home() {
  const [blogs, setBlogs] = useState([]);
  const [showDescription, setShowDescription] = useState({});

  useEffect(() => {
    axios
      .get("https://localhost:7189/api/Blogs")
      .then((response) => setBlogs(response.data))
      .catch((error) => console.error("Error fetching data", error));
  }, [blogs]);

  const toggleDescription = (id) => {
    setShowDescription((prevState) => ({
      ...prevState,
      [id]: !prevState[id],
    }));
  };

  return (
    <>
      <div className="nav">
        <div className="logo">
          <h2>ERIC PAI</h2>
          <a href="Write">Create</a>
        </div>
      </div>
      <div className="home">
        {blogs.map((blog, i) => (
          <div key={i} className="blog-container">
            <div>
              <img src={blog1} />
            </div>
            <div>
              <h2>{blog.title}</h2>
              <p>{blog.description}</p>
              {showDescription[blog.id] ? <p>{blog.description}</p> : null}
              <Link to={`single/${blog.id}`}>
                {showDescription[blog.id] ? "Read Less" : "Read More"}
              </Link>
            </div>
          </div>
        ))}
      </div>
    </>
  );
}

export default Home;
