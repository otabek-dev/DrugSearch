import React, {useEffect, useState} from 'react';
import './DrugItem.css';
import {useParams} from "react-router-dom";
import DrugService from "../../API/DrugService.js";
import Button from "../Button/Button.jsx";

const DrugItem = ({drug, className}) => {
  const onClickHandler = () => {
    console.log('clicked')
  };

  return (
    <div className={'drug ' + className}>
      <div className={'img'}/>
      <div className={'title'}>{drug.title}</div>
      <div className={'description'}>{drug.description}</div>
      <div className={'price'}>
        <span>Price: <b>{drug.price}</b></span>
      </div>
      <Button className={'view-btn'} onClick={onClickHandler}>
        View
      </Button>
    </div>
  );
};

export default DrugItem;