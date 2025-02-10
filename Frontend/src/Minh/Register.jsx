import React, { useState } from 'react';
import { Link, useNavigate } from 'react-router-dom';
import './index.css';
import api from './config/axios';

const Register = () => {
  const navigate = useNavigate();
  const [ActiveTab, setActiveTab] = useState('login');
  const [formData, setFormData] = useState({
    email: "",
    fullName: "",
    userName: "",
    date  : "",
    cccd: "",
    password: "",
    confirmPassword: "",
  });
  const [errors, setErrors] = useState({});

  const ValidateForm = () => {
    const newErrors = {};
    if (ActiveTab === "register") {
      if (!formData.email) {
        newErrors.email = "Email is required";
      } else if (!/\S+@\S+\.\S+/.test(formData.email)) {
        newErrors.email = "Email is invalid";
      }
    }
    if (!formData.fullName) newErrors.fullName = "Full name is required";
    if (!formData.userName) newErrors.userName = "User name is required";
    if (!formData.date) newErrors.date = "Date is required";
    if (!formData.password) {
      newErrors.password = "Password is required";
    } else if (formData.password.length < 8) {
      newErrors.password = "Password must be at least 8 characters long";
    }
    if (!formData.confirmPassword) {
      newErrors.confirmPassword = "Confirm Password is required";
    } else if (formData.confirmPassword !== formData.password) {
      newErrors.confirmPassword = "Passwords do not match";
    }
    if (!formData.cccd) newErrors.cccd = "CCCD is required";
    return newErrors;
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    const newErrors = ValidateForm();
    if (Object.keys(newErrors).length === 0) {
      try {
        const response = await api.post("/api/authentications/register", formData);
        console.log(response);
        setErrors({});
        navigate('/login'); // Navigate to login page
      } catch (error) {
        console.error("Đăng ký thất bại: ", error);
      }
    } else {
      setErrors(newErrors);
    }
  };

  const handleInputChange = async (e) => {
    const { name, value } = e.target;
    setFormData(prevState => ({
      ...prevState,
      [name]: value
    }));

    if (name === "userName") {
      try {
        const response = await api.get(`/api/check-username?username=${value}`);
        if (!response.data.available) {
          setErrors(prevErrors => ({
            ...prevErrors,
            userName: "Tên người dùng đã tồn tại"
          }));
        } else {
          setErrors(prevErrors => ({
            ...prevErrors,
            userName: ""
          }));
        }
      } catch (error) {
        console.error("Lỗi kiểm tra tên người dùng: ", error);
      }
    }
  }

  return (
    <div className="slide-in-left">
    <div className="register-container">
      <div className="register-form">
        <h2 className="register-title">Đăng ký</h2>
        <div className="form-group">
          <p>Email</p>
          <input
            type="text"
            name="email"
            value={formData.email}
            placeholder="vd:ABC@gmail.com"
            className={`input-field ${errors.email ? "error" : ""}`}
            onChange={handleInputChange}
          />
          {errors.email && <span className="error-message">{errors.email}</span>}
        </div>
        <div className="form-group">
          <p>Họ và tên</p>
          <input
            type="text"
            name="fullName"
            value={formData.fullName}
            placeholder="vd:Nguyễn Văn A"
            className={`input-field ${errors.fullName ? "error" : ""}`}
            onChange={handleInputChange}
          />
          {errors.fullName && <span className="error-message">{errors.fullName}</span>}
        </div>
        <div className="form-group">
          <p>Tài khoản</p>
          <input
            type="text"
            name="userName"
            value={formData.userName}
            placeholder="vd:nguyenvana"
            className={`input-field ${errors.userName ? "error" : ""}`}
            onChange={handleInputChange}
          />
          {errors.userName && <span className="error-message">{errors.userName}</span>}
        </div>
        <div className="form-group">
          <p>Ngày sinh</p>
          <input
            type="date"
            name="date"
            value={formData.date}
            className={`input-field ${errors.date ? "error" : ""}`}
            onChange={handleInputChange}
          />
          {errors.date && <span className="error-message">{errors.date}</span>}
        </div>
        <div className="form-group">
          <p>CCCD</p>
          <input
            type="text"
            name="cccd"
            value={formData.cccd}
            placeholder="vd:123456"
            className={`input-field ${errors.cccd ? "error" : ""}`}
            onChange={handleInputChange}
          />
          {errors.cccd && <span className="error-message">{errors.cccd}</span>}
        </div>
        <div className="form-group">
          <p>Mật khẩu</p>
          <input
            type="password"
            name="password"
            value={formData.password}
            placeholder="vd:123456"
            className={`input-field ${errors.password ? "error" : ""}`}
            onChange={handleInputChange}
          />
          {errors.password && <span className="error-message">{errors.password}</span>}
        </div>
        <div className="form-group">
          <p>Xác nhận mật khẩu</p>
          <input
            type="password"
            name="confirmPassword"
            value={formData.confirmPassword}
            placeholder="vd:123456"
            className={`input-field ${errors.confirmPassword ? "error" : ""}`}
            onChange={handleInputChange}
          />
          {errors.confirmPassword && <span className="error-message">{errors.confirmPassword}</span>}
        </div>
        <button className={`register-button ${ActiveTab === "register" ? "active-class" : ""}`} onClick={handleSubmit}>Đăng ký</button>
        <p>Đã có tài khoản? <button><Link to="/" className="login-reg-button">Đăng nhập ngay</Link></button></p>
      </div>
      <div className="picture">Picture</div>
      </div>
    </div>
  );
};

export default Register;
