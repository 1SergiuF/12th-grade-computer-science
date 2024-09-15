import React from "react";
import "./styles/App.css";
import NavigationBar from "./components/NavigationBar.tsx";
import { Box, Button, CssBaseline, IconButton } from "@mui/material";
import { Instagram } from "@mui/icons-material";
import { Route, Routes } from "react-router-dom";
import Homepage from "./pages/Homepage.tsx";
import Aboutpage from "./pages/Aboutpage.tsx";
import Projectspage from "./pages/Projectspage.tsx";
import "@fontsource/outfit";

const App = () => {
  return (
    <div className="container">
      <CssBaseline />
      <NavigationBar />
      <Routes>
        <Route path="/" element={<Homepage />} />
        <Route path="/about" element={<Aboutpage />} />
        <Route path="/projects" element={<Projectspage />} />
      </Routes>
      <div className="topBlur" />
    </div>
  );
};

export default App;
