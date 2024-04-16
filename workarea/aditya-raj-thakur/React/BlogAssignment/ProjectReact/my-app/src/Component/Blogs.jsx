import { useEffect, useState } from "react";
import { useParams, Link } from "react-router-dom";
import axios from "axios";
function Blogs() {
  const { id } = useParams();
  const [blog, setBlog] = useState(null);

  useEffect(() => {
    const fetchBlog = async () => {
      try {
        const response = await axios.get(
          `https://localhost:7209/api/Blogs/${id}`
        );
        setBlog(response.data);
      } catch (error) {
        console.error("Error fetching blog:", error);
      }
    };

    fetchBlog();
  }, [id]);

  const handleDelete = async () => {
    try {
      await axios.delete(`https://localhost:7209/api/Blogs/${id}`);
      window.location.href = "/";
    } catch (error) {
      console.error("Error deleting blog:", error);
    }
  };
  return (
    <div>
      <div className="Container ">
        <div className="container CreateBlog contain">
          {blog ? (
            <div>
              <h2>{blog.title}</h2>
              <p>{blog.description}</p>
              <Link to="/" className="btn btn-primary createBtn">
                Back to Home
              </Link>
              <button
                onClick={handleDelete}
                className="btn btn-danger createBtn"
              >
                Delete
              </button>
            </div>
          ) : (
            <p>Loading...</p>
          )}
        </div>
      </div>
    </div>
  );
}
export default Blogs;
