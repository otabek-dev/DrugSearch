import React, {useEffect} from 'react';
import './DrugItem.css';
import {useParams} from "react-router-dom";

const DrugItem = () => {
  const relativeURL = window.location.pathname.replace('/', '')
  const {id} = useParams();

  useEffect(() => {
    console.log(id)
  }, [])

  return (
      <div>
        <h1>Item</h1>
        <h2>{id}</h2>
      </div>
  );
};

export default DrugItem;