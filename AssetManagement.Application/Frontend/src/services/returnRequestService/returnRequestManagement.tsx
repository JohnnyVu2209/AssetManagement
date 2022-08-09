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

export { getReturnRequestList };
