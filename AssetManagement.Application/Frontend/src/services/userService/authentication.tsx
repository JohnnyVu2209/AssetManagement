import axiosInstance from "../axiosInstance";
import { setAuthToken } from "./setAuthToken";
import { openPopup } from "../../components/MessagePopup";

function login(Username: string, Password: string) {
  const loginPayload = {
    Username: Username,
    Password: Password,
  };
  // Login request
  axiosInstance
    .post("authentication/login", loginPayload)
    .then((response) => {
      // Get token from response
      const token = response.data.token;
      const role = response.data.role;
      const isPasswordChanged = response.data.isPasswordChanged;
      //   console.log(token);
      if (role === "User") {
        alert("User interface is in developing");
        window.location.href = "/login";
      }

      // Set JWT token to local
      localStorage.setItem("token", token);
      localStorage.setItem("role", role);
      if (!isPasswordChanged)
        localStorage.setItem("isPasswordChanged", "false");

      // Set token to axios common header
      setAuthToken(token);

      // Redirect user to Home page
      window.location.href = "/";
    })
    .catch((error) => {
      let statusCode = error.response.status;
      if (statusCode === 400) {
        openPopup("Your account is disabled. Please contact with IT Team");
      }
      if (statusCode === 401) {
        openPopup("Username or password is incorrect. Please try again");
      }
    });
}

function logout() {
  localStorage.clear();
  window.location.href = "/login";
}

async function changePassword(oldPassword: string, newPassword: string) {
  const changePasswordPayload = {
    oldPassword: oldPassword,
    newPassword: newPassword,
  };
  return await axiosInstance
    .put("Authentication/changePassword", changePasswordPayload)
    .then((res) => {
      alert("Your password has been changed successfully");
      if (localStorage.getItem("isPasswordChanged"))
        localStorage.removeItem("isPasswordChanged");
      window.location.href = "/";
    })
    .catch((error) => {
      let statusCode = error.response.status;
      if (statusCode === 401) {
        alert("Token Expired. Please re-login to continue");
        logout();
      }
      if (statusCode === 400) {
        openPopup("Wrong Password");
        return error;
      }
      // }
    });
}

export { login, logout, changePassword };
