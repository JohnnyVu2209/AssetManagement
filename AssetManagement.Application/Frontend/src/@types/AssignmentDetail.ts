import { GridRowParams } from "@mui/x-data-grid"

export interface AssignmentDetailType {
    id: number
    assetCode: string
    assetName: string
    specification: string
    assignedTo: string
    assignedBy: string
    assignedDate: string
    state: number
    note: string
}

export type AssignmentDetailContextType = {
    assignmentDetail: AssignmentDetailType;
    openAssignmentDetailState: boolean;
    openAssignmentDetail: (params: GridRowParams) => void;
    closeAssignmentDetail: () => void;
};