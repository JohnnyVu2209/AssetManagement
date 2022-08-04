import { createAsyncThunk, createSlice, PayloadAction } from "@reduxjs/toolkit";
import assetService from "../services/assetService";

type Asset = {
    name: string;
    code: string;
    category: string;
    state: string;
}

export type FilterSelect = {
    id: number;
    name: string;
}

type InitialState = {
    assetList: Asset[],
    categories: FilterSelect[],
    states: FilterSelect[]
}

export const getCategories = createAsyncThunk("asset/categories", async () => {
    const response = await assetService.getCategories();
    return response.data;
});

export const getStates = createAsyncThunk("asset/states", async () => {
    const response = await assetService.getStates();
    return response.data;
})

const initialState: InitialState = {
    assetList: [],
    categories: [{
        id: 0,
        name: "All",
    }],
    states: [
        {
            id: 0,
            name: "All",
        },
        {
            id: 1,
            name: "Assigned",
        },
        {
            id: 2,
            name: "Available",
        },
        {
            id: 3,
            name: "Not available",
        },
    ]
}

export const assetSlice = createSlice({
    name: 'asset',
    initialState,
    reducers: {},
    extraReducers: (builder) => {
        builder.addCase(getCategories.fulfilled, (state, action: PayloadAction<FilterSelect[]>) => {
            action.payload.forEach(element => {
                if (state.categories.findIndex(x => x.id === element.id) === -1)
                    state.categories.push(element);
            });
        });
        builder.addCase(getStates.fulfilled, (state, action: PayloadAction<FilterSelect[]>) => {
            action.payload.forEach(element => {
                if (state.states.findIndex(x => x.id === element.id) === -1)
                    state.states.push(element);
            });
        })
    }
})

export const { } = assetSlice.actions;
export default assetSlice.reducer;