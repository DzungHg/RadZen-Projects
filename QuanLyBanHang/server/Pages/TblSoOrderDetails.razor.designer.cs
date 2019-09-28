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
    public partial class TblSoOrderDetailsComponent : ComponentBase
    {
        [Inject]
        protected IUriHelper UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected OtErpService OtErp { get; set; }


        protected RadzenContent content1;

        protected RadzenHeading pageTitle;

        protected RadzenButton button0;

        protected RadzenGrid<TblSoOrderDetail> grid0;

        protected RadzenButton gridDeleteButton;

        IEnumerable<TblSoOrderDetail> _getTblSoOrderDetailsResult;
        protected IEnumerable<TblSoOrderDetail> getTblSoOrderDetailsResult
        {
            get
            {
                return _getTblSoOrderDetailsResult;
            }
            set
            {
                if(_getTblSoOrderDetailsResult != value)
                {
                    _getTblSoOrderDetailsResult = value;
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
            var otErpGetTblSoOrderDetailsResult = await OtErp.GetTblSoOrderDetails(null, null);
            getTblSoOrderDetailsResult = otErpGetTblSoOrderDetailsResult;
        }

        protected async void Button0Click(UIMouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblSoOrderDetail>("Add Tbl So Order Detail", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(TblSoOrderDetail args)
        {
            var result = await DialogService.OpenAsync<EditTblSoOrderDetail>("Edit Tbl So Order Detail", new Dictionary<string, object>() { {"SODetail_SEQ", $"{args.SODetail_SEQ}"} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(UIMouseEventArgs args, TblSoOrderDetail data)
        {
            try
            {
                var otErpDeleteTblSoOrderDetailResult = await OtErp.DeleteTblSoOrderDetail(data.SODetail_SEQ);
                if (otErpDeleteTblSoOrderDetailResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception otErpDeleteTblSoOrderDetailException)
            {
                NotificationService.Notify(new NotificationMessage() { Severity = "error", Summary = $"Error", Detail = $"Unable to delete TblSoOrderDetail" });
            }
        }
    }
}
