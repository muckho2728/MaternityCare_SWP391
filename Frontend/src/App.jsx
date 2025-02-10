import { BrowserRouter as Router, Routes, Route } from 'react-router-dom'
import CreateFetus from './pages/CreateFetus/CreateFetus'
import CreateFetusHealth from './pages/CreateFetusHealth/CreateFetusHealth'
import Header from './components/Header/Header'
import Footer from './components/Footer/Footer'
import LoginPage from './pages/Login/Login';
import RegisPage from './pages/Register/Register';
import ForgetPage from './pages/ForgotPassword/ForgetP';
import ForgetPage2 from './pages/ForgotPassword/ForgetP2';
import Home from './pages/Home/Home.jsx';
import { useEffect, useState } from 'react';

function App() {
	const [isLogin, setIsLogin] = useState(false);
	useEffect(() => {
		const userToken = localStorage.getItem("userToken");
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
						<Route path="/" element={<Home />} />
						<Route path="/login" element={<LoginPage />} />
						<Route path="/regis" element={<RegisPage />} />
						<Route path="/forget" element={<ForgetPage />} />
						<Route path="/forget2" element={<ForgetPage2 />} />
						<Route path="/create-fetus" element={<CreateFetus />} />
						<Route path="/fetus-health" element={<CreateFetusHealth />} />
					</Routes>
				</main>
				<Footer />
			</div>
		</Router>
	);
}

export default App;
