import React, { useState, createContext } from "react";
import "../assets/css/Modal.css";
import "../assets/css/ChangePasswordModal.css";
import { changePassword } from "../services/userService/authentication";

function Modal() {
  const [oldPassword, setOldPassword] = useState("");
  const [newPassword, setNewPassword] = useState("");
  const saveButton = document.getElementById("change-password-save-button");
  let oldPasswordInput = document.getElementById("old-password-input");
  let wrongPasswordMessage = document.getElementById("hidden-password-message");
  const changePasswordModal = document.getElementById("change-password-modal");

  const closeModal = (e: React.MouseEvent) => {
    e.preventDefault();
    if (changePasswordModal) {
      changePasswordModal.classList.add("hidden");
      if (oldPasswordInput) {
        oldPasswordInput.classList.remove("not-correct-password");
        if (wrongPasswordMessage) wrongPasswordMessage.classList.add("hidden");
      }
    }
  };

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
    changePassword(oldPassword, newPassword)
      .then((res) => {
        console.log(res.response.status);
        if (oldPasswordInput) {
          oldPasswordInput.classList.add("not-correct-password");
          if (wrongPasswordMessage)
            wrongPasswordMessage.classList.remove("hidden");
        }
      })
      .catch((error) => {
        console.log(error.response);
      });
  };

  return (
    <div className="modal-container hidden" id="change-password-modal">
      <form
        action=""
        className="modal-form"
        id="change-password-modal-form"
        onSubmit={changePasswordHandle}
      >
        <div className="modal-form-top">
          <h2>Change password</h2>
          <div
            className="modal-form-exit-button"
            id="modal-form-exit-button"
            onClick={(e) => {
              closeModal(e);
            }}
          >
            <i className="fa-solid fa-x"></i>
          </div>
        </div>
        <div className="modal-form-input-container">
          <input
            type="password"
            placeholder="Old password"
            id="old-password-input"
            onChange={handleChangeOldPassword}
            onKeyUp={checkEmpty}
            value={oldPassword}
          />
          <p id="hidden-password-message" className="hidden">
            Password is incorrect
          </p>
          <input
            type="password"
            placeholder="New password"
            id="new-password-input"
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
            id="change-password-save-button"
            disabled
          />
          <button className="button-reverse" onClick={(e) => closeModal(e)}>
            CANCLE
          </button>
        </div>
      </form>
    </div>
  );
}

export default Modal;
