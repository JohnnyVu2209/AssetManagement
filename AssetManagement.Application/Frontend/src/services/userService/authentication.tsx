import axiosInstance from "../axiosInstance";
import { setAuthToken } from "./setAuthToken";
import { openPopup } from "../../components/MessagePopup";
import Swal from "sweetalert2";

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
        Swal.fire({
          text: "User interface is in developing",
          customClass: {
            confirmButton: "button",
          },
          buttonsStyling: false,
        }).then(() => {
          logout();
        });
      } else {
        // Set JWT token to local
        localStorage.setItem("token", token);
        localStorage.setItem("role", role);
        if (!isPasswordChanged)
          localStorage.setItem("isPasswordChanged", "false");

        // Set token to axios common header
        setAuthToken(token);

        // Redirect user to Home page
        window.location.href = "/";
      }
    })
    .catch((error) => {
      let statusCode = error.response.status;
      if (statusCode === 400) {
        Swal.fire({
          text: "Your account is disabled. Please contact with IT Team",
          customClass: {
            confirmButton: "button",
          },
          buttonsStyling: false,
        });
      }
      if (statusCode === 401) {
        Swal.fire({
          text: "Username or password is incorrect. Please try again",
          customClass: {
            confirmButton: "button",
          },
          buttonsStyling: false,
        });
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
      // alert("Your password has been changed successfully");
      // openPopup("Your password has been changed successfully").then(() => {
      //   if (localStorage.getItem("isPasswordChanged"))
      //     localStorage.removeItem("isPasswordChanged");
      //   window.location.href = "/";
      // });
      Swal.fire({
        text: "Your password has been changed successfully",
        customClass: {
          confirmButton: "button",
        },
        buttonsStyling: false,
      }).then(() => {
        if (localStorage.getItem("isPasswordChanged"))
          localStorage.removeItem("isPasswordChanged");
        window.location.href = "/";
      });
    })

    .catch((error) => {
      let statusCode = error.response.status;
      if (statusCode === 401) {
        Swal.fire({
          text: "Token Expired. Please re-login to continue",
          customClass: {
            confirmButton: "button",
          },
          buttonsStyling: false,
        }).then(() => {
          logout();
        });
      }
      if (statusCode === 400) {
        Swal.fire({
          text: "Wrong Password",
          customClass: {
            confirmButton: "button",
          },
          buttonsStyling: false,
        });
        return error;
      }
      // }
    });
}

export { login, logout, changePassword };
