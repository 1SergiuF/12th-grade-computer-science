import { Box, ThemeProvider, Typography, createTheme } from "@mui/material";
import React from "react";
import "@fontsource/roboto";
import "../styles/App.css";

const Homepage = () => {
  return (
    <Box
      display="flex"
      alignItems="flex-start"
      flexDirection="column"
      height="300px"
      width="750px"
      marginLeft={5}
      marginTop={10}
    >
      <Typography
        variant="h1"
        sx={{
          color: "#ff9666",
          fontSize: { xs: "40px", sm: "70px", md: "72px" },
          fontWeight: 700,
          marginBottom: "33px",
          fontFamily: "roboto",
          letterSpacing: 2,
          background:
            "linear-gradient(90deg, tan 70%, rgba(255, 255, 255, 0) 120%);",
          WebkitTextFillColor: "transparent",
          WebkitBackgroundClip: "text",
        }}
      >
        Hello, I am Sergiu
      </Typography>
    </Box>
  );
};

export default Homepage;
