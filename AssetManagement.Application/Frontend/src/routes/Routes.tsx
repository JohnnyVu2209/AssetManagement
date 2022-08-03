import React from "react";
import { Router, Switch, Route, Redirect } from "react-router-dom";
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
import CreateUser from "../pages/CreateUser";
import EditUser from "../pages/EditUser";
import ManageAsset from "../pages/ManageAsset";
import Error from "../pages/Error";

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
            <RouteGuard path="/edit-user/:staffCode?" component={EditUser} />
            <RouteGuard path="/list-view" component={ListView} />
            <RouteGuard path="/create-user" component={CreateUser} />
            <RouteGuard path="/manage-asset" component={ManageAsset} />
            <RouteGuard path="/error" component={Error} />
            <Redirect from="*" to="/error"/>
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
