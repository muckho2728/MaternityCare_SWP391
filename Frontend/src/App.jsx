import { BrowserRouter as Router, Routes, Route } from 'react-router-dom'
import CreateFetus from './component/CreateFetus/CreateFetus'
import CreateFetusHealth from './component/CreateFetusHealth/CreateFetusHealth'
import Header from './component/Header/Header'
import Footer from './component/Footer/Footer'
<<<<<<< HEAD
import Home from './component/Home/Home'
=======
>>>>>>> b4ec0dadcd15a5d3b920a6cb5caf550fa0698dee

function App() {
  return (
    <Router>
      <div className="app">
        <Header />
        <main className="main-content">
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/create-fetus" element={<CreateFetus />} />
            <Route path="/create-fetus-health" element={<CreateFetusHealth />} />
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