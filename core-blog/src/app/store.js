import { configureStore } from '@reduxjs/toolkit';
import { BlogsSlice } from './BlogsSlice';

export default configureStore({
  reducer: {
    blogsSlice: BlogsSlice,
  },
});
