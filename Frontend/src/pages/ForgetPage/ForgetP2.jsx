import React, { useState } from "react";
import { Link } from "react-router-dom";
import "./index.css";

const ForgetP2 = () => {
	const [password, setPassword] = useState("");
	const [confirmPassword, setConfirmPassword] = useState("");
	return (
		<div className="forget-container">
			<div className="forget-form">
				<input
					type="password"
					placeholder="Mật khẩu"
					className="input-field"
					value={password}
					onChange={(e) => setPassword(e.target.value)}
				/>
				<input
					type="password"
					placeholder="Xác nhận mật khẩu"
					className="input-field"
					value={confirmPassword}
					onChange={(e) => setConfirmPassword(e.target.value)}
				/>
				<button className="forget-button">Xác nhận</button>
				<Link to="/login" className="login-reg-button">
					Đăng nhập
				</Link>
			</div>
		</div>
	);
};
export default ForgetP2;
