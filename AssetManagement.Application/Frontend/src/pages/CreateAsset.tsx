import React, { useEffect, useState } from "react";
import { SubmitHandler, useForm } from "react-hook-form";
import * as yup from "yup";
import { differenceInYears, isSaturday, isSunday } from "date-fns";
import { yupResolver } from "@hookform/resolvers/yup";
import { Link } from "react-router-dom";
import "../assets/css/CreateAsset.css";
import { createAsset, createCategory, getCategories } from "../services/assetService/assetManagement";

import Box from '@mui/material/Box';
import InputLabel from '@mui/material/InputLabel';
import MenuItem from '@mui/material/MenuItem';
import FormControl from '@mui/material/FormControl';
import Select from '@mui/material/Select';

import CloseIcon from '@mui/icons-material/Close';
import CheckIcon from '@mui/icons-material/Check';


type FormValues = {
  assetName: string;
  specification: string;
  installedDate: Date;
  categoryId: number;
  //categoryPrefix: string;
  assetStateId: number;
};

const CreateAsset = () => {
  //VALIDATION
  const schema = yup
    .object()
    .shape({
      assetName:yup
        .string()
        .required("Please enter assetName")
        .matches(/^[a-zA-Z0-9 ]+$/, "assetName only contains English characters"),
      specification: yup
        .string()
        .required("Please enter specification"),
      installedDate: yup
        .date()
        .required("Please Select Installed Date")
        .nullable()
        .transform((curr,orig) => (orig === "" ? null : curr))
        .test(
          "id",
          "Installed Date is Saturday or Sunday. Please select another date",
          (value: any) => {
            return !isSaturday(value);
          }
        )
        .test(
          "id",
          "Installed Date is Saturday or Sunday. Please select another date",
          (value: any) => {
            return !isSunday(value);
          }
        )
  });

  const {
    register,
    getValues,
    handleSubmit,
    formState: {errors},
  } = useForm<FormValues>({
    resolver:yupResolver(schema),
    defaultValues:{
      assetStateId: 2,
    },
  });

  const [categoryName, setCategoryName] = useState("");
  const [prefix, setPrefix] = useState("");

  const onSubmit_createCategory/* : SubmitHandler<FormValues> */ = (e:any) =>{
    e.preventDefault();
    const data = {
      name: categoryName,
      prefix: prefix
    }
    //console.log(data);
    const token = localStorage.getItem("token");
    let sendData = { ...data };
    createCategory(sendData);
    console.log(sendData);
    //console.log(categoryName, prefix);
  }

  //const column = [{field: "name", width:358,},];

  const [categories, setCategories] = useState<ICategory[]>([]);
  useEffect(() => {
    getCategories().then((res:any) => {
      setCategories(res.data);
      console.log(res.data);
    });
  },[]);

  interface ICategory{
    name:string;
    prefix:string;
    id:number;
  }

  const [categoryValue, setCategoryValue] = useState("");
  const handleCategoryValueChange = (event:any) => {
    setCategoryValue(event.target.value);
  };

  const collapse_categorycontent = () => {
    var x = document.getElementById("add-category-content");
    if(x!== null){
      if (x.style.display === "none"){
      x.style.display = "block";
    } else {
      x.style.display = "none";
    }
    }
  }

  const collapse_categorytext = () => {
    var x = document.getElementById("add-category-content");
    if(x!== null){
      if (x.style.display === "block"){
      x.style.display = "none";
    } /* else {
      x.style.display = "block";
    } */
    }
  }

  /* const handleClickOneCategory = (event:any) => {
    const myValue = event.target.value;
    //console.log(myValue);
  } */

  const onSubmit: SubmitHandler<FormValues> = (data: any) => {
    //data.preventDefault();
    console.log(data);
    const token = localStorage.getItem("token");
    let sendData = { ...data };
    //sendData.categoryId = 
    sendData.installedDate.setDate(sendData.installedDate.getDate() + 1);
    createAsset(sendData);
  };


  return (
    <div className="form-page-container app-content">
      <form className="form-page-form" onSubmit={handleSubmit(onSubmit)}>
        <div className="form-page-form-title">
          <h2>Create new asset</h2>
        </div>
        <div className="form-page-form-input-container">
          <div className="form-page-form-input">
            <label htmlFor="">assetName</label>
            <input
              {...register("assetName", {
                required: "assetName is required",
              })}
              type="text"
              placeholder="assetName"
            />
          </div>
          <p className="form-page-form-error-message">
            {errors.assetName ? errors.assetName.message : ""}
          </p>

          <div className="form-page-form-input">
            <label htmlFor="">Category</label>
            <form>
              <Box sx={{width:358.86,minHeight:34}}>
                <FormControl fullWidth>
                  <Select labelId="demo-simple-select-label"
                          id="demo-simple-select"
                          defaultValue={categoryValue}
                          /* onChange={(event:any)=>setCategories(event.target.value)} */
                          /* onChange={(e:any)=>setCategoryValue(e.target.value)} */
                          sx={{overflow: 'hidden'}} 
                          {...register("categoryId",{required:true})}
                          >
                    {categories.map((category)=>
                      <MenuItem value={category.id} key={category.id}>{category.name}</MenuItem>
                    )}
                    
                    
                    <MenuItem style={{backgroundColor:"#eeeeee"}}
                              id="add-category-text">
                      <p className="add-category-menuitem" onClick={collapse_categorycontent}>Add new category</p>
                    </MenuItem>
                    <MenuItem id="add-category-content" style={{backgroundColor:"#eeeeee",display: "none"}} onKeyDown={(e) => e.stopPropagation()}>
                      <>
                        <input placeholder="Bluetooth Mouse"
                              type="text"
                              value={categoryName}
                              style={{fontStyle:"italic"}}
                              onChange={(e:any)=>setCategoryName(e.target.value)}/>
                        <input placeholder="BM"
                              type="text"
                              value={prefix}
                              onChange={(e:any)=>setPrefix(e.target.value)}
                              style={{width: "59px",fontStyle:"italic"}}/>
                        <CheckIcon style={{color:"red"}} onClick={onSubmit_createCategory}/>
                        <CloseIcon style={{color:"black"}} onClick={collapse_categorytext}/>
                      </>
                    </MenuItem>
                  </Select>
                </FormControl>
              </Box>
            </form>
          </div>
          
          <div className="form-page-form-input">
            <label htmlFor="">Specification</label>
            <input
              {...register("specification", {
                required: "Specification is required",
              })}
              type="text"
              placeholder="Specification"
            />
          </div>
          <p className="form-page-form-error-message">
            {errors.specification ? errors.specification.message : ""}
          </p>
          <div className="form-page-form-input">
            <label htmlFor="">Installed Date</label>
            <input
              type="date"
              placeholder="Installed Date"
              {...register("installedDate", {
                required: true,
              })}
            />
          </div>
          <p className="form-page-form-error-message">
            {errors.installedDate ? errors.installedDate.message : ""}
          </p>
          <div className="form-page-form-input">
            <label htmlFor="">State</label>
            <div className="form-page-form-input-radio-container" style={{display: "inline-block"}}>
              <div className="form-page-form-input-radio">
                <input
                  type="radio"
                  id="available"
                  style={{width:"13px"}}
                  value={2}
                  {...register("assetStateId", { required: true })}
                />
                <label htmlFor="available">Available</label>
              </div>
              <div className="form-page-form-input-radio">
                <input
                  type="radio"
                  style={{width:"13px"}}
                  id="notavailable"
                  value={3}
                  checked
                  {...register("assetStateId", { required: true })}
                />
                <label htmlFor="notavailable">Not Available</label>
              </div>
            </div>
          </div>
        </div>
        <div className="form-page-form-buttons modal-form-buttons">
          <input type="submit" className="button" value="Save" />
          <Link to="/manage-asset">
            <button className="button-reverse">Cancel</button>
          </Link>
        </div>
      </form>
    </div>
  );
};

export default CreateAsset;
