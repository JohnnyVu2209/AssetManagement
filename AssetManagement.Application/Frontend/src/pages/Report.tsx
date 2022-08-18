import { Box, Grid, Table, TableBody, TableCell, TableContainer, TableRow } from '@mui/material'
import { format } from 'date-fns';
import React, { useEffect, useState } from 'react'
import { CSVLink } from "react-csv";
import { Data } from 'react-csv/components/CommonPropTypes';
import TableHeader, { getComparator, Order, stableSort } from '../components/TableHeader';
import reportService from '../services/reportService';
interface Report {
    category: string;
    total: number;
    assigned: number;
    available: number;
    notAvailable: number;
    waitingForRecycling: number;
    recycled: number;
}

const TABLE_HEAD = [
    { id: 'category', label: "Category" },
    { id: 'total', label: "Total" },
    { id: 'assigned', label: "Assigned" },
    { id: 'available', label: "Available" },
    { id: 'notAvailable', label: "Not available" },
    { id: 'waitingForRecycling', label: "Waiting for recycling" },
    { id: 'recycled', label: "Recycled" },
]

const headers = [
    { label: "Category", key: "category" },
    { label: "Total", key: "total" },
    { label: "Assigned", key: "assigned" },
    { label: "Available", key: "available" },
    { label: "Not Available", key: "notAvailable" },
    { label: "Waiting for recycling", key: "waitingForRecycling" },
    { label: "Recycled", key: "recycled" },
  ];

const Report = () => {

    const [order, setOrder] = React.useState<Order>("asc");
    const [orderBy, setOrderBy] = React.useState<keyof Report>("category");
    const [report, setReport] = useState<Report[]>([]);

    useEffect(() => {
        reportService.getReport()
            .then((res) => {
                console.log(res);
                setReport(res.data);
            })
    }, [])


    const handleRequestSort = (
        event: React.MouseEvent<unknown>,
        property: keyof Report
    ) => {
        const isAsc = orderBy === property && order === "asc";
        setOrder(isAsc ? "desc" : "asc");
        setOrderBy(property);
    };
    return (
        <div className="app-content page-container">
            <div className="page-top-custom">
                <h1 className="page-title">Report</h1>
                <Grid container spacing={2}>
                    <Grid item xs={9} />
                    <Grid item xs={3}>
                        <CSVLink data={report} headers={headers} filename={`Report_${format(new Date(), "ddMMyyyy")}`}>
                            <button className="page-create-button button">
                                Export
                            </button>
                        </CSVLink>
                    </Grid>
                </Grid>
            </div>
            <Box>
                <TableContainer>
                    <Table aria-label="simple table">
                        <TableHeader
                            headLabel={TABLE_HEAD}
                            onRequestSort={handleRequestSort}
                            order={order}
                            orderBy={orderBy}
                        />
                        <TableBody>
                            {report && stableSort(report, getComparator(order, orderBy)).map((item, index) => (
                                <TableRow
                                    key={index}
                                >
                                    <TableCell>{item.category}</TableCell>
                                    <TableCell>{item.total}</TableCell>
                                    <TableCell>{item.assigned}</TableCell>
                                    <TableCell>{item.available}</TableCell>
                                    <TableCell>{item.notAvailable}</TableCell>
                                    <TableCell>{item.waitingForRecycling}</TableCell>
                                    <TableCell>{item.recycled}</TableCell>
                                </TableRow>
                            ))}
                        </TableBody>
                    </Table>
                </TableContainer>
            </Box>
        </div>
    )
}

export default Report