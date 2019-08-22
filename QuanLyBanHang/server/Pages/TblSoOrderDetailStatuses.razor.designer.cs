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
    public partial class TblSoOrderDetailStatusesComponent : ComponentBase
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

        protected RadzenGrid<TblSoOrderDetailStatus> grid0;

        protected RadzenButton gridDeleteButton;

        IEnumerable<TblSoOrderDetailStatus> _getTblSoOrderDetailStatusesResult;
        protected IEnumerable<TblSoOrderDetailStatus> getTblSoOrderDetailStatusesResult
        {
            get
            {
                return _getTblSoOrderDetailStatusesResult;
            }
            set
            {
                if(_getTblSoOrderDetailStatusesResult != value)
                {
                    _getTblSoOrderDetailStatusesResult = value;
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
            var otErpGetTblSoOrderDetailStatusesResult = await OtErp.GetTblSoOrderDetailStatuses(null, null);
            getTblSoOrderDetailStatusesResult = otErpGetTblSoOrderDetailStatusesResult;
        }

        protected async void Button0Click(UIMouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblSoOrderDetailStatus>("Add Tbl So Order Detail Status", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(TblSoOrderDetailStatus args)
        {
            var result = await DialogService.OpenAsync<EditTblSoOrderDetailStatus>("Edit Tbl So Order Detail Status", new Dictionary<string, object>() { {"SODetailStatus_SEQ", $"{args.SODetailStatus_SEQ}"} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(UIMouseEventArgs args, TblSoOrderDetailStatus data)
        {
            var otErpDeleteTblSoOrderDetailStatusResult = await OtErp.DeleteTblSoOrderDetailStatus(data.SODetailStatus_SEQ);
            if (otErpDeleteTblSoOrderDetailStatusResult != null) {
                grid0.Reload();
}
        }
    }
}
