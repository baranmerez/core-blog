/* eslint-disable import/no-anonymous-default-export */
import { React, useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { GetBlogs } from "../../services/blogs";
import { Button, Row, Col } from "react-bootstrap";
import { Helmet } from "react-helmet";

export default () => {
  const dispatch = useDispatch();
  console.log(GetBlogs(dispatch));
  const blogs = useSelector(state => state.blogsSlice.blogs);

  useEffect(() => {
    GetBlogs(dispatch);
  }, []); 

  return blogs.map((e) => (
    <div key={e.id} style={{ marginBottom: "1rem" }}>
      <ListRow blog={e} />
    </div>
  ));
};

const ListRow = ({ blog }) => {
  return (
    <div>
      <Row>
        <Col>{blog.BlogsId}</Col>
        <Col>{blog.header}</Col>
        <Col>{blog.snipet}</Col>
        <Col>{blog.content}</Col>
        <Col>{blog.publishDate}</Col>
        <Col>{blog.author}</Col>
      </Row>
    </div>
  );
};

