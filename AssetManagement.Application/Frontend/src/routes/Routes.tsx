import React from "react";
import { Router, Switch, Route } from "react-router-dom";
import { history } from "../others/history";
import RouteGuard from "../components/RouteGuard";
import Navbar from "../components/Navbar";
import Sidebar from "../components/Sidebar";
import Dashboard from "../pages/Dashboard";
import ListView from "../pages/ListView";
import Login from "../pages/Login";
import UserDetailProvider from "../context/UserDetailContext";
import ManageUser from "../pages/ManageUser";
import ManageUserProvider from "../context/ManageUserContext";

function Routes() {
  return (
    <div>
      <Router history={history}>
        <div>
          <Switch>
            <Route path="/login" component={Login} />
          </Switch>
          <Sidebar />
          <Navbar />
          <Switch>
            <RouteGuard exact path="/" component={Dashboard} />
            <RouteGuard path="/list-view" component={ListView} />
            <UserDetailProvider>
              <ManageUserProvider>
                <RouteGuard path="/manage-user" component={ManageUser} />
              </ManageUserProvider>
            </UserDetailProvider>
            <RouteGuard path="/list-view" component={ListView} />
          </Switch>
        </div>
      </Router>
    </div>
  );
}

export default Routes;
