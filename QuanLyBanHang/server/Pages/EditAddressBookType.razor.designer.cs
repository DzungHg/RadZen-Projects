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
    public partial class EditAddressBookTypeComponent : ComponentBase
    {
        [Inject]
        protected IUriHelper UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected OtErpService OtErp { get; set; }


        [Parameter]
        public string AddressBookType_SEQ { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<TblGnAddressBookType> form0;

        protected RadzenLabel label2;

        protected RadzenTextBox addressBookTypeId;

        protected RadzenLabel label3;

        protected RadzenTextBox addressBookTypeText;

        protected RadzenButton button2;

        protected RadzenButton button3;

        bool _canEdit;
        protected bool canEdit
        {
            get
            {
                return _canEdit;
            }
            set
            {
                if(_canEdit != value)
                {
                    _canEdit = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

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
            canEdit = true;

            try
            {
                var otErpGetTblGnAddressBookTypeByAddressBookTypeSeqResult = await OtErp.GetTblGnAddressBookTypeByAddressBookTypeSeq(int.Parse(AddressBookType_SEQ));
                tblgnaddressbooktype = otErpGetTblGnAddressBookTypeByAddressBookTypeSeqResult;
            }
            catch (Exception otErpGetTblGnAddressBookTypeByAddressBookTypeSeqException)
            {

            }
        }

        protected async void CloseButtonClick(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(TblGnAddressBookType args)
        {
            try
            {
                var otErpUpdateTblGnAddressBookTypeResult = await OtErp.UpdateTblGnAddressBookType(int.Parse(AddressBookType_SEQ), tblgnaddressbooktype);
                DialogService.Close(tblgnaddressbooktype);
            }
            catch (Exception otErpUpdateTblGnAddressBookTypeException)
            {
                NotificationService.Notify(new NotificationMessage() { Severity = "error", Summary = $"Error", Detail = $"Unable to update TblGnAddressBookType" });
            }
        }

        protected async void Button3Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
