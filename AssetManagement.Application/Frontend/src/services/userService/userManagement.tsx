import Swal from "sweetalert2";
import axiosInstance from "../axiosInstance";
import { logout } from "./authentication";

async function getUserByStaffCode(staffCode: string) {
  return await axiosInstance
    .get("Users/" + staffCode)
    .then((res) => {
      return res;
    })
    .catch((error) => {
      return error;
    });
}

async function updateUser(userInfo: any) {
  console.log(userInfo);
  axiosInstance
    .put("Users", userInfo)
    .then((res) => {
      Swal.fire({
        text: "User information updated",
        customClass: {
          confirmButton: "button",
        },
        buttonsStyling: false,
      }).then(() => {
        window.location.href = "/manage-user";
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
    });
}

async function createUser(data: any) {
  axiosInstance
    .post("User/createUser", data)
    .then((data) => {
      Swal.fire({
        text: "Created new user successfully.",
        customClass: {
          confirmButton: "button",
        },
        buttonsStyling: false,
      }).then(() => {
        window.location.href = "/manage-user";
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
    });
}

export { getUserByStaffCode, updateUser, createUser };
