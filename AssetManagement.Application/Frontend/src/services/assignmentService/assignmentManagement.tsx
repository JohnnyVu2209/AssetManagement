import axiosInstance from "../axiosInstance";

async function getAssignmentList(sortingOption?: any) {
  let stateArray = sortingOption.state;
  let stateString = "";
  let searchString = "";
  let assignDateString = "";
  stateArray.forEach((element: any) => {
    stateString += `&state=${element}`;
  });
  if (sortingOption.searching)
    searchString = `&searching=${sortingOption.searching}`;
  if (assignDateString)
    assignDateString = `&assignDate=${sortingOption.assignDate}`;
  // console.log(stateString);
  return await axiosInstance
    .get(`Assignment?${searchString}${stateString}${assignDateString}`)
    .then((res) => {
      return res;
    })
    .catch((error) => {
      return error;
    });
}

export { getAssignmentList };
