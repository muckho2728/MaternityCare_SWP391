import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import './ForgetP.css';

const ForgetP = () => {
  const [email, setEmail] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    // Xử lý logic khi form được gửi
  };

  return (
    <div className="forget-container">
      <form className="forget-form" onSubmit={handleSubmit}>
        <h2>Quên mật khẩu</h2>
        <p>Hãy nhập email</p>
        <input 
          type="text" 
          placeholder="Email" 
          className="input-field" 
          value={email} 
          onChange={(e) => setEmail(e.target.value)} 
        />
        <button type="submit" className="forget-button"><Link to="/forget2">Tiếp theo</Link></button>
        <Link to="/login" className="login-reg-button">Đăng nhập</Link>
      </form>
    </div>
  );
};

export default ForgetP;