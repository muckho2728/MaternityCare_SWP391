import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import { Provider } from 'react-redux';
import { store } from './store/config';
import Header from './component/Header/Header';
import Footer from './component/Footer/Footer';
import CreateFetus from './component/CreateFetus/CreateFetus';
import CreateFetusHealth from './component/CreateFetusHealth/CreateFetusHealth';
import ManageUsersPage from './component/Admin/ManageUsersPage';
import Profile from './component/Profile/Profile';
function App() {
  return (
    <Provider store={store}>
      <Router>
        <div className="app">
          <Header />
          <main className="main-content">
            <Routes>
              <Route path="/" element={<CreateFetus />} />
              <Route path="/create-fetus" element={<CreateFetus />} />
              <Route path="/create-fetus-health" element={<CreateFetusHealth />} />
              <Route path="/management-users" element={<ManageUsersPage />} />
              <Route path="/profile" element={<Profile />} /> 
            </Routes>
          </main>
          <Footer />
        </div>
      </Router>
    </Provider>
  );
}

export default App;