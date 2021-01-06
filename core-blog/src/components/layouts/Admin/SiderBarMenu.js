import React from "react";
import * as FaIcons from "react-icons/fa";
import * as AiIcons from "react-icons/ai";
import * as IoIcons from "react-icons/io";

export const SidebarData = [
  {
    title: "Dashboard",
    path: "/admin/dashboard",
    icon: <AiIcons.AiFillHome />,
    cName: "nav-text",
  },
  {
    title: "Blogs",
    path: "/admin/blogs",
    icon: <IoIcons.IoIosPaper />,
    cName: "nav-text",
  },
  {
    title: "Category",
    path: "/admin/categories",
    icon: <FaIcons.FaCartPlus />,
    cName: "nav-text",
  },
  {
    title: "Create Blogs",
    path: "/admin/create-blogs",
    icon: <IoIcons.IoIosApps />,
    cName: "nav-text",
  },
  {
    title: "Create Categories",
    path: "/admin/create-category",
    icon: <FaIcons.FaEnvelopeOpenText />,
    cName: "nav-text",
  },
  
];
