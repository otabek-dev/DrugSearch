import './DrugItem.css';
import Button from "../Button/Button.jsx";

const DrugItem = ({drug, className}) => {
  const onClickHandler = () => {
    console.log('clicked')
  };

  return (
    <div className={'drug ' + className}>
      <div className={'img'}/>
      <div className={'name'}>{drug.name}</div>

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