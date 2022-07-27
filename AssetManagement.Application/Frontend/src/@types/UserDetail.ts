import { GridRowParams } from "@mui/x-data-grid"

export interface UserDetailType {
    id: number
    firstName: string
    lastName: string
    userName: string
    dateOfBirth: string
    gender: boolean
    joinedDate: string
    type: string
    locationName: string
}

export type UserDetailContextType = {
    userDetail: UserDetailType;
    openUserDetailState: boolean;
    openUserDetail: (params: GridRowParams) => void;
    closeUserDetail: () => void;
};