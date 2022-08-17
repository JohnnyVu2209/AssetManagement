import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { getAssignmentDetail } from "../services/assignmentService/assignmentManagement";

export type Assignment = {
  assetCode: string;
  assignedTo: string,
  assignedDate: Date | null,
  note: string,
}

type InitialState = {
    assignment : Assignment
}

const initialState: InitialState = {
    assignment: {
        assetCode:"",
        assignedDate: null,
        assignedTo: "",
        note:""
    }
}

export const getAssignmentDetails = createAsyncThunk("assignment/detail", async (id:number, thunkApi) => {
    try {
        const response = await getAssignmentDetail(id);
        return response.data as Assignment;
    } catch (error: any) {
        if (!error.response) {
            throw error
        }
        return thunkApi.rejectWithValue(error.response.data);
    }
});

export const assignmentSlice = createSlice({
    name:"assignment",
    initialState,
    reducers:{},
    extraReducers: (builder) => {
        builder.addCase(getAssignmentDetails.fulfilled, (state,action) => {
            state.assignment = action.payload;
        })
    }
})

export const {} = assignmentSlice.actions;
export default assignmentSlice.reducer;