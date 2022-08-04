import Swal from "sweetalert2";
import axiosInstance from "../axiosInstance";
import { logout } from "../userService/authentication";

async function createAsset(data:any){
    axiosInstance
        .post("Asset",data)
        .then((data) => {
            Swal.fire({
                text: "Created new asset successfully.",
                customClass: {
                confirmButton: "button",
            },
            buttonsStyling: false,
            }).then(() => {
                window.location.href = "/manage-asset";
                // window.location.href = "/manage-user";
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

async function createCategory(data:any){
    axiosInstance
        .post("Categories", data)
        .then((data) => {
            Swal.fire({
                text: "Created new category successfully.",
                customClass: {
                confirmButton: "button",
            },
            buttonsStyling: false,
            }).then(() => {
                window.location.href = "/create-asset";
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
        })
}

async function getCategories(){
    return await axiosInstance
        .get("Categories")
        .then((res) => {
            return res;
        })
        .catch((error)=>{
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
        })
}

export { createAsset, createCategory, getCategories };