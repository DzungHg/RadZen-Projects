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
    public partial class TblSoOrderStatusesComponent : ComponentBase
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

        protected RadzenGrid<TblSoOrderStatus> grid0;

        protected RadzenButton gridDeleteButton;

        IEnumerable<TblSoOrderStatus> _getTblSoOrderStatusesResult;
        protected IEnumerable<TblSoOrderStatus> getTblSoOrderStatusesResult
        {
            get
            {
                return _getTblSoOrderStatusesResult;
            }
            set
            {
                if(_getTblSoOrderStatusesResult != value)
                {
                    _getTblSoOrderStatusesResult = value;
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
            var otErpGetTblSoOrderStatusesResult = await OtErp.GetTblSoOrderStatuses(null, null);
            getTblSoOrderStatusesResult = otErpGetTblSoOrderStatusesResult;
        }

        protected async void Button0Click(UIMouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblSoOrderStatus>("Add Tbl So Order Status", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(TblSoOrderStatus args)
        {
            var result = await DialogService.OpenAsync<EditTblSoOrderStatus>("Edit Tbl So Order Status", new Dictionary<string, object>() { {"SOStatus_SEQ", $"{args.SOStatus_SEQ}"} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(UIMouseEventArgs args, TblSoOrderStatus data)
        {
            try
            {
                var otErpDeleteTblSoOrderStatusResult = await OtErp.DeleteTblSoOrderStatus(data.SOStatus_SEQ);
                if (otErpDeleteTblSoOrderStatusResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception otErpDeleteTblSoOrderStatusException)
            {
                NotificationService.Notify(new NotificationMessage() { Severity = "error", Summary = $"Error", Detail = $"Unable to delete TblSoOrderStatus" });
            }
        }
    }
}
