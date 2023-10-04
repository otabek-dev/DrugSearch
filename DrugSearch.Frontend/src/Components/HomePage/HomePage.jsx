import React, {useEffect} from 'react';
import {useTelegram} from "../../Hooks/useTelegram.js";
import {useNavigate} from "react-router-dom";

const HomePage = () => {
  const {startParams} = useTelegram()
  const navigate = useNavigate()
  useEffect(() => {
    if (startParams !== undefined)
      navigate(`/drug/${startParams}`)
  }, [])
  return (
      <div>
        <h1>Not found!</h1>
      </div>
  );
};

export default HomePage;