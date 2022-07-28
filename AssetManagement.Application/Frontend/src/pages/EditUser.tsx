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

  const [userInfo, setUserInfo] = useState<userInterface>({
    firstName: "Vinh",
    lastName: "Bui",
    dateOfBirth: new Date(1905, 12, 12),
    gender: 0,
    joinedDate: new Date(),
    type: "string",
    typeId: 1,
    staffCode: "string",
  });
  const [userGender, setUserGender] = useState(1);
  const [dateOfBirth, setDateOfBirth] = useState("");
  const [dateJoined, setDateJoined] = useState("");
  const saveButton = document.getElementById("edit-user-save-button");

  const params: any = useParams();
  // const [userInfo, setUserInfo] = useState([]);
  // let userInfo: FormValues;

  //LOAD DATA WHEN PAGE LOADED
  useEffect(() => {
    getUserByStaffCode(params.staffCode).then((res) => {
      setUserInfo(res.data);
      setUserGender(res.data.gender);
    });
  }, [params.staffCode]);

  const datetimeToDate = (datetime: Date) => {
    let dateParse = new Date(datetime);
    let date = String(getDate(dateParse)).padStart(2, "0");
    let month = String(getMonth(dateParse)).padStart(2, "0");
    let year = getYear(dateParse);
    return year + "-" + month + "-" + date;
  };

  useEffect(() => {
    setDateOfBirth(datetimeToDate(userInfo.dateOfBirth));
    setDateJoined(datetimeToDate(userInfo.joinedDate));
    if (!userInfo.gender) userInfo.gender = 0;
  }, [userInfo]);

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
    if (saveButton) saveButton.removeAttribute("disabled");
  };

  //VALIDATION
  const schema = yup
    .object()
    .shape({
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
    watch,
    formState: { errors },
  } = useForm<FormValues>({
    resolver: yupResolver(schema),
    defaultValues: {
      dateOfBirth: userInfo.dateOfBirth
        ? new Date(userInfo.dateOfBirth)
        : new Date(),
      joinedDate: userInfo.joinedDate
        ? new Date(userInfo.joinedDate)
        : new Date(),
    },
  });

  const checking = () => {
    console.log(errors);
  };

  // RETURN
  return (
    <div className="form-page-container app-content">
      <form
        className="form-page-form"
        onSubmit={handleSubmit((data) => {
          updateUser(data);
          // let time = data.dateOfBirth;
          // // let year = time.getFullYear();
          // console.log(time);
        })}
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
              value={userInfo.firstName ? userInfo.firstName : "Vinh"}
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
              value={userInfo.lastName ? userInfo.lastName : "Bui"}
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
              {...register("dateOfBirth", {
                required: "Date of Birth is required",
              })}
              type="date"
              placeholder="Last Name"
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
                  // onChange={handleGenderChange}
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
              {...register("joinedDate", {
                required: true,
              })}
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
              defaultValue={userInfo.typeId}
              {...register("typeId", { required: true, valueAsNumber: true })}
              onChange={(e) => handleTypeChange(e.target.value)}
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
