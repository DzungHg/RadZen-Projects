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
    public partial class EditTblGnAddressBookComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected OtErpService OtErp { get; set; }


        [Parameter]
        public string AddressBook_SEQ { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<TblGnAddressBook> form0;

        protected RadzenLabel label2;

        protected RadzenTextBox addressBookId;

        protected RadzenRequiredValidator addressBookIdRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenDropDown addressBookTypeFk;

        protected RadzenLabel label4;

        protected RadzenTextBox lastName;

        protected RadzenLabel label5;

        protected RadzenTextBox firstName;

        protected RadzenLabel label6;

        protected RadzenDropDown genderFk;

        protected RadzenLabel label7;

        protected RadzenDatePicker dob;

        protected RadzenLabel label8;

        protected RadzenTextBox origin;

        protected RadzenLabel label9;

        protected RadzenTextBox idNumber;

        protected RadzenLabel label10;

        protected RadzenTextBox taxIdNumber;

        protected RadzenLabel label11;

        protected RadzenTextBox organizationName;

        protected RadzenLabel label12;

        protected RadzenTextBox jobPosition;

        protected RadzenLabel label13;

        protected RadzenTextBox address;

        protected RadzenLabel label14;

        protected RadzenDropDown cityFk;

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

        TblGnAddressBook _tblgnaddressbook;
        protected TblGnAddressBook tblgnaddressbook
        {
            get
            {
                return _tblgnaddressbook;
            }
            set
            {
                if(_tblgnaddressbook != value)
                {
                    _tblgnaddressbook = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

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
            canEdit = true;

            try
            {
                var otErpGetTblGnAddressBookByAddressBookSeqResult = await OtErp.GetTblGnAddressBookByAddressBookSeq(int.Parse(AddressBook_SEQ));
                tblgnaddressbook = otErpGetTblGnAddressBookByAddressBookSeqResult;
            }
            catch (Exception otErpGetTblGnAddressBookByAddressBookSeqException)
            {

            }

            var otErpGetTblGnAddressBookTypesResult = await OtErp.GetTblGnAddressBookTypes();
            getTblGnAddressBookTypesResult = otErpGetTblGnAddressBookTypesResult;

            var otErpGetTblGnGendersResult = await OtErp.GetTblGnGenders();
            getTblGnGendersResult = otErpGetTblGnGendersResult;

            var otErpGetTblGnCitiesResult = await OtErp.GetTblGnCities();
            getTblGnCitiesResult = otErpGetTblGnCitiesResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(TblGnAddressBook args)
        {
            try
            {
                var otErpUpdateTblGnAddressBookResult = await OtErp.UpdateTblGnAddressBook(int.Parse(AddressBook_SEQ), tblgnaddressbook);
                DialogService.Close(tblgnaddressbook);
            }
            catch (Exception otErpUpdateTblGnAddressBookException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblGnAddressBook");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
