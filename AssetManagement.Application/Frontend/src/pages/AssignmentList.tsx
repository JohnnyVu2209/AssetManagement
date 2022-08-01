// @ts-nocheck
import React, { useState } from "react";
import Box from "@mui/material/Box";
import {
  DataGrid,
  GridColDef,
  GridFilterAltIcon,
  GridToolbar,
} from "@mui/x-data-grid";
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
import { FilterAlt } from "@mui/icons-material";
import Select from "@mui/material/Select";
import MenuItem from "@mui/material/MenuItem";
import FormControlLabel from "@mui/material/FormControlLabel";
import Checkbox from "@mui/material/Checkbox";
import ListItemIcon from "@mui/material/ListItemIcon";
import ListItemText from "@mui/material/ListItemText";
import { makeStyles } from "@mui/material/styles";

const columns: GridColDef[] = [
  { field: "id", headerName: "No", width: 100 },
  {
    field: "assetCode",
    headerName: "Asset Code",
    width: 200,
    editable: true,
  },
  {
    field: "assetName",
    headerName: "Asset Name",
    width: 300,
    editable: true,
  },
  {
    field: "assignTo",
    headerName: "Assign to",
    type: "number",
    width: 150,
    editable: true,
  },
  {
    field: "assignBy",
    headerName: "Assign by",
    type: "number",
    width: 150,
    editable: true,
  },
  {
    field: "assignDate",
    headerName: "Assign Date",
    type: "number",
    width: 150,
    editable: true,
  },
  {
    field: "state",
    headerName: "State",
    type: "number",
    width: 250,
    editable: true,
  },
  {
    field: "",
    sortable: false,
    width: 100,
    renderCell: () => {
      return (
        <>
          <Link to={"/"}>
            <EditIcon style={{ color: "black" }} />
          </Link>
          <Link to={"/"}>
            <HighlightOffIcon style={{ color: "red" }} />
          </Link>
        </>
      );
    },
  },
];

const rows = [
  {
    id: 1,
    assetCode: "PC0001",
    assetName: "Personal Computer",
    assignTo: "vuhk",
    assignBy: "vinz",
    assignDate: "2022-08-10",
    state: "Accepted",
  },
  {
    id: 2,
    assetCode: "PC0002",
    assetName: "Personal Computer",
    assignTo: "vuhk",
    assignBy: "vinz",
    assignDate: "2022-08-10",
    state: "Waiting for Acceptance",
  },
];

function ListView() {
  const [stateData, setStateData] = useState([
    { name: "All", check: false },
    { name: "Accepted", check: false },
    { name: "Waiting for acceptance", check: false },
  ]);

  const [filterContent, setFilterContent] = useState({
    assignDate: "",
    state: [],
    keyword: "",
  });

  const testSearch = (e: any) => {
    e.preventDefault();
    console.log(filterContent);
  };

  const handleSearchChange = (e: any) => {
    setFilterContent({ ...filterContent, keyword: e.target.value });
  };

  const handleAsignDateChange = (e: any) => {
    setFilterContent({ ...filterContent, assignDate: e.target.value });
  };

  // const handleStateChange = (e: any) => {
  //   const allSelected = stateData.find((x) => (x.name = "All"));
  //   const newState = stateData.map((obj) => {
  //     if (e.target.name === "All")
  //       return { ...obj, check: allSelected ? !allSelected.check : false };
  //     else if (e.target.name === obj.name) return { ...obj, check: !obj.check };
  //     return obj;
  //   });

  //   setStateData(newState);
  //   // setFilterContent(...filterContent,state:newState)
  //   console.log(stateData);
  // };

  const options = ["Acceepted", "Waiting for acceptance"];
  const [selected, setSelected] = useState([]);
  const isAllSelected =
    options.length > 0 && selected.length === options.length;

  const handleChange = (event: any) => {
    const value = event.target.value;
    if (value[value.length - 1] === "all") {
      setSelected(selected.length === options.length ? [] : options);
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

            {/* <FormControl fullWidth>
              <InputLabel id="state-select-label">State</InputLabel>
              <Select
                IconComponent={GridFilterAltIcon}
                labelId="state-select-label"
              >
                {stateData.map((item) => (
                  <MenuItem>
                    <FormControlLabel
                      control={
                        <Checkbox
                          name={item.name}
                          checked={item.check}
                          onChange={handleStateChange}
                        />
                      }
                      label={item.name}
                    />
                  </MenuItem>
                ))}
              </Select>
            </FormControl> */}
            <FormControl fullWidth>
              <InputLabel id="mutiple-select-label">Multiple Select</InputLabel>
              <Select
                labelId="mutiple-select-label"
                multiple
                value={selected}
                onChange={handleChange}
                renderValue={(selected) => selected.join(", ")}
              >
                <MenuItem value="all">
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
                {options.map((option: any) => (
                  <MenuItem key={option} value={option}>
                    <ListItemIcon>
                      <Checkbox checked={selected.indexOf(option) > -1} />
                    </ListItemIcon>
                    <ListItemText primary={option} />
                  </MenuItem>
                ))}
              </Select>
            </FormControl>
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
              onClick={() => open()}
            >
              CREATE
            </button>
          </div>
        </div>

        <Box sx={{ height: 667, width: "100%" }}>
          <DataGrid
            sx={{
              fontFamily: "Nunito Sans",
              fontSize: 15,
            }}
            rows={rows}
            columns={columns}
            pageSize={5}
            // rowsPerPageOptions={[5]}
            disableSelectionOnClick
          />
        </Box>
      </div>
    </>
  );
}

export default ListView;
