import { Button, Paper, Stack, TextField, Typography } from "@mui/material";
import { amber } from "@mui/material/colors";
import React, { SyntheticEvent, useState } from "react";
import { ProductsTableProps } from "../interfaces/interfaces";
import axios from "axios";
import { BASE_URL } from "../../constants";

const AddProductForm = ({ getProducts }: ProductsTableProps) => {
  const initialValues = {
    Name: "",
    Price: "",
    Stock: "",
  };
  const [values, setValues] = useState(initialValues);
  const handleSubmit = (e: SyntheticEvent) => {
    e.preventDefault();
    postProducts();
  };

  const postProducts = () => {
    axios({
      method: "post",
      url: `${BASE_URL}/Products`,
      data: {
        productName: values.Name,
        price: values.Price,
        stock: values.Stock,
      },
    })
      .then((response) => getProducts!())
      .catch((error) => alert(error.response.status));
  };

  const handleClick = (e: SyntheticEvent) => {
    const { name, value } = e.currentTarget as HTMLInputElement;
    setValues({ ...values, [name]: value });
  };

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setValues({ ...values, [name]: value });
  };

  return (
    <Paper
      elevation={4}
      component="form"
      noValidate
      autoComplete="off"
      sx={{
        width: 300,
        height: 300,
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
        Adauga Produs
      </Typography>
      <TextField
        variant="outlined"
        fullWidth
        label="Name"
        name="Name"
        value={values.Name}
        onChange={handleChange}
      />
      <TextField
        variant="outlined"
        fullWidth
        label="Price"
        name="Price"
        value={values.Price}
        onChange={handleChange}
      />
      <TextField
        variant="outlined"
        fullWidth
        label="Stock"
        name="Stock"
        value={values.Stock}
        onChange={handleChange}
      />
      <Button type="submit" variant="contained" fullWidth onClick={handleClick}>
        Adauga produs
      </Button>
    </Paper>
  );
};

export default AddProductForm;
