import { BrowserRouter, Route, Routes } from 'react-router-dom';
import CheckData from './hoc/CheckData';
import Home from './pages/Home/Home';
import PlanetDetails from './pages/PlanetDetails/PlanetDetails';
import classes from './App.module.css';
import StarsBackground from './components/layout/StarsBackground/StarsBackground';

function App() {
  return (
    <BrowserRouter>
      <CheckData>
        <div className={classes.appBg}>
          <StarsBackground />
          <Routes>
            <Route path='/' element={<Home />} />
            <Route path='/:id' element={<PlanetDetails />} />
          </Routes>
        </div>
      </CheckData>
    </BrowserRouter>
  );
}

export default App;
