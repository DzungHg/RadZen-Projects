﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using QuanLyBanHang.Models.OtErp;

namespace QuanLyBanHang.Pages
{
    public partial class EditTblSoOrderStatusComponent : ComponentBase
    {
        [Inject]
        protected IUriHelper UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected OtErpService OtErp { get; set; }


        [Parameter]
        public string SOStatus_SEQ { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<TblSoOrderStatus> form0;

        protected RadzenLabel label2;

        protected RadzenTextBox soStatusId;

        protected RadzenRequiredValidator soStatusIdRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenTextBox soStatusText;

        protected RadzenLabel label4;

        protected RadzenTextBox description;

        protected RadzenButton button2;

        protected RadzenButton button3;

        bool _canEdit;
        protected bool canEdit
        {
            get
            {
                return _canEdit;
            }
            set
            {
                if(_canEdit != value)
                {
                    _canEdit = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        TblSoOrderStatus _tblsoorderstatus;
        protected TblSoOrderStatus tblsoorderstatus
        {
            get
            {
                return _tblsoorderstatus;
            }
            set
            {
                if(_tblsoorderstatus != value)
                {
                    _tblsoorderstatus = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        protected override async Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            canEdit = true;

            var otErpGetTblSoOrderStatusBySoStatusSeqResult = await OtErp.GetTblSoOrderStatusBySoStatusSeq(int.Parse(SOStatus_SEQ));
            tblsoorderstatus = otErpGetTblSoOrderStatusBySoStatusSeqResult;
        }

        protected async void CloseButtonClick(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(TblSoOrderStatus args)
        {
            var otErpUpdateTblSoOrderStatusResult = await OtErp.UpdateTblSoOrderStatus(int.Parse(SOStatus_SEQ), tblsoorderstatus);
            DialogService.Close(tblsoorderstatus);
        }

        protected async void Button3Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}