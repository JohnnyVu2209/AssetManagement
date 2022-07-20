import React from "react";
import "../assets/css/Modal.css";

function Modal() {
  function closeModal(e: React.MouseEvent) {
    e.preventDefault();
    const modal = document.getElementById("modal");
    if (modal != null) {
      modal.classList.add("hidden");
    }
  }

  return (
    <div className="modal-container hidden" id="modal">
      <form action="" className="modal-form">
        <div className="modal-form-top">
          <h2>Modal name</h2>
          <button
            className="modal-form-exit-button"
            id="modal-form-exit-button"
            onClick={(e) => {
              closeModal(e);
            }}
          >
            <i className="fa-solid fa-x"></i>
          </button>
        </div>
        <div className="modal-form-input-container">
          {/* <label htmlFor="text-input">Text Input</label> */}
          <input
            type="text"
            placeholder="Text input"
            id="text-input"
            required
          />

          <input type="number" placeholder="Number input" required />
          <textarea placeholder="Text field"></textarea>
        </div>
        <div className="modal-form-buttons">
          <input type="submit" className="button" value="SUBMIT" />
          <button className="button-reverse" onClick={(e) => closeModal(e)}>
            CANCLE
          </button>
        </div>
      </form>
    </div>
  );
}

export default Modal;
