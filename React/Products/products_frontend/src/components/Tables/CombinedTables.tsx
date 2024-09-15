import { Box, Stack } from "@mui/material";
import React from "react";
import ProductsTable from "./ProductsTable";
import OrdersTable from "./OrdersTable";
import { CombinedTablesProps } from "../interfaces/interfaces";

const CombinedTables = ({
  productsRows,
  ordersRows,
  getProducts,
  getOrders,
}: CombinedTablesProps) => {
  return (
    <Box
      sx={{
        marginTop: "10%",
        display: "flex",
        gap: 5,
        alignItems: "center",
        justifyContent: "center",
      }}
    >
      <ProductsTable rows={productsRows} getProducts={getProducts} />
      <OrdersTable rows={ordersRows} getOrders={getOrders} />
    </Box>
  );
};

export default CombinedTables;
