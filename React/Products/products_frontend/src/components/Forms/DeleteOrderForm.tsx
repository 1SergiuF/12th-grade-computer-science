import { Button, Paper, Stack, TextField, Typography } from "@mui/material";
import { amber } from "@mui/material/colors";
import React, { SyntheticEvent, useState } from "react";
import { OrdersTableProps, ProductsTableProps } from "../interfaces/interfaces";
import axios from "axios";
import { BASE_URL } from "../../constants";

const AddProductForm = ({ getOrders }: OrdersTableProps) => {
  const initialValues = {
    OrderID: "",
  };
  const [values, setValues] = useState(initialValues);
  const handleSubmit = (e: SyntheticEvent) => {
    e.preventDefault();
    deleteOrder();
  };

  const deleteOrder = () => {
    console.log(values);
    axios
      .delete(`${BASE_URL}/Orders/${values.OrderID}`)
      .then((response) => {
        getOrders!();
      })
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
        height: 170,
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
        Sterge comanda
      </Typography>
      <TextField
        variant="outlined"
        fullWidth
        label="ID Comanda"
        name="OrderID"
        value={values.OrderID}
        onChange={handleChange}
      />
      <Button type="submit" variant="contained" fullWidth onClick={handleClick}>
        Sterge comanda
      </Button>
    </Paper>
  );
};

export default AddProductForm;
