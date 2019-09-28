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
    public partial class TblGnShipViaComponent : ComponentBase
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

        protected RadzenGrid<TblGnShipVium> grid0;

        protected RadzenButton gridDeleteButton;

        IEnumerable<TblGnShipVium> _getTblGnShipViaResult;
        protected IEnumerable<TblGnShipVium> getTblGnShipViaResult
        {
            get
            {
                return _getTblGnShipViaResult;
            }
            set
            {
                if(_getTblGnShipViaResult != value)
                {
                    _getTblGnShipViaResult = value;
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
            var otErpGetTblGnShipViaResult = await OtErp.GetTblGnShipVia(null, null);
            getTblGnShipViaResult = otErpGetTblGnShipViaResult;
        }

        protected async void Button0Click(UIMouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnShipVium>("Add Tbl Gn Ship Vium", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(TblGnShipVium args)
        {
            var result = await DialogService.OpenAsync<EditTblGnShipVium>("Edit Tbl Gn Ship Vium", new Dictionary<string, object>() { {"ShipVia_SEQ", $"{args.ShipVia_SEQ}"} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(UIMouseEventArgs args, TblGnShipVium data)
        {
            try
            {
                var otErpDeleteTblGnShipViumResult = await OtErp.DeleteTblGnShipVium(data.ShipVia_SEQ);
                if (otErpDeleteTblGnShipViumResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception otErpDeleteTblGnShipViumException)
            {
                NotificationService.Notify(new NotificationMessage() { Severity = "error", Summary = $"Error", Detail = $"Unable to delete TblGnShipVium" });
            }
        }
    }
}
