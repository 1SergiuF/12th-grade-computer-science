import * as React from "react";
import {
  AppBar,
  Toolbar,
  IconButton,
  Typography,
  Box,
  Menu,
  Stack,
  Button,
  capitalize,
  ButtonPropsVariantOverrides,
  MenuItem,
  Divider,
} from "@mui/material";
import { ThemeProvider, createTheme, makeStyles } from "@mui/material/styles";
import MenuIcon from "@mui/icons-material/Menu";
import {
  Bookmarks,
  Code,
  GitHub,
  Instagram,
  Twitter,
} from "@mui/icons-material";
import UnderlinedButton from "./UnderlinedButton.tsx";
import { amber, lightGreen } from "@mui/material/colors";
import { Link } from "react-router-dom";
import "../styles/App.css";
import { alpha } from "@mui/material/styles";
import AccountCircleIcon from "@mui/icons-material/AccountCircle";
import HomeIcon from "@mui/icons-material/Home";
import InfoIcon from "@mui/icons-material/Info";
import FolderIcon from "@mui/icons-material/Folder";
import "../styles/App.css";

declare module "@mui/material/Button" {
  interface ButtonPropsVariantOverrides {
    underlined: true;
  }
}

const pages = [
  { name: "Home", route: "/", ck: false },
  { name: "About", route: "/about", ck: false },
  { name: "Projects", route: "/projects", ck: false },
];

const socials = [
  { name: "Instagram", path: "https://www.instagram.com/za_breado/" },
  { name: "Github", path: "https://github.com/1SergiuF" },
  { name: "Twitter", path: "https://twitter.com/Sh1nobi5" },
];
const theme = createTheme({
  palette: {
    primary: {
      main: "#ff6600",
    },
  },

  typography: {
    button: {
      textTransform: "none",
    },
  },

  components: {
    MuiButtonBase: {
      defaultProps: {
        disableRipple: true,
      },
    },
    MuiButton: {
      variants: [
        {
          props: { variant: "underlined" },
          style: {
            "&:hover": {
              backgroundColor: "transparent",
            },
          },
        },
      ],
    },
  },
});

const darkTheme = createTheme({
  palette: {
    mode: "dark",
  },
});

const NavigationBar = () => {
  const [pageClick, setPageClick] = React.useState([false, false, false]);
  const [anchorElNav, setAnchorElNav] = React.useState<null | HTMLElement>(
    null
  );
  const [anchorElSocials, setAnchorElSocials] =
    React.useState<null | HTMLElement>(null);

  const handleOpenNavMenu = (event: React.MouseEvent<HTMLElement>) => {
    setAnchorElNav(event.currentTarget);
  };
  const handleOpenSocialsMenu = (event: React.MouseEvent<HTMLElement>) => {
    setAnchorElSocials(event.currentTarget);
  };

  const handleCloseNavMenu = () => {
    setAnchorElNav(null);
  };

  const handleCloseSocialsMenu = () => {
    setAnchorElSocials(null);
  };

  const handleClick = (e: React.MouseEvent<HTMLElement>) => {
    const currPageIndex = pages.findIndex(
      (p) => p.name === e.currentTarget.title
    );

    const nextPages = pageClick.map((value: boolean, i: number) => {
      if (i === currPageIndex) return true;
      else return false;
    });

    setPageClick(nextPages);
    console.log(nextPages);
  };
  return (
    <ThemeProvider theme={theme}>
      <Box
        sx={{
          flexGrow: 1,
          borderBottom: 3,
          borderBottomColor: "#ff6600",
          boxShadow: 20,
        }}
      >
        <AppBar
          position="static"
          sx={{
            height: "100px",
            justifyContent: "center",
            backgroundColor: "#29333d",
          }}
        >
          <Toolbar variant="dense">
            <Stack direction={"row"} flexGrow={1} spacing={25}>
              <Box
                sx={{
                  display: "flex",
                  flexDirection: "row",
                  alignItems: "center",
                }}
              >
                <Bookmarks
                  color="primary"
                  fontSize="large"
                  sx={{ marginRight: 3, display: { xs: "none", sm: "flex" } }}
                />
                <Typography
                  variant="h4"
                  noWrap
                  color="tan"
                  component="div"
                  justifyContent={"center"}
                  sx={{
                    mr: 2,
                    display: { md: "flex" },
                    fontWeight: 700,
                    letterSpacing: 2,
                    textDecoration: "none",
                  }}
                >
                  Portofolio
                </Typography>
                <Box sx={{ flexGrow: 1, display: { xs: "flex", md: "none" } }}>
                  <IconButton
                    size="large"
                    color="primary"
                    aria-controls="menu-appbar"
                    onClick={handleOpenNavMenu}
                    aria-haspopup="true"
                  >
                    <MenuIcon fontSize="large" />
                  </IconButton>
                  <ThemeProvider theme={darkTheme}>
                    <Menu
                      id="menu-appbar"
                      anchorEl={anchorElNav}
                      anchorOrigin={{
                        vertical: "bottom",
                        horizontal: "left",
                      }}
                      keepMounted
                      transformOrigin={{
                        vertical: "top",
                        horizontal: "left",
                      }}
                      open={Boolean(anchorElNav)}
                      onClose={handleCloseNavMenu}
                      sx={{
                        display: { xs: "block", md: "none" },
                      }}
                    >
                      {pages.map((page) => (
                        <MenuItem key={page.route} onClick={handleCloseNavMenu}>
                          <Stack direction="row" spacing="10px">
                            {(() => {
                              switch (page.name) {
                                case "Home":
                                  return <HomeIcon />;
                                case "About":
                                  return <InfoIcon />;
                                case "Projects":
                                  return <FolderIcon />;
                                default:
                                  return null;
                              }
                            })()}
                            <Link
                              to={page.route}
                              style={{
                                textDecoration: "none",
                                textTransform: "none",
                                color: "white",
                              }}
                            >
                              {page.name}
                            </Link>
                          </Stack>
                        </MenuItem>
                      ))}
                    </Menu>
                  </ThemeProvider>
                </Box>
              </Box>
              <Stack
                direction="row"
                spacing={"50px"}
                alignItems={"center"}
                sx={{ display: { md: "flex", xs: "none" } }}
              >
                {pages.map((page) => (
                  <Button
                    variant="underlined"
                    sx={{
                      marginLeft: 20,
                      "& .link": {
                        position: "relative",

                        "&:after": {
                          content: '""',
                          position: "absolute",
                          height: "2px",
                          left: 0,
                          bottom: 0,
                          width:
                            pageClick[
                              pages.findIndex((p) => p.name === page.name)
                            ] === true
                              ? "100%"
                              : 0,
                          background: "lightgreen",
                          transition: "width .2s",
                        },

                        "&:hover:after": {
                          width: "100%",
                        },
                      },
                    }}
                  >
                    <Link
                      className="link"
                      title={page.name}
                      to={page.route}
                      onClick={handleClick}
                      style={{
                        textDecoration: "none",
                        gap: "47px",
                        textTransform: "none",
                        color: "#ff8533",
                        fontSize: "25px",
                        listStyle: "none",
                        fontWeight:
                          pageClick[
                            pages.findIndex((p) => p.name === page.name)
                          ] === true
                            ? "bold"
                            : "normal",
                      }}
                    >
                      {page.name}
                    </Link>
                  </Button>
                ))}
              </Stack>
            </Stack>

            <Stack direction="row" spacing={"10px"}>
              <IconButton
                size="large"
                edge="start"
                color="primary"
                sx={{ display: { xs: "none", sm: "none", lg: "flex" } }}
                href="https://www.instagram.com/za_breado/"
              >
                <Instagram fontSize="large" />
              </IconButton>

              <IconButton
                size="large"
                edge="start"
                color="primary"
                sx={{ display: { xs: "none", sm: "none", lg: "flex" } }}
                href="https://github.com/1SergiuF"
              >
                <GitHub fontSize="large" />
              </IconButton>

              <IconButton
                size="large"
                edge="start"
                color="primary"
                sx={{ display: { xs: "none", sm: "none", lg: "flex" } }}
                href="https://twitter.com/Sh1nobi5"
              >
                <Twitter fontSize="large" />
              </IconButton>

              <Box
                sx={{
                  flexGrow: 1,
                  display: { xs: "flex", sm: "flex", lg: "none" },
                }}
              >
                <IconButton
                  size="large"
                  color="primary"
                  aria-controls="socials-appbar"
                  onClick={handleOpenSocialsMenu}
                  aria-haspopup="true"
                >
                  <AccountCircleIcon fontSize="large" />
                </IconButton>
                <ThemeProvider theme={darkTheme}>
                  <Menu
                    id="socials-appbar"
                    anchorEl={anchorElSocials}
                    anchorOrigin={{
                      vertical: "bottom",
                      horizontal: "left",
                    }}
                    keepMounted
                    transformOrigin={{
                      vertical: "top",
                      horizontal: "left",
                    }}
                    open={Boolean(anchorElSocials)}
                    onClose={handleCloseSocialsMenu}
                  >
                    {socials.map((social) => (
                      <MenuItem
                        key={social.name}
                        onClick={handleCloseSocialsMenu}
                        href={social.path}
                      >
                        <Stack direction="row" spacing="10px">
                          {(() => {
                            switch (social.name) {
                              case "Instagram":
                                return <Instagram />;
                              case "Github":
                                return <GitHub />;
                              case "Twitter":
                                return <Twitter />;
                              default:
                                return null;
                            }
                          })()}

                          <Link to={social.path}>{social.name}</Link>
                        </Stack>
                      </MenuItem>
                    ))}
                  </Menu>
                </ThemeProvider>
              </Box>
            </Stack>
          </Toolbar>
        </AppBar>
      </Box>
    </ThemeProvider>
  );
};

export default NavigationBar;
