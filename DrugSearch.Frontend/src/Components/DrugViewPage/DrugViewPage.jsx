import React, {useEffect, useState} from 'react';
import {useNavigate, useParams, useSearchParams} from "react-router-dom";
import DrugService from "../../API/DrugService.js";
import {useTelegram} from "../../Hooks/useTelegram.js";
import {useFetching} from "../../Hooks/useFetching.js";
import Loader from "../Loader/Loader.jsx";
import DrugStoreItem from "../DrugStoreItem/DrugStoreItem.jsx";

const DrugViewPage = () => {
  const {id} = useParams();
  let [urlParams, setUrlParams] = useSearchParams();
  const navigate = useNavigate();
  const [drugPricesInDrugStores, setDrugPricesInDrugStores] = useState({
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
    setDrugPricesInDrugStores(response.data)
  })

  useEffect( () => {
    fetchDrugPriceInDrugStoreById(id).then(() => {
      tg.ready();
      console.log(drugPricesInDrugStores)
    })
  }, [])

  useEffect(() => {
    if (urlParams.get('isBackButtVisible')) {
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
            : <DrugStoreItem drug={drugPricesInDrugStores}/>
        }
      </div>
  );
};

export default DrugViewPage;