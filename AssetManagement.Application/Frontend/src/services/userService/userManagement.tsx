import Swal from "sweetalert2";
import axiosInstance from "../axiosInstance";
import { logout } from "./authentication";

async function getUserList(sortingOption?: any) {
  let typeArray = sortingOption.type;
  let typeString = "";
  typeArray.forEach((element: any) => {
    typeString += `&Type=${element == 1 ? "Admin" : "User"}`;
  });
  // console.log(typeString);

  return await axiosInstance
    .get(
      `User/GetUsersList?${typeString}&Searching=${sortingOption.searching}&OrderBy=${sortingOption.orderBy}&PageSize=500`
    );
}


const getUsers = (pageNumber: number, orderBy: string, searching: string) => {
  return axiosInstance.get('User/GetUsersList',
    {
      params: {
        PageSize: 5,
        pageNumber,
        orderBy,
        searching,
      }
    })
}


async function getUserByStaffCode(staffCode: string) {
  return await axiosInstance
    .get("User/" + staffCode)
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
    .put("User", userInfo)
    .then((res) => {
      Swal.fire({
        text: "User information updated",
        customClass: {
          confirmButton: "button",
        },
        buttonsStyling: false,
      }).then(() => {
        window.location.href = "/manage-user/true";
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
        window.location.href = "/manage-user/true";
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

export { getUserList, getUserByStaffCode, updateUser, createUser, getUsers };
