import React, { useEffect } from 'react';
import Box from "@mui/material/Box";
import { DataGrid, GridColDef } from "@mui/x-data-grid";
import "../assets/css/ListView.css";
import Modal from "../components/Modal";
import DataGridToolbar from "../components/DataGridToolbar";
import { ManageUserContext } from '../context/ManageUserContext';
import { manageUserTypeContext } from '../@types/ManageUser';
import { UserDetailContext } from '../context/UserDetailContext';
import { UserDetailContextType } from '../@types/UserDetail';
import UserDetail from '../components/UserDetail';

const columns: GridColDef[] = [
  {
    field: "id",
    headerName: "ID",
    width: 90
  },
  {
    field: "staffCode",
    headerName: "Staff Code",
    width: 90,
    editable: true,
  },
  {
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
  },
  {
    field: "userName",
    headerName: "User name",
    width: 90,
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
  },
];

function ManageUser() {

  const { Data, handleChangeSearching, goSearching, getPagination } = React.useContext(ManageUserContext) as manageUserTypeContext;
  const { openUserDetail } = React.useContext(UserDetailContext) as UserDetailContextType

  useEffect(() => {
    getPagination()
  }, [])

  return (
    <>
      <Modal />
      <div className="app-content page-container">
        <div className="page-top">
          <h1 className="page-title">User List</h1>
          <div>
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
          </div>
          <button className="page-create-button button" onClick={() => open()}>
            Create new user
          </button>
        </div>

        <Box sx={{ height: 667, width: "100%" }}>
          <DataGrid
            sx={{
              fontFamily: "Nunito Sans",
              fontSize: 15,
            }}
            rows={Data}
            columns={columns}
            pageSize={5}
            rowsPerPageOptions={[10]}
            disableSelectionOnClick
            onRowClick={(params) => {
              openUserDetail(params)
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
  )
}

export default ManageUser;