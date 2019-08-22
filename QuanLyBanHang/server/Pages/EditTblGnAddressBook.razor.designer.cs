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
    public partial class EditTblGnAddressBookComponent : ComponentBase
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

        protected RadzenTextBox gender;

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

        protected RadzenDropDown cityPk;

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

        protected override async Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            canEdit = true;

            var otErpGetTblGnAddressBookByAddressBookSeqResult = await OtErp.GetTblGnAddressBookByAddressBookSeq(int.Parse(AddressBook_SEQ));
            tblgnaddressbook = otErpGetTblGnAddressBookByAddressBookSeqResult;

            var otErpGetTblGnAddressBookTypesResult = await OtErp.GetTblGnAddressBookTypes(null, null);
            getTblGnAddressBookTypesResult = otErpGetTblGnAddressBookTypesResult;

            var otErpGetTblGnCitiesResult = await OtErp.GetTblGnCities(null, null);
            getTblGnCitiesResult = otErpGetTblGnCitiesResult;
        }

        protected async void CloseButtonClick(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(TblGnAddressBook args)
        {
            var otErpUpdateTblGnAddressBookResult = await OtErp.UpdateTblGnAddressBook(int.Parse(AddressBook_SEQ), tblgnaddressbook);
            DialogService.Close(tblgnaddressbook);
        }

        protected async void Button3Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
