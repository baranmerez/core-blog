import React from "react";
import { Nav, NavLink, Bars, NavMenu, AdminNavMenu } from "./Navbar";

const Navbar = () => {
  return (
    <>
      <Nav>
        <Bars/>
        <NavMenu>
          <NavLink to="/home" activeStyleHome>
            Home
          </NavLink>
          <NavLink to="/blogs" activeStyle>
            Blogs
          </NavLink>
          <NavLink to="/category" activeStyle>
            Category
          </NavLink>
        </NavMenu>
        <AdminNavMenu>
          <NavLink to="/admin/dashboard" activeStyle>
            Admin Panel
          </NavLink>
        </AdminNavMenu>
      </Nav>
    </>
  );
};

export default Navbar;
