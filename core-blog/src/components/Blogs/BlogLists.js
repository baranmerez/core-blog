import { React, useEffect } from "react";
import { useDispatch } from "react-redux";
import { GetBlogs } from "../../services/blogs";

export const Blogs = () => {
  const dispatch = useDispatch();

  useEffect(() => {
    GetBlogs(dispatch);
  }, []);

  return "Blog List";
};
