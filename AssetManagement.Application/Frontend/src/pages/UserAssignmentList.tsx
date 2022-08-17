import React, { useEffect, useState } from "react";
import Box from "@mui/material/Box";
import { DataGrid, GridColDef } from "@mui/x-data-grid";
import "../assets/css/ListView.css";
//import Modal from "../components/Modal";
import { Link } from "react-router-dom";
import EditIcon from "@mui/icons-material/Edit";
import HighlightOffIcon from "@mui/icons-material/HighlightOff";
import { CustomPagination } from "../components/CustomPagination";
import {
  getAssignmentByUserLogin,
  acceptAssignment,
  declineAssignment,
  createReturingRequest,
} from "../services/assignmentService/assignmentManagement";
import { format, setISODay } from "date-fns";
import RestartAltIcon from "@mui/icons-material/RestartAlt";
import CheckIcon from "@mui/icons-material/Check";
import CloseIcon from "@mui/icons-material/Close";
import ReplayIcon from "@mui/icons-material/Replay";
import Swal from "sweetalert2";
import Modal from "react-modal";
import AssignmentDetail from "../components/Modal_AssignmentDetail";

function ListAssignmentView() {
  const [needReload, setNeedReload] = useState(false);

  function openAcceptPopup(id: any, e: any) {
    e.stopPropagation();
    Swal.fire({
      title: "Are you sure?",
      text: "Do you want to accept this assignment?",
      showCancelButton: true,
      confirmButtonColor: "#3085d6",
      cancelButtonColor: "#d33",
      confirmButtonText: "Accept",
    }).then(async (result) => {
      if (result.isConfirmed) {
        await acceptAssignment(id);
        console.log("Before needReload change: ", needReload);
        setNeedReload(!needReload);
      }
    });
    return;
  }

  function openDeclinePopup(id: any, e: any) {
    e.stopPropagation();
    Swal.fire({
      title: "Are you sure?",
      text: "Do you want to decline this assignment?",
      showCancelButton: true,
      confirmButtonColor: "#3085d6",
      cancelButtonColor: "#d33",
      confirmButtonText: "Decline",
    }).then(async (result) => {
      if (result.isConfirmed) {
        await declineAssignment(id);
        console.log("Before needReload change: ", needReload);
        setNeedReload(!needReload);
      }
    });
    return;
  }

  function openReturnRequestPopup(id: any, e: any) {
    e.stopPropagation();
    Swal.fire({
      title: "Are you sure?",
      text: "Do you want to create a returning request for this asset?",
      showCancelButton: true,
      confirmButtonColor: "#3085d6",
      cancelButtonColor: "#d33",
      confirmButtonText: "Yes",
    }).then(async (result) => {
      if (result.isConfirmed) {
        await createReturingRequest(id);
        setNeedReload(!needReload);
      }
    });
    return;
  }

  const columns: GridColDef[] = [
    {
      field: "assetCode",
      headerName: "Asset Code",
      flex: 1,
    },
    {
      field: "assetName",
      headerName: "Asset Name",
      flex: 1,
    },
    {
      field: "categoryName",
      headerName: "Category",
      flex: 1,
    },
    {
      field: "assignedDate",
      headerName: "Assigned Date",
      type: "date",
      flex: 1,
      valueFormatter: (params) => {
        const valueFormatted = format(new Date(params.value), "dd/MM/yyyy");
        return `${valueFormatted}`;
      },
    },
    {
      field: "state",
      headerName: "State",
      flex: 1,
      valueFormatter: (param) => {
        if (param.value == 1) return "Accepted";
        else if(param.value == 2 ) return "Waiting for acceptance";
            else return "Waiting for returning" 
      },
    },
    {
      field: "",
      type: "actions",
      flex: 1,
      renderCell: (obj) => {
        return (
            <>
              <CheckIcon
                className={(obj.row.state === 2) ? "" : "disable-action"}
                style={{ color: "red" }}
                onClick={(e) => {
                  openAcceptPopup(obj.id, e);
                }}
              />
              <CloseIcon
                className={obj.row.state === 2 ? "" : "disable-action"}
                style={{ color: "black" }}
                onClick={(e) => {
                  openDeclinePopup(obj.id, e);
                }}
              />
              <ReplayIcon
                className={obj.row.state === 1 ? "" : "disable-action"}
                style={{ color: "CornflowerBlue" }}
                onClick={(e) => {
                  openReturnRequestPopup(obj.id, e);
                }}
              />
            </>
        );
      },
    },
  ];

  const [assignmentList, setAssignmentList] = useState([]);
  const [modalAssignmentDetail, setModalAssignmentDetail] = useState(false); //open modal

  const [idAssignment, setIdAssignment] = useState<number>();

  const handelModalAssignment = (id: number) => {
    setIdAssignment(id);
    console.log("id: " + id);
    setModalAssignmentDetail(true);
  };

  useEffect(() => {
    getAssignmentByUserLogin().then((res) => {
      if (res.response) {
        let statusCode = res.response.status;
        if (statusCode == 404) {
          setAssignmentList([]);
        }
      }
      if (res.data) {
        setAssignmentList(res.data.items);
        console.log("After needReload change: ", needReload);
        console.log("AssignmentList: ", assignmentList);
        console.log("Items: ", res.data.items);
      }
    });
  }, [needReload]);

  return (
    <>
      <div className="app-content page-container">
        <div className="page-top">
          <h1 className="page-title">My Assignment</h1>
        </div>

        <Box sx={{ height: 526.5, width: "100%" }}>
          <DataGrid
            sx={{
              fontFamily: "Nunito Sans",
              fontSize: 15,
              ".MuiDataGrid-columnSeparator": {
                display: "none",
              },
            }}
            components={{
              Pagination: CustomPagination,
            }}
            rows={assignmentList}
            columns={columns}
            pageSize={5}
            disableSelectionOnClick
            disableColumnMenu
            onRowClick={(params) => {
              handelModalAssignment(params.row.id);
            }}
          />
        </Box>
      </div>

      <Modal
        isOpen={modalAssignmentDetail}
        onRequestClose={() => setModalAssignmentDetail(false)}
        style={{
          overlay: {
            backgroundColor: "rgba(0,0,0,0.4)",
            zIndex: 1000,
          },
          content: {
            width: "40%",
            margin: "auto",
            height: "85%",
          },
        }}
      >
        <AssignmentDetail
          data={idAssignment}
          setModalAssignmentDetail={setModalAssignmentDetail}
        />
      </Modal>
    </>
  );
}

export default ListAssignmentView;
