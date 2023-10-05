import React, {useEffect, useState} from 'react';
import classes from './drugViewPage.module.css';
import {useNavigate, useParams} from "react-router-dom";
import DrugService from "../../API/DrugService.js";
import {useTelegram} from "../../Hooks/useTelegram.js";
import {useFetching} from "../../Hooks/useFetching.js";

const DrugViewPage = () => {
  const {id} = useParams();
  const navigate = useNavigate();
  const [drugs, setDrugs] = useState({
    "id": "",
    "name": "",
    "description": "",
    "drugStoreViewModel": [
      {
        "price": "",
        "drugStoreName": "",
        "drugStoreAddress": "",
        "drugStoreContact": ""
      },
    ]
  });
  const {tg, webAppData} = useTelegram();

  const [fetchDrugPriceInDrugStoreById, isLoading, error] = useFetching(async (id) => {
    const response = await DrugService.GetById(id)
    setDrugs(response.data)
  })

  useEffect( () => {
    fetchDrugPriceInDrugStoreById(id).then(() => {
      tg.ready();
      console.log(drugs)
    })
  }, [])

  useEffect(() => {
    console.log(webAppData)
    tg.BackButton.show();
    tg.BackButton.onClick(() => {
      tg.BackButton.hidden()
      navigate(-1)
    })
  }, [])

  console.log(drugs)

  return (
      <div>
        <div className={classes.drugView}>
          <img
              className={classes.img}
              src="https://loremflickr.com/cache/resized/65535_50608049121_ca39c59dc6_q_140_100_nofilter.jpg"
              alt="test"
          />
          <div className={classes.item}>
            <strong>{drugs.name}</strong> <br/>
            {drugs.description}
          </div>
        </div>
      </div>
  );
};

export default DrugViewPage;