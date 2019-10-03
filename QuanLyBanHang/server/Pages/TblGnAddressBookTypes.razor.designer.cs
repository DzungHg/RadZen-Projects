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
    public partial class TblGnAddressBookTypesComponent : ComponentBase
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

        protected RadzenGrid<TblGnAddressBookType> grid0;

        protected RadzenButton gridDeleteButton;

        IEnumerable<TblGnAddressBookType> _getTblGnAddressBookTypesResult;
        protected IEnumerable<TblGnAddressBookType> getTblGnAddressBookTypesResult
        {
            get
            {
                return _getTblGnAddressBookTypesResult;
            }
            set
            {
                if(_getTblGnAddressBookTypesResult != value)
                {
                    _getTblGnAddressBookTypesResult = value;
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
            var otErpGetTblGnAddressBookTypesResult = await OtErp.GetTblGnAddressBookTypes();
            getTblGnAddressBookTypesResult = otErpGetTblGnAddressBookTypesResult;
        }

        protected async void Button0Click(MouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnAddressBookType>("Add Tbl Gn Address Book Type", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(TblGnAddressBookType args)
        {
            var result = await DialogService.OpenAsync<EditAddressBookType>("Edit AddressBook Type", new Dictionary<string, object>() { {"AddressBookType_SEQ", $"{args.AddressBookType_SEQ}"} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(MouseEventArgs args, TblGnAddressBookType data)
        {
            try
            {
                var otErpDeleteTblGnAddressBookTypeResult = await OtErp.DeleteTblGnAddressBookType(data.AddressBookType_SEQ);
                if (otErpDeleteTblGnAddressBookTypeResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception otErpDeleteTblGnAddressBookTypeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblGnAddressBookType");
            }
        }
    }
}
