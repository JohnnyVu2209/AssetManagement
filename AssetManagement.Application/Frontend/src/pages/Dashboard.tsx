import React from "react";
import FirstPasswordModal from "../components/FirstPasswordModal";

const firstPasswordChange = () => {
  window.addEventListener("load", () => {
    let something = document.getElementById("first-password-modal");
    if (something) something.classList.remove("hidden");
  });
};

if (localStorage.getItem("isPasswordChanged")) firstPasswordChange();

function Dashboard() {
  return (
    <div className="app-content">
      <FirstPasswordModal />
      Dash
    </div>
  );
}

export default Dashboard;
