using System;

namespace HCM.Client.Services
{
    public class ModalService
    {
        public event Action<bool, string> OnShow;
        public event Action OnClose;
        public void Show(bool show, string name)
        {
            OnShow?.Invoke(show, name);
        }

        public void Close()
        {
            OnClose?.Invoke();
        }
    }
}
