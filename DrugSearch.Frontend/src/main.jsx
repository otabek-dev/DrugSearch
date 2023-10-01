import ReactDOM from 'react-dom/client'
import App from './App.jsx'
import {BrowserRouter, Route, Routes} from "react-router-dom";
import DrugList from "./Components/DrugList/DrugList.jsx";

ReactDOM.createRoot(document.getElementById('root')).render(
    <BrowserRouter>
      <App />
      <Routes>
        <Route
            path="*"
            element={<DrugList />}
        />
      </Routes>
    </BrowserRouter>
)
