﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using ErpCan.Models.CanErpDbAt132;

namespace ErpCan.Pages
{
    public partial class AddTblGnAddressBookComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenContent content1;

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblGnAddressBook> form0;

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

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnAddressBookType> _getTblGnAddressBookTypesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnAddressBookType> getTblGnAddressBookTypesResult
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

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnGender> _getTblGnGendersResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnGender> getTblGnGendersResult
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

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnCity> _getTblGnCitiesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnCity> getTblGnCitiesResult
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

        ErpCan.Models.CanErpDbAt132.TblGnAddressBook _tblgnaddressbook;
        protected ErpCan.Models.CanErpDbAt132.TblGnAddressBook tblgnaddressbook
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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            var canErpDbAt132GetTblGnAddressBookTypesResult = await CanErpDbAt132.GetTblGnAddressBookTypes();
            getTblGnAddressBookTypesResult = canErpDbAt132GetTblGnAddressBookTypesResult;

            var canErpDbAt132GetTblGnGendersResult = await CanErpDbAt132.GetTblGnGenders();
            getTblGnGendersResult = canErpDbAt132GetTblGnGendersResult;

            var canErpDbAt132GetTblGnCitiesResult = await CanErpDbAt132.GetTblGnCities();
            getTblGnCitiesResult = canErpDbAt132GetTblGnCitiesResult;

            tblgnaddressbook = new ErpCan.Models.CanErpDbAt132.TblGnAddressBook();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnAddressBook args)
        {
            try
            {
                var canErpDbAt132CreateTblGnAddressBookResult = await CanErpDbAt132.CreateTblGnAddressBook(tblgnaddressbook);
                DialogService.Close(tblgnaddressbook);
            }
            catch (Exception canErpDbAt132CreateTblGnAddressBookException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblGnAddressBook!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
