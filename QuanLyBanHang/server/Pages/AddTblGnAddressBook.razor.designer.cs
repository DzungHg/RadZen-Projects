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
    public partial class AddTblGnAddressBookComponent : ComponentBase
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

        protected RadzenTemplateForm<TblGnAddressBook> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox addressBookId;

        protected RadzenRequiredValidator addressBookIdRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenDropDown addressBookTypeFk;

        protected RadzenLabel label3;

        protected RadzenTextBox lastName;

        protected RadzenLabel label4;

        protected RadzenTextBox firstName;

        protected RadzenLabel label5;

        protected RadzenDropDown genderFk;

        protected RadzenLabel label6;

        protected RadzenDatePicker dob;

        protected RadzenLabel label7;

        protected RadzenTextBox origin;

        protected RadzenLabel label8;

        protected RadzenTextBox idNumber;

        protected RadzenLabel label9;

        protected RadzenTextBox taxIdNumber;

        protected RadzenLabel label10;

        protected RadzenTextBox organizationName;

        protected RadzenLabel label11;

        protected RadzenTextBox jobPosition;

        protected RadzenLabel label12;

        protected RadzenTextBox address;

        protected RadzenLabel label13;

        protected RadzenDropDown cityFk;

        protected RadzenButton button1;

        protected RadzenButton button2;

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

        protected override async Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            var otErpGetTblGnAddressBookTypesResult = await OtErp.GetTblGnAddressBookTypes(null, null);
            getTblGnAddressBookTypesResult = otErpGetTblGnAddressBookTypesResult;

            var otErpGetTblGnGendersResult = await OtErp.GetTblGnGenders(null, null);
            getTblGnGendersResult = otErpGetTblGnGendersResult;

            var otErpGetTblGnCitiesResult = await OtErp.GetTblGnCities(null, null);
            getTblGnCitiesResult = otErpGetTblGnCitiesResult;

            tblgnaddressbook = new TblGnAddressBook();
        }

        protected async void Form0Submit(TblGnAddressBook args)
        {
            try
            {
                var otErpCreateTblGnAddressBookResult = await OtErp.CreateTblGnAddressBook(tblgnaddressbook);
                DialogService.Close(tblgnaddressbook);
            }
            catch (Exception otErpCreateTblGnAddressBookException)
            {
                NotificationService.Notify(new NotificationMessage() { Severity = "error", Summary = $"Error", Detail = $"Unable to create new TblGnAddressBook!" });
            }
        }

        protected async void Button2Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
