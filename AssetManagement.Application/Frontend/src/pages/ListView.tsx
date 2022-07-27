import React from "react";
import Box from "@mui/material/Box";
import { DataGrid, GridColDef } from "@mui/x-data-grid";
import "../assets/css/ListView.css";
import Modal from "../components/Modal";
import DataGridToolbar from "../components/DataGridToolbar";

const columns: GridColDef[] = [
  { field: "id", headerName: "ID", width: 90 },
  {
    field: "firstName",
    headerName: "First name",
    width: 150,
    editable: true,
  },
  {
    field: "lastName",
    headerName: "Last name",
    width: 150,
    editable: true,
  },
  {
    field: "age",
    headerName: "Age",
    type: "number",
    width: 110,
    editable: true,
  },
];

const rows = [
  { id: 'SD0001', lastName: "Snow", firstName: "Jon", age: 35 },
  { id: 'SD0002', lastName: "Lannister", firstName: "Cersei", age: 42 },
  { id: 'SD0003', lastName: "Lannister", firstName: "Jaime", age: 45 },
  { id: 'SD0004', lastName: "Stark", firstName: "Arya", age: 16 },
  { id: 'SD0005', lastName: "Targaryen", firstName: "Daenerys", age: null },
  { id: 'SD0006', lastName: "Melisandre", firstName: null, age: 150 },
  { id: 'SD0007', lastName: "Clifford", firstName: "Ferrara", age: 44 },
  { id: 'SD0008', lastName: "Frances", firstName: "Rossini", age: 36 },
  { id: 'SD0009', lastName: "Roxie", firstName: "Harvey", age: 65 },
  { id: 'SD0010', lastName: "Roxie", firstName: "Harvey", age: 65 },
];

function ListView() {

  function open() {
    const modal = document.getElementById("modal");
    if (modal != null) {
      modal.classList.remove("hidden");
    }
  }

  return (
    <>
      <Modal />
      <div className="app-content page-container">
        <div className="page-top">
          <h1 className="page-title">Data List</h1>
          <button className="page-create-button button" onClick={() => open()}>
            CREATE
          </button>
        </div>

        <Box sx={{ height: 667, width: "100%" }}>
          <DataGrid
            sx={{
              fontFamily: "Nunito Sans",
              fontSize: 15,
            }}
            rows={rows}
            columns={columns}
            pageSize={10}
            rowsPerPageOptions={[5]}
            disableSelectionOnClick
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
      </div>
    </>
  );
}

export default ListView;
