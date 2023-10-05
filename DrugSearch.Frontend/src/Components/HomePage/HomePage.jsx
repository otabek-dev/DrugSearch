import React, {useEffect} from 'react';
import {useTelegram} from "../../Hooks/useTelegram.js";
import {useNavigate} from "react-router-dom";

const HomePage = () => {
  const {startParam} = useTelegram()
  const navigate = useNavigate()
  useEffect(() => {
    if (startParam !== undefined)
      navigate(`/drug/${startParam}`)
  }, [])
  return (
      <div>
        <h1>Not found!</h1>
      </div>
  );
};

export default HomePage;