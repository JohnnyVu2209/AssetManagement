import Swal from "sweetalert2";
import axiosInstance from "../axiosInstance";

async function getReturnRequestList(sortingOption?: any) {
  let stateArray = sortingOption.state;
  let stateString = "";
  stateArray.forEach((element: any) => {
    stateString += `&state=${element}`;
  });
  console.log(stateString);

  return await axiosInstance
    .get(
      `ReturnRequest?searching=${sortingOption.searching}${stateString}&returnedDate=${sortingOption.returnedDate}`
    )
    .then((res) => {
      return res;
    })
    .catch((error) => {
      return error;
    });
}

async function updateReturnRequestStatus(id: number, state: boolean) {
  return await axiosInstance
    .put(`/ReturnRequest/${id}/${state}`)
    .then((res) => {
      Swal.fire({
        text: "Returning request updated",
        customClass: {
          confirmButton: "button",
        },
        buttonsStyling: false,
      }).then(() => {
        return;
      });
    })
    .catch((error) => {
      Swal.fire({
        text: "Error occured!",
        customClass: {
          confirmButton: "button",
        },
        buttonsStyling: false,
      }).then(() => {
        return;
      });
    });
}

export { getReturnRequestList, updateReturnRequestStatus };
