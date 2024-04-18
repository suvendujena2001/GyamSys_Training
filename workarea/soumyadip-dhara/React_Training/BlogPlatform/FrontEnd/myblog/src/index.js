import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import { BrowserRouter, Routes, Route } from 'react-router-dom'; // Import Routes and Route
import Home from './Component/Home';
import Blogs from './Component/Blogs';
import Details from'./Component/Details'

ReactDOM.render(
  <BrowserRouter>
    <Routes>
      <Route path="/" element={<Home />} />
      <Route path="/createnew" element={<Blogs />} /> {}
      <Route path="/details/:id" element={<Details />} /> 
    </Routes>
  </BrowserRouter>,
  document.getElementById('root')
);

reportWebVitals();
