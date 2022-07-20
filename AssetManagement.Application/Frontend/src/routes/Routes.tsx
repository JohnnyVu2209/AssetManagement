import React from "react";
import { Router, Switch, Route } from "react-router-dom";
import { history } from "../others/history";
import RouteGuard from "../components/RouteGuard";
import Navbar from "../components/Navbar";
import Sidebar from "../components/Sidebar";
import Dashboard from "../pages/Dashboard";
import ListView from "../pages/ListView";
import Login from "../pages/Login";

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
            <RouteGuard path="/list-view" component={ListView} />
            <RouteGuard path="/" exact component={Dashboard} />
          </Switch>
        </div>
      </Router>
    </div>
  );
}

export default Routes;
