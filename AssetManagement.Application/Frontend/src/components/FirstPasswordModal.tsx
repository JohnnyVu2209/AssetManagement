import React, { useState, createContext } from "react";
import "../assets/css/Modal.css";
import "../assets/css/FirstPasswordModal.css";
import { changePassword } from "../services/userService/authentication";

function FirstPasswordModal() {
  const [oldPassword, setOldPassword] = useState("");
  const [newPassword, setNewPassword] = useState("");
  const saveButton = document.getElementById("first-password-save-button");
  let oldPasswordInput = document.getElementById("first-old-password-input");
  let wrongPasswordMessage = document.getElementById(
    "first-hidden-password-message"
  );

  const handleChangeOldPassword = (e: any) => {
    setOldPassword(e.target.value);
  };

  const handleChangeNewPassword = (e: any) => {
    setNewPassword(e.target.value);
  };

  const checkEmpty = () => {
    if (saveButton) {
      if (oldPassword != "" && newPassword != "")
        saveButton.removeAttribute("disabled");
      if (oldPassword == "" || newPassword == "")
        saveButton.setAttribute("disabled", "");
    }
  };

  const changePasswordHandle = (e: any) => {
    e.preventDefault();
    changePassword(oldPassword, newPassword).then(() => {
      if (localStorage.getItem("isPasswordCorrect")) {
        localStorage.removeItem("isPasswordCorrect");
        if (oldPasswordInput) {
          oldPasswordInput.classList.add("not-correct-password");
          if (wrongPasswordMessage)
            wrongPasswordMessage.classList.remove("hidden");
        }
      }
    });
  };

  return (
    <div className="modal-container hidden" id="first-password-modal">
      <form
        action=""
        className="modal-form"
        id="first-password-modal-form"
        onSubmit={changePasswordHandle}
      >
        <div className="modal-form-top">
          <h2>Change Password</h2>
        </div>
        <div className="modal-form-input-container">
          <p className="first-password-message">
            This is your first time you logged in. <br />
            You have to change your password to continue.
          </p>
          <input
            type="password"
            placeholder="Old password"
            id="first-old-password-input"
            onChange={handleChangeOldPassword}
            onKeyUp={checkEmpty}
            value={oldPassword}
          />
          <p id="first-hidden-password-message" className="hidden">
            Password is incorrect
          </p>
          <input
            type="password"
            placeholder="New password"
            id="first-new-password-input"
            required
            onChange={handleChangeNewPassword}
            onKeyUp={checkEmpty}
            value={newPassword}
          />
        </div>
        <div className="modal-form-buttons">
          <input
            type="submit"
            className="button"
            value="SAVE"
            id="first-password-save-button"
            disabled
          />
        </div>
      </form>
    </div>
  );
}

export default FirstPasswordModal;
