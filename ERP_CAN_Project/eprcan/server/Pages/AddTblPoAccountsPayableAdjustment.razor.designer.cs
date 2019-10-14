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
    public partial class AddTblPoAccountsPayableAdjustmentComponent : ComponentBase
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

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox voucherNo;

        protected RadzenRequiredValidator voucherNoRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenDatePicker voucherDate;

        protected RadzenLabel label3;

        protected RadzenTextBox vendorFk;

        protected RadzenLabel label4;

        protected RadzenTextBox transactId;

        protected RadzenLabel label5;

        protected RadzenTextBox recordCode;

        protected RadzenLabel label6;

        protected RadzenTextBox poNo;

        protected RadzenLabel label7;

        protected RadzenTextBox invoiceNo;

        protected RadzenLabel label8;

        protected RadzenDatePicker invoiceDate;

        protected RadzenLabel label9;

        protected RadzenTextBox debitAccount;

        protected RadzenLabel label10;

        protected RadzenTextBox creditAccount;

        protected RadzenLabel label11;

        protected RadzenTextBox description;

        protected RadzenLabel label12;

        protected dynamic amount;

        protected RadzenLabel label13;

        protected dynamic authorizeBy;

        protected RadzenButton button1;

        protected RadzenButton button2;

        ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment _tblpoaccountspayableadjustment;
        protected ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment tblpoaccountspayableadjustment
        {
            get
            {
                return _tblpoaccountspayableadjustment;
            }
            set
            {
                if(_tblpoaccountspayableadjustment != value)
                {
                    _tblpoaccountspayableadjustment = value;
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
            tblpoaccountspayableadjustment = new ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment args)
        {
            try
            {
                var canErpDbAt132CreateTblPoAccountsPayableAdjustmentResult = await CanErpDbAt132.CreateTblPoAccountsPayableAdjustment(tblpoaccountspayableadjustment);
                DialogService.Close(tblpoaccountspayableadjustment);
            }
            catch (Exception canErpDbAt132CreateTblPoAccountsPayableAdjustmentException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblPoAccountsPayableAdjustment!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
