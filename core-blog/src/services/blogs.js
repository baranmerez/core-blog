import { setBlogs, createBlog, updateBlog, deleteBlog} 
from '../app/BlogsSlice';
import * as axios from 'axios';

const axiosInstance = axios.create({
    baseURL: 'http://localhost:1923/blogs',
})

export const GetBlogs = async (dispatch) => {
    try {
        const { data } = await axiosInstance.get();

        dispatch(setBlogs(data));
    } catch {
        console.log('Error!');
    }
}

export const CreateBlog = async (dispatch, Blog) => {
    try {
        const { data } = await axiosInstance.post('', Blog);
        dispatch(createBlog(data));
    } catch {
        console.log('Error!');
    }
}

export const UpdateBlog = async (dispatch, Blog) => {
    try {
        await axiosInstance.put('', Blog);
        dispatch(updateBlog(Blog));
    } catch {
        console.log('Error!');
    }
}

export const DeleteBlog = async (dispatch, Blog) => {
    try {
        console.log('deleteing Blog: ', Blog);
        await axiosInstance.delete('', { data: { ...Blog } });
        dispatch(deleteBlog(Blog));
    } catch {
        console.log('Error!');
    }
}
