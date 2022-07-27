import axiosInstance from "../axiosInstance";

async function getUserSorting(Keyword: string) {
  return await axiosInstance.get(`api/Users?Keyword=${Keyword}`)
                    .then((res) => {
                        return res;
                        window.location.href="/";
                    })
}

export { getUserSorting };