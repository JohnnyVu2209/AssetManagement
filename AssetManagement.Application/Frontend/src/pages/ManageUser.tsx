import React, { useEffect, useState } from "react";
import Box from "@mui/material/Box";
import { DataGrid, GridColDef, GridSortDirection } from "@mui/x-data-grid";
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
import { Link, useParams } from "react-router-dom";
import FormControl from "@mui/material/FormControl";
import InputLabel from "@mui/material/InputLabel";
import Select from "@mui/material/Select";
import MenuItem from "@mui/material/MenuItem";
import ListItemIcon from "@mui/material/ListItemIcon";
import Checkbox from "@mui/material/Checkbox";
import ListItemText from "@mui/material/ListItemText";
import InputBase from "@mui/material/InputBase";
import IconButton from "@mui/material/IconButton";
import Paper from "@mui/material/Paper";
import { getUserList } from "../services/userService/userManagement";

const columns: GridColDef[] = [
  /* {
    field: "id",
    headerName: "ID",
    width: 90
  }, */
  {
    field: "staffCode",
    headerName: "Staff Code",
    flex: 1,
    /* width: 100,
    editable: true, */
  },
  {
    field: "fullName",
    headerName: "Full name",
    flex: 1,
    /* width: 150,
    editable: true, */
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
    flex: 1,
    /* width: 100,
    editable: true, */
  },
  {
    field: "type",
    headerName: "Type",
    flex: 1,
    /* valueFormatter: (params) => {
      const valueFormatted =
        params.value === true ? "Admin" : "User";
      return `${valueFormatted}`;
    }, */
    /* width: 90,
    editable: true, */
  },
  {
    field: "action",
    type: "action",
    flex: 1,
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

interface ParamsType {
  isSort: string
}

function ManageUser() {
  const { isSort } = useParams<ParamsType>();
  const [filterContent, setFilterContent] = useState({
    type: [] as number[],
    searching: "",
    orderBy: "staffCode asc"
  });
  const options = [1, 2];
  const [selected, setSelected] = useState([] as number[]);
  const [userList, setUserList] = useState([]);

  //----------------------------------------------------------------
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
    if (isSort)
      setFilterContent({ ...filterContent, orderBy: "updatedDate desc" });
    /* getPagination(); */
    getUserList(filterContent).then((res) => {
      console.log(res);
      if (res.response) {
        let staffCode = res.response.type;
        if (staffCode == 404) {
          /* Data === []; */
          setUserList([]);
        }
      }
      if (res.data) {
        /* Data === res.data; */
        setUserList(res.data);
      }
    });
  }, [filterContent]);

  //----------------------------------------------------------------

  const testSearch = (e: any) => {
    e.preventDefault();
  };

  const handleSearchChange = (e: any) => {
    setFilterContent({ ...filterContent, searching: e.target.value });
  };

  const isAllSelected =
    options.length > 0 && selected.length === options.length;

  const handleChange = (event: any) => {
    const value = event.target.value;
    if (value[value.length - 1] === "All") {
      setSelected(selected.length === options.length ? [] : options);
      setFilterContent({
        ...filterContent,
        type: selected.length === options.length ? [] : options,
      });
      return;
    }
    setSelected(value);
    setFilterContent({ ...filterContent, type: value });
  }; //

  useEffect(() => {
    if (performance.navigation.type === 1) {
      window.location.href = "/manage-user";
    } 
  },[])

  return (
    <>
      <Modal />
      <div className="app-content page-container">
        <div className="page-top">
          <h1 className="page-title">User List</h1>
        </div>
        <div className="page-filter">
          <div className="page-filter-left">
            <FormControl sx={{ width: 300 }}>
              <InputLabel id="mutiple-select-label">Select Type</InputLabel>
              <Select
                labelId="mutiple-select-label"
                multiple
                value={selected}
                onChange={handleChange}
                renderValue={(selected) => {
                  let test = [] as string[];
                  selected.forEach((element) => {
                    element === 1 ? test.push("Admin") : test.push("User");
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
                    <ListItemText primary={option === 1 ? "Admin" : "User"} />
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
                /* type="text" */
                /* id="input-searching" */
                inputProps={{ "nunito-sans": "search google maps" }}
                sx={{ ml: 1, flex: 1 }}
                placeholder=""
                onChange={handleSearchChange}
              />
              <IconButton sx={{ p: "10px" }} aria-label="search">
                <SearchIcon
                  type="submit"
                  id="searchSubmit"
                  /* onClick={goSearching} */
                />
              </IconButton>
            </Paper>
            <Link to="/create-user">
              <button
                className="page-create-button button"
                style={{ width: "200px" }}
              >
                Create new user
              </button>
            </Link>
          </div>
        </div>

        <Box sx={{ height: 500, width: "100%" }}>
          <DataGrid
            sx={{
              fontFamily: "Nunito Sans",
              fontSize: 15,
              ".MuiDataGrid-columnSeparator": {
                display: "none",
              },
            }}
            /* rows={Data} */
            rows={userList}
            columns={columns}
            pageSize={5}
            //rowsPerPageOptions={[5,10,20]} /
            disableSelectionOnClick
            disableColumnMenu
            onRowClick={(params) => {
              openUserDetail(params);
            }}
            components={
              {
                /*  Pagination: CustomPagination, */
              }
            }
            initialState={{
              sorting:{
                sortModel: [{field: !isSort ? filterContent.orderBy.split(' ')[0] : '',
                 sort: !isSort ? filterContent.orderBy.split(' ')[1] as GridSortDirection : 'asc' }]
              }
            }}
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
