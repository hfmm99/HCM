using System;

namespace HCM.Client.Services
{
    public class ModalService
    {
        public event Action<bool, string> OnShow;
        public event Action OnClose;
        public void ShowModal(bool show, string name = null)
        {
            OnShow?.Invoke(show, name);
        }

        public void CloseModal()
        {
            OnClose?.Invoke();
        }
    }
}
