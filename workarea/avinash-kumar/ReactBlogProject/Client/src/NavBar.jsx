import { NavLink, Link } from "react-router-dom";
const NavBar = () => {
    return (
        <div className="nav">
            <Link to="/" className="site-title">WebTales</Link>
            <ul>
                <NavLink to="/">Home</NavLink>
                <NavLink to="/blogs/:id">Blogs</NavLink>
                <NavLink to="/write">Write</NavLink>
            </ul>
        </div >
    );
}


export default NavBar;

