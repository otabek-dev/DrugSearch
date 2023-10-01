import React, {useEffect} from 'react';

const tg = window.Telegram.WebApp
const DrugList = () => {

  const fullURL = window.location.href;
  const baseURL = window.location.origin;
  const relativeURL = fullURL.substring(baseURL.length + 1, fullURL.indexOf('#'));

  useEffect(() => {
    tg.ready()
  }, [])

  const onClose = () => {
    tg.close()
  }

  return (
      <div>
        <h1>{relativeURL}</h1>
        <button onClick={onClose}>Close</button>
      </div>
  );
};

export default DrugList;