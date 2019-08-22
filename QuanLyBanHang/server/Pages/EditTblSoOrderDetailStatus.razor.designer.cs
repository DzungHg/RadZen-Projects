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
    public partial class EditTblSoOrderDetailStatusComponent : ComponentBase
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
        public string SODetailStatus_SEQ { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<TblSoOrderDetailStatus> form0;

        protected RadzenLabel label2;

        protected dynamic soDetailStatusId;

        protected RadzenLabel label3;

        protected RadzenTextBox soDetailStatusText;

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

        TblSoOrderDetailStatus _tblsoorderdetailstatus;
        protected TblSoOrderDetailStatus tblsoorderdetailstatus
        {
            get
            {
                return _tblsoorderdetailstatus;
            }
            set
            {
                if(_tblsoorderdetailstatus != value)
                {
                    _tblsoorderdetailstatus = value;
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

            var otErpGetTblSoOrderDetailStatusBySoDetailStatusSeqResult = await OtErp.GetTblSoOrderDetailStatusBySoDetailStatusSeq(int.Parse(SODetailStatus_SEQ));
            tblsoorderdetailstatus = otErpGetTblSoOrderDetailStatusBySoDetailStatusSeqResult;
        }

        protected async void CloseButtonClick(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(TblSoOrderDetailStatus args)
        {
            var otErpUpdateTblSoOrderDetailStatusResult = await OtErp.UpdateTblSoOrderDetailStatus(int.Parse(SODetailStatus_SEQ), tblsoorderdetailstatus);
            DialogService.Close(tblsoorderdetailstatus);
        }

        protected async void Button3Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}