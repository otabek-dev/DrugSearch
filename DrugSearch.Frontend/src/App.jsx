import './App.css'
import {Route, Routes} from "react-router-dom";
import DrugList from "./Components/DrugList/DrugList.jsx";
import DrugItem from "./Components/DrugItem/DrugItem.jsx";
import {useEffect} from "react";
import {useTelegram} from "./Hooks/useTelegram.js";

function App() {
  const {tg} = useTelegram();

  useEffect(() => {
    tg.ready();
  }, [])

  return (
    <div>
      <Routes>
        <Route
            path={":query"}
            element={<DrugList />}
        />
        <Route
            path={'item/:id'}
            element={<DrugItem />}
        />
      </Routes>
    </div>
  )
}

export default App
