import { Box, FormControl, FormControlLabel, FormLabel, Grid, InputAdornment, MenuItem, Pagination, PaginationItem, Paper, Radio, Select, Stack, Table, TableBody, TableCell, TableContainer, TableRow, TextField, Typography } from '@mui/material';
import React, { useEffect, useState } from 'react'
import SearchIcon from '@mui/icons-material/Search';
import SearchOffIcon from '@mui/icons-material/SearchOff';
import { DesktopDatePicker, LocalizationProvider } from '@mui/x-date-pickers';
import { AdapterDateFns } from '@mui/x-date-pickers/AdapterDateFns';

import { getUsers, getUsersBySearching } from '../services/userService/userManagement';
import "../assets/css/CustomSelect.css";
import TableHeader, { Order } from '../components/TableHeader';
import assetService from '../services/assetService';
import { Link, useParams } from 'react-router-dom';
import { createAssignment, updateAssignment } from '../services/assignmentService/assignmentManagement';
import getUserDetail from '../services/userService/userDetail';
import { useAppDispatch, useAppSelector } from '../features/hooks';
import { getAssignmentDetails } from '../features/AssignmentSlice';
import { isEqual } from 'date-fns';

interface UserData {
    id: number;
    staffCode: string;
    firstName: string;
    lastName: string;
    type: string;
    fullName: string;
}

interface AssetData {
    id: number;
    code: string;
    name: string;
    category: string;
}

type Pagination = {
    CurrentPage: number;
    HasNext: boolean;
    HasPrevious: boolean;
    PageSize: number;
    TotalCount: number;
    TotalPages: number;
}

type SelectData = {
    id: number;
    name: string;
}


const USER_TABLE_HEAD = [
    { id: "", label: "" },
    { id: "staffCode", label: "Staff code" },
    { id: "fullName", label: "Full Name" },
    { id: "type", label: "Type" },
]

const ASSET_TABLE_HEAD = [
    { id: "", label: "" },
    { id: "code", label: "Asset Code" },
    { id: "name", label: "Asset Name" },
    { id: "category", label: "Category" }
]

type TypeParams = {
    id: string
}

const EditAssignment = () => {
    const { id } = useParams<TypeParams>();
    const dispatch = useAppDispatch();
    const { assignment } = useAppSelector(state => state.assignments);

    const [assignedDate, setAssignedDate] = useState<Date | null>(new Date());
    const [note, setNote] = useState<string>();

    const [check, setCheck] = useState(true);

    useEffect(() => {
        dispatch(getAssignmentDetails(Number(id)));
    }, [id]);

    const [userPage, setUserPage] = useState(1);
    const [userOrderBy, setUserOrderBy] = useState<keyof UserData>("staffCode");
    const [userOrder, setUserOrder] = useState<Order>('asc');
    const [userSearch, setUserSearch] = useState("");
    const [userSelected, setUserSelected] = useState<SelectData>({ id: 0, name: "" });
    const [userPagination, setUserPagination] = useState<Pagination>()
    const [userSelectOpen, setUserSelectOpen] = useState(false);
    const [userData, setUserData] = useState<UserData[]>([]);
    const [defaultUser, setDefaultUser] = useState<UserData>();

    useEffect(() => {
        getUsers(userPage, `${userOrderBy} ${userOrder}`, userSearch)
            .then((response) => {
                // console.log(response)
                const resPagination = JSON.parse(response.headers.pagination);
                if (resPagination.TotalPages < resPagination.CurrentPage)
                    setUserPage(1);
                setUserPagination(resPagination);
                setUserData(response.data);
            });
    }, [userPage, userOrderBy, userOrder, userSearch]);

    const handleUserRequestSort = (
        event: React.MouseEvent<unknown>,
        property: keyof UserData,
    ) => {
        const isAsc = userOrderBy === property && userOrder === 'asc';
        setUserOrder(isAsc ? 'desc' : 'asc');
        setUserOrderBy(property);
    };

    const handleUserPageChange = (event: any, page: number) => {
        setUserPage(page);
    }

    const isUserDataNotFound = userData.length === 0;

    const userEmptyRows = userPage > 1 && userPagination ? Math.max(0, userPage * 5 - userPagination.TotalCount) : 0;


    const [assetPage, setAssetPage] = useState(1);
    const [assetOrderBy, setAssetOrderBy] = useState<keyof AssetData>("code");
    const [assetOrder, setAssetOrder] = useState<Order>('asc');
    const [assetSearch, setAssetSearch] = useState("");
    const [assetSelected, setAssetSelected] = useState<SelectData>({ id: 0, name: "" });
    const [assetSelectOpen, setAssetSelectOpen] = useState(false);
    const [assetPagination, setAssetPagination] = useState<Pagination>()
    const [assetData, setAssetData] = useState<AssetData[]>([]);
    const [defaultAsset, setDefaultAsset] = useState<AssetData>();

    useEffect(() => {
        assetService.getAssetListBySearch(assetPage, assetSearch, `${assetOrderBy} ${assetOrder}`)
            .then((response) => {
                // console.log(response.data);
                const resPagination = JSON.parse(response.headers.pagination);
                if (resPagination.TotalPages < resPagination.CurrentPage)
                    setAssetPage(1);
                setAssetPagination(resPagination);
                setAssetData(response.data);
            })
    }, [assetPage, assetSearch, assetOrderBy, assetOrder]);


    const handleAssetRequestSort = (
        event: React.MouseEvent<unknown>,
        property: keyof AssetData,
    ) => {
        const isAsc = assetOrderBy === property && assetOrder === 'asc';
        setAssetOrder(isAsc ? 'desc' : 'asc');
        setAssetOrderBy(property);
    };

    const handleAssetPageChange = (event: any, page: number) => {
        setAssetPage(page);
    }

    const isAssetDataNotFound = assetData.length === 0;

    const assetEmptyRows = assetPage > 1 && assetPagination ? Math.max(0, assetPage * 5 - assetPagination.TotalCount) : 0;

    useEffect(() => {
        assignment && assignment.assignedDate && setAssignedDate(new Date(assignment.assignedDate));
        setNote(assignment.note);
        DefaultAsset();
        getUsersBySearching(assignment.assignedTo)
            .then(res => {
                setDefaultUser(res.data[0]);
                setUserSelected({ id: res.data[0].id, name: `${res.data[0].firstName} ${res.data[0].lastName}` })
            })
    }, [assignment])

    const CheckEqualDate = (date1: Date, date2: Date) => {
        var compareDate1 = new Date(date1);
        var compareDate2 = new Date(date2);
        if (isEqual(new Date(compareDate1.getFullYear(), compareDate1.getMonth(), compareDate1.getDate(), 0, 0, 0),
            new Date(compareDate2.getFullYear(), compareDate2.getMonth(), compareDate2.getDate(), 0, 0, 0)))
            return true;
        return false;
    }

    const DefaultAsset = () => {
        assetService.getAssetBySearch(assignment.assetCode)
            .then(res => {
                setDefaultAsset(res.data[0]);
                setAssetSelected({ id: res.data[0].id, name: res.data[0].name })
            });
    }

    useEffect(() => {
        if (defaultUser && defaultAsset && assignedDate && assignment && typeof note === 'string' && note.trim().length !== 0 &&
            ( 
                userSelected.id !== defaultUser.id ||
                assetSelected.id !== defaultAsset.id ||
                note != assignment.note ||
                !CheckEqualDate(assignedDate, assignment.assignedDate as Date)
            )
        )
            setCheck(false);
        else setCheck(true);
    }, [userSelected, assetSelected, note, assignedDate, assignment])


    const handleSubmit = (e: any) => {
        e.preventDefault();
        const data = {
            userId: userSelected.id,
            assetId: assetSelected.id,
            assignedDate: assignedDate,
            note: note
        };
        updateAssignment(Number(id), data);
    }

    return (
        <div className="app-content page-container">
            <form className="form-page-form" onSubmit={handleSubmit}>
                <div className="form-page-form-title">
                    <h2>Edit assignment</h2>
                </div>
                <div className="form-page-form-input-container">
                    <div className="form-page-form-input">
                        <label className="create-asset-label" style={{ alignItems: "center" }}>
                            User <span style={{ color: "red" }}> *</span>
                        </label>
                        <FormControl fullWidth>
                            <Select
                                IconComponent={SearchIcon}
                                open={userSelectOpen}
                                onOpen={() => setUserSelectOpen(!userSelectOpen)}
                                defaultValue={userSelected.name}
                                displayEmpty
                            >
                                <Box sx={{ width: "fit-content", height: 650 }}>
                                    <Grid container spacing={1}>
                                        <Grid item xs={1} />
                                        <Grid item xs={5}>
                                            <h1 className="page-title">Select User</h1>
                                        </Grid>
                                        <Grid item xs={5}>
                                            <FormControl fullWidth>
                                                <TextField
                                                    id="outlined-basic"
                                                    variant="outlined"
                                                    value={userSearch}
                                                    onChange={(event: any) => setUserSearch(event.target.value)}
                                                    InputProps={{
                                                        endAdornment: <InputAdornment position='end'>
                                                            <SearchIcon />
                                                        </InputAdornment>
                                                    }} />
                                            </FormControl>
                                        </Grid>
                                        <Grid item xs={1} />
                                    </Grid>
                                    <TableContainer>
                                        <Table sx={{ minWidth: 650 }} aria-label="simple table">
                                            <TableHeader
                                                headLabel={USER_TABLE_HEAD}
                                                onRequestSort={handleUserRequestSort}
                                                order={userOrder}
                                                orderBy={userOrderBy}
                                            />
                                            <TableBody>
                                                {userData.map(item => (
                                                    <TableRow key={item.id}>
                                                        <TableCell>
                                                            <Radio key={item.staffCode} checked={userSelected.id === item.id} onChange={(e) => setUserSelected({ id: item.id, name: `${item.firstName} ${item.lastName}` })} />
                                                        </TableCell>
                                                        <TableCell>{item.staffCode}</TableCell>
                                                        <TableCell>{item.firstName} {item.lastName}</TableCell>
                                                        <TableCell>{item.type}</TableCell>
                                                    </TableRow>
                                                ))}
                                                {userEmptyRows > 0 && (
                                                    <TableRow style={{ height: 53 * userEmptyRows }}>
                                                        <TableCell colSpan={6} />
                                                    </TableRow>
                                                )}
                                            </TableBody>
                                            {isUserDataNotFound && (
                                                <TableBody>
                                                    <TableRow style={{ height: 53 * userEmptyRows }}>
                                                        <TableCell align='center' colSpan={6} sx={{ py: 3 }}>
                                                            <Paper>
                                                                <SearchOffIcon />
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
                                                    {userPagination && (
                                                        <Pagination
                                                            count={userPagination.TotalPages}
                                                            page={userPage}
                                                            shape="rounded"
                                                            onChange={handleUserPageChange}
                                                            renderItem={(item) => (
                                                                <PaginationItem {...item} />
                                                            )} />
                                                    )}
                                                    <Grid container spacing={1}>
                                                        <Grid item xs={6}>
                                                            <input type="submit" className="button" value="Save" onClick={() => setUserSelectOpen(!userSelectOpen)} />
                                                        </Grid>
                                                        <Grid item xs={6}>
                                                            <button className="button-reverse" onClick={() => {
                                                                setUserSelectOpen(!userSelectOpen);
                                                            }}>Cancel</button>
                                                        </Grid>
                                                    </Grid>
                                                </Stack>
                                            </div>
                                        </Table>
                                    </TableContainer>
                                </Box>
                                <MenuItem value="" sx={{ display: "none" }}>{userSelected.name}</MenuItem>
                            </Select>
                        </FormControl>
                    </div>
                    <div className="form-page-form-input">
                        <label className="create-asset-label" style={{ alignItems: "center" }}>
                            Asset <span style={{ color: "red" }}> *</span>
                        </label>
                        <FormControl fullWidth>
                            <Select
                                IconComponent={SearchIcon}
                                defaultValue={assetSelected.name}
                                displayEmpty
                                open={assetSelectOpen}
                                onOpen={() => setAssetSelectOpen(!assetSelectOpen)}
                            >
                                <Box sx={{ width: "fit-content", height: 600 }}>
                                    <Grid container spacing={1}>
                                        <Grid item xs={1} />
                                        <Grid item xs={5}>
                                            <h1 className="page-title">Select Asset</h1>
                                        </Grid>
                                        <Grid item xs={5}>
                                            <FormControl fullWidth>
                                                <TextField
                                                    id="outlined-basic"
                                                    variant="outlined"
                                                    value={assetSearch}
                                                    onChange={(event: any) => setAssetSearch(event.target.value)}
                                                    InputProps={{
                                                        endAdornment: <InputAdornment position='end'>
                                                            <SearchIcon />
                                                        </InputAdornment>
                                                    }} />
                                            </FormControl>
                                        </Grid>
                                        <Grid item xs={1} />
                                    </Grid>
                                    <TableContainer>
                                        <Table sx={{ minWidth: 650 }} aria-label="simple table">
                                            <TableHeader
                                                headLabel={ASSET_TABLE_HEAD}
                                                onRequestSort={handleAssetRequestSort}
                                                order={assetOrder}
                                                orderBy={assetOrderBy}
                                            />
                                            <TableBody>
                                                {assetData.map(item => (
                                                    <TableRow key={item.id}>
                                                        <TableCell>
                                                            <Radio key={item.code} checked={assetSelected.id === item.id} onChange={(e) => setAssetSelected({ id: item.id, name: item.name })} />
                                                        </TableCell>
                                                        <TableCell>{item.code}</TableCell>
                                                        <TableCell>{item.name}</TableCell>
                                                        <TableCell>{item.category}</TableCell>
                                                    </TableRow>
                                                ))}
                                                {assetEmptyRows > 0 && (
                                                    <TableRow style={{ height: 53 * assetEmptyRows }}>
                                                        <TableCell colSpan={6} />
                                                    </TableRow>
                                                )}
                                            </TableBody>
                                            {isAssetDataNotFound && (
                                                <TableBody>
                                                    <TableRow>
                                                        <TableCell align='center' colSpan={6} sx={{ py: 3 }}>
                                                            <Paper>
                                                                <SearchOffIcon />
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
                                                    {assetPagination && (
                                                        <Pagination
                                                            count={assetPagination.TotalPages}
                                                            page={assetPage}
                                                            shape="rounded"
                                                            onChange={handleAssetPageChange}
                                                            renderItem={(item) => (
                                                                <PaginationItem {...item} />
                                                            )} />
                                                    )}
                                                    <Grid container spacing={1}>
                                                        <Grid item xs={6}>
                                                            <input type="submit" className="button" value="Save" onClick={() => setAssetSelectOpen(!assetSelectOpen)} />
                                                        </Grid>
                                                        <Grid item xs={6}>
                                                            <button className="button-reverse" onClick={() => {
                                                                setAssetSelectOpen(!assetSelectOpen);
                                                                DefaultAsset();
                                                            }}>Cancel</button>
                                                        </Grid>
                                                    </Grid>
                                                </Stack>
                                            </div>
                                        </Table>
                                    </TableContainer>
                                </Box>
                                <MenuItem value="" sx={{ display: "none" }}>{assetSelected.name}</MenuItem>
                            </Select>
                        </FormControl>
                    </div>
                    <div className="form-page-form-input">
                        <label className="create-asset-label" style={{ alignItems: "center" }}>
                            Assigned Date <span style={{ color: "red" }}> *</span>
                        </label>
                        <FormControl fullWidth>
                            <LocalizationProvider dateAdapter={AdapterDateFns}>
                                <DesktopDatePicker
                                    value={assignedDate}
                                    minDate={assignment && assignment.assignedDate && new Date(assignment.assignedDate)}
                                    onChange={(newValue) => {
                                        setAssignedDate(newValue);
                                        // enableSaveButton();
                                    }}
                                    renderInput={(params) => <TextField variant='outlined' {...params} />}
                                />
                            </LocalizationProvider>
                        </FormControl>
                    </div>
                    <div className="form-page-form-input">
                        <label className="create-asset-label" style={{ alignItems: "center" }}>
                            Note <span style={{ color: "red" }}> *</span>
                        </label>
                        <FormControl fullWidth>
                            <TextField
                                id="standard-multiline-static"
                                multiline
                                rows={4}
                                value={note}
                                onChange={(e) => setNote(e.target.value)}
                                variant="outlined"
                            />
                        </FormControl>
                    </div>
                </div>
                <div className="form-page-form-buttons modal-form-buttons">
                    <input type="submit" className="button" value="Save"
                        id="create-assignment-save-button" disabled={check} />
                    <Link to="/assignment-list">
                        <button className="button-reverse">Cancel</button>
                    </Link>
                </div>
            </form>
        </div>
    )
}

export default EditAssignment