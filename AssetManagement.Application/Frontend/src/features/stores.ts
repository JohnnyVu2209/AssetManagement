import { configureStore } from "@reduxjs/toolkit";
import assetReducer from './AssetSlice';

const store = configureStore({
    reducer: {
        assets : assetReducer
    }
});

export default store;
export type RootState = ReturnType<typeof store.getState>
export type AppDispatch = typeof store.dispatch
