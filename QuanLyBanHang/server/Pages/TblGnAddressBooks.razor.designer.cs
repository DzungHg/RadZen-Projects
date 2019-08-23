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
    public partial class TblGnAddressBooksComponent : ComponentBase
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

        protected RadzenGrid<TblGnAddressBook> grid0;

        protected RadzenButton gridDeleteButton;

        IEnumerable<TblGnAddressBook> _getTblGnAddressBooksResult;
        protected IEnumerable<TblGnAddressBook> getTblGnAddressBooksResult
        {
            get
            {
                return _getTblGnAddressBooksResult;
            }
            set
            {
                if(_getTblGnAddressBooksResult != value)
                {
                    _getTblGnAddressBooksResult = value;
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
            var otErpGetTblGnAddressBooksResult = await OtErp.GetTblGnAddressBooks(null, null);
            getTblGnAddressBooksResult = otErpGetTblGnAddressBooksResult;
        }

        protected async void Button0Click(UIMouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<ThemLienHệ>("Thêm Liên Hệ", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(TblGnAddressBook args)
        {
            var result = await DialogService.OpenAsync<EditTblGnAddressBook>("Edit Tbl Gn Address Book", new Dictionary<string, object>() { {"AddressBook_SEQ", $"{args.AddressBook_SEQ}"} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(UIMouseEventArgs args, TblGnAddressBook data)
        {
            var otErpDeleteTblGnAddressBookResult = await OtErp.DeleteTblGnAddressBook(data.AddressBook_SEQ);
            if (otErpDeleteTblGnAddressBookResult != null) {
                grid0.Reload();
}
        }
    }
}
