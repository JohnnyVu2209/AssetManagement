import React, { useEffect, useState } from "react";
import Box from "@mui/material/Box";
import { DataGrid, GridColDef } from "@mui/x-data-grid";
import "../assets/css/ListView.css";
import Modal from "../components/Modal";
import { Link } from "react-router-dom";
import EditIcon from "@mui/icons-material/Edit";
import HighlightOffIcon from "@mui/icons-material/HighlightOff";
import TextField from "@mui/material/TextField";
import Paper from "@mui/material/Paper";
import InputBase from "@mui/material/InputBase";
import IconButton from "@mui/material/IconButton";
import SearchIcon from "@mui/icons-material/Search";
import FormControl from "@mui/material/FormControl";
import InputLabel from "@mui/material/InputLabel";
import Select from "@mui/material/Select";
import MenuItem from "@mui/material/MenuItem";
import Checkbox from "@mui/material/Checkbox";
import ListItemIcon from "@mui/material/ListItemIcon";
import ListItemText from "@mui/material/ListItemText";
import { CustomPagination } from "../components/CustomPagination";
import { getAssignmentList } from "../services/assignmentService/assignmentManagement";
import { format } from "date-fns";
import RestartAltIcon from "@mui/icons-material/RestartAlt";
import Stack from "@mui/material/Stack";

const columns: GridColDef[] = [
  { field: "id", headerName: "No", width: 120 },
  {
    field: "assetCode",
    headerName: "Asset Code",
    flex:1,
  },
  {
    field: "assetName",
    headerName: "Asset Name",
    flex:1,
  },
  {
    field: "assignedTo",
    headerName: "Assigned to",
    flex:1,
  },
  {
    field: "assignedBy",
    headerName: "Assigned by",
    flex:1,
  },
  {
    field: "assignedDate",
    headerName: "Assigned Date",
    flex:1,
    type: "date",
    valueFormatter: (params) => {
      const valueFormatted = format(new Date(params.value), "dd/MM/yyyy");
      return `${valueFormatted}`;
    },
  },
  {
    field: "assignedState",
    headerName: "State",
    flex:1,
    valueFormatter: (params) => {
      const valueFormatted =
        params.value === 1 ? "Accepted" : "Waiting for acceptance";
      return `${valueFormatted}`;
    },
  },
  {
    field: "",
    type: "actions",
    flex:1,
    renderCell: () => {
      return (
        <>
          <Link to={"/assignment-list"}>
            <EditIcon style={{ color: "black" }} />
          </Link>
          <Link to={"/assignment-list"}>
            <HighlightOffIcon style={{ color: "red" }} />
          </Link>
          <Link to={"/assignment-list"}>
            <RestartAltIcon style={{ color: "CornflowerBlue" }} />
          </Link>
        </>
      );
    },
  },
];

function ListView() {
  const [filterContent, setFilterContent] = useState({
    assignDate: "",
    state: [] as number[],
    searching: "",
  });
  const options = [1, 2];
  const [selected, setSelected] = useState([] as number[]);
  const [assignmentList, setAssignmentList] = useState([]);
  useEffect(() => {
    getAssignmentList(filterContent).then((res) => {
      if (res.response) {
        let statusCode = res.response.status;
        if (statusCode == 404) {
          setAssignmentList([]);
        }
      }
      if (res.data) {
        setAssignmentList(res.data);
      }
    });
  }, [filterContent]);

  const testSearch = (e: any) => {
    e.preventDefault();
  };

  const handleSearchChange = (e: any) => {
    setFilterContent({ ...filterContent, searching: e.target.value });
  };

  const handleAsignDateChange = (e: any) => {
    setFilterContent({ ...filterContent, assignDate: e.target.value });
  };

  const isAllSelected =
    options.length > 0 && selected.length === options.length;

  const handleChange = (event: any) => {
    const value = event.target.value;
    if (value[value.length - 1] === "All") {
      setSelected(selected.length === options.length ? [] : options);
      setFilterContent({
        ...filterContent,
        state: selected.length === options.length ? [] : options,
      });
      return;
    }
    setSelected(value);
    setFilterContent({ ...filterContent, state: value });
  };

  return (
    <>
      <Modal />
      <div className="app-content page-container">
        <div className="page-top">
          <h1 className="page-title">Assignment List</h1>
        </div>
        <div className="page-filter">
          <div className="page-filter-left">
            <FormControl sx={{ width: 300 }}>
              <InputLabel id="mutiple-select-label">Multiple Select</InputLabel>
              <Select
                labelId="mutiple-select-label"
                multiple
                value={selected}
                onChange={handleChange}
                renderValue={(selected) => {
                  let test = [] as string[];
                  selected.forEach((element) => {
                    element === 1
                      ? test.push("Accepted")
                      : test.push("Waiting for acceptance");
                  });
                  return test.join(", ");
                }}
              >
                <MenuItem value="All">
                  <ListItemIcon>
                    <Checkbox
                      checked={isAllSelected}
                      indeterminate={
                        selected.length > 0 && selected.length < options.length
                      }
                    />
                  </ListItemIcon>
                  <ListItemText primary="Select All" />
                </MenuItem>
                {options.map((option) => (
                  <MenuItem key={option} value={option}>
                    <ListItemIcon>
                      <Checkbox checked={selected.indexOf(option) > -1} />
                    </ListItemIcon>
                    <ListItemText
                      primary={
                        option === 1 ? "Accept" : "Waiting for acceptance"
                      }
                    />
                  </MenuItem>
                ))}
              </Select>
            </FormControl>
            <div>
              <TextField
                id="date"
                label="Assign Date"
                type="date"
                sx={{ width: 220 }}
                InputLabelProps={{
                  shrink: true,
                }}
                onChange={handleAsignDateChange}
              />
            </div>
          </div>

          <div className="page-filter-right">
            <Paper
              component="form"
              sx={{
                p: "2px 4px",
                display: "flex",
                alignItems: "center",
                width: 400,
              }}
              onSubmit={testSearch}
            >
              <InputBase
                sx={{ ml: 1, flex: 1 }}
                placeholder=""
                inputProps={{ "nunito-sans": "search google maps" }}
                onChange={handleSearchChange}
              />
              <IconButton type="submit" sx={{ p: "10px" }} aria-label="search">
                <SearchIcon />
              </IconButton>
            </Paper>
            <button
              className="page-create-button button"
              style={{ width: "200px" }}
              onClick={() => open()}
            >
              Create new assignment
            </button>
          </div>
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
              // NoRowsOverlay: () => (
              //   <Stack
              //     height="100%"
              //     alignItems="center"
              //     justifyContent="center"
              //   >
              //     No rows in DataGrid
              //   </Stack>
              // ),
              // NoResultsOverlay: () => (
              //   <Stack
              //     height="100%"
              //     alignItems="center"
              //     justifyContent="center"
              //   >
              //     Local filter returns no result
              //   </Stack>
              // ),
            }}
            rows={assignmentList}
            columns={columns}
            pageSize={8}
            // rowsPerPageOptions={[5]}
            disableSelectionOnClick
          />
        </Box>
      </div>
    </>
  );
}

export default ListView;
