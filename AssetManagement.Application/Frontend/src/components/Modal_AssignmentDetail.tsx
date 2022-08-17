import React, { useEffect, useState } from "react";
import { Button, Dialog, DialogContent, DialogTitle } from "@mui/material";
import "../assets/css/AssignmentDetail.css";
import axiosInstance from "../services/axiosInstance";
import CancelPresentationIcon from "@mui/icons-material/CancelPresentation";

export default function AssignmentDetail(props: any) {
  const [statee, setStatee] = useState<any>([]);

  useEffect(() => {
    //e.preventDefault();
    const getFormattedDate = (date: Date) => {
      var year = date.getFullYear();
      var month = (1 + date.getMonth()).toString();
      month = month.length > 1 ? month : "0" + month;
      var day = date.getDate().toString();
      day = day.length > 1 ? day : "0" + day;
      return month + "/" + day + "/" + year;
    };
    const getData = async () => {
      await axiosInstance
        .get(`Assignment/${props.data}`)
        .then((res) => {
          console.log("show data: ", res.data);
          // Handle date format
          const assignedDate = new Date(res.data.assignedDate);
          res.data.assignedDate = getFormattedDate(assignedDate);
          // return res.data
          setStatee(res.data);
        })
        .catch((error) => {
          console.log("errorr: " + error);
        });
    };
    getData();
  }, [props.data]);

  return (
    <div>
      <div className="dig-data-data">
        <DialogTitle
          className="dig-data-label"
          sx={{
            color: "#E41F28",
            fontWeight: "bold",
          }}
        >
          Detailed Assignment Information
        </DialogTitle>
        <CancelPresentationIcon
          style={{ color: "red", marginLeft: "180px", marginTop: "20px" }}
          onClick={() => props.setModalAssignmentDetail(false)}
        />
      </div>
      <DialogContent className="dig-data">
        <div className="dig-data-label">Asset Code</div>
        <div className="dig-data-data">
          <p>{statee.assetCode}</p>
        </div>
      </DialogContent>
      <DialogContent className="dig-data">
        <div className="dig-data-label">Asset Name</div>
        <div className="dig-data-data">{statee.assetName}</div>
      </DialogContent>
      <DialogContent className="dig-data">
        <div className="dig-data-label">Specification</div>
        <div className="dig-data-data">{statee.specification}</div>
      </DialogContent>
      <DialogContent className="dig-data">
        <div className="dig-data-label">Assigned to</div>
        <div className="dig-data-data">{statee.assignedTo}</div>
      </DialogContent>
      <DialogContent className="dig-data">
        <div className="dig-data-label">Assigned by</div>
        <div className="dig-data-data">{statee.assignedBy}</div>
      </DialogContent>
      <DialogContent className="dig-data">
        <div className="dig-data-label">Assigned Date</div>
        <div className="dig-data-data">{statee.assignedDate}</div>
      </DialogContent>
      <DialogContent className="dig-data">
        <div className="dig-data-label">State</div>
        <div className="dig-data-data">
          {statee.assignedState === 1
            ? "Accepted"
            : statee.assignedState === 2
            ? "Waiting for acceptance"
            : statee.assignedState === 3
            ? "Declined"
            : "Waiting for returning"}
        </div>
      </DialogContent>
      <DialogContent className="dig-data">
        <div className="dig-data-label">Note</div>
        <div className="dig-data-data">{statee.note}</div>
      </DialogContent>
    </div>
  );
}
