using System;
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
    public partial class AddTblPoCashDisbursementComponent : ComponentBase
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

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox poCashDisbNo;

        protected RadzenRequiredValidator poCashDisbNoRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenDatePicker poCashDisbDate;

        protected RadzenLabel label3;

        protected RadzenDropDown customerFk;

        protected RadzenLabel label4;

        protected RadzenTextBox description;

        protected RadzenLabel label5;

        protected RadzenTextBox disbursementType;

        protected RadzenRequiredValidator disbursementTypeRequiredValidator;

        protected RadzenLabel label6;

        protected dynamic grossInvtAmt;

        protected RadzenLabel label7;

        protected dynamic discountInvtAmt;

        protected RadzenLabel label8;

        protected RadzenTextBox checkNo;

        protected RadzenRequiredValidator checkNoRequiredValidator;

        protected RadzenLabel label9;

        protected RadzenDatePicker checkDate;

        protected RadzenLabel label10;

        protected dynamic checkAmount;

        protected RadzenLabel label11;

        protected RadzenTextBox debiAccount;

        protected RadzenLabel label12;

        protected RadzenTextBox creditAccount;

        protected RadzenLabel label13;

        protected RadzenCheckBox payment;

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

        ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement _tblpocashdisbursement;
        protected ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement tblpocashdisbursement
        {
            get
            {
                return _tblpocashdisbursement;
            }
            set
            {
                if(_tblpocashdisbursement != value)
                {
                    _tblpocashdisbursement = value;
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

            tblpocashdisbursement = new ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement args)
        {
            try
            {
                var canErpDbAt132CreateTblPoCashDisbursementResult = await CanErpDbAt132.CreateTblPoCashDisbursement(tblpocashdisbursement);
                DialogService.Close(tblpocashdisbursement);
            }
            catch (Exception canErpDbAt132CreateTblPoCashDisbursementException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblPoCashDisbursement!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
