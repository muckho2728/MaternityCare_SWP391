import { BrowserRouter as Router, Routes, Route } from 'react-router-dom'
import CreateFetus from './component/CreateFetus/CreateFetus'
import CreateFetusHealth from './component/CreateFetusHealth/CreateFetusHealth'
import Header from './component/Header/Header'
import Footer from './component/Footer/Footer'
import Home from './component/Home/Home'

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
        <Footer />
      </div>
    </Router>
  )
}

export default App