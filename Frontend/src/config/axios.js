import axios from "axios";
// Create an Axios instance with the base URL
const api = axios.create({
    baseURL: "https://maternitycare.azurewebsites.net/api/",
});



export default api;