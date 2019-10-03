﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using QuanLyBanHang.Models.OtErp;

namespace QuanLyBanHang.Pages
{
    public partial class TblGnPaymentTypesComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected OtErpService OtErp { get; set; }


        protected RadzenContent content1;

        protected RadzenHeading pageTitle;

        protected RadzenButton button0;

        protected RadzenGrid<TblGnPaymentType> grid0;

        protected RadzenButton gridDeleteButton;

        IEnumerable<TblGnPaymentType> _getTblGnPaymentTypesResult;
        protected IEnumerable<TblGnPaymentType> getTblGnPaymentTypesResult
        {
            get
            {
                return _getTblGnPaymentTypesResult;
            }
            set
            {
                if(_getTblGnPaymentTypesResult != value)
                {
                    _getTblGnPaymentTypesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            var otErpGetTblGnPaymentTypesResult = await OtErp.GetTblGnPaymentTypes();
            getTblGnPaymentTypesResult = otErpGetTblGnPaymentTypesResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnPaymentType>("Add Tbl Gn Payment Type", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(TblGnPaymentType args)
        {
            var result = await DialogService.OpenAsync<EditTblGnPaymentType>("Edit Tbl Gn Payment Type", new Dictionary<string, object>() { {"PaymentType_SEQ", $"{args.PaymentType_SEQ}"} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, TblGnPaymentType data)
        {
            try
            {
                var otErpDeleteTblGnPaymentTypeResult = await OtErp.DeleteTblGnPaymentType(data.PaymentType_SEQ);
                if (otErpDeleteTblGnPaymentTypeResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception otErpDeleteTblGnPaymentTypeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblGnPaymentType");
            }
        }
    }
}
