import axios from "axios";
import { setAuthToken } from "./setAuthToken";

function login(Username: string, Password: string) {
  const loginPayload = {
    Username: Username,
    Password: Password,
  };
  // Login request
  axios
    .post("api/authentication/login", loginPayload)
    .then((response) => {
      // Get token from response
      const token = response.data.token;
      const role = response.data.role;
      //   console.log(token);

      // Set JWT token to local
      localStorage.setItem("token", token);
      localStorage.setItem("role", role);

      // Set token to axios common header
      setAuthToken(token);

      // Redirect user to Home page
      window.location.href = "/";
    })
    .catch((error) => console.log(error));
}

function logout() {
  localStorage.removeItem("token");
  window.location.href = "/login";
}

export { login, logout };
