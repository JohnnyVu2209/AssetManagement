import React from "react";
import "../assets/css/Navbar.css";

function Navbar() {
  return (
    <div className="app-content navbar-container ">
      <div className="navbar-left"></div>
      <div className="navbar-right">
        <div className="navbar-right-icon-container">
          <div className="navbar-right-icon">
            <i className="fa-regular fa-envelope"></i>
            <div className="navbar-right-icon-number">
              <p>1</p>
            </div>
          </div>
          <div className="navbar-right-icon">
            <i className="fa-regular fa-bell"></i>
            <div className="navbar-right-icon-number">
              <p>2</p>
            </div>
          </div>
        </div>
        <div className="navbar-user">
          <div className="navbar-user-left">
            <img src="/UserLogo.png" alt="" className="navbar-user-img" />
            <p className="navbar-user-name">Vinz</p>
          </div>
          <div className="navbar-user-left">
            <i className="fa-solid fa-angle-down"></i>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Navbar;
