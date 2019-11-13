﻿using HCM.Client.Services;
using Microsoft.AspNetCore.Components;
using System;

namespace HCM.Client
{
    public class DeleteModalBase : ComponentBase, IDisposable
    {
        [Inject] ModalService ModalService { get; set; }
        protected bool IsVisible { get; set; }
        protected string Name { get; set; }
        protected override void OnInitialized()
        {
            ModalService.OnShowDeleteModal += ShowModal;
            ModalService.OnCloseDeleteModal += CloseModal;
        }
        public void ShowModal(bool show, string name)
        {
            IsVisible = show;
            Name = name;
            StateHasChanged();
        }
        public void CloseModal()
        {
            IsVisible = false;

            StateHasChanged();
        }
        public void Dispose()
        {
            ModalService.OnShowDeleteModal -= ShowModal;
            ModalService.OnCloseDeleteModal -= CloseModal;
        }
    }
}