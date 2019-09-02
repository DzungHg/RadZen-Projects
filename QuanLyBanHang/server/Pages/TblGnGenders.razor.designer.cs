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
    public partial class TblGnGendersComponent : ComponentBase
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

        protected RadzenGrid<TblGnGender> grid0;

        protected RadzenButton gridDeleteButton;

        IEnumerable<TblGnGender> _getTblGnGendersResult;
        protected IEnumerable<TblGnGender> getTblGnGendersResult
        {
            get
            {
                return _getTblGnGendersResult;
            }
            set
            {
                if(_getTblGnGendersResult != value)
                {
                    _getTblGnGendersResult = value;
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
            var otErpGetTblGnGendersResult = await OtErp.GetTblGnGenders(null, null);
            getTblGnGendersResult = otErpGetTblGnGendersResult;
        }

        protected async void Button0Click(UIMouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnGender>("Add Tbl Gn Gender", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(TblGnGender args)
        {
            var result = await DialogService.OpenAsync<EditTblGnGender>("Edit Tbl Gn Gender", new Dictionary<string, object>() { {"Gender_SEQ", $"{args.Gender_SEQ}"} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(UIMouseEventArgs args, TblGnGender data)
        {
            try
            {
                var otErpDeleteTblGnGenderResult = await OtErp.DeleteTblGnGender(data.Gender_SEQ);
                if (otErpDeleteTblGnGenderResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception otErpDeleteTblGnGenderException)
            {
                NotificationService.Notify(new NotificationMessage() { Severity = "error", Summary = $"Error", Detail = $"Unable to delete TblGnGender" });
            }
        }
    }
}
