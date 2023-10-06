import cl from './drugItem.module.css';
import MyLink from "../MyLink/MyLink.jsx";
import {useSearchParams} from "react-router-dom";

const DrugItem = ({drug, className}) => {
  return (
    <div className={cl.drug + " " + className}>
      <img src='/drug.png' className={cl.img} alt={'drug img'}/>
      <div className={cl.name}>{drug.name}</div>

      <MyLink className={cl.viewBtn} to={'/drug/' + drug.id + '?isBackButtVisible=true'} value={'View'} />
    </div>
  );
};

export default DrugItem;