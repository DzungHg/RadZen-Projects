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
    public partial class TblGnCitiesComponent : ComponentBase
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

        protected RadzenGrid<TblGnCity> grid0;

        protected RadzenButton gridDeleteButton;

        IEnumerable<TblGnCity> _getTblGnCitiesResult;
        protected IEnumerable<TblGnCity> getTblGnCitiesResult
        {
            get
            {
                return _getTblGnCitiesResult;
            }
            set
            {
                if(_getTblGnCitiesResult != value)
                {
                    _getTblGnCitiesResult = value;
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
            var otErpGetTblGnCitiesResult = await OtErp.GetTblGnCities(null, null);
            getTblGnCitiesResult = otErpGetTblGnCitiesResult;
        }

        protected async void Button0Click(UIMouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnCity>("Add Tbl Gn City", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(TblGnCity args)
        {
            var result = await DialogService.OpenAsync<EditTblGnCity>("Edit Tbl Gn City", new Dictionary<string, object>() { {"City_SEQ", $"{args.City_SEQ}"} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(UIMouseEventArgs args, TblGnCity data)
        {
            var otErpDeleteTblGnCityResult = await OtErp.DeleteTblGnCity(data.City_SEQ);
            if (otErpDeleteTblGnCityResult != null) {
                grid0.Reload();
}
        }
    }
}
