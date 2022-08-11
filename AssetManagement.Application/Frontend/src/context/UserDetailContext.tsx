import { GridRowParams } from "@mui/x-data-grid";
import React from "react";
import { UserDetailContextType, UserDetailType } from "../@types/UserDetail";
import getUserDetail from "../services/userService/userDetail";

export const UserDetailContext = React.createContext<UserDetailContextType | null>(null);

const UserDetailProvider: React.FC<React.PropsWithChildren> = ({ children }) => {

    const defaultUserDetail: UserDetailType = {
        staffCode: '',
        firstName: '',
        lastName: '',
        userName: '',
        dateOfBirth: '',
        gender: 0,
        joinedDate: '',
        type: '',
        locationName: '',
    }

    const [userDetail, setUserDetail] = React.useState<UserDetailType>(defaultUserDetail)

    const [openUserDetailState, setOpenUserDetailState] = React.useState(false)

    function openUserDetail(params: GridRowParams) {
        getUserDetail(`User/${params.row.staffCode}`)
            .then((res) => {
                if (res !== null) {
                    setUserDetail(res)
                }
            })
            .catch((error) => console.log(error));
        setOpenUserDetailState(true)
    }

    function closeUserDetail() {
        setUserDetail(defaultUserDetail)
        setOpenUserDetailState(false)
    }

    return (
        <UserDetailContext.Provider value={{ userDetail, openUserDetailState, openUserDetail, closeUserDetail }}>
            {children}
        </UserDetailContext.Provider>
    );
};

export default UserDetailProvider;