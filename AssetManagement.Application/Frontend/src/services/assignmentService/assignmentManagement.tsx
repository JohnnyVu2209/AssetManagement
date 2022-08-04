import axiosInstance from "../axiosInstance";

async function getAssignmentList(sortingOption?: any) {
  let stateArray = sortingOption.state;
  let stateString = "";
  stateArray.forEach((element: any) => {
    stateString += `&state=${element}`;
  });
  console.log(stateString);

  return await axiosInstance
    .get(
      `Assignment?searching=${sortingOption.searching}${stateString}&assignDate=${sortingOption.assignDate}`
    )
    .then((res) => {
      return res;
    })
    .catch((error) => {
      return error;
    });
}

export { getAssignmentList };
