import React, {useEffect, useState} from 'react';
import "./DrugViewPage.css";
import {useParams} from "react-router-dom";
import DrugService from "../../API/DrugService.js";

const DrugViewPage = () => {
  const {id} = useParams();
  const [drug, setDrug] = useState({
    "id": "eb8a72f3-8bcb-4f43-bed4-320ce980e91b",
    "name": "Ciprofloxacin",
    "description": "Ciprofloxacin is an antibiotic used to treat a variety of bacterial infections, including urinary tract and skin infections.",
    "price": "680.50",
    "drugStoreName": "Pfannerstill - Greenholt",
    "drugStoreAddress": "Erdmanstad:838 Kling Way",
    "drugStoreContact": "562.588.2644 x9055"
  });

  const searchDrugById = async (id) => {
    const response = await DrugService.GetById(id)
    return response.data
  }

  useEffect(() => {
    // searchDrugById(id).then((data) => {
    //   setDrug(data)
    // })
  }, [])

  console.log(drug)

  return (
      <div>
        <h1>Drug view page</h1>
        {id}
      </div>
  );
};

export default DrugViewPage;