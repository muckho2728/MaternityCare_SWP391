import React, { useState } from "react";
import { Link } from "react-router-dom";
import "./Login.css";
const Login = () => {
	//code remember me
	const [remember, setRemember] = useState(false);
	const [identifier, setIdentifier] = useState("");
	const [password, setPassword] = useState("");
	const handleCheckboxChange = () => {
		setRemember(!remember);
	};
	const [formData, setFormData] = useState({
		emailOrUsername: "",
		password: "",
	});

	const handleLogin = async () => {
		try {
			const response = await fetch("/api/authentications/login", {
				method: "POST",
				headers: {
					"Content-Type": "application/json",
				},
				body: JSON.stringify({ identifier, password }),
			});
			const data = await response.json();
			if (response.ok) {
				if (remember) {
					localStorage.setItem("userToken", data.token);
				}
				// Redirect to home page or dashboard
			} else {
				alert(data.message || "Login failed");
			}
		} catch (error) {
			alert("An error occurred during login");
		}
	};
	const handleIdentifierChange = (e) => {
		setIdentifier(e.target.value);
	};
	const handlePasswordChange = (e) => {
		setPassword(e.target.value);
	};

	const validateLogin = () => {
		const newErrors = {};
		if (
			!formData.emailOrUsername.trim() ||
			formData.emailOrUsername.length < 1
		) {
			newErrors.emailOrUsername = "Email or username cannot be empty";
		}
		if (!formData.password || formData.password.length < 8) {
			newErrors.password = "Password must be at least 8 characters";
		}
		setErrors(newErrors);
		return Object.keys(newErrors).length === 0;
	};

	const handleSubmit = async (e) => {
		e.preventDefault();
		const isValid = isLoginView ? validateLogin() : validateForgotPassword();

		if (isValid) {
			setLoading(true);
			try {
				// Simulate API call
				await new Promise((resolve) => setTimeout(resolve, 2000));
				if (isLoginView) {
					console.log("Login successful");
				} else {
					console.log("Reset email sent");
				}
			} catch (error) {
				console.error("Authentication error:", error);
			} finally {
				setLoading(false);
			}
		}
	};

	//form login
	return (
		<div className="login-wrapper">
			<div className="slide-in-left">
				<div className="login-container">
					<div className="login-form">
						<h2>Đăng nhập</h2>
						<input
							type="text"
							value={identifier}
							onChange={handleIdentifierChange}
							placeholder="Email hoặc Tên người dùng"
							className="input-field"
						/>
						<input
							type="password"
							value={password}
							onChange={handlePasswordChange}
							placeholder="Mật khẩu"
							className="input-field"
						/>
						<div className="options">
							<label>
								<input
									type="checkbox"
									checked={remember}
									onChange={handleCheckboxChange}
								/>{" "}
								Tự động đăng nhập
							</label>
							<Link to="/forget" className="forgot-password">
								Quên mật khẩu?
							</Link>
						</div>
						<button
							type="submit"
							className="login-button"
							onClick={handleLogin}
						>
							Đăng nhập
						</button>
						<div className="register">
							Chưa có tài khoản?{" "}
							<Link to="/regis" className="register-link">
								Đăng kí ngay
							</Link>
						</div>
					</div>
				</div>
			</div>
		</div>
	);
};

export default Login;
