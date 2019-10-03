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
    public partial class TblGnGendersComponent : ComponentBase
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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            var otErpGetTblGnGendersResult = await OtErp.GetTblGnGenders();
            getTblGnGendersResult = otErpGetTblGnGendersResult;
        }

        protected async void Button0Click(MouseEventArgs args)
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

        protected async void GridDeleteButtonClick(MouseEventArgs args, TblGnGender data)
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
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblGnGender");
            }
        }
    }
}
