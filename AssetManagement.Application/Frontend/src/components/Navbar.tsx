import React, { useState } from "react";
import "../assets/css/Navbar.css";
import ChangePasswordModal from "../components/ChangePasswordModal";

function Navbar() {
  const [open, setOpen] = useState(false);
  const openUserAccountOption = () => {
    setOpen(!open);
  };

  const openChangePasswordModal = () => {
    const modal = document.getElementById("change-password-modal");
    if (modal != null) {
      modal.classList.remove("hidden");
    }
  };

  return (
    <div className="app-content navbar-container ">
      <ChangePasswordModal />
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
        <div className="navbar-user" onClick={() => openUserAccountOption()}>
          <div className="navbar-user-left">
            <img src="/UserLogo.png" alt="" className="navbar-user-img" />
            <p className="navbar-user-name">Vinz</p>
          </div>
          <div className="navbar-user-left">
            <i className="fa-solid fa-angle-down"></i>
          </div>
          <div
            className={
              open
                ? "navbar-user-option-container"
                : "hidden  navbar-user-option-container"
            }
            id="user-account-option"
          >
            <div className="navbar-user-option">
              <i className="fa-solid fa-lock"></i>
              <p>Profile</p>
            </div>
            <div
              className="navbar-user-option"
              onClick={() => openChangePasswordModal()}
            >
              <i className="fa-solid fa-lock"></i>
              <p>Change Password</p>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Navbar;
