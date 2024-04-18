import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import HomePage from './components/HomePage'; 
import BlogPage from './components/BlogPage'; 

const App = () => (
  <Router>
    <Routes>
      <Route path="/" element={<HomePage />} />
      <Route path="/blogs/:id" element={<BlogPage />} />
    </Routes>
  </Router>
);

export default App;