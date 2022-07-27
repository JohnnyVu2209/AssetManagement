import React, { useState } from "react";
import "../assets/css/Login.css";
import { login } from "../services/userService/authentication";

function Login() {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const loginButton = document.getElementById("login-button");

  const handleChangeUsername = (e: any) => {
    setUsername(e.target.value);
  };

  const handleChangePassword = (e: any) => {
    setPassword(e.target.value);
  };

  const checkEmpty = () => {
    if (loginButton) {
      if (username != "" && password != "")
        loginButton.removeAttribute("disabled");
      if (username == "" || password == "")
        loginButton.setAttribute("disabled", "");
    }
  };

  function loginHandle(e: any) {
    e.preventDefault();
    login(username, password);
  }

  return (
    <div className="login-container">
      <div className="login-side-img">
        <img src="/Logo.png" alt="" className="login-logo" />
      </div>
      <form className="login-form" onSubmit={loginHandle}>
        <div className="login-top">
          <p>
            Welcome to Page<br></br>
            Please Sign in to your account
          </p>
        </div>
        <div className="login-input">
          <input
            type="text"
            placeholder="Username"
            id="username"
            onChange={handleChangeUsername}
            onKeyUp={checkEmpty}
            value={username}
          />
          <input
            type="password"
            placeholder="Password"
            id="password"
            onChange={handleChangePassword}
            onKeyUp={checkEmpty}
            value={password}
          />
        </div>
        <div className="login-buttons">
          <input
            type="submit"
            className="button login-button"
            value="Sign In"
            disabled
            id="login-button"
          />
        </div>
      </form>
    </div>
  );
}

export default Login;
