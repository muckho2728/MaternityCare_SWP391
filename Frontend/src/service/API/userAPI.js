import axios from "axios";
import { baseUrl } from "../../config/baseURL";

export const getAllUserAPI = (idUsers) => {
	return axios({
		method: "GET",
		url: `${baseUrl}/users/${idUsers}`,
		headers: {
			"Content-Type": "application/json",
		},
	});
};

export const getUserByIdAPI = (id) => {
	return axios({
		method: "GET",
		url: `${baseUrl}/users/${id}`,
		headers: {
			"Content-Type": "application/json",
		},
	});
};

export const updateUserAPI = (id, data) => {
	return axios({
		method: "PUT",
		url: `${baseUrl}/users/${id}`,
		headers: {
			"Content-Type": "application/json",
		},
		data: data,
	});
};

export const activeUserAPI = (id) => {
	return axios({
		method: "PUT",
		url: `${baseUrl}/active/${id}`,
		headers: {
			"Content-Type": "application/json",
		},
	});
};
