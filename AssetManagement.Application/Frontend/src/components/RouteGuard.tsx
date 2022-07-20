import React from "react";
import { Route, Redirect } from "react-router-dom";

const RouteGuard = ({ component: Component, ...rest }: any) => {
  function hasJWT() {
    let flag = false;
    let token = localStorage.getItem("token");
    // Check if user has JWT token and authorize
    if (token) {
      if (localStorage.getItem("role") === "Admin") flag = true;
    } else {
      flag = false;
    }
    return flag;
  }

  return (
    <Route
      {...rest}
      render={(props) =>
        hasJWT() ? (
          <Component {...props} />
        ) : (
          <Redirect to={{ pathname: "/login" }} />
        )
      }
    />
  );
};

export default RouteGuard;
