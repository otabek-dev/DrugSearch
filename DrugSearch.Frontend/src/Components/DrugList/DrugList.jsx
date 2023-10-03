import React, {useEffect, useState} from 'react';
import {useParams} from "react-router-dom";
import DrugService from "../../API/DrugService.js";
import DrugItem from "../DrugItem/DrugItem.jsx";
import {useTelegram} from "../../Hooks/useTelegram.js";

const tg = window.Telegram.WebApp

const DrugList = () => {
  const {tg} = useTelegram();
  const {query} = useParams()
  const [drugs, setDrugs] = useState([
    {
      "id": "",
      "name": "",
      "description": "",
      "price": "",
      "drugStoreName": "",
      "drugStoreAddress": "",
      "drugStoreContact": ""
    },
  ])

  const searchDrugByQuery = async (query) => {
    const response = await DrugService.SearchByQuery(query)
    return response.data
  }

  useEffect( () => {
     searchDrugByQuery(query).then((data) => {
       setDrugs(data)
       tg.ready();
     })
  }, [query])

  console.log(drugs)

  return (
      <>
        <h1 style={{textAlign: "center", marginTop: "10px"}}>Search: {query}</h1>
        <div className={'list'}>
          {drugs.map(drug => (
              <DrugItem drug={drug} className={'item'} key={drug.id}/>
          ))}
        </div>
      </>
  );
};

export default DrugList;