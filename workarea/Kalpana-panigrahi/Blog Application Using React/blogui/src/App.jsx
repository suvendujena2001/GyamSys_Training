import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Home from './components/Home';
import Blog from './components/Blog';
import AddBlog from './components/AddBlog';

const App = () => {
    return (
        <Router>
            <Routes>
                <Route path="/" element={<Home />} />
                <Route path="/blogs/:id" element={<Blog />} />
                <Route path="/add" element={<AddBlog />} />
            </Routes>
        </Router>
    );
};

export default App;
