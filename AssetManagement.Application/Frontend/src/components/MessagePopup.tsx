import React, { useState } from "react";
import "../assets/css/MessagePopup.css";
import Swal from "sweetalert2";

const closePopup = () => {
  let closePopup = document.getElementById("message-popup");
  if (closePopup) closePopup.classList.add("hidden");
};

export async function openPopup(text: string) {
  let openPopupMessage = document.getElementById("message-popup-text");
  let openPopup = document.getElementById("message-popup");
  if (openPopupMessage) openPopupMessage.innerHTML = text;
  if (openPopup) openPopup.classList.remove("hidden");
}

const MessagePopup = () => {
  return (
    <template className="message-popup-container hidden" id="message-popup">
      <div className="message-popup-content">
        <div className="message-popup-top">
          <h2>Message</h2>
        </div>
        <div className="message-popup-message">
          <p id="message-popup-text"></p>
        </div>
        <div className="message-popup-buttons">
          <button className="button" onClick={closePopup}>
            OK
          </button>
        </div>
      </div>
    </template>
  );
};
export default MessagePopup;
