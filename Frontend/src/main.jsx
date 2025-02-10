import { createRoot } from "react-dom/client";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Footer from "./components/Footer/Footer";
import Header from "./components/Header/Header";
import "./index.css";
import CreateFetus from "./pages/CreateFetus/CreateFetus";
import CreateFetusHealth from "./pages/CreateFetusHealth/CreateFetusHealth";
import ForgetP from "./pages/ForgetPage/ForgetP";
import ForgetP2 from "./pages/ForgetPage/ForgetP2";
import Home from "./pages/Home/Home";
import Login from "./pages/LoginPage/Login";
import Register from "./pages/RegisterPage/Register";

createRoot(document.getElementById("root")).render(
	<BrowserRouter>
		<Header />
		<Routes>
			<Route path="/" element={<Home />} />
			<Route path="/login" element={<Login />} />
			<Route path="/regis" element={<Register />} />
			<Route path="/forget" element={<ForgetP />} />
			<Route path="/forget2" element={<ForgetP2 />} />
			<Route path="/create-fetus" element={<CreateFetus />} />
			<Route path="/fetus-health" element={<CreateFetusHealth />} />
		</Routes>
		<Footer />
	</BrowserRouter>,
);
