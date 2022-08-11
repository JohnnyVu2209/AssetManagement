import React from "react";
import { Route, Redirect } from "react-router-dom";

const RouteGuard = ({ component: Component, ...rest }: any) => {
  function hasJWT() {
    let flag = 0;
    let token = localStorage.getItem("token");
    // Check if user has JWT token and authorize
    if (token) {
      if (localStorage.getItem("role") === "Admin") flag = 1;
      if (localStorage.getItem("role") === "User") flag = 2;
    } else {
      flag = 0;
    }
    return flag;
  }

  return (
    <Route
      {...rest}
      render={(props) =>
        hasJWT() == 1 || hasJWT() == 2 ? (
          <Component {...props} />
        ) : (
          <Redirect to={{ pathname: "/login" }} />
        )
      }
    />
  );
};

export default RouteGuard;
