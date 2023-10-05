const tg = window.Telegram.WebApp;

export function useTelegram() {
  const onClose = () => {
    tg.close()
  }

  return {
    tg,
    onClose,
    webAppData: tg.initDataUnsafe,
    user: tg.initDataUnsafe?.user,
    queryId: tg.initDataUnsafe?.query_id,
    startParams: tg.initDataUnsafe?.start_param
  }
}