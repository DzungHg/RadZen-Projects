using System;
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
    public partial class TblGnCitiesComponent : ComponentBase
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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            var otErpGetTblGnCitiesResult = await OtErp.GetTblGnCities();
            getTblGnCitiesResult = otErpGetTblGnCitiesResult;
        }

        protected async void Button0Click(MouseEventArgs args)
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

        protected async void GridDeleteButtonClick(MouseEventArgs args, TblGnCity data)
        {
            try
            {
                var otErpDeleteTblGnCityResult = await OtErp.DeleteTblGnCity(data.City_SEQ);
                if (otErpDeleteTblGnCityResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception otErpDeleteTblGnCityException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblGnCity");
            }
        }
    }
}
