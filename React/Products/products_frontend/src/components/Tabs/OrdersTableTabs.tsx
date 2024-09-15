import * as React from "react";
import Tabs from "@mui/material/Tabs";
import Tab from "@mui/material/Tab";
import Typography from "@mui/material/Typography";
import Box from "@mui/material/Box";
import ProductsTable from "../Tables/ProductsTable";
import {
  OrdersTableProps,
  ProductsTableProps,
  TabPanelProps,
} from "../interfaces/interfaces";
import SearchByNameForm from "../Forms/SearchProductByNameForm";
import AddProductForm from "../Forms/AddProductForm";
import DeleteProductForm from "../Forms/DeleteProductForm";
import { Divider, Stack } from "@mui/material";
import OrdersTable from "../Tables/OrdersTable";
import AddOrderForm from "../Forms/AddOrderForm";
import DeleteOrderForm from "../Forms/DeleteOrderForm";
import UpdateOrderForm from "../Forms/UpdateOrderForm";
import SearchOrderByConsigneeNameForm from "../Forms/SearchOrderByConsigneeNameForm";

function CustomTabPanel(props: TabPanelProps) {
  const { children, value, index, ...other } = props;

  return (
    <Box>
      {value === index && (
        <Box sx={{ p: 3 }}>
          <Typography>{children}</Typography>
        </Box>
      )}
    </Box>
  );
}

const OrdersTableTabs = ({
  rows,
  getOrders,
  getOrdersByName,
  getOrdersSorted,
}: OrdersTableProps) => {
  const [value, setValue] = React.useState(0);

  const handleChange = (event: React.SyntheticEvent, newValue: number) => {
    setValue(newValue);
  };

  return (
    <Box sx={{ width: "100%" }}>
      <Box sx={{ borderBottom: 1, borderColor: "divider" }}>
        <Tabs value={value} onChange={handleChange}>
          <Tab label="Cauta Comanda" />
          <Tab label="Adauga Comanda" />
          <Tab label="Modifica comanda" />
          <Tab label="Sterge comanda" />
        </Tabs>
      </Box>
      <CustomTabPanel value={value} index={0}>
        <Stack
          sx={{
            width: "100%",
            height: "100%",
            display: "flex",
          }}
          direction="row"
          spacing={4}
        >
          <OrdersTable rows={rows} getOrders={getOrders} />
          <SearchOrderByConsigneeNameForm
            getOrders={getOrders}
            getOrdersByName={getOrdersByName}
            getOrdersSorted={getOrdersSorted}
          />
        </Stack>
      </CustomTabPanel>
      <CustomTabPanel value={value} index={1}>
        <Stack
          sx={{
            width: "100%",
            height: "100%",
            display: "flex",
          }}
          direction="row"
          spacing={4}
        >
          <OrdersTable rows={rows} getOrders={getOrders} />
          <AddOrderForm getOrders={getOrders} />
        </Stack>
      </CustomTabPanel>
      <CustomTabPanel value={value} index={2}>
        <Stack
          sx={{
            width: "100%",
            height: "100%",
            display: "flex",
          }}
          direction="row"
          spacing={4}
        >
          <OrdersTable rows={rows} getOrders={getOrders} />
          <UpdateOrderForm getOrders={getOrders} />
        </Stack>
      </CustomTabPanel>
      <CustomTabPanel value={value} index={3}>
        <Stack
          sx={{
            width: "100%",
            height: "100%",
            display: "flex",
          }}
          direction="row"
          spacing={4}
        >
          <OrdersTable rows={rows} getOrders={getOrders} />
          <DeleteOrderForm getOrders={getOrders} />
        </Stack>
      </CustomTabPanel>
    </Box>
  );
};

export default OrdersTableTabs;
