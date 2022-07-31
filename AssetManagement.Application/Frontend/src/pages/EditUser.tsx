import React, { useEffect, useState } from "react";
import "../assets/css/Modal.css";
import "../assets/css/FormPage.css";
import { useForm } from "react-hook-form";
import * as yup from "yup";
import {
  differenceInYears,
  isAfter,
  isSaturday,
  isSunday,
  format,
  getDate,
  getMonth,
  getYear,
} from "date-fns";
import { yupResolver } from "@hookform/resolvers/yup";
import { Link, useParams } from "react-router-dom";
import {
  getUserByStaffCode,
  updateUser,
} from "../services/userService/userManagement";

const EditUser = () => {
  //DECLARATION
  type FormValues = {
    firstName: string;
    lastName: string;
    dateOfBirth: Date;
    gender: number;
    joinedDate: Date;
    type: string;
    typeId: number;
    staffCode: string;
  };

  interface userInterface {
    firstName: string;
    lastName: string;
    dateOfBirth: Date;
    gender: number;
    joinedDate: Date;
    type: string;
    typeId: number;
    staffCode: string;
  }

  const [userInfo, setUserInfo] = useState<userInterface>();
  const [userGender, setUserGender] = useState(1);
  const [dateOfBirth, setDateOfBirth] = useState("");
  const [dateJoined, setDateJoined] = useState("");
  const [type, setType] = useState(2);
  const saveButton = document.getElementById("edit-user-save-button");

  const params: any = useParams();

  //LOAD DATA WHEN PAGE LOADED
  useEffect(() => {
    setType(userInfo ? userInfo.typeId : type);

    if (userInfo) {
      setDateOfBirth(datetimeToDate(userInfo.dateOfBirth));
      setDateJoined(datetimeToDate(userInfo.joinedDate));
      setValue("dateOfBirth", userInfo.dateOfBirth);
      setValue("joinedDate", userInfo.joinedDate);
    }

    // if (!userInfo.gender) {
    //   window.location.href = "/manage-user";
    //   alert("This admin cannot be edit");
    // }
  }, [userInfo]);
  useEffect(() => {
    getUserByStaffCode(params.staffCode).then((res) => {
      setUserInfo(res.data);
      setUserGender(res.data.gender);
    });
  }, [params.staffCode]);


  const datetimeToDate = (datetime: Date) => {
    let dateParse = new Date(datetime);
    let date = String(getDate(dateParse)).padStart(2, "0");
    let month = String(getMonth(dateParse) + 1).padStart(2, "0");
    let year = getYear(dateParse);
    return year + "-" + month + "-" + date;
  };

  const handleGenderChange = (event: any) => {
    setUserGender(event.target.value);
    if (saveButton) saveButton.removeAttribute("disabled");
  };
  const handleDOBChange = (event: any) => {
    setDateOfBirth(event.target.value);
    if (saveButton) saveButton.removeAttribute("disabled");
  };
  const handleDJChange = (event: any) => {
    setDateJoined(event.target.value);
    if (saveButton) saveButton.removeAttribute("disabled");
  };
  const handleTypeChange = (event: any) => {
    setType(event.target.value);
    if (saveButton) saveButton.removeAttribute("disabled");
  };

  //VALIDATION
  const schema = yup
    .object()
    .shape
    ({
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
      joinedDate: yup.date()
        .required("Join date is required")
        .test(
          "dj",
          "User under the age of 18 may not join company. Please select a different date",
          (value: any) => {
            return differenceInYears(new Date(value), new Date(dateOfBirth)) >= 18;
          }
        )
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
        ),
    })
    ;

  const {
    register,
    handleSubmit,
    watch,
    setValue,
    getValues,
    setError,
    clearErrors,
    formState: { errors },
  } = useForm<FormValues>({
    resolver: yupResolver(schema),
  });

  const checking = () => {
    let jdInput = document.getElementById("edit-joined-date-input");
    if (jdInput) {
      jdInput.setAttribute("autofocus", "");
    }
    console.log(errors);
  };

  const onSubmit = (data: any) => {
    let sendData = { ...data };
    sendData.dateOfBirth.setDate(sendData.dateOfBirth.getDate() + 1);
    sendData.joinedDate.setDate(sendData.joinedDate.getDate() + 1);
    console.log(sendData);
    updateUser(sendData);
  }

  // RETURN
  return (
    <div className="form-page-container app-content">
      <form
        className="form-page-form"
        onSubmit={handleSubmit(onSubmit)}
      >
        <div className="form-page-form-title">
          <h2>Edit User</h2>
        </div>
        <div className="form-page-form-input-container">
          <input
            type="hidden"
            value={params.staffCode}
            {...register("staffCode", {
              required: true,
            })}
          />
          <div className="form-page-form-input">
            <label htmlFor="">First name</label>
            <input
              disabled
              type="text"
              placeholder="First Name"
              value={userInfo ? userInfo.firstName : "Vinh"}
              {...register("firstName", {
                required: "First name is required",
              })}
            />
          </div>
          {errors.firstName && (
            <p className="form-page-form-error-message">
              This field is required
            </p>
          )}
          <div className="form-page-form-input">
            <label htmlFor="">Last name</label>
            <input
              disabled
              type="text"
              placeholder="Last Name"
              value={userInfo ? userInfo.lastName : "Bui"}
              {...register("lastName", {
                required: "First name is required",
              })}
            />
          </div>
          {errors.lastName && (
            <p className="form-page-form-error-message">
              This field is required
            </p>
          )}
          <div className="form-page-form-input">
            <label htmlFor="">Date of Birth</label>
            <input
              {...register("dateOfBirth")}
              type="date"
              id="edit-date-of-birth-input"
              // placeholder="Last Name"
              value={dateOfBirth}
              onChange={(e: any) => handleDOBChange(e)}
            />
          </div>
          {errors.dateOfBirth && (
            <p className="form-page-form-error-message">
              {errors.dateOfBirth.message}
            </p>
          )}
          <div className="form-page-form-input">
            <label htmlFor="">Gender</label>
            <div className="form-page-form-input-radio-container">
              <div className="form-page-form-input-radio">
                <label htmlFor="gender-male">Male</label>
                <input
                  type="radio"
                  id="gender-male"
                  value={1}
                  checked={userGender == 1}
                  {...register("gender", {
                    required: true,
                    valueAsNumber: true,
                  })}
                  onChange={(e: any) => handleGenderChange(e)}
                />
              </div>
              <div className="form-page-form-input-radio">
                <label htmlFor="gender-female">Female</label>
                <input
                  type="radio"
                  id="gender-female"
                  value={0}
                  checked={userGender == 0}
                  {...register("gender", {
                    required: true,
                    valueAsNumber: true,
                  })}
                  onChange={(e: any) => handleGenderChange(e)}
                />
              </div>
            </div>
          </div>
          <div className="form-page-form-input">
            <label htmlFor="">Joined Date</label>
            <input
              type="date"
              value={dateJoined}
              id="edit-joined-date-input"
              {...register("joinedDate", {})}
              onChange={(e: any) => handleDJChange(e)}
            />
          </div>

          {errors.joinedDate && (
            <p className="form-page-form-error-message">
              {errors.joinedDate.message}
            </p>
          )}

          <div className="form-page-form-input">
            <label htmlFor="">Type</label>
            <select
              id="type"
              value={type}
              {...register("typeId", { required: true, valueAsNumber: true })}
              onChange={(e) => handleTypeChange(e)}
            >
              <option value={1}>Admin</option>
              <option value={2}>User</option>
            </select>
          </div>
        </div>
        <div className="form-page-form-buttons modal-form-buttons">
          <input
            type="submit"
            className="button"
            value="Save"
            id="edit-user-save-button"
            disabled
            onClick={checking}
          />
          <Link to={"/manage-user/"}>
            <button className="button-reverse">Cancel</button>
          </Link>
        </div>
      </form>
    </div>
  );
};

export default EditUser;
