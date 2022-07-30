import React, { useEffect, useState } from "react";
import "../assets/css/Modal.css";
import "../assets/css/CreateUser.css";
import { SubmitHandler, useForm } from "react-hook-form";
import * as yup from "yup";
import { differenceInYears, isSaturday, isSunday } from "date-fns";
import { yupResolver } from "@hookform/resolvers/yup";
import { Link } from "react-router-dom";
import {createUser} from "../services/userService/userManagement";

type FormValues = {
  firstName: string;
  lastName: string;
  dateOfBirth: Date;
  joinedDate: Date;
  gender: boolean;
  type: number;
};

const CreateUser = () => {
  //VALIDATION
  const schema = yup
    .object()
    .shape({
      firstName: yup
        .string()
        .required("Please enter first name")
        .matches(/^[a-zA-Z ]+$/, "First name only contains English characters"),
      lastName: yup
        .string()
        .required("Please enter last name")
        .matches(/^[a-zA-Z ]+$/, "Last name only contains English characters"),
      dateOfBirth: yup
        .date()
        .required("Please Select Date of Birth")
        .nullable()
        .transform((curr, orig) => (orig === "" ? null : curr))
        .test(
          "dob",
          "User is under 18. Please select a different date",
          (value: any) => {
            return differenceInYears(new Date(), value) >= 18;
          }
        ),
      joinedDate: yup
        .date()
        .required("Join date is required")
        .when("dateOfBirth", {
          is: (value: any) => differenceInYears(new Date(), value) < 18,
          then: yup
            .date()
            .nullable()
            .transform((curr, orig) => (orig === "" ? null : curr))
            .required("User is under 18. Please select a different date"),
          otherwise: yup
            .date()
            .nullable()
            .transform((curr, orig) => (orig === "" ? null : curr))
            .when("dateOfBirth", {
              is: (value: any) => differenceInYears(new Date(), value) >= 18,
              then: yup
                .date()

                .test(
                  "dj",
                  "Joined date is Saturday or Sunday. Please select a different date",
                  (value: any) => {
                    return !isSaturday(value);
                  }
                )
                .test(
                  "dj",
                  "Joined date is Saturday or Sunday. Please select a different date",
                  (value: any) => {
                    return !isSunday(value);
                  }
                )
                .nullable()
                .transform((curr, orig) => (orig === "" ? null : curr)),
            }),
        }),

      // .test("dj", "Date joined should be greater", (value) => {
      //   // const { dateOfBirth } = this.parent;
      //   return isAfter(dateOfBirth, value)
      //   );
      // }),
    })
    .test(
      "gloablok",
      "User under the age of 18 may not join company. Please select a different date",
      (value: any) => {
        return differenceInYears(value.joinedDate, value.dateOfBirth) >= 18;
      }
    );

  const {
    register,
    handleSubmit,
    formState: { errors },
    getValues,
    /* setValue, */
  } = useForm<FormValues>({
    resolver: yupResolver(schema),
    defaultValues: {
      gender: true,
    },
  });

  const selectOptions = ["User", "Admin"];
  const [typeValue, setTypeValue] = useState(selectOptions[1]);

  const getYearFromValue = (value: string) => {
    return new Date(value).getFullYear();
  };

  const onSubmit: SubmitHandler<FormValues> = (data: any) => {
    console.log(data);
    const token = localStorage.getItem("token");
    createUser(data);
  };

  return (
    <div className="form-page-container app-content">
      <form className="form-page-form" onSubmit={handleSubmit(onSubmit)}>
        <div className="form-page-form-title">
          <h2>Create new user</h2>
        </div>
        <div className="form-page-form-input-container">
          <div className="form-page-form-input">
            <label htmlFor="">First name</label>
            <input
              {...register("firstName", {
                required: "First name is required",
              })}
              type="text"
              placeholder="First Name"
            />
          </div>
          <p className="form-page-form-error-message">
            {errors.firstName ? errors.firstName.message : ""}
          </p>
          <div className="form-page-form-input">
            <label htmlFor="">Last name</label>
            <input
              {...register("lastName", {
                required: "Last name is required",
              })}
              type="text"
              placeholder="Last Name"
            />
          </div>
          <p className="form-page-form-error-message">
            {errors.lastName ? errors.lastName.message : ""}
          </p>
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
          <p className="form-page-form-error-message">
            {errors.dateOfBirth ? errors.dateOfBirth.message : ""}
          </p>
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
              placeholder="Joined Date"
              {...register("joinedDate", {
                required: true,
              })}
            />
          </div>

          <p className="form-page-form-error-message">
            {errors.joinedDate ? errors.joinedDate.message : ""}
          </p>

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
};

export default CreateUser;
