import { createSlice } from '@reduxjs/toolkit';

export const BlogsSlice = createSlice({
    name: 'blogs',
    initialState:{
        blogs: [],
    },
    reducers: {
        setBlogs: (state, action) => {
            return { ...state, blogs: [...action.payload] };
        },
        createBlog: (state, action) => {
            return { ...state, blogs: [action.payload, ...state.blogs] }
        },
        updateBlog: (state, action) => {
            const blogs = state.blogs.map(blog => {
                if (blog.id === action.payload.id) {
                    blog = action.payload;
                }
                return blog;
            });
            return { ...state, blogs: [...blogs] };
        },
        deleteBlog: (state, action) => {
            const blogs = state.blogs.filter(blog =>
                blog.id !== action.payload.id);
            return { ...state, blogs: [...blogs] };
        }
    }
});

export const { setBlogs, createBlog, updateBlog, deleteBlog } = BlogsSlice.actions;

export default BlogsSlice.reducer;