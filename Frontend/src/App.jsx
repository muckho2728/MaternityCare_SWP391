import { useEffect, useState } from "react";
import { Route, BrowserRouter as Router, Routes } from "react-router-dom";
import ForgetPage from "./Minh/ForgetP";
import ForgetPage2 from "./Minh/ForgetP2";
import LoginPage from "./Minh/Login";
import RegisPage from "./Minh/Register";
import CreateFetus from "./pages/CreateFetus/CreateFetus";
import CreateFetusHealth from "./pages/CreateFetusHealth/CreateFetusHealth";
import Footer from "./pages/Footer/Footer";
import Header from "./pages/Header/Header";
import Home from "./pages/Home/Home";

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
						<Route path="/login" element={<LoginPage />} />
						<Route path="/regis" element={<RegisPage />} />
						<Route path="/forget" element={<ForgetPage />} />
						<Route path="/forget2" element={<ForgetPage2 />} />
						<Route path="/" element={<Home />} />
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
