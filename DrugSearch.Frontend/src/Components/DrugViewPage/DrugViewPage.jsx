import React, {useEffect, useState} from 'react';
import classes from './drugViewPage.module.css';
import {useNavigate, useParams} from "react-router-dom";
import DrugService from "../../API/DrugService.js";
import {useTelegram} from "../../Hooks/useTelegram.js";
import {useFetching} from "../../Hooks/useFetching.js";
import Loader from "../Loader/Loader.jsx";

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
    if (navigate.length >= 2) {
      tg.BackButton.show();
      tg.BackButton.onClick(() => {
        navigate(-1)
        tg.BackButton.hide()
      })
    }
    else {
      tg.BackButton.hide()
    }

    return () => {
      tg.BackButton.offClick()
    }
  }, [])

  return (
      <div style={{display: "flex",justifyContent: "center"}}>
        {
          isLoading
            ? <Loader />
            : <div className={classes.startSection}>
                <div className={classes.drugView}>
                  <p>
                    <img
                        className={classes.img}
                        src="/drug.png"
                        alt="test"
                    />
                    <strong>{drug.name}</strong> <br/>
                    {drug.description}
                  </p>
                </div>

                {drug.drugStoreViewModel.map((ds) => (
                    <div className={classes.drugStoreView} key={ds.price}>
                      <strong>Price: </strong>{ds.price} <br/>
                      <strong>Drug store: </strong>{ds.drugStoreName} <br/>
                      <strong>Address: </strong>{ds.drugStoreAddress} <br/>
                      <strong>Contact: </strong>{ds.drugStoreContact} <br/>
                    </div>
                ))}
              </div>
        }
      </div>
  );
};

export default DrugViewPage;