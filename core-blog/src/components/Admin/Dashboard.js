import React from 'react';
import { Helmet } from 'react-helmet';


const Dashboard = () => {
  return (
    <div>
    <Helmet>
        <title>Core-Blog | Dashboard</title>
      </Helmet>
    <div
      style={{
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
      }}
    >
      <h1>Blogs Dashboards</h1>
    </div>
    </div>
  );
};

export default Dashboard;
