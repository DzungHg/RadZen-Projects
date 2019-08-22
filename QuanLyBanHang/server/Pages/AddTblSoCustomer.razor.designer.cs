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
    public partial class AddTblSoCustomerComponent : ComponentBase
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

        protected RadzenTemplateForm<TblSoCustomer> form0;

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

        IEnumerable<TblGnPaymentTerm> _getTblGnPaymentTermsResult;
        protected IEnumerable<TblGnPaymentTerm> getTblGnPaymentTermsResult
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

        IEnumerable<TblGnPaymentType> _getTblGnPaymentTypesResult;
        protected IEnumerable<TblGnPaymentType> getTblGnPaymentTypesResult
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

        TblSoCustomer _tblsocustomer;
        protected TblSoCustomer tblsocustomer
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

        protected override async Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            var otErpGetTblGnAddressBooksResult = await OtErp.GetTblGnAddressBooks(null, null);
            getTblGnAddressBooksResult = otErpGetTblGnAddressBooksResult;

            var otErpGetTblGnPaymentTermsResult = await OtErp.GetTblGnPaymentTerms(null, null);
            getTblGnPaymentTermsResult = otErpGetTblGnPaymentTermsResult;

            var otErpGetTblGnPaymentTypesResult = await OtErp.GetTblGnPaymentTypes(null, null);
            getTblGnPaymentTypesResult = otErpGetTblGnPaymentTypesResult;

            tblsocustomer = new TblSoCustomer();
        }

        protected async void Form0Submit(TblSoCustomer args)
        {
            var otErpCreateTblSoCustomerResult = await OtErp.CreateTblSoCustomer(tblsocustomer);
            DialogService.Close(tblsocustomer);
        }

        protected async void Button2Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
