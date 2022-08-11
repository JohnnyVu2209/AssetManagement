import React from "react";
import { Link } from "react-router-dom";
import "../assets/css/Sidebar.css";
import { logout } from "../services/userService/authentication";

function Sidebar() {
  if (localStorage.getItem("role") == "User")
    return (
      <div className="sidebar-container">
        <div className="sidebar-links">
          <Link to="/" className="sidebar-logo">
            <img src="/Logo.png" alt="" />
          </Link>
          <Link to="/user-home">
            <i className="fa-solid fa-bars-progress"></i>Home
          </Link>

          {/* <Link to="/list-view">
          <i className="fa-solid fa-apple-whole"></i>List View
        </Link> */}
        </div>
        <div className="sidebar-buttons">
          <button className="button" onClick={() => logout()}>
            LOGOUT
          </button>
        </div>
      </div>
    );
  else
    return (
      <div className="sidebar-container">
        <div className="sidebar-links">
          <Link to="/" className="sidebar-logo">
            <img src="/Logo.png" alt="" />
          </Link>
          <Link to="/user-home">
            <i className="fa-solid fa-bars-progress"></i>Home
          </Link>
          <Link to="/manage-user">
            <i className="fa-solid fa-bars-progress"></i>Manage User
          </Link>
          <Link to="/manage-asset">
            <i className="fa-solid fa-bars-progress"></i>Manage Asset
          </Link>
          <Link to="/assignment-list">
            <i className="fa-solid fa-bars-progress"></i>Manage Assingment
          </Link>
          <Link to="/return-request-list">
            <i className="fa-solid fa-bars-progress"></i>Request for Returning
          </Link>
          <Link to="/reports">
            <i className="fa-solid fa-bars-progress"></i>Report
          </Link>
          {/* <Link to="/list-view">
          <i className="fa-solid fa-apple-whole"></i>List View
        </Link> */}
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
