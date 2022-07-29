import axiosInstance from "../axiosInstance";

async function getUserSorting(Keyword: string) {
  return await axiosInstance.get(`Users?Keyword=${Keyword}`)
                    .then((res) => {
                        return res;
                        window.location.href="/";
                    })
}

export { getUserSorting };