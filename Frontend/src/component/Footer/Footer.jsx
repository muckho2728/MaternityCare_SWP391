<<<<<<< HEAD
import React from 'react';
import { Link } from 'react-router-dom';
import './Footer.css';
=======
import React from 'react'
import '../Footer/Footer.css'
import { Link } from 'react-router-dom'
>>>>>>> b4ec0dadcd15a5d3b920a6cb5caf550fa0698dee

const Footer = () => {
    return (
        <footer className="footer">
            <div className="footer-content">
                <div className="footer-section">
                    <h3>Maternity Care</h3>
                    <ul>
<<<<<<< HEAD
                        <li><Link to="/create-fetus">Pregnancy Tracker</Link></li>
                        <li><Link to="/health-records">Health Records</Link></li>
                        <li><Link to="/nutrition">Nutrition Guide</Link></li>
=======
                        <li>Theo Dõi Thai Kỳ</li>
                        <li>Hồ Sơ Sức Khỏe</li>
                        <li>Hướng Dẫn Dinh Dưỡng</li>
>>>>>>> b4ec0dadcd15a5d3b920a6cb5caf550fa0698dee
                    </ul>
                </div>

                <div className="footer-section">
<<<<<<< HEAD
                    <h3>Resources</h3>
                    <ul>
                        <li><Link to="/articles">Community</Link></li>
                        <li><Link to="/faq">FAQ</Link></li>
                        <li><Link to="/support">Support</Link></li>
=======
                <h3>Tài Nguyên</h3>
                    <ul>
                        <li><Link to='/community'>Cộng Đồng</Link></li>
                        <li>FAQ</li>
                        <li>Hỗ trợtrợ</li>
>>>>>>> b4ec0dadcd15a5d3b920a6cb5caf550fa0698dee
                    </ul>
                </div>

                <div className="footer-section">
<<<<<<< HEAD
                    <h3>Contact Us</h3>
                    <ul>
                        <li>Email: maternitycare@gmail.com</li>
=======
                    <h3>Liên hệ</h3>
                    <ul>
                        <li>Email: HaiHa@gmail.com</li>
>>>>>>> b4ec0dadcd15a5d3b920a6cb5caf550fa0698dee
                        <li>Phone: (123) 456-7890</li>
                        <li>Address: 123 Baby Care St</li>
                    </ul>
                </div>
            </div>

            <div className="footer-bottom">
                <p>&copy; {new Date().getFullYear()} Baby Care. All rights reserved.</p>
            </div>
        </footer>
<<<<<<< HEAD
    );
};

export default Footer;
=======
    )
}

export default Footer
>>>>>>> b4ec0dadcd15a5d3b920a6cb5caf550fa0698dee
