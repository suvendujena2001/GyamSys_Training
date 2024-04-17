import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import HomePage from './components/HomePage'; // Assuming correct relative path
import BlogPage from './components/BlogPage'; // Assuming correct relative path

const App = () => (
  <Router>
    <Routes>
      <Route path="/" element={<HomePage />} />
      <Route path="/blogs/:id" element={<BlogPage />} />
    </Routes>
  </Router>
);

export default App;