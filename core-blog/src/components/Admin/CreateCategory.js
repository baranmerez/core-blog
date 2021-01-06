import React from 'react';
import { Helmet } from 'react-helmet';

const CreateCategory = () => {
  return (
    <div>
    <Helmet>
        <title>Core-Blog | Create Category</title>
      </Helmet>
    <div
      style={{
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
      }}
    >
      <h1>Create Category</h1>
    </div>
    </div>
  );
};

export default CreateCategory;
