export interface Products {
  productID: number;
  productName: string;
  price: number;
  stock: number;
  orders?: [];
}

export interface ProductsTableProps {
  rows?: Products[];
  getProducts?: () => void;
  getProductsByName?: (text: string) => void;
  getProductsSorted?: (sortBy: string) => void;
}

export interface Orders {
  orderID: number;
  consigneeName: string;
  orderDate: Date;
  productID?: number;
}

export interface OrdersTableProps {
  rows?: Orders[];
  getOrders?: () => void;
  getOrdersByName?: (text: string) => void;
  getOrdersSorted?: (sortBy: string) => void;
}

export interface TabPanelProps {
  children?: React.ReactNode;
  index: number;
  value: number;
}

export interface NavBarProps {
  darkMode: boolean;
  setDarkMode: React.Dispatch<React.SetStateAction<boolean>>;
}

export interface CombinedTablesProps {
  productsRows: Products[];
  ordersRows: Orders[];
  getProducts: () => void;
  getOrders: () => void;
}
