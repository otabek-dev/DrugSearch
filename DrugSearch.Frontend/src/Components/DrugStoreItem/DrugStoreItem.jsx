import React from 'react';
import classes from "../DrugViewPage/drugViewPage.module.css";

const DrugStoreItem = () => {
  return (
      <div>
        <div className={classes.startSection}>
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
      </div>
  );
};

export default DrugStoreItem;