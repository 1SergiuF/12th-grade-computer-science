import {
  Autocomplete,
  Button,
  Paper,
  Stack,
  TextField,
  Typography,
} from "@mui/material";
import { amber } from "@mui/material/colors";
import React, { ChangeEvent, SyntheticEvent, useEffect, useState } from "react";
import { ProductsTableProps } from "../interfaces/interfaces";
import axios from "axios";
import { BASE_URL } from "../../constants";

const options: string[] = ["asc", "desc"];
const SearchProductByNameForm = ({
  getProducts,
  getProductsByName,
  getProductsSorted,
}: ProductsTableProps) => {
  const [text, setText] = useState("");
  const [sortBy, setSortBy] = useState("");

  const handleSubmit = (e: SyntheticEvent) => {
    e.preventDefault();
  };

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setText(e.target.value);
  };

  useEffect(() => {
    if (text === "") {
      sortBy ? getProductsSorted!(sortBy) : getProducts!();
    } else getProductsByName!(text);
  }, [text]);

  useEffect(() => {
    sortBy ? getProductsSorted!(sortBy) : getProducts!();
  }, [sortBy]);
  return (
    <Paper
      elevation={4}
      component="form"
      noValidate
      autoComplete="off"
      sx={{
        width: 300,
        height: 210,
        borderRadius: "5px",
        display: "flex",
        flexDirection: "column",
        alignItems: "center",
        p: 1,
        gap: 1,
      }}
      onSubmit={handleSubmit}
    >
      <Typography
        variant="h4"
        component="div"
        align="center"
        sx={{
          width: "100%",
          height: 50,
          bgcolor: amber[900],
          color: "white",
          borderRadius: "5px 5px 0 0",
        }}
      >
        Cauta Produs
      </Typography>
      <Autocomplete
        fullWidth
        disablePortal
        options={options}
        value={sortBy}
        onChange={(event: SyntheticEvent, newValue: string | null) => {
          newValue === null ? setSortBy("") : setSortBy(newValue);
        }}
        renderInput={(params) => <TextField {...params} label="Criteriu" />}
      ></Autocomplete>
      <TextField
        fullWidth
        variant="outlined"
        label="Cauta produs..."
        value={text}
        onChange={handleChange}
      />
    </Paper>
  );
};

export default SearchProductByNameForm;
