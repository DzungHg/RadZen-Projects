using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using QuanLyBanHang.Models.OtErp;

namespace QuanLyBanHang.Pages
{
    public partial class TblSoSalesOrdersComponent : ComponentBase
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

        protected RadzenGrid<TblSoSalesOrder> grid0;

        protected RadzenButton gridDeleteButton;

        IEnumerable<TblSoSalesOrder> _getTblSoSalesOrdersResult;
        protected IEnumerable<TblSoSalesOrder> getTblSoSalesOrdersResult
        {
            get
            {
                return _getTblSoSalesOrdersResult;
            }
            set
            {
                if(_getTblSoSalesOrdersResult != value)
                {
                    _getTblSoSalesOrdersResult = value;
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
            var otErpGetTblSoSalesOrdersResult = await OtErp.GetTblSoSalesOrders(null, null);
            getTblSoSalesOrdersResult = otErpGetTblSoSalesOrdersResult;
        }

        protected async void Button0Click(UIMouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblSoSalesOrder>("Add Tbl So Sales Order", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(TblSoSalesOrder args)
        {
            var result = await DialogService.OpenAsync<EditTblSoSalesOrder>("Edit Tbl So Sales Order", new Dictionary<string, object>() { {"SO_SEQ", $"{args.SO_SEQ}"} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(UIMouseEventArgs args, TblSoSalesOrder data)
        {
            try
            {
                var otErpDeleteTblSoSalesOrderResult = await OtErp.DeleteTblSoSalesOrder(data.SO_SEQ);
                if (otErpDeleteTblSoSalesOrderResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception otErpDeleteTblSoSalesOrderException)
            {
                NotificationService.Notify(new NotificationMessage() { Severity = "error", Summary = $"Error", Detail = $"Unable to delete TblSoSalesOrder" });
            }
        }
    }
}
