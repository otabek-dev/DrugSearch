import './App.css'
import {Route, Routes} from "react-router-dom";
import DrugList from "./Components/DrugList/DrugList.jsx";
import {useEffect} from "react";
import {useTelegram} from "./Hooks/useTelegram.js";
import DrugViewPage from "./Components/DrugViewPage/DrugViewPage.jsx";

function App() {
  const {tg} = useTelegram();

  useEffect(() => {
    tg.ready();
  }, [])

  return (
    <div className="App">
      <Routes>
        <Route
            path={":query"}
            element={<DrugList />}
        />
        <Route
            path={'item/:id'}
            element={<DrugViewPage />}
        />
      </Routes>
    </div>
  )
}

export default App
