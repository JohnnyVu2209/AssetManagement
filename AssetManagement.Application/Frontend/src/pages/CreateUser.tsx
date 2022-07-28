import React, { useEffect, useState } from "react";
import "../assets/css/Modal.css";
import "../assets/css/CreateUser.css";
import { SubmitHandler, useForm } from "react-hook-form";
import * as yup from "yup";
import { differenceInYears } from "date-fns";
import { yupResolver } from "@hookform/resolvers/yup";
import axios from "axios";
import { Link } from "react-router-dom";

type FormValues = {
  firstName: string,
  lastName: string,
  dateOfBirth:Date,
  joinedDate:Date,
  gender:boolean,
  type:number,
}


const CreateUser = () => {
  const schema = yup.object().shape({
    dateOfBirth: yup
      .date()
      .required("DOB REQUIRED")
      .test("dob", "Message DOB", (value: any) => {
        return differenceInYears(new Date(), value) >= 6;
      }),
  });

  const {
    register,
    handleSubmit,
    formState: { errors },
    getValues,
    /* setValue, */
  } = useForm<FormValues>({ resolver: yupResolver(schema),
    defaultValues: {
      gender:true,
    }});

  const selectOptions = ["User", "Admin"];
  const [typeValue, setTypeValue] = useState(selectOptions[1]);

  const getYearFromValue = (value: string) => {
    return new Date(value).getFullYear();
  };

  const onSubmit:SubmitHandler<FormValues> = (data:any) =>{
    console.log(data);
   const token = localStorage.getItem("token");
   axios.post("https://localhost:7019/api/User/createUser",data,{
      headers:{authorization: "Bearer " + token}
    }).then((data) => {
      console.log(data);
      window.location.reload();
    });
  }

  return (
    <div className="form-page-container app-content">
      <form
        className="form-page-form"
        onSubmit={handleSubmit(onSubmit)}
      >
        <div className="form-page-form-title">
          <h2>Create new user</h2>
        </div>
        <div className="form-page-form-input-container">
          <div className="form-page-form-input">
            <label htmlFor="">First name</label>
            <input {...register("firstName", {
                required: "First name is required",
              })}type="text" placeholder="First Name" />
          </div>
          <div className="form-page-form-input">
            <label htmlFor="">Last name</label>
            <input {...register("lastName", {
                required: "Last name is required",
              })}type="text" placeholder="Last Name" />
          </div>
          <div className="form-page-form-input">
            <label htmlFor="">Date of Birth</label>
            <input
              {...register("dateOfBirth", {
                required: "Date of Birth is required",
              })}
              type="date"
              placeholder="Last Name"
            />
          </div>
          {errors.dateOfBirth && <p>This field is required</p>}
          <div className="form-page-form-input">
          <label htmlFor="">Gender</label>
          <div className="form-page-form-input-radio-container">
              <div className="form-page-form-input-radio">
                <label htmlFor="gender-male">Male</label>
                <input
                  type="radio"
                  id="gender-male"
                  value={1}
                  {...register("gender", { required: true })}
                />
              </div>
              <div className="form-page-form-input-radio">
                <label htmlFor="gender-female">Female</label>
                <input
                  type="radio"
                  id="gender-female"
                  value={0}
                  checked
                  {...register("gender", { required: true })}

                />
              </div>
            </div>
          </div>
          <div className="form-page-form-input">
            <label htmlFor="">Joined Date</label>
            <input
              type="date"
              placeholder="Last Name"
              {...register("joinedDate", {
                required: true,
              })}
            />
          </div>

          {errors.dateOfBirth && <p>This field is required</p>}

          <div className="form-page-form-input">
            <label htmlFor="">Type</label>
            <select
              id="type"
              defaultValue={typeValue}
              // onChange={(e) => setTypeValue(e.target.value)}
              {...register("type", { required: true })}
            >
              <option value={1}>Admin</option>
              <option value={2}>User</option>
            </select>
          </div>
        </div>
        <div className="form-page-form-buttons modal-form-buttons">
          <input type="submit" className="button" value="Save" />
          <Link to="/manage-user">
            <button className="button-reverse">Cancel</button>
          </Link>
        </div>
      </form>
    </div>
  );

}

export default CreateUser;