import React from 'react';
import { Helmet } from 'react-helmet';

const CreateBlogs = () => {
  return (
    <div>
    <Helmet>
        <title>Core-Blog | Create Blogs</title>
      </Helmet>
    <div
      style={{
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
      }}
    >
      <h1>Create Blogs</h1>
    </div>
    </div>
  );
};

export default CreateBlogs;
