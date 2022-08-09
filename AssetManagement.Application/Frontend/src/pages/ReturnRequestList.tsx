import React, { useEffect, useState } from "react";
import Box from "@mui/material/Box";
import { DataGrid, GridColDef } from "@mui/x-data-grid";
import "../assets/css/ListView.css";
import Modal from "../components/Modal";
import { Link } from "react-router-dom";
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
import { getReturnRequestList } from "../services/returnRequestService/returnRequestManagement";
import { format } from "date-fns";
import CheckIcon from "@mui/icons-material/Check";
import CloseIcon from "@mui/icons-material/Close";

const columns: GridColDef[] = [
  { field: "id", headerName: "No", flex: 1.5 },
  {
    field: "assetCode",
    headerName: "Asset Code",
    flex: 3,
  },
  {
    field: "assetName",
    headerName: "Asset Name",
    flex: 4,
  },
  {
    field: "requestedBy",
    headerName: "Requested by",
    flex: 3,
  },

  {
    field: "assignedDate",
    headerName: "Assigned Date",
    flex: 3,
    type: "date",
    valueFormatter: (params) => {
      const valueFormatted = format(new Date(params.value), "dd/MM/yyyy");
      return `${valueFormatted}`;
    },
  },
  {
    field: "acceptedBy",
    headerName: "Accepted by",
    flex: 3,
  },
  {
    field: "returnedDate",
    headerName: "Returned Date",
    flex: 3,
    type: "date",
    valueFormatter: (params) => {
      const valueFormatted = format(new Date(params.value), "dd/MM/yyyy");
      return `${valueFormatted}`;
    },
  },
  {
    field: "state",
    headerName: "State",
    flex: 4,
    valueFormatter: (params) => {
      const valueFormatted =
        params.value === 1 ? "Completed" : "Waiting for returning";
      return `${valueFormatted}`;
    },
  },
  {
    field: "",
    type: "actions",
    flex: 2,
    renderCell: (params) => {
      return (
        <div className={params.row.state === 1 ? "disable-action" : ""}>
          <Link to={"/return-request-list"}>
            <CheckIcon style={{ color: "red" }} />
          </Link>
          <Link to={"/return-request-list"}>
            <CloseIcon style={{ color: "black" }} />
          </Link>
        </div>
      );
    },
  },
];

function ReturnRequestList() {
  const [filterContent, setFilterContent] = useState({
    returnedDate: "",
    state: [] as number[],
    searching: "",
  });
  const options = [1, 2];
  const [selected, setSelected] = useState([] as number[]);
  const [returnRequestList, setReturnRequestList] = useState([]);
  useEffect(() => {
    getReturnRequestList(filterContent).then((res) => {
      if (res.response) {
        let statusCode = res.response.status;
        if (statusCode == 404) {
          setReturnRequestList([]);
        }
      }
      if (res.data) {
        setReturnRequestList(res.data);
      }
    });
  }, [filterContent]);

  const testSearch = (e: any) => {
    e.preventDefault();
  };

  const handleSearchChange = (e: any) => {
    setFilterContent({ ...filterContent, searching: e.target.value });
  };

  const handleReturnedDateChange = (e: any) => {
    setFilterContent({ ...filterContent, returnedDate: e.target.value });
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
          <h1 className="page-title">Request List</h1>
        </div>
        <div className="page-filter">
          <div className="page-filter-left">
            <FormControl sx={{ width: 300 }}>
              <InputLabel id="mutiple-select-label">State</InputLabel>
              <Select
                labelId="mutiple-select-label"
                multiple
                value={selected}
                onChange={handleChange}
                renderValue={(selected) => {
                  let test = [] as string[];
                  selected.forEach((element) => {
                    element === 1
                      ? test.push("Completed")
                      : test.push("Waiting for returning");
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
                        option === 1 ? "Completed" : "Waiting for returning"
                      }
                    />
                  </MenuItem>
                ))}
              </Select>
            </FormControl>
            <div>
              <TextField
                id="date"
                label="Returned Date"
                type="date"
                sx={{
                  width: 220,
                }}
                InputLabelProps={{
                  shrink: true,
                }}
                onChange={handleReturnedDateChange}
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
            }}
            rows={returnRequestList}
            columns={columns}
            pageSize={8}
            // rowsPerPageOptions={[5]}
            disableSelectionOnClick
            disableColumnMenu
          />
        </Box>
      </div>
    </>
  );
}

export default ReturnRequestList;
