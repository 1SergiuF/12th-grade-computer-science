import React, { useEffect, useState } from "react";
import "./App.css";
import NavigationBar from "./components/NavigationBar";
import { CssBaseline, createTheme } from "@mui/material";
import { ThemeProvider } from "@emotion/react";
import { Route, Routes } from "react-router-dom";
import ProductsTable from "./components/Tabs/ProductsTableTabs";
import OrdersTable from "./components/Tabs/OrdersTableTabs";
import { BASE_URL } from "./constants";
import axios, { AxiosError, AxiosResponse } from "axios";
import ProductsTableTabs from "./components/Tabs/ProductsTableTabs";
import OrdersTableTabs from "./components/Tabs/OrdersTableTabs";
import CombinedTables from "./components/Tables/CombinedTables";

function App() {
  const [darkMode, setDarkMode] = useState<boolean>(true);
  const [products, setProducts] = useState<[]>([]);
  const [orders, setOrders] = useState<[]>([]);
  const theme = createTheme({
    palette: {
      mode: darkMode ? "dark" : "light",
    },
  });

  const getProducts = () => {
    axios
      .get(`${BASE_URL}/Products`)
      .then((response: AxiosResponse) => {
        setProducts(response.data);
      })
      .catch((error) => {
        console.log(error);
      });
  };

  const getOrders = () => {
    axios
      .get(`${BASE_URL}/Orders`)
      .then((response: AxiosResponse) => {
        setOrders(response.data);
      })
      .catch((error) => {
        console.log(error);
      });
  };

  const getProductsByName = (text: string) => {
    axios
      .get(`${BASE_URL}/Products/filtered?text=${text}`)
      .then((response) => setProducts(response.data))
      .catch((error) => console.log(error.response.status));
  };

  const getProductsSorted = (sortBy: string) => {
    axios
      .get(`${BASE_URL}/Products/sorted?sortBy=${sortBy}`)
      .then((response) => setProducts(response.data))
      .catch((error) => console.log(error.response.status));
  };

  const getOrdersByName = (text: string) => {
    axios
      .get(`${BASE_URL}/Orders/filtered?text=${text}`)
      .then((response) => setOrders(response.data))
      .catch((error) => console.log(error.response.status));
  };

  const getOrdersSorted = (sortBy: string) => {
    axios
      .get(`${BASE_URL}/Orders/sorted?sortBy=${sortBy}`)
      .then((response) => setOrders(response.data))
      .catch((error) => console.log(error.response.status));
  };

  useEffect(() => {
    getProducts();
    getOrders();
  }, []);

  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
      <NavigationBar darkMode={darkMode} setDarkMode={setDarkMode} />
      <Routes>
        <Route
          path="/products"
          element={
            <ProductsTableTabs
              rows={products}
              getProducts={getProducts}
              getProductsByName={getProductsByName}
              getProductsSorted={getProductsSorted}
            />
          }
        />
        <Route
          path="/orders"
          element={
            <OrdersTableTabs
              rows={orders}
              getOrders={getOrders}
              getOrdersByName={getOrdersByName}
              getOrdersSorted={getOrdersSorted}
            />
          }
        />
        <Route
          path="/combined"
          element={
            <CombinedTables
              productsRows={products}
              ordersRows={orders}
              getProducts={getProducts}
              getOrders={getOrders}
            />
          }
        />
      </Routes>
    </ThemeProvider>
  );
}

export default App;
