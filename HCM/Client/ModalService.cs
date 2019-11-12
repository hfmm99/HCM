using System;

namespace HCM.Client.Services
{
    public class ModalService
    {
        public event Action<bool> OnShow;
        public event Action OnClose;
        public void Show(bool show)
        {
            OnShow?.Invoke(show);
        }

        public void Close()
        {
            OnClose?.Invoke();
        }
    }
}
