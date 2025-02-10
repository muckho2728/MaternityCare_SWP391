import axios from "axios";
// Create an Axios instance with the base URL
const api = axios.create({
    baseURL: "https://maternitycare.azurewebsites.net/api/",
});

const handleBefore = (config) => {
    const token = localStorage.getItem('userToken');
    if (token) {
        config.headers["Authorization"] = `Bearer ${token}`;
    }
    return config;
};

api.interceptors.request.use(handleBefore);


export default api;