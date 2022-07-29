import axiosInstance from "../axiosInstance";
import {logout} from "./authentication";

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
      console.log(res);
      alert("User information updated");
      window.location.href = "/manage-user";
    })
    .catch((error) => {
      let statusCode = error.response.status;
      if (statusCode === 401) {
        alert("Token Expired. Please re-login to continue");
        logout();
      }
    });
}

async function createUser(data:any){
  axiosInstance
    .post("User/createUser",data)
    .then((data) => {
      console.log(data);
      alert("Created new user successfully.");
      window.location.reload();
    })
    .catch((error) => {
      let statusCode = error.response.status;
      if (statusCode === 401) {
        alert("Token Expired. Please re-login to continue");
        logout();
      }
    });
};


export { getUserByStaffCode, updateUser, createUser };
