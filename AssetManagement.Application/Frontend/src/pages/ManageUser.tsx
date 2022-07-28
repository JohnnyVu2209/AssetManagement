import React, { useEffect } from "react";
import Box from "@mui/material/Box";
import { DataGrid, GridColDef } from "@mui/x-data-grid";
import "../assets/css/ListView.css";
import Modal from "../components/Modal";
import DataGridToolbar from "../components/DataGridToolbar";
import { ManageUserContext } from "../context/ManageUserContext";
import { manageUserTypeContext } from "../@types/ManageUser";
import { UserDetailContext } from "../context/UserDetailContext";
import { UserDetailContextType } from "../@types/UserDetail";
import UserDetail from "../components/UserDetail";
import SearchIcon from "@mui/icons-material/Search";
import EditIcon from "@mui/icons-material/Edit";
import HighlightOffIcon from "@mui/icons-material/HighlightOff";
import { Link } from "react-router-dom";

const columns: GridColDef[] = [
  /* {
    field: "id",
    headerName: "ID",
    width: 90
  }, */
  {
    field: "staffCode",
    headerName: "Staff Code",
    width: 100,
    editable: true,
  },
  {
    field: "fullName",
    headerName: "Full name",
    width: 150,
    editable: true,
    valueGetter: (params) =>
      `${params.row.firstName || ""} ${params.row.lastName || ""}`,
  },
  /* {
    field: "lastName",
    headerName: "Last name",
    width: 90,
    editable: true,
  },
  {
    field: "firstName",
    headerName: "First name",
    width: 90,
    editable: true,
  }, */
  {
    field: "userName",
    headerName: "User name",
    width: 100,
    editable: true,
  },
  {
    field: "type",
    headerName: "Type",
    width: 90,
    editable: true,
  },
  {
    field: "action",
    headerName: "Action",
    width: 100,
    renderCell: (value) => {
      return (
        <>
          <Link to={"/edit-user/" + value.row.staffCode}>
            <EditIcon style={{ color: "black" }} />
          </Link>
          <Link to={"/manage-user/"}>
            <HighlightOffIcon style={{ color: "red" }} />
          </Link>
        </>
      );
    },
  },
];

function ManageUser() {
  const {
    Data,
    handleChangeSearching,
    goSearching,
    getPagination,
  } = React.useContext(ManageUserContext) as manageUserTypeContext;
  const { openUserDetail } = React.useContext(
    UserDetailContext
  ) as UserDetailContextType;

  useEffect(() => {
    getPagination();
  }, []);

  return (
    <>
      <Modal />
      <div className="app-content page-container">
        <div className="page-top">
          <h1 className="page-title">User List</h1>
          <div className="search-bar">
            <input
              type="text"
              id="input-searching"
              className="input-searching"
              placeholder="Search"
              required
              onChange={handleChangeSearching}
            />
            <a onClick={goSearching}>
              <SearchIcon className="search-icon" />
            </a>
          </div>
          {/* <div>
            <input type="text"
              id="input-searching"
              className="input-searching"
              placeholder="Enter name"
              required
              onChange={handleChangeSearching} />
            <button className="search-button"
              type="submit"
              id="searchSubmit"
              onClick={goSearching}>
              Search
            </button>
          </div> */}
          <Link to="/create-user">
            <button className="page-create-button button">
              Create new user
            </button>
          </Link>
        </div>

        <Box sx={{ height: 500, width: "100%" }}>
          <DataGrid
            sx={{
              fontFamily: "Nunito Sans",
              fontSize: 15,
            }}
            rows={Data}
            columns={columns}
            pageSize={5}
            //rowsPerPageOptions={[5,10,20]} /
            disableSelectionOnClick
            onRowClick={(params) => {
              openUserDetail(params);
            }}
            components={{ Toolbar: DataGridToolbar }}
            componentsProps={{
              panel: {
                sx: {
                  "& .MuiTypography-root": {
                    fontFamily: "Nunito Sans",
                  },
                },
              },
            }}
          />
        </Box>
        <UserDetail />
      </div>
    </>
  );
}

export default ManageUser;
