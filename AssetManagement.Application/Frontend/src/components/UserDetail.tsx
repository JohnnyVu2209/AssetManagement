import React from "react";
import { Button, Dialog, DialogContent, DialogTitle } from '@mui/material';
import { UserDetailContextType } from "../@types/UserDetail";
import { UserDetailContext } from "../context/UserDetailContext";
import "../assets/css/UserDetail.css"

export default function UserDetail() {

    const { userDetail, openUserDetailState, closeUserDetail }
        = React.useContext(UserDetailContext) as UserDetailContextType

    return (
        <Dialog
            fullWidth={true} maxWidth={'xs'}
            open={openUserDetailState} onClose={closeUserDetail}>
            <div className="dig-data-data">
                <DialogTitle className="dig-data-label" sx={{
                    color: "#E41F28",
                    fontWeight: "bold",
                }}>
                    Detailed User Information
                </DialogTitle>
                <Button className="dig-data-data" onClick={closeUserDetail}>Close</Button>
            </div>
            <DialogContent className="dig-data">
                <div className="dig-data-label">
                    Staff Code
                </div>
                <div className="dig-data-data">
                    {userDetail.id}
                </div>
            </DialogContent>
            <DialogContent className="dig-data">
                <div className="dig-data-label">
                    Full Name
                </div>
                <div className="dig-data-data">
                    {userDetail.firstName + ' ' + userDetail.lastName}
                </div>
            </DialogContent>
            <DialogContent className="dig-data">
                <div className="dig-data-label">
                    Username
                </div>
                <div className="dig-data-data">
                    {userDetail.userName}
                </div>
            </DialogContent>
            <DialogContent className="dig-data">
                <div className="dig-data-label">
                    Date of Birth
                </div>
                <div className="dig-data-data">
                    {userDetail.dateOfBirth}
                </div>
            </DialogContent>
            <DialogContent className="dig-data">
                <div className="dig-data-label">
                    Gender
                </div>
                <div className="dig-data-data">
                    {`${userDetail.gender ? "Female" : "Male"}`}
                </div>
            </DialogContent>
            <DialogContent className="dig-data">
                <div className="dig-data-label">
                    Joined Date
                </div>
                <div className="dig-data-data">
                    {userDetail.joinedDate}
                </div>
            </DialogContent>
            <DialogContent className="dig-data">
                <div className="dig-data-label">
                    Type
                </div>
                <div className="dig-data-data">
                    {userDetail.type}
                </div>
            </DialogContent>
            <DialogContent className="dig-data">
                <div className="dig-data-label">
                    Location
                </div>
                <div className="dig-data-data">
                    {userDetail.locationName}
                </div>
            </DialogContent>
        </Dialog>
    )
}