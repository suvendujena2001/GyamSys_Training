

import { Route, Routes } from "react-router-dom"
import Home from './components/Home';
import Write from './components/Write'
import Blogs from './components/Blogs'
const App = () => {
  return (
    <div>


      <Routes>
        <Route path='/' element={<Home />} />

        <Route path='/blogs/:id' element={<Blogs />} />
        <Route path='/write' element={<Write />} />
      </Routes>

    </div>
  );

}

export default App;
