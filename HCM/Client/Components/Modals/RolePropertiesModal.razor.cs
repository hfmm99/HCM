using HCM.Client.Services;
using Microsoft.AspNetCore.Components;
using System;

namespace HCM.Client
{
    public class RolePropertiesModalBase : ComponentBase, IDisposable
    {
        [Inject] ModalService ModalService { get; set; }
        protected bool IsVisible { get; set; }
        protected string Name { get; set; }
        protected override void OnInitialized()
        {
            ModalService.OnShowRolePropertiesModal += ShowModal;
            ModalService.OnCloseRolePropertiesModal += CloseModal;
        }
        public void ShowModal(bool show)
        {
            IsVisible = show;
            StateHasChanged();
        }
        public void CloseModal()
        {
            IsVisible = false;

            StateHasChanged();
        }
        public void Dispose()
        {
            ModalService.OnShowRolePropertiesModal -= ShowModal;
            ModalService.OnCloseRolePropertiesModal -= CloseModal;
        }
    }
}