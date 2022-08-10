import {
  Box,
  Checkbox,
  createTheme,
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
  Stack,
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  TableSortLabel,
  TextField,
  ThemeProvider,
  Typography
} from '@mui/material'
import SearchOffIcon from '@mui/icons-material/SearchOff';
import React, { useEffect, useState } from 'react'
import { Link, useParams } from 'react-router-dom'
import FilterAltIcon from '@mui/icons-material/FilterAlt';
import SearchIcon from '@mui/icons-material/Search';
import CheckIcon from '@mui/icons-material/Check';
import EditIcon from "@mui/icons-material/Edit";
import HighlightOffIcon from "@mui/icons-material/HighlightOff";
import TableHeader, { getComparator, Order, stableSort } from '../components/TableHeader';
import "../assets/css/Pagination.css";
import { useAppDispatch, useAppSelector } from '../features/hooks';
import { getCategories, FilterSelect, getStates } from '../features/AssetSlice';
import assetService from '../services/assetService';

const assetMockData = [
  {
    "code": "LA000001",
    "name": "Laptop HP Probook 450 G1",
    "category": "Laptop",
    "state": "Available",
    "location": "Hồ Chí Minh"
  },
  {
    "code": "MO000001",
    "name": "Moninor Dell UltraSharp",
    "category": "Laptop",
    "state": "Available",
    "location": "Đà Nẵng"
  },
  {
    "code": "PC000001",
    "name": "Personal Computer",
    "category": "Laptop",
    "state": "Available",
    "location": "Hà Nội"
  },
  {
    "code": "LA000002",
    "name": "Laptop HP Probook 450 G1",
    "category": "Laptop",
    "state": "Available",
    "location": "Hồ Chí Minh"
  },
  {
    "code": "MO000002",
    "name": "Moninor Dell UltraSharp",
    "category": "Laptop",
    "state": "Available",
    "location": "Đà Nẵng"
  },
  {
    "code": "PC000002",
    "name": "Personal Computer",
    "category": "Laptop",
    "state": "Available",
    "location": "Hà Nội"
  },
  {
    "code": "PC000002",
    "name": "Personal Computer",
    "category": "Laptop",
    "state": "Available",
    "location": "Hà Nội"
  },
  {
    "code": "PC000002",
    "name": "Personal Computer",
    "category": "Laptop",
    "state": "Available",
    "location": "Hà Nội"
  },
  {
    "code": "PC000002",
    "name": "Personal Computer",
    "category": "Laptop",
    "state": "Available",
    "location": "Hà Nội"
  },
  {
    "code": "PC000002",
    "name": "Personal Computer",
    "category": "Laptop",
    "state": "Available",
    "location": "Hà Nội"
  },
];

const TABLE_HEAD = [
  { id: "code", label: "Asset Code" },
  { id: "name", label: "Asset Name" },
  { id: "category", label: "Category" },
  { id: "state", label: "State" },
  { id: "", label: "" },
]

interface AssetData {
  code: string,
  name: string,
  category: string,
  state: string,
  updatedDate: string
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
}

interface ParamsType {
  sort: string
}


const ManageAsset = () => {
  const { categories, states } = useAppSelector(state => state.assets);
  const dispatch = useAppDispatch();
  const { sort } = useParams<ParamsType>();
  const [stateData, setStateData] = useState<SelectData[]>([
    {
      id: 1,
      name: "Assigned",
      check: true
    },
    {
      id: 2,
      name: "Available",
      check: true
    },
    {
      id: 3,
      name: "Not available",
      check: true
    },
  ]);
  const [assetData, setAssetData] = useState<AssetData[]>([]);
  const [categoryData, setCategoryData] = useState<SelectData[]>([]);
  const [page, setPage] = useState(1);
  const [pageSize, setPageSize] = useState(5);
  const [totalCount, setTotalCount] = useState(0);
  const [totalPages, setTotalPages] = useState(1);
  const [pagination, setPagination] = useState<Pagination>();
  const [filterName, setFilterName] = useState('');
  const [order, setOrder] = React.useState<Order>('asc');
  const [orderBy, setOrderBy] = React.useState<keyof AssetData>('code');

  useEffect(() => {
    dispatch(getCategories());
    dispatch(getStates());
  }, []);

  useEffect(() => {
    if (performance.navigation.type === 1) {
      console.log("This page is reloaded");
      window.location.href = "/manage-asset";
    } else {
      console.log("This page is not reloaded");
    }
  })


  useEffect(() => {
    if (sort) {
      setOrderBy("updatedDate");
      setOrder('desc');
    }
    assetService.getAssetList(
      page,
      pageSize,
      `${orderBy} ${order}`,
      filterName,
      stateData.filter(x => x.check === true && x.id !== 0).map(x => x.id),
      categoryData.filter(x => x.check === true && x.id != 0).map(x => x.id))
      .then(response => {
        // console.log(response.data);
        const resPagination = JSON.parse(response.headers.pagination);
        if(resPagination.TotalPages < resPagination.CurrentPage)
          setPage(1);
          
        setAssetData(response.data);
        setPagination(resPagination);
      })
  }, [page, pageSize, orderBy, order, filterName, stateData, categoryData, sort]);

  useEffect(() => {
    if (categories.length > 1) {
      let arr: SelectData[] = [];
      categories.forEach(element => {
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
      categories.forEach(element => {
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
      states.forEach(element => {
        if (element.id === 1 || element.id === 2 || element.id === 3)
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
      setStateData(arr);
    }
  }, [states]);



  const handleRequestSort = (
    event: React.MouseEvent<unknown>,
    property: keyof AssetData,
  ) => {
    const isAsc = orderBy === property && order === 'asc';
    setOrder(isAsc ? 'desc' : 'asc');
    setOrderBy(property);
  };

  const handleStateChange = (event: any) => {
    const allSelected = stateData.find(x => x.name === "All");
    const newState = stateData.map(obj => {
      if (event.target.name === "All")
        return { ...obj, check: allSelected ? !allSelected.check : false }
      else if (event.target.name === obj.name)
        return { ...obj, check: !obj.check }

      return obj;
    });
    setStateData(newState);
  }
  const handleCategoryChange = (event: any) => {
    const allSelected = categoryData.find(x => x.name === "All");
    const newState = categoryData.map(obj => {
      if (event.target.name === "All")
        return { ...obj, check: allSelected ? !allSelected.check : false }
      else if (event.target.name === obj.name)
        return { ...obj, check: !obj.check }

      return obj;
    });
    setCategoryData(newState);
  };

  const handlePageChange = (event: any, page: number) => {
    setPage(page);
  }

  const isDataNotFound = assetData.length === 0;

  const emptyRows = page > 1 && pagination ? Math.max(0, page * pageSize - pagination.TotalCount) : 0;

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
                {stateData.map(item => (
                  <MenuItem>
                    <FormControlLabel control={
                      <Checkbox
                        name={item.name}
                        checked={item.check}
                        onChange={handleStateChange}
                        checkedIcon={<CheckIcon sx={{ color: "#e30c18" }} />}
                      />} label={item.name} />
                  </MenuItem>
                ))}
              </Select>
            </FormControl>
            <>
              {/* {console.log("from return ", pagination)} */}
            </>
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
                {categoryData.map(item => (
                  <MenuItem>
                    <FormControlLabel control={<Checkbox
                      name={item.name}
                      checked={item.check}
                      onChange={handleCategoryChange}
                      checkedIcon={<CheckIcon sx={{ color: "#e30c18" }} />}
                    />} label={item.name} />
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
                  endAdornment: <InputAdornment position='end'>
                    <SearchIcon />
                  </InputAdornment>
                }} />
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
              {assetData.map(item => (
                <TableRow>
                  <TableCell>{item.code}</TableCell>
                  <TableCell>{item.name}</TableCell>
                  <TableCell>{item.category}</TableCell>
                  <TableCell>{item.state}</TableCell>
                  <TableCell>
                    <IconButton disabled={item.state === stateData[1].name} >
                      <Link to={"/edit-asset/" + item.code}>
                        <EditIcon
                          style={item.state === stateData[1].name ? { color: "gray" } : { color: "black" }}
                        />
                      </Link>
                    </IconButton>
                    <IconButton disabled={item.state === stateData[1].name} >
                      <HighlightOffIcon style={item.state === stateData[1].name ? { color: "#dc6b79" } : { color: "red" }} />
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
                  <TableCell align='center' colSpan={6} sx={{ py: 3 }}>
                    <Paper>
                      <SearchOffIcon/>
                      <Typography gutterBottom align='center' variant='subtitle1'>
                        Data not found
                      </Typography>
                    </Paper>
                  </TableCell>
                </TableRow>
              </TableBody>
            )}
            <div style={{
              position: "absolute",
              right: "36px",
              marginTop: "12px"
            }}>
              <Stack spacing={2}>
                {pagination && (
                  <Pagination
                    count={pagination.TotalPages}
                    page={page}
                    shape="rounded"
                    onChange={handlePageChange}
                    renderItem={(item) => (
                      <PaginationItem {...item} />
                    )} />
                )}
              </Stack>
            </div>
          </Table>
        </TableContainer>
      </Box>

    </div>
  )
}

export default ManageAsset