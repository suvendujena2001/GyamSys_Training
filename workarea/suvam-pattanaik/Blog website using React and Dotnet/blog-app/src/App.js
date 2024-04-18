// // App.js
// import React from 'react';
// import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
// import Home from './components/Home';
// import BlogsPage from './components/BlogsPage';
// import './App.css';
// // index.js or App.js
// import 'bootstrap/dist/css/bootstrap.min.css';
// import Navbar from './components/Navbar';



// function App() {
//   return (
//     <Router>
//       <div className="App">
//         <Navbar/>
//         <Routes>
//           <Route path="/" element={<Home />} />
//           <Route path="/blogs" element={<BlogsPage />} />
//         </Routes>
//       </div>
//     </Router>
//   );
// }

// export default App;



// App.js

import React, { useState } from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Navbar from './components/Navbar';
import Home from './components/Home';
import BlogsPage from './components/BlogsPage';
import CreateBlogModal from './components/CreateBlogModal'; // Import the CreateBlogModal component
import BlogDetail from './components/BlogDetail';


import './App.css';

function App() {
  const [showModal, setShowModal] = useState(false);
  const [blogs, setBlogs] = useState([]);

  const handleToggleModal = () => {
    setShowModal(!showModal);
  };

  const handleAddBlog = (newBlog) => {
    setBlogs([...blogs, newBlog]);
    setShowModal(false); // Close the modal after adding the blog
  };

  return (
    <Router>
      <div className="App">
        <Navbar onToggleModal={handleToggleModal} /> {/* Pass the toggle modal function to Navbar */}
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/blogs" element={<BlogsPage />} />
          <Route path="/create" element={<CreateBlogModal onAddBlog={handleAddBlog} />} /> {/* Add route for CreateBlogModal */}
          {/* Add routes for other components */}
          <Route path="/blogs/:id" element={<BlogDetail />} />
        </Routes>
        {showModal && <CreateBlogModal onAddBlog={handleAddBlog} />} {/* Conditionally render the modal */}
      </div>
    </Router>
  );
}

export default App;
