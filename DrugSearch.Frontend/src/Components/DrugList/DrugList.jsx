import React, {useEffect, useState} from 'react';
import {useParams} from "react-router-dom";
import DrugService from "../../API/DrugService.js";
import DrugItem from "../DrugItem/DrugItem.jsx";

const tg = window.Telegram.WebApp

const DrugList = () => {
  const {query} = useParams()
  const [drugs, setDrugs] = useState([
    {
      "id": "eb8a72f3-8bcb-4f43-bed4-320ce980e91b",
      "name": "Ciprofloxacin",
      "description": "Ciprofloxacin is an antibiotic used to treat a variety of bacterial infections, including urinary tract and skin infections.",
      "price": "680.50",
      "drugStoreName": "Pfannerstill - Greenholt",
      "drugStoreAddress": "Erdmanstad:838 Kling Way",
      "drugStoreContact": "562.588.2644 x9055"
    },
  ])
  const searchDrugByQuery = async (query) => {
    const response = await DrugService.SearchByQuery(query)
    return response.data
  }

  useEffect( () => {
     searchDrugByQuery(query).then((data) => {
       setDrugs(data)
     })
  }, [])

  console.log(drugs)

  return (
      <div className={'list'}>
        {/*<h1>Query: {query}</h1>*/}
        {drugs.map(drug => (
            <DrugItem drug={drug} className={'item'} key={drug.id}/>
        ))}
      </div>
  );
};

export default DrugList;