import axiosInstance from "../axiosInstance";

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
      console.log(error);
    });
}

export { getUserByStaffCode, updateUser };
