import React, {useEffect, useState} from 'react';
import {useLocation, useParams, useSearchParams} from "react-router-dom";
import DrugService from "../../API/DrugService.js";
import DrugItem from "../DrugItem/DrugItem.jsx";
import {useTelegram} from "../../Hooks/useTelegram.js";
import {useFetching} from "../../Hooks/useFetching.js";
import Loader from "../Loader/Loader.jsx";
import cl from './drugList.module.css';

const DrugList = () => {
  const {tg} = useTelegram();
  const {query} = useParams()
  const [drugs, setDrugs] = useState([
    {
      "id": "",
      "name": "",
      "description": ""
    },
  ])

  const [fetchDrugByQuery, isLoading, error] = useFetching(async (query) => {
    const response = await DrugService.SearchByQuery(query)
    setDrugs(response.data)
  })

  useEffect( () => {
    fetchDrugByQuery(query).then(() => {
       tg.ready();
     })
  }, [])

  return (
      <div className={cl.startSection}>
        <h1 style={{textAlign: "center", marginTop: "10px"}}>Search: {query}</h1>
        {isLoading
          ? <Loader/>
          : <div className={cl.list}>
              {drugs.map(drug => (
                  <DrugItem drug={drug} className={cl.item} key={drug.id}/>
              ))}
            </div>
        }
      </div>
  );
};

export default DrugList;

