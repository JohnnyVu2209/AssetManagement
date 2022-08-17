import {
  Box,
  Checkbox,
  createTheme,
  Dialog,
  DialogContent,
  DialogContentText,
  DialogTitle,
  FormControl,
  FormControlLabel,
  Grid,
  IconButton,
  InputAdornment,
  InputLabel,
  makeStyles,
  MenuItem,
  Pagination,
  PaginationItem,
  PaginationProps,
  Paper,
  Select,
  Slide,
  Stack,
  styled,
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  TableSortLabel,
  TextField,
  ThemeProvider,
  Typography,
} from "@mui/material";
import SearchOffIcon from "@mui/icons-material/SearchOff";
import React, { useEffect, useState } from "react";
import { Link, useParams } from "react-router-dom";
import FilterAltIcon from "@mui/icons-material/FilterAlt";
import SearchIcon from "@mui/icons-material/Search";
import CheckIcon from "@mui/icons-material/Check";
import EditIcon from "@mui/icons-material/Edit";
import CancelPresentationIcon from "@mui/icons-material/CancelPresentation";
import CloseIcon from "@mui/icons-material/Close";
import TableHeader, {
  getComparator,
  Order,
  stableSort,
} from "../components/TableHeader";
import "../assets/css/Pagination.css";
import { useAppDispatch, useAppSelector } from "../features/hooks";
import {
  getCategories,
  FilterSelect,
  getStates,
  getAssetDetails,
  History,
} from "../features/AssetSlice";
import assetService from "../services/assetService";
import Swal from "sweetalert2";
import { deleteAsset } from "../services/assetService/assetManagement";
import { TransitionProps } from "@mui/material/transitions";
import { format } from "date-fns";

const assetMockData = [
  {
    code: "LA000001",
    name: "Laptop HP Probook 450 G1",
    category: "Laptop",
    state: "Available",
    location: "Hồ Chí Minh",
  },
  {
    code: "MO000001",
    name: "Moninor Dell UltraSharp",
    category: "Laptop",
    state: "Available",
    location: "Đà Nẵng",
  },
  {
    code: "PC000001",
    name: "Personal Computer",
    category: "Laptop",
    state: "Available",
    location: "Hà Nội",
  },
  {
    code: "LA000002",
    name: "Laptop HP Probook 450 G1",
    category: "Laptop",
    state: "Available",
    location: "Hồ Chí Minh",
  },
  {
    code: "MO000002",
    name: "Moninor Dell UltraSharp",
    category: "Laptop",
    state: "Available",
    location: "Đà Nẵng",
  },
  {
    code: "PC000002",
    name: "Personal Computer",
    category: "Laptop",
    state: "Available",
    location: "Hà Nội",
  },
  {
    code: "PC000002",
    name: "Personal Computer",
    category: "Laptop",
    state: "Available",
    location: "Hà Nội",
  },
  {
    code: "PC000002",
    name: "Personal Computer",
    category: "Laptop",
    state: "Available",
    location: "Hà Nội",
  },
  {
    code: "PC000002",
    name: "Personal Computer",
    category: "Laptop",
    state: "Available",
    location: "Hà Nội",
  },
  {
    code: "PC000002",
    name: "Personal Computer",
    category: "Laptop",
    state: "Available",
    location: "Hà Nội",
  },
];

const assetHistoryMock = [
  {
    date: "12/10/2018",
    assignedTo: "hungtv1",
    assignedBy: "binhnv",
    returnedDate: "07/03/2019",
  },
  {
    date: "10/03/2019",
    assignedTo: "thinhptx",
    assignedBy: "tuanha",
    returnedDate: "22/03/2020",
  },
];

const TABLE_HEAD = [
  { id: "code", label: "Asset Code" },
  { id: "name", label: "Asset Name" },
  { id: "category", label: "Category" },
  { id: "state", label: "State" },
  { id: "", label: "" },
];

const HISTORY_HEAD = [
  { id: "date", label: "Date" },
  { id: "assignedTo", label: "Assigned To" },
  { id: "assignedBy", label: "Assigned By" },
  { id: "returnedDate", label: "Returned Date" },
];

interface AssetData {
  code: string;
  name: string;
  category: string;
  state: string;
  updatedDate: string;
  id: number;
}

interface SelectData {
  id: number;
  name: string;
  check: boolean;
}

type Pagination = {
  Category: number[];
  CurrentPage: number;
  HasNext: boolean;
  HasPrevious: boolean;
  PageSize: number;
  State: number[];
  TotalCount: number;
  TotalPages: number;
};

interface ParamsType {
  sort: string;
}

const Transition = React.forwardRef(function Transition(
  props: TransitionProps & {
    children: React.ReactElement<any, any>;
  },
  ref: React.Ref<unknown>
) {
  return <Slide direction="up" ref={ref} {...props} />;
});

const BootstrapDialog = styled(Dialog)(({ theme }) => ({
  "& .MuiDialogContent-root": {
    padding: theme.spacing(2),
  },
  // '& .MuiDialogActions-root': {
  //   padding: theme.spacing(1),
  // },
}));

export interface DialogTitleProps {
  id: string;
  children?: React.ReactNode;
  onClose: () => void;
}

const BootstrapDialogTitle = (props: DialogTitleProps) => {
  const { children, onClose, ...other } = props;

  return (
    <DialogTitle
      sx={{
        m: 0,
        p: 2,
        color: "#cf2338",
        backgroundColor: "#eff1f5",
        fontWeight: "bold",
      }}
      {...other}
    >
      {children}
      {onClose ? (
        <IconButton
          aria-label="close"
          onClick={onClose}
          sx={{
            position: "absolute",
            right: 8,
            top: 8,
            color: "#e63d47",
          }}
        >
          <CancelPresentationIcon />
        </IconButton>
      ) : null}
    </DialogTitle>
  );
};

interface AssetProps {
  fieldName: string;
  fieldValue: any;
}

const AssetField = (props: AssetProps) => {
  return (
    <>
      <Grid item xs={1} />
      <Grid item xs={3}>
        <Typography variant="h6" gutterBottom component="div">
          {props.fieldName}
        </Typography>
      </Grid>
      <Grid item xs={6}>
        <Typography variant="h6" gutterBottom component="div">
          {props.fieldValue}
        </Typography>
      </Grid>
      <Grid item xs={2} />
    </>
  );
};

const ManageAsset = () => {
  const { categories, states, asset } = useAppSelector((state) => state.assets);
  const dispatch = useAppDispatch();
  const { sort } = useParams<ParamsType>();
  const [stateData, setStateData] = useState<SelectData[]>([
    {
      id: 1,
      name: "Assigned",
      check: true,
    },
    {
      id: 2,
      name: "Available",
      check: true,
    },
    {
      id: 3,
      name: "Not available",
      check: true,
    },
  ]);

  const [open, setOpen] = React.useState(false);

  const handleClickOpen = (id: number) => {
    setAssetId(id);
    setOpen(true);
  };

  const handleClose = () => {
    setOpen(false);
  };

  const [assetId, setAssetId] = useState<number>();
  const [assetData, setAssetData] = useState<AssetData[]>([]);
  const [categoryData, setCategoryData] = useState<SelectData[]>([]);
  const [page, setPage] = useState(1);
  const [pageSize, setPageSize] = useState(5);
  const [pagination, setPagination] = useState<Pagination>();
  const [filterName, setFilterName] = useState("");
  const [order, setOrder] = React.useState<Order>("asc");
  const [orderBy, setOrderBy] = React.useState<keyof AssetData>("code");
  const [returnAssetState, setReturnRequestState] = useState(true);
  const [historyOrder, setHistoryOrder] = useState<Order>("asc");
  const [historyOrderBy, setHistoryOrderBy] = useState<keyof History>("date");

  useEffect(() => {
    dispatch(getCategories());
    dispatch(getStates());
  }, []);

  useEffect(() => {
    if (assetId) dispatch(getAssetDetails(assetId));
  }, [assetId]);

  useEffect(() => {
    if (performance.navigation.type === 1) {
      window.location.href = "/manage-asset";
    }
  });

  useEffect(() => {
    if (sort) {
      setOrderBy("updatedDate");
      setOrder("desc");
    }
    assetService
      .getAssetList(
        page,
        pageSize,
        `${orderBy} ${order}`,
        filterName,
        stateData
          .filter((x) => x.check === true && x.id !== 0)
          .map((x) => x.id),
        categoryData
          .filter((x) => x.check === true && x.id != 0)
          .map((x) => x.id)
      )
      .then((response) => {
        // console.log(response.data);
        const resPagination = JSON.parse(response.headers.pagination);
        if (resPagination.TotalPages < resPagination.CurrentPage) setPage(1);

        setAssetData(response.data);
        setPagination(resPagination);
      });
  }, [
    page,
    pageSize,
    orderBy,
    order,
    filterName,
    stateData,
    categoryData,
    sort,
  ]);

  useEffect(() => {
    if (categories.length > 1) {
      let arr: SelectData[] = [];
      categories.forEach((element) => {
        arr.push({
          id: element.id,
          name: element.name,
          check: false,
        });
      });
      setCategoryData(arr);
    }
  }, [categories]);

  useEffect(() => {
    if (categories.length > 1) {
      let arr: SelectData[] = [];
      categories.forEach((element) => {
        if (element.id === 0)
          arr.push({
            id: element.id,
            name: element.name,
            check: true,
          });
        else
          arr.push({
            id: element.id,
            name: element.name,
            check: false,
          });
      });
      setCategoryData(arr);
    }
  }, [categories]);
  useEffect(() => {
    if (states.length > 1) {
      let arr: SelectData[] = [];
      states.forEach((element) => {
        if (element.id === 1 || element.id === 2 || element.id === 3)
          arr.push({
            id: element.id,
            name: element.name,
            check: true,
          });
        else {
          !sort
            ? arr.push({
                id: element.id,
                name: element.name,
                check: false,
              })
            : arr.push({
                id: element.id,
                name: element.name,
                check: true,
              });
        }
      });
      setStateData(arr);
    }
  }, [states, sort]);

  const handleRequestSort = (
    event: React.MouseEvent<unknown>,
    property: keyof AssetData
  ) => {
    const isAsc = orderBy === property && order === "asc";
    setOrder(isAsc ? "desc" : "asc");
    setOrderBy(property);
  };

  const handleHistoryRequestSort = (
    event: React.MouseEvent<unknown>,
    property: keyof History
  ) => {
    const isAsc = historyOrderBy === property && historyOrder === "asc";
    setHistoryOrder(isAsc ? "desc" : "asc");
    setHistoryOrderBy(property);
  };

  const handleStateChange = (event: any) => {
    const allSelected = stateData.find((x) => x.name === "All");
    const newState = stateData.map((obj) => {
      if (event.target.name === "All")
        return { ...obj, check: allSelected ? !allSelected.check : false };
      else if (event.target.name === obj.name)
        return { ...obj, check: !obj.check };

      return obj;
    });
    setStateData(newState);
  };

  const handleCategoryChange = (event: any) => {
    const allSelected = categoryData.find((x) => x.name === "All");
    const newState = categoryData.map((obj) => {
      if (event.target.name === "All")
        return { ...obj, check: allSelected ? !allSelected.check : false };
      else if (event.target.name === obj.name)
        return { ...obj, check: !obj.check };

      return obj;
    });
    setCategoryData(newState);
  };

  const handlePageChange = (event: any, page: number) => {
    setPage(page);
  };

  const handleDelete = (id: number) => {
    Swal.fire({
      title: "Are you sure?",
      text: "Do you want to delete this asset?",
      showCancelButton: true,
      confirmButtonText: "Delete",
      cancelButtonText: "Cancel",
      customClass: {
        confirmButton: "button button-spacing",
        cancelButton: "button-reverse button-spacing",
      },
      buttonsStyling: false,
    }).then((result) => {
      if (result.isConfirmed) {
        deleteAsset(id).then((res) => {
          window.location.reload();
          //console.log(res);
        });
      }
    });
  };

  const isDataNotFound = assetData.length === 0;

  const emptyRows =
    page > 1 && pagination
      ? Math.max(0, page * pageSize - pagination.TotalCount)
      : 0;

  return (
    <div className="app-content page-container">
      <div className="page-top-custom">
        <h1 className="page-title">Asset List</h1>
        <Grid container spacing={2}>
          <Grid item xs={3}>
            <FormControl fullWidth>
              <InputLabel id="demo-simple-select-label">State</InputLabel>
              <Select
                labelId="demo-simple-select-label"
                id="demo-simple-select"
                label="State"
                IconComponent={FilterAltIcon}
                // sx={{'.MuiSelect-iconOpen' :{transform:'none'}}}
                // onChange={handleChange}
              >
                {stateData.map((item) => (
                  <MenuItem key={item.id}>
                    <FormControlLabel
                      control={
                        <Checkbox
                          name={item.name}
                          checked={item.check}
                          onChange={handleStateChange}
                          checkedIcon={<CheckIcon sx={{ color: "#e30c18" }} />}
                        />
                      }
                      label={item.name}
                    />
                  </MenuItem>
                ))}
              </Select>
            </FormControl>
            <>{/* {console.log("from return ", pagination)} */}</>
          </Grid>
          <Grid item xs={3}>
            <FormControl fullWidth>
              <InputLabel id="demo-simple-select-label">Category</InputLabel>
              <Select
                labelId="demo-simple-select-label"
                id="demo-simple-select"
                label="Category"
                IconComponent={FilterAltIcon}
              >
                {categoryData.map((item) => (
                  <MenuItem key={item.id}>
                    <FormControlLabel
                      control={
                        <Checkbox
                          name={item.name}
                          checked={item.check}
                          onChange={handleCategoryChange}
                          checkedIcon={<CheckIcon sx={{ color: "#e30c18" }} />}
                        />
                      }
                      label={item.name}
                    />
                  </MenuItem>
                ))}
              </Select>
            </FormControl>
          </Grid>
          <Grid item xs={3}>
            <FormControl fullWidth>
              <TextField
                id="outlined-basic"
                variant="outlined"
                value={filterName}
                onChange={(event: any) => setFilterName(event.target.value)}
                InputProps={{
                  endAdornment: (
                    <InputAdornment position="end">
                      <SearchIcon />
                    </InputAdornment>
                  ),
                }}
              />
            </FormControl>
          </Grid>
          <Grid item xs={3}>
            <Link to="/create-asset">
              <button className="page-create-button button">
                Create new asset
              </button>
            </Link>
          </Grid>
        </Grid>
      </div>
      <Box>
        <TableContainer>
          <Table sx={{ minWidth: 650 }} aria-label="simple table">
            <TableHeader
              headLabel={TABLE_HEAD}
              onRequestSort={handleRequestSort}
              order={order}
              orderBy={orderBy}
            />
            <TableBody>
              {assetData.map((item) => (
                <TableRow
                  key={item.id}
                  onClick={() => handleClickOpen(item.id)}
                >
                  <TableCell>{item.code}</TableCell>
                  <TableCell>{item.name}</TableCell>
                  <TableCell>{item.category}</TableCell>
                  <TableCell>{item.state}</TableCell>
                  <TableCell>
                    <IconButton disabled={item.state === stateData[1].name}>
                      <Link to={"/edit-asset/" + item.id}>
                        <EditIcon
                          style={
                            item.state === stateData[1].name
                              ? { color: "gray" }
                              : { color: "black" }
                          }
                        />
                      </Link>
                    </IconButton>
                    <IconButton disabled={item.state === stateData[1].name}>
                      <CloseIcon
                        style={
                          item.state === stateData[1].name
                            ? { color: "#dc6b79" }
                            : { color: "red" }
                        }
                        onClick={(e) => handleDelete(item.id)}
                      />
                      {/* <Link to={"/manage-asset/"} >
                      </Link> */}
                    </IconButton>
                  </TableCell>
                </TableRow>
              ))}
              {emptyRows > 0 && (
                <TableRow style={{ height: 53 * emptyRows }}>
                  <TableCell colSpan={6} />
                </TableRow>
              )}
            </TableBody>
            {isDataNotFound && (
              <TableBody>
                <TableRow>
                  <TableCell align="center" colSpan={6} sx={{ py: 3 }}>
                    <Paper>
                      <SearchOffIcon />
                      <Typography
                        gutterBottom
                        align="center"
                        variant="subtitle1"
                      >
                        Data not found
                      </Typography>
                    </Paper>
                  </TableCell>
                </TableRow>
              </TableBody>
            )}
            <div
              style={{
                position: "absolute",
                right: "36px",
                marginTop: "12px",
              }}
            >
              <Stack spacing={2}>
                {pagination && (
                  <Pagination
                    count={pagination.TotalPages}
                    page={page}
                    shape="rounded"
                    onChange={handlePageChange}
                    renderItem={(item) => <PaginationItem {...item} />}
                  />
                )}
              </Stack>
            </div>
          </Table>
        </TableContainer>
      </Box>
      <BootstrapDialog
        open={open}
        TransitionComponent={Transition}
        keepMounted
        onClose={handleClose}
        maxWidth="md"
        fullWidth
        aria-describedby="alert-dialog-slide-description"
      >
        <BootstrapDialogTitle id="demo" onClose={handleClose}>
          Detailed Asset Information
        </BootstrapDialogTitle>
        {asset && (
          <DialogContent dividers>
            <DialogContentText id="alert-dialog-slide-description">
              <Grid container spacing={2}>
                <AssetField fieldName="Asset Code" fieldValue={asset.code} />
                <AssetField fieldName="Asset Name" fieldValue={asset.name} />
                <AssetField fieldName="Category" fieldValue={asset.category} />
                <AssetField
                  fieldName="Installed Date"
                  fieldValue={format(
                    new Date(asset.installedDate),
                    "dd/MM/yyyy"
                  )}
                />
                <AssetField fieldName="State" fieldValue={asset.state} />
                <AssetField fieldName="Location" fieldValue={asset.location} />
                <AssetField
                  fieldName="Specification"
                  fieldValue={asset.specification}
                />
                <Grid item xs={1} />
                <Grid item xs={3}>
                  <Typography variant="h6" gutterBottom component="div">
                    History
                  </Typography>
                </Grid>
                {asset.history.length > 0 && (
                  <Grid item xs={8}>
                    <TableContainer>
                      <Table aria-label="simple table">
                        <TableHeader
                          headLabel={HISTORY_HEAD}
                          onRequestSort={handleHistoryRequestSort}
                          order={historyOrder}
                          orderBy={historyOrderBy}
                        />
                        <TableBody>
                          {stableSort(
                            asset.history,
                            getComparator(historyOrder, historyOrderBy)
                          ).map((row, index) => (
                            <TableRow key={index}>
                              <TableCell>
                                {format(new Date(row.date), "dd/MM/yyyy")}
                              </TableCell>
                              <TableCell>{row.assignedTo}</TableCell>
                              <TableCell>
                                {row.assignedBy && row.assignedBy}
                              </TableCell>
                              <TableCell>
                                {format(
                                  new Date(row.returnedDate),
                                  "dd/MM/yyyy"
                                )}
                              </TableCell>
                            </TableRow>
                          ))}
                        </TableBody>
                      </Table>
                    </TableContainer>
                  </Grid>
                )}
              </Grid>
            </DialogContentText>
          </DialogContent>
        )}
      </BootstrapDialog>
    </div>
  );
};

export default ManageAsset;
