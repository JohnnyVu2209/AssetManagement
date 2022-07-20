import React from "react";
import { Link } from "react-router-dom";
import "../assets/css/Sidebar.css";
import { logout } from "../services/userService/authentication";

function Sidebar() {
  return (
    <div className="sidebar-container">
      <div className="sidebar-links">
        <Link to="/" className="sidebar-logo">
          <img src="/Logo.png" alt="" />
        </Link>
        <Link to="/">
          <i className="fa-solid fa-bars-progress"></i>Dashboard
        </Link>
        <Link to="/list-view">
          <i className="fa-solid fa-apple-whole"></i>List View
        </Link>
      </div>
      <div className="sidebar-buttons">
        <button className="button" onClick={() => logout()}>
          LOGOUT
        </button>
      </div>
    </div>
  );
}

export default Sidebar;
