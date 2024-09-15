import * as React from "react";
import Tabs from "@mui/material/Tabs";
import Tab from "@mui/material/Tab";
import Typography from "@mui/material/Typography";
import Box from "@mui/material/Box";
import ProductsTable from "../Tables/ProductsTable";
import { ProductsTableProps, TabPanelProps } from "../interfaces/interfaces";
import SearchByNameForm from "../Forms/SearchProductByNameForm";
import AddProductForm from "../Forms/AddProductForm";
import DeleteProductForm from "../Forms/DeleteProductForm";
import { Divider, Stack } from "@mui/material";
import UpdateProductForm from "../Forms/UpdateProductForm";

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

const ProductsTableTabs = ({
  rows,
  getProducts,
  getProductsByName,
  getProductsSorted,
}: ProductsTableProps) => {
  const [value, setValue] = React.useState(0);

  const handleChange = (event: React.SyntheticEvent, newValue: number) => {
    setValue(newValue);
  };

  return (
    <Box sx={{ width: "100%" }}>
      <Box sx={{ borderBottom: 1, borderColor: "divider" }}>
        <Tabs value={value} onChange={handleChange}>
          <Tab label="Cauta Produs" />
          <Tab label="Adauga produs" />
          <Tab label="Modifica produs" />
          <Tab label="Sterge produs" />
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
          <ProductsTable rows={rows} getProducts={getProducts} />
          <SearchByNameForm
            getProducts={getProducts}
            getProductsByName={getProductsByName}
            getProductsSorted={getProductsSorted}
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
          <ProductsTable rows={rows} getProducts={getProducts} />
          <AddProductForm getProducts={getProducts} />
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
          <ProductsTable rows={rows} getProducts={getProducts} />
          <UpdateProductForm getProducts={getProducts} />
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
          <ProductsTable rows={rows} getProducts={getProducts} />
          <DeleteProductForm getProducts={getProducts} />
        </Stack>
      </CustomTabPanel>
    </Box>
  );
};

export default ProductsTableTabs;
