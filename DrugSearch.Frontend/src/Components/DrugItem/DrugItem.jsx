import cl from './drugItem.module.css';
import MyLink from "../MyLink/MyLink.jsx";

const DrugItem = ({drug, className}) => {
  return (
    <div className={cl.drug + " " + className}>
      <img src='/drug.png' className={cl.img} alt={'drug img'}/>
      <div className={cl.name}>{drug.name}</div>

      <MyLink className={cl.viewBtn} to={'/drug/' + drug.id} value={'View'} />
    </div>
  );
};

export default DrugItem;