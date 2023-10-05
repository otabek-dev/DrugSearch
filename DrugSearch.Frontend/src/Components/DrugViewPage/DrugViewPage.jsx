import React, {useCallback, useEffect, useState} from 'react';
import classes from './drugViewPage.module.css';
import {useNavigate, useParams} from "react-router-dom";
import DrugService from "../../API/DrugService.js";
import {useTelegram} from "../../Hooks/useTelegram.js";
import {useFetching} from "../../Hooks/useFetching.js";

const DrugViewPage = ({isActiveBackButton}) => {
  const {id} = useParams();
  const navigate = useNavigate();
  const [drug, setDrug] = useState({
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
  const {tg} = useTelegram();

  const [fetchDrugPriceInDrugStoreById, isLoading, error] = useFetching(async (id) => {
    const response = await DrugService.GetById(id)
    setDrug(response.data)
  })

  useEffect( () => {
    fetchDrugPriceInDrugStoreById(id).then(() => {
      tg.ready();
      console.log(drug)
    })
  }, [])

  useEffect(() => {
    // if (isActiveBackButton) {
    //   tg.BackButton.show();
    // }
    // else {
    //   tg.BackButton.hide()
    // }

    tg.BackButton.show();
    // tg.BackButton.onClick(() => {
    //   navigate(-1)
    // })

  }, [])

  useEffect(() => {
    tg.onEvent('backButtonClicked', navigate(-1))
    return () => {
      tg.offEvent('backButtonClicked', navigate(-1))
    }
  }, [])

  return (
      <div className={classes.startSection}>

        <div className={classes.drugView}>
          <p>
            <img
                className={classes.img}
                src="https://loremflickr.com/cache/resized/65535_50608049121_ca39c59dc6_q_140_100_nofilter.jpg"
                alt="test"
            />
            <strong>{drug.name}</strong> <br/>
            {drug.description}
          </p>
        </div>

        {drug.drugStoreViewModel.map((ds) => (
            <div className={classes.drugView} key={ds.price}>
              {ds.price} <br/>
              {ds.drugStoreName}
              {ds.drugStoreAddress}
              {ds.drugStoreContact}
            </div>
        ))}
      </div>
  );
};

export default DrugViewPage;