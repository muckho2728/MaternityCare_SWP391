import { BrowserRouter as Router, Routes, Route } from 'react-router-dom'
import React, { useState, useEffect } from 'react';
import CreateFetus from './component/CreateFetus/CreateFetus'
import CreateFetusHealth from './component/CreateFetusHealth/CreateFetusHealth'
import Header from './component/Header/Header'
import Footer from './component/Footer/Footer'
import LoginPage from './component/Login/Login';
import RegisPage from './component/Register/Register';
import ForgetPage from './component/ForgotPassword/ForgetP';
import ForgetPage2 from './component/ForgotPassword/ForgetP2';

function App() {
  const [isLogin, setIsLogin] = useState(false);
  useEffect(() => {
      const userToken = localStorage.getItem('userToken');
      if (userToken) {
          setIsLogin(true);
      }
  }, []);
  return (
    <Router>
      <div className="app">
        <Header />
        <main className="main-content">
          <Routes>
            <Route path="/login" element={<LoginPage />} />
            <Route path="/regis" element={<RegisPage />} />
            <Route path="/forget" element={<ForgetPage />} />
            <Route path="/forget2" element={<ForgetPage2 />} />
            <Route path="/" element={<CreateFetus />} />
            <Route path="/fetus-health" element={<CreateFetusHealth />} />
          </Routes>
        </main>
        <Footer/>
      </div>
    </Router>
  )
}

export default App