using System;

namespace HCM.Client.Services
{
    public class ModalService
    {
        public event Action<bool, string> OnShowDeleteModal;
        public event Action OnCloseDeleteModal;
        public void ShowDeleteModal(bool show, string name)
        {
            OnShowDeleteModal?.Invoke(show, name);
        }

        public void CloseDeleteModal()
        {
            OnCloseDeleteModal?.Invoke();
        }

        public event Action<bool> OnShowRolePropertiesModal;
        public event Action OnCloseRolePropertiesModal;

        public void ShowRolePropertiesModal(bool show)
        {
            OnShowRolePropertiesModal?.Invoke(show);
        }

        public void CloseRolePropertiesModal()
        {
            OnCloseRolePropertiesModal?.Invoke();
        }
    }
}
