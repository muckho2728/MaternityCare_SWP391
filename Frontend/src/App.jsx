import { BrowserRouter as Router, Routes, Route } from 'react-router-dom'
import CreateFetus from './component/CreateFetus/CreateFetus'
import CreateFetusHealth from './component/CreateFetusHealth/CreateFetusHealth'
import Header from './component/Header/Header'
import Footer from './component/Footer/Footer'

function App() {
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
        <Footer/>
      </div>
    </Router>
  )
}

export default App