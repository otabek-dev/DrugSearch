const tg = window.Telegram.WebApp;

export function useTelegram() {
  const onClose = () => {
    tg.close()
  }

  const onToggleButton = () => {
    if(tg.MainButton.isVisible) {
      tg.MainButton.hide();
    } else {
      tg.MainButton.show();
    }
  }

  return {
    tg,
    onClose,
    onToggleButton,
    webAppData: tg.initDataUnsafe,
    user: tg.initDataUnsafe?.user,
    queryId: tg.initDataUnsafe?.query_id,
    startParams: tg.initDataUnsafe?.start_param
  }
}