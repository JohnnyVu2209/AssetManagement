import React, { useEffect, useState } from "react";
import Box from "@mui/material/Box";
import { DataGrid, GridColDef } from "@mui/x-data-grid";
import "../assets/css/ListView.css";
//import Modal from "../components/Modal";
import { Link, useParams } from "react-router-dom";
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
import Modal from "react-modal";
import AssignmentDetail from "../components/Modal_AssignmentDetail";
import getAssignmentDetail from "../services/assignmentService/assignmentDetail";

const columns: GridColDef[] = [
  { field: "id", headerName: "No", width: 120 },
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
    field: "assignedTo",
    headerName: "Assigned to",
    flex: 1,
  },
  {
    field: "assignedBy",
    headerName: "Assigned by",
    flex: 1,
  },
  {
    field: "assignedDate",
    headerName: "Assigned Date",
    flex: 1,
    type: "date",
    valueFormatter: (params) => {
      const valueFormatted = format(new Date(params.value), "dd/MM/yyyy");
      return `${valueFormatted}`;
    },
  },
  {
    field: "assignedState",
    headerName: "State",
    flex: 1,
    valueFormatter: (params) => {
      const valueFormatted =
        params.value === 1 ? "Accepted" : (params.value === 3 ? "Declined" : "Waiting for acceptance");
      return `${valueFormatted}`;
    },
  },
  {
    field: "",
    type: "actions",
    flex: 1,

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

interface ParamsType {
  sort: string;
}

function AssignmentList() {
  const { sort } = useParams<ParamsType>();
  const [filterContent, setFilterContent] = useState({
    assignDate: "",
    state: [] as number[],
    searching: "",
    orderBy: "id asc",
  });
  const options = [1, 2, 3];
  const [selected, setSelected] = useState([] as number[]);
  const [assignmentList, setAssignmentList] = useState([]);

  useEffect(() => {
    if (sort)
      setFilterContent({ ...filterContent, orderBy: "updatedDate desc" });
    getAssignmentList(filterContent)
      .then((res) => {
        setAssignmentList(res.data);
      })
      .catch((error) => {
        if (error.response) {
          let statusCode = error.response.status;
          if (statusCode == 404) {
            setAssignmentList([]);
          }
        }
      });
  }, [
    filterContent.assignDate,
    filterContent.searching,
    filterContent.state,
    filterContent.orderBy,
    sort,
  ]);

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

  const [modalAssignmentDetail, setModalAssignmentDetail] = useState(false); //open modal

  const [idAssignment, setIdAssignment] = useState<number>();

  const handelModalAssignment = (id: number) => {
    setIdAssignment(id);
    console.log("id: " + id);
    setModalAssignmentDetail(true);
  };

  useEffect(() => {
    if (performance.navigation.type === 1) {
      window.location.href = "/assignment-list";
    } 
  },[])

  return (
    <>
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
                      : (element === 3 ? test.push("Declined") : test.push("Waiting for acceptance"));
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
                        option === 1 ? "Accept" : (option === 3 ? "Declined" : "Waiting for acceptance")
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
            <Link to="/assignment/create">
              <button
                className="page-create-button button"
                style={{ width: "200px" }}
              >
                Create new assignment
              </button>
            </Link>
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
            rows={assignmentList}
            columns={columns}
            pageSize={8}
            // rowsPerPageOptions={[5]}
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
            height: "90%",
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

export default AssignmentList;
