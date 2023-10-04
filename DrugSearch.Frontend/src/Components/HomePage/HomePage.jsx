import React from 'react';
import {useTelegram} from "../../Hooks/useTelegram.js";

const HomePage = () => {
  const {startParams} = useTelegram()
  console.log(startParams)
  return (
      <div>
        {startParams}
      </div>
  );
};

export default HomePage;