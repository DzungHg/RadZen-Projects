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
    public partial class AddAddressbookTypeComponent : ComponentBase
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

        protected RadzenTemplateForm<TblGnAddressBookType> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox addressBookTypeId;

        protected RadzenLabel label2;

        protected RadzenTextBox addressBookTypeText;

        protected RadzenButton button1;

        protected RadzenButton button2;

        TblGnAddressBookType _tblgnaddressbooktype;
        protected TblGnAddressBookType tblgnaddressbooktype
        {
            get
            {
                return _tblgnaddressbooktype;
            }
            set
            {
                if(_tblgnaddressbooktype != value)
                {
                    _tblgnaddressbooktype = value;
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
            tblgnaddressbooktype = new TblGnAddressBookType();
        }

        protected async void Form0Submit(TblGnAddressBookType args)
        {
            try
            {
                var otErpCreateTblGnAddressBookTypeResult = await OtErp.CreateTblGnAddressBookType(tblgnaddressbooktype);
                DialogService.Close(tblgnaddressbooktype);
            }
            catch (Exception otErpCreateTblGnAddressBookTypeException)
            {
                NotificationService.Notify(new NotificationMessage() { Severity = "error", Summary = $"Error", Detail = $"Unable to create new TblGnAddressBookType!" });
            }
        }

        protected async void Button2Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
