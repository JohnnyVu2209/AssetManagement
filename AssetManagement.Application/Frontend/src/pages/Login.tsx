import React from "react";
import "../assets/css/Login.css";
import { login } from "../services/userService/authentication";

function loginHandle(e: React.FormEvent<HTMLInputElement>) {
  e.preventDefault();
  let username = "";
  let password = "";
  const usernameInput = document.getElementById("username") as HTMLInputElement;
  const passwordInput = document.getElementById("password") as HTMLInputElement;
  if (!usernameInput.value || !passwordInput.value) {
    alert("Please fill in Username and Password");
    return;
  }
  if (usernameInput.value) {
    username = usernameInput.value;
  }
  if (passwordInput.value) {
    password = passwordInput.value;
  }
  login(username, password);
}

function Login() {
  return (
    <div className="login-container">
      <div className="login-side-img">
        <img src="/Logo.png" alt="" className="login-logo" />
      </div>
      <form className="login-form">
        <div className="login-top">
          <p>
            Welcome to Page<br></br>
            Please Sign in to your account
          </p>
        </div>
        <div className="login-input">
          <input type="text" placeholder="Username" id="username" />
          <input type="password" placeholder="Password" id="password" />
        </div>
        <div className="login-buttons">
          <input
            type="submit"
            className="button login-button"
            value="Sign In"
            onClick={(e: React.FormEvent<HTMLInputElement>) => loginHandle(e)}
          />
        </div>
      </form>
    </div>
  );
}

export default Login;
