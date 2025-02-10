import { useEffect, useState } from "react";
import { Route, BrowserRouter as Router, Routes } from "react-router-dom";
import CreateFetus from "./component/CreateFetus/CreateFetus";
import CreateFetusHealth from "./component/CreateFetusHealth/CreateFetusHealth";
import Footer from "./component/Footer/Footer";
import Header from "./component/Header/Header";
import Home from "./component/Home/Home";

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
