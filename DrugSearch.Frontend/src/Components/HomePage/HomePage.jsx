import React, {useEffect} from 'react';
import {useTelegram} from "../../Hooks/useTelegram.js";
import {useNavigate} from "react-router-dom";

const HomePage = () => {
  const {startParams} = useTelegram()
  const navigate = useNavigate()
  useEffect(() => {
    if (startParams !== undefined)
      navigate('/pi')
  }, [])
  return (
      <div>
        {startParams}
      </div>
  );
};

export default HomePage;