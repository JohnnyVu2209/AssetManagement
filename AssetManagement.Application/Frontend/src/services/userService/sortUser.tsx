import axiosInstance from "../axiosInstance";
import {logout} from "./authentication";

async function getUserSorting(Keyword: string) {
  return await 
    axiosInstance.get(`User?Keyword=${Keyword}`)
                    .then((res) => {
                        return res;
                    }).catch((error) => {
                      let statusCode = error.response.status;
                      if (statusCode === 401) {
                        alert("Token Expired. Please re-login to continue");
                        logout();
                      }
                      return error;
                      
                      // }
                    });
}

export { getUserSorting };