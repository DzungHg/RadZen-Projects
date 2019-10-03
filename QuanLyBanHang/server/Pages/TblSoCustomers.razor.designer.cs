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
    public partial class TblSoCustomersComponent : ComponentBase
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

        protected RadzenGrid<TblSoCustomer> grid0;

        protected RadzenButton gridDeleteButton;

        IEnumerable<TblSoCustomer> _getTblSoCustomersResult;
        protected IEnumerable<TblSoCustomer> getTblSoCustomersResult
        {
            get
            {
                return _getTblSoCustomersResult;
            }
            set
            {
                if(_getTblSoCustomersResult != value)
                {
                    _getTblSoCustomersResult = value;
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
            var otErpGetTblSoCustomersResult = await OtErp.GetTblSoCustomers();
            getTblSoCustomersResult = otErpGetTblSoCustomersResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblSoCustomer>($"Thêm mới", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(TblSoCustomer args)
        {
            var result = await DialogService.OpenAsync<EditTblSoCustomer>("Edit Tbl So Customer", new Dictionary<string, object>() { {"Customer_SEQ", $"{args.Customer_SEQ}"} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, TblSoCustomer data)
        {
            try
            {
                var otErpDeleteTblSoCustomerResult = await OtErp.DeleteTblSoCustomer(data.Customer_SEQ);
                if (otErpDeleteTblSoCustomerResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception otErpDeleteTblSoCustomerException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblSoCustomer");
            }
        }
    }
}
