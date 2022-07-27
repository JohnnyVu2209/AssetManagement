import React, { useState } from "react";
import "../assets/css/MessagePopup.css";
const closePopup = () => {
  let closePopup = document.getElementById("message-popup");
  if (closePopup) closePopup.classList.add("hidden");
};

export const openPopup = (text: string) => {
  let openPopupMessage = document.getElementById("message-popup-text");
  let openPopup = document.getElementById("message-popup");
  if (openPopupMessage) openPopupMessage.innerHTML = text;
  if (openPopup) openPopup.classList.remove("hidden");
};

const MessagePopup = () => {
  return (
    <div className="message-popup-container hidden" id="message-popup">
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
    </div>
  );
};
export default MessagePopup;
