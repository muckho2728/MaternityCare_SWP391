import { BrowserRouter as Router, Routes, Route } from 'react-router-dom'
import CreateFetus from './component/CreateFetus/CreateFetus'
import CreateFetusHealth from './component/CreateFetusHealth/CreateFetusHealth'
import Header from './component/Header/Header'
import Footer from './component/Footer/Footer'
import LoginPage from './Minh/Login';
import RegisPage from './Minh/Register';
import ForgetPage from './Minh/ForgetP';
import ForgetPage2 from './Minh/ForgetP2';

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
            <Route path="/" element={<CreateFetus />} />
            <Route path="/fetus-health" element={<CreateFetusHealth />} />
          </Routes>
        </main>
<<<<<<< HEAD
        <Footer />
=======
        <Footer/>
>>>>>>> b4ec0dadcd15a5d3b920a6cb5caf550fa0698dee
      </div>
    </Router>
  )
}

export default App