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
    public partial class AddTblSoCustomerComponent : ComponentBase
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

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblSoCustomer> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox customerId;

        protected RadzenRequiredValidator customerIdRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenTextBox lastName;

        protected RadzenLabel label3;

        protected RadzenTextBox firstName;

        protected RadzenLabel label4;

        protected RadzenDropDown customerAdressBookFk;

        protected RadzenLabel label5;

        protected dynamic creditLimit;

        protected RadzenLabel label6;

        protected RadzenDatePicker lastRevisedCreditLimitDate;

        protected RadzenLabel label7;

        protected RadzenDropDown paymentTermFk;

        protected RadzenLabel label8;

        protected RadzenDropDown paymentTypeFk;

        protected RadzenLabel label9;

        protected dynamic discountPercent;

        protected RadzenLabel label10;

        protected dynamic currentMtdSales;

        protected RadzenLabel label11;

        protected dynamic currentMtdReturns;

        protected RadzenLabel label12;

        protected dynamic ytdGrossSales;

        protected RadzenLabel label13;

        protected dynamic ytdReturns;

        protected RadzenLabel label14;

        protected dynamic ytdCogs;

        protected RadzenLabel label15;

        protected dynamic lyrGrossSales;

        protected RadzenLabel label16;

        protected dynamic lyrCogs;

        protected RadzenLabel label17;

        protected dynamic lastAmountSales;

        protected RadzenLabel label18;

        protected dynamic salesPersonAdressBookFk;

        protected RadzenLabel label19;

        protected dynamic commissionPercent;

        protected RadzenLabel label20;

        protected dynamic salesPersonMtdGoal;

        protected RadzenLabel label21;

        protected dynamic salesPersonYtdGoal;

        protected RadzenLabel label22;

        protected RadzenCheckBox chargeInterest;

        protected RadzenLabel label23;

        protected RadzenCheckBox statement;

        protected RadzenLabel label24;

        protected dynamic aging30DayAmout;

        protected RadzenLabel label25;

        protected dynamic aging60DayAmout;

        protected RadzenLabel label26;

        protected dynamic aging90DayAmout;

        protected RadzenLabel label27;

        protected RadzenTextBox notes;

        protected RadzenLabel label28;

        protected RadzenDatePicker lastUpdatedDate;

        protected RadzenLabel label29;

        protected dynamic lastUdpatedBy;

        protected RadzenLabel label30;

        protected RadzenCheckBox inactive;

        protected RadzenButton button1;

        protected RadzenButton button2;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnAddressBook> _getTblGnAddressBooksResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnAddressBook> getTblGnAddressBooksResult
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

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnPaymentTerm> _getTblGnPaymentTermsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnPaymentTerm> getTblGnPaymentTermsResult
        {
            get
            {
                return _getTblGnPaymentTermsResult;
            }
            set
            {
                if(_getTblGnPaymentTermsResult != value)
                {
                    _getTblGnPaymentTermsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnPaymentType> _getTblGnPaymentTypesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnPaymentType> getTblGnPaymentTypesResult
        {
            get
            {
                return _getTblGnPaymentTypesResult;
            }
            set
            {
                if(_getTblGnPaymentTypesResult != value)
                {
                    _getTblGnPaymentTypesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        ErpCan.Models.CanErpDbAt132.TblSoCustomer _tblsocustomer;
        protected ErpCan.Models.CanErpDbAt132.TblSoCustomer tblsocustomer
        {
            get
            {
                return _tblsocustomer;
            }
            set
            {
                if(_tblsocustomer != value)
                {
                    _tblsocustomer = value;
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
            var canErpDbAt132GetTblGnAddressBooksResult = await CanErpDbAt132.GetTblGnAddressBooks();
            getTblGnAddressBooksResult = canErpDbAt132GetTblGnAddressBooksResult;

            var canErpDbAt132GetTblGnPaymentTermsResult = await CanErpDbAt132.GetTblGnPaymentTerms();
            getTblGnPaymentTermsResult = canErpDbAt132GetTblGnPaymentTermsResult;

            var canErpDbAt132GetTblGnPaymentTypesResult = await CanErpDbAt132.GetTblGnPaymentTypes();
            getTblGnPaymentTypesResult = canErpDbAt132GetTblGnPaymentTypesResult;

            tblsocustomer = new ErpCan.Models.CanErpDbAt132.TblSoCustomer();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblSoCustomer args)
        {
            try
            {
                var canErpDbAt132CreateTblSoCustomerResult = await CanErpDbAt132.CreateTblSoCustomer(tblsocustomer);
                DialogService.Close(tblsocustomer);
            }
            catch (Exception canErpDbAt132CreateTblSoCustomerException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblSoCustomer!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
