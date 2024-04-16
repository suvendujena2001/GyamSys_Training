import React, { useState, useEffect } from "react";
import axios from "axios";
import { Link } from "react-router-dom";

function Navbar() {
  const [blog, setBlog] = useState([]);

  useEffect(() => {
    (async () => {
      try {
        const blogsResponse = await axios.get(
          "https://localhost:7209/api/Blogs"
        );
        setBlog(blogsResponse.data);
      } catch (err) {
        console.log("Error occured when fetching blogs");
      }
    })();
  }, []);

  return (
    <div>
      <nav className="navbar navbar-expand-lg navbar-light bg-light text center">
        <button
          className="navbar-toggler"
          type="button"
          data-toggle="collapse"
          data-target="#navbarSupportedContent"
          aria-controls="navbarSupportedContent"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span className="navbar-toggler-icon"></span>
        </button>
        <h1>Blog Site</h1>

        <div
          className="collapse navbar-collapse float-end  "
          id="navbarSupportedContent"
        >
          <ul className="navbar-nav mr-auto">
            <li className="nav-item active">
              <Link
                className="createBtn btn btn-primary createBtn "
                to="/write"
              >
                Create Blog
              </Link>
            </li>
          </ul>
        </div>
      </nav>

      <div className="container contain">
        <table className="table text-center table-striped table-bordered ">
          <thead>
            <tr>
              <th>Blog No.</th>
              <th>Title</th>
              <th>Action</th>
            </tr>
          </thead>
          <tbody>
            {blog.map((blog, i) => (
              <tr key={blog.blogId}>
                <td>{i + 1}</td>
                <td>{blog.title}</td>
                <td>
                  <Link
                    to={`/blogs/${blog.blogId}`}
                    className="btn btn-primary createBtn"
                  >
                    Read More
                  </Link>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}

export default Navbar;
