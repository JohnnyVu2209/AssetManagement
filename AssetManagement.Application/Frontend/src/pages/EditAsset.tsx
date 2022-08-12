import { FormControl, FormControlLabel, MenuItem, Radio, RadioGroup, Select, TextField } from '@mui/material'
import { DesktopDatePicker, LocalizationProvider } from '@mui/x-date-pickers';
import { AdapterDateFns } from '@mui/x-date-pickers/AdapterDateFns';
import { isEqual } from 'date-fns';
import React, { useEffect, useState } from 'react'
import { useParams } from 'react-router';
import { Link } from 'react-router-dom';
import Swal from 'sweetalert2';
import { Asset, getAssetDetails } from '../features/AssetSlice';
import { useAppDispatch, useAppSelector } from '../features/hooks';
import { updateAsset } from '../services/assetService/assetManagement';

type TypeParams = {
    id: string
}

const stateData = [
    { value: 2, label: "Available" },
    { value: 3, label: "Not available" },
    { value: 4, label: "Waiting for recycling" },
    { value: 5, label: "Recycled" },
]

const EditAsset = () => {
    const { id } = useParams<TypeParams>();
    const dispatch = useAppDispatch();
    const { asset } = useAppSelector((state) => state.assets);

    const [name, setName] = useState<string>();
    const [specification, setSpecification] = useState<string>();
    const [installedDate, setInstalledDate] = useState<Date | null>(new Date(2022, 7, 1));
    const [stateId, setStateId] = useState(0);
    const [data, setData] = useState<Asset>();
    const [check, setCheck] = useState(true);

    useEffect(() => {
        dispatch(getAssetDetails(Number(id)))
            .unwrap().catch(err => {
                if (err === "ASSET_NOT_FOUND") {
                    Swal.fire({
                        text: "this asset not exist",
                        customClass: {
                            confirmButton: "button",
                        },
                        buttonsStyling: false,
                    }).then(() => {
                        window.location.href = "/manage-asset";
                        // window.location.href = "/manage-user";
                    });
                }
            });
    }, [id])

    useEffect(() => {
        if (asset.stateID === 1) {
            Swal.fire({
                text: "this asset have been already assigned",
                customClass: {
                    confirmButton: "button",
                },
                buttonsStyling: false,
            }).then(() => {
                window.location.href = "/manage-asset";
                // window.location.href = "/manage-user";
            });
        }
        setData(asset);
        setStateId(asset.stateID);
        setName(asset.name);
        setSpecification(asset.specification);
        setInstalledDate(asset.installedDate);
    }, [asset])

    const enableSaveButton = () => {
        console.log("from check ", typeof specification)
        if (typeof name === 'string' && name.trim().length !== 0 && typeof specification === 'string' && specification.trim().length !== 0 &&
            (name !== asset.name ||
                specification !== asset.specification ||
                installedDate &&
                !CheckEqualDate(installedDate, asset.installedDate) ||
                stateId !== asset.stateID))
            setCheck(false);
        else
            setCheck(true);
    };

    const CheckEqualDate = (date1: Date, date2: Date) => {
        var compareDate1 = new Date(date1);
        var compareDate2 = new Date(date2);
        if (isEqual(new Date(compareDate1.getFullYear(), compareDate1.getMonth(), compareDate1.getDate(), 0, 0, 0),
            new Date(compareDate2.getFullYear(), compareDate2.getMonth(), compareDate2.getDate(), 0, 0, 0)))
            return true;
        return false;
    }

    useEffect(() => {
        if (name !== asset.name ||
            specification !== asset.specification ||
            installedDate &&
            !CheckEqualDate(installedDate, asset.installedDate) ||
            stateId !== asset.stateID)
            setCheck(false);
        else
            setCheck(true);
    }, [asset, name, specification, installedDate, stateId]);

    const handleSubmit = (e: any) => {
        e.preventDefault();
        const data = {
            name: name,
            specification: specification,
            installedDate: installedDate,
            stateId: stateId
        };
        // createAssignment(data);
        updateAsset(Number(id), data);
    }

    return (
        <div className="app-content page-container">
            {data && data.stateID !== 0 && (
                <form className="form-page-form" autoComplete={'off'} onSubmit={handleSubmit}>
                    <div className="form-page-form-title">
                        <h2>Edit asset</h2>
                    </div>
                    <div className="form-page-form-input-container">
                        <div className="form-page-form-input">
                            <label className="create-asset-label" style={{ alignItems: "center" }}>
                                Name <span style={{ color: "red" }}> *</span>
                            </label>
                            <FormControl fullWidth>
                                <TextField
                                    id="standard-multiline-static"
                                    value={name}
                                    onKeyUp={enableSaveButton}
                                    onChange={(e) => setName(e.target.value)}
                                    variant="outlined"
                                />
                            </FormControl>
                        </div>
                        <div className="form-page-form-input">
                            <label className="create-asset-label" style={{ alignItems: "center" }}>
                                Category <span style={{ color: "red" }}> *</span>
                            </label>
                            <FormControl fullWidth>
                                <Select
                                    displayEmpty
                                    disabled
                                    value={data.categoryID}
                                >
                                    <MenuItem value={data.categoryID}>{data.category}</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className="form-page-form-input">
                            <label className="create-asset-label" style={{ alignItems: "center" }}>
                                Specification <span style={{ color: "red" }}> *</span>
                            </label>
                            <FormControl fullWidth>
                                <TextField
                                    id="standard-multiline-static"
                                    multiline
                                    rows={4}
                                    value={specification}
                                    onKeyUp={enableSaveButton}
                                    onChange={(e) => setSpecification(e.target.value)}
                                    variant="outlined"
                                />
                            </FormControl>
                        </div>
                        <div className="form-page-form-input">
                            <label className="create-asset-label" style={{ alignItems: "center" }}>
                                Installed Date <span style={{ color: "red" }}> *</span>
                            </label>
                            <FormControl fullWidth>
                                <LocalizationProvider dateAdapter={AdapterDateFns}>
                                    <DesktopDatePicker
                                        value={installedDate}
                                        onChange={(newValue) => {
                                            setInstalledDate(newValue);
                                            enableSaveButton();
                                        }}
                                        renderInput={(params) => <TextField variant='outlined' onKeyUp={enableSaveButton} {...params} />}
                                    />
                                </LocalizationProvider>
                            </FormControl>
                        </div>
                        <div className="form-page-form-input">
                            <label className="create-asset-label" style={{ maxWidth: 145 }}>
                                State <span style={{ color: "red" }}> *</span>
                            </label>
                            <FormControl sx={{ height: "fit-content" }}>
                                <RadioGroup
                                    aria-labelledby="demo-radio-buttons-group-label"
                                    value={stateId}
                                    name="stateID"
                                    onChange={(e) => {
                                        setStateId(Number((e.target as HTMLInputElement).value));
                                        enableSaveButton();
                                    }}
                                >
                                    {stateData.map(item => (
                                        <FormControlLabel key={item.value} value={item.value} control={<Radio />} label={item.label} />
                                    ))}
                                </RadioGroup>
                            </FormControl>
                        </div>
                    </div>
                    <div className="form-page-form-buttons modal-form-buttons">
                        <input type="submit" className="button" value="Save"
                            id="edit-asset-save-button" disabled={check} />
                        <Link to="/manage-asset">
                            <button className="button-reverse">Cancel</button>
                        </Link>
                    </div>
                </form>
            )}
        </div>
    )
}

export default EditAsset