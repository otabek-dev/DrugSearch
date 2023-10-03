import './DrugItem.css';
import MyLink from "../MyLink/MyLink.jsx";

const DrugItem = ({drug, className}) => {

  return (
    <div className={'drug ' + className}>
      <div className={'img'}/>
      <div className={'name'}>{drug.name}</div>

      <div className={'price'}>
        <span>Price: <b>{drug.price}</b></span>
      </div>
      <MyLink className={'view-btn'} to={'/drug/' + drug.id} value={'View'} />
    </div>
  );
};

export default DrugItem;