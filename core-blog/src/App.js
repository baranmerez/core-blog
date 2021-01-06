import React from "react";
import Navbar from "./components/Navbar";
import AdminSidebar from "./components/layouts/Admin/AdminPanel";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import "./App.css";

//* Static Pages
import Blogs from "./components/pages/Blogs";
import Category from "./components/pages/Category";
import Home from "./components/pages/Home";

//* Admin Components
import Dashboard from "./components/Admin/Dashboard";
import CreateBlogs from "./components/Admin/CreateBlogs";
// import UpdateBlogs from "./components/Admin/Dashboard";
// import CreateCategories from "./components/Admin/CreateCategory";
// import UpdateCategories from "./components/Admin/UpdateCategories";
import CreateCategory from "./components/Admin/CreateCategory";

const App = () => {
  return (
    <div className="App">
      <Router>
        <Switch>
          <Route path="/admin/:path?" exact>
            <AdminSidebar />
            <Switch>
              <Route path="/admin/blogs" component={Blogs} />
              <Route path="/admin/categories" component={Category} />
              <Route path="/admin/create-blogs" component={CreateBlogs} />
              <Route path="/admin/create-category" component={CreateCategory} />
              <Route path="/admin" component={Dashboard} />
            </Switch>
          </Route>

          <Route path="/">
            <Navbar />
            <Switch>
              <Route path="/home" component={Home} />
              <Route path="/blogs" component={Blogs} />
              <Route path="/category" component={Category} />
            </Switch>
          </Route>
        </Switch>
      </Router>
    </div>
  );
}

export default App;
