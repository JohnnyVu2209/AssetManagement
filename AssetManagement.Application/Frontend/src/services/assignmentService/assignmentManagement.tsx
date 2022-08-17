import Swal from "sweetalert2";
import axiosInstance from "../axiosInstance";

var qs = require("qs");

// async function getAssignmentList(sortingOption?: any) {
//   let stateArray = sortingOption.state;
//   let stateString = "";
//   stateArray.forEach((element: any) => {
//     stateString += `&state=${element}`;
//   });
//   console.log(stateString);

//   return await axiosInstance
//     .get(
//       `Assignment?searching=${sortingOption.searching}${stateString}&assignDate=${sortingOption.assignDate}`
//     )
//     .then((res) => {
//       return res;
//     })
//     .catch((error) => {
//       return error;
//     });
// }

const getAssignmentList = async (sortingOption?: any) => {
  return await axiosInstance.get("Assignment", {
    params: {
      state: sortingOption.state,
      searching: sortingOption.searching,
      orderBy: sortingOption.orderBy,
      assignDate: sortingOption.assignDate,
    },
    paramsSerializer: (params) => {
      return qs.stringify(params);
    },
  });
};

const getAssignmentDetail = async (id: number) => {
  return axiosInstance.get(`Assignment/${id}`);
};

const createAssignment = async (data: any) => {
  return await axiosInstance
    .post("Assignment/CreateAssignment", data)
    .then(() => {
      Swal.fire({
        text: "Create new assignment successfully",
        customClass: {
          confirmButton: "button",
        },
        buttonsStyling: false,
      })
        .then(() => {
          window.location.href = "/assignment-list/true";
        })
        .catch((error) => {
          console.log(error);
        });
    });
};

const updateAssignment = async (id: number, data: any) => {
  return axiosInstance
    .put(`Assignment/EditAssignment/${id}`, data)
    .then(() => {
      Swal.fire({
        text: "Edit assignment successfully",
        customClass: {
          confirmButton: "button",
        },
        buttonsStyling: false,
      }).then(() => {
        window.location.href = "/assignment-list/true";
      });
    })
    .catch(() => {
      Swal.fire({
        text: "Edit assignment failed",
        customClass: {
          confirmButton: "button",
        },
        buttonsStyling: false,
      });
    });
};

async function getAssignmentByUserLogin() {
  return await axiosInstance
    .get(`Assignment/ByUserLogin`)
    .then((res) => {
      return res;
    })
    .catch((error) => {
      return error;
    });
}

async function acceptAssignment(id: number) {
  return await axiosInstance
    .put(`Assignment/Accept/${id}`)
    .then(() => {
      Swal.fire({
        text: "Accept this assignment successfully!",
        customClass: {
          confirmButton: "button",
        },
        buttonsStyling: false,
      });
    })
    .catch((error) => {
      return error;
    });
}

async function declineAssignment(id: number) {
  return await axiosInstance
    .put(`Assignment/Decline/${id}`)
    .then(() => {
      Swal.fire({
        text: "Decline this assignment successfully!",
        customClass: {
          confirmButton: "button",
        },
        buttonsStyling: false,
      });
    })
    .catch((error) => {
      return error;
    });
}

async function createReturingRequest(assignmentId: any) {
  return await axiosInstance
    .post(`ReturnRequest/${assignmentId}`)
    .then(() => {
      Swal.fire({
        text: "Create returning request for this assignment successfully!",
        customClass: {
          confirmButton: "button",
        },
        buttonsStyling: false,
      });
    })
    .catch((error) => {
      return error;
    });
}

async function deleteAssignmentById(id: number) {
  return await axiosInstance
    .delete(`Assignment/${id}`)
    .then((res) => {
      return res;
    })
    .catch((error) => {
      return error;
    });
}

export {
  getAssignmentList,
  getAssignmentByUserLogin,
  acceptAssignment,
  declineAssignment,
  createAssignment,
  getAssignmentDetail,
  updateAssignment,
  createReturingRequest,
  deleteAssignmentById,
};
