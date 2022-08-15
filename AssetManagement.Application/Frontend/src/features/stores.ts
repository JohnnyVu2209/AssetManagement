import { configureStore } from "@reduxjs/toolkit";
import assetReducer from './AssetSlice';
import assignmentReducer from './AssignmentSlice';

const store = configureStore({
    reducer: {
        assets : assetReducer,
        assignments: assignmentReducer
    }
});

export default store;
export type RootState = ReturnType<typeof store.getState>
export type AppDispatch = typeof store.dispatch
