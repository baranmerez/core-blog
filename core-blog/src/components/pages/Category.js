import React from 'react';
import { Helmet } from 'react-helmet';

const Category = () => {
  return (
    <div>
      <Helmet>
        <title>Core-Blog | Category</title>
      </Helmet>
    <div
      style={{
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
      }}
    >
      <h1>List of Categories</h1>
      </div>
    </div>
  );
};

export default Category;
