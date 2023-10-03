import React, {useEffect} from 'react';
import {useParams} from "react-router-dom";
import DrugService from "../../API/DrugService.js";

const tg = window.Telegram.WebApp

const DrugList = () => {
  const {query} = useParams();
  const searchDrugByQuery = async (query) => {
    const response = await DrugService.SearchByQuery(query)
    console.log(response)
  }

  useEffect( () => {
     searchDrugByQuery(query)
         .then()
  }, [])

  return (
      <div>
        <h2>query: {query}</h2>
      </div>
  );
};

export default DrugList;