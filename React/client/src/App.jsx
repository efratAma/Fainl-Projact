import { BrowserRouter, Routes, Route } from 'react-router-dom';
// import Register from './pages/Register';
// import Dashboard from './pages/Dashboard';
// import Login from './pages/Login';
// import AdminDashboard from './pages/AdminDashboard'
import Home from './components/Home'
import LoginPage from './components/LoginPage'
import SignupPage from './components/SignupPage';
import ProjectsPage from './components/Projects';
import Profile from './components/Profile';
import Navbar from './components/Navbar';

function App() {
  return (

    <BrowserRouter>
      <Navbar />
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/login" element={<LoginPage />} />
        <Route path="/signup" element={<SignupPage />} />
        <Route path="/projects" element={<ProjectsPage />} />
        <Route path="/profile" element={<Profile />} />

      </Routes>
    </BrowserRouter>
  );
}

export default App;
