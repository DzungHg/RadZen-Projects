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
    public partial class AddTblPoVendorComponent : ComponentBase
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

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoVendor> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox vendorId;

        protected RadzenRequiredValidator vendorIdRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenTextBox lastName;

        protected RadzenLabel label3;

        protected RadzenTextBox firstName;

        protected RadzenLabel label4;

        protected dynamic vendorAdressBookFk;

        protected RadzenLabel label5;

        protected RadzenTextBox performingRating;

        protected RadzenLabel label6;

        protected dynamic apBalance;

        protected RadzenLabel label7;

        protected dynamic outstandInvAmt;

        protected RadzenLabel label8;

        protected dynamic outstandCredit;

        protected RadzenLabel label9;

        protected RadzenDatePicker lastPurchaseDate;

        protected RadzenLabel label10;

        protected RadzenDatePicker lastPaymentDate;

        protected RadzenLabel label11;

        protected dynamic currentMtdReturns;

        protected RadzenLabel label12;

        protected dynamic mtdPurchase;

        protected RadzenLabel label13;

        protected dynamic ytdPurchase;

        protected RadzenLabel label14;

        protected dynamic lyrPurchase;

        protected RadzenLabel label15;

        protected RadzenTextBox notes;

        protected RadzenLabel label16;

        protected RadzenCheckBox inactive;

        protected RadzenButton button1;

        protected RadzenButton button2;

        ErpCan.Models.CanErpDbAt132.TblPoVendor _tblpovendor;
        protected ErpCan.Models.CanErpDbAt132.TblPoVendor tblpovendor
        {
            get
            {
                return _tblpovendor;
            }
            set
            {
                if(_tblpovendor != value)
                {
                    _tblpovendor = value;
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
            tblpovendor = new ErpCan.Models.CanErpDbAt132.TblPoVendor();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoVendor args)
        {
            try
            {
                var canErpDbAt132CreateTblPoVendorResult = await CanErpDbAt132.CreateTblPoVendor(tblpovendor);
                DialogService.Close(tblpovendor);
            }
            catch (Exception canErpDbAt132CreateTblPoVendorException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblPoVendor!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
