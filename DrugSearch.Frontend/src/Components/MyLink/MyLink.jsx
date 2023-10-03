import React from 'react';
import "./MyLink.css"
import {Link} from "react-router-dom";

const MyLink = ({to, value, ...props}) => {
  return (
      <>
        <Link
            to={to}
            children={value}
            className={'my-link ' + props.className}
        />
      </>
  );
};

export default MyLink;