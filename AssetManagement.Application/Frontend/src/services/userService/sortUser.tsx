import axios from "axios";

async function getUserSorting(Keyword: string) {
  return await axios.get(`api/Users?Keyword=${Keyword}`)
                    .then((res) => {
                        return res;
                        window.location.href="/";
                    })
}

export { getUserSorting };