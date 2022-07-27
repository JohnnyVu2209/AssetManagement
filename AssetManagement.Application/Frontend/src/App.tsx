import React from "react";
import "./assets/css/App.css";
import Routes from "./routes/Routes";
import MessagePopup from "./components/MessagePopup";

function App() {
  return (
    <div className="App">
      <MessagePopup />
      <Routes />
    </div>
  );
}

export default App;
