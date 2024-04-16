import { Route, Routes } from "react-router-dom";
import Blog from "./Component/Blogs";
import Navbar from "./Component/navbar";
import Write from "./Component/Write";

function App() {
  return (
    <div>
      <Routes>
        <Route path="/" element={<Navbar />} />
        <Route path="/blogs/:id" element={<Blog />} />
        <Route path="/write" element={<Write />} />
      </Routes>
    </div>
  );
}

export default App;
