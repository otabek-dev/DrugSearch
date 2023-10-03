import './App.css'
import {Route, Routes} from "react-router-dom";
import DrugList from "./Components/DrugList/DrugList.jsx";
import DrugViewPage from "./Components/DrugViewPage/DrugViewPage.jsx";

function App() {
  return (
    <div className="App">
      <Routes>
        <Route
            path={":query"}
            element={<DrugList />}
        />
        <Route
            path={'drug/:id'}
            element={<DrugViewPage />}
        />
      </Routes>
    </div>
  )
}

export default App
