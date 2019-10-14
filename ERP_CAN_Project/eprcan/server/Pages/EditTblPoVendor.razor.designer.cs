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
    public partial class EditTblPoVendorComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        [Parameter]
        public string Vendor_ID { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoVendor> form0;

        protected RadzenLabel label2;

        protected RadzenTextBox vendorId;

        protected RadzenRequiredValidator vendorIdRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenTextBox lastName;

        protected RadzenLabel label4;

        protected RadzenTextBox firstName;

        protected RadzenLabel label5;

        protected dynamic vendorAdressBookFk;

        protected RadzenLabel label6;

        protected RadzenTextBox performingRating;

        protected RadzenLabel label7;

        protected dynamic apBalance;

        protected RadzenLabel label8;

        protected dynamic outstandInvAmt;

        protected RadzenLabel label9;

        protected dynamic outstandCredit;

        protected RadzenLabel label10;

        protected RadzenDatePicker lastPurchaseDate;

        protected RadzenLabel label11;

        protected RadzenDatePicker lastPaymentDate;

        protected RadzenLabel label12;

        protected dynamic currentMtdReturns;

        protected RadzenLabel label13;

        protected dynamic mtdPurchase;

        protected RadzenLabel label14;

        protected dynamic ytdPurchase;

        protected RadzenLabel label15;

        protected dynamic lyrPurchase;

        protected RadzenLabel label16;

        protected RadzenTextBox notes;

        protected RadzenLabel label17;

        protected RadzenCheckBox inactive;

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
            canEdit = true;

            var canErpDbAt132GetTblPoVendorByVendorIdResult = await CanErpDbAt132.GetTblPoVendorByVendorId($"{Vendor_ID}");
            tblpovendor = canErpDbAt132GetTblPoVendorByVendorIdResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoVendor args)
        {
            try
            {
                var canErpDbAt132UpdateTblPoVendorResult = await CanErpDbAt132.UpdateTblPoVendor($"{Vendor_ID}", tblpovendor);
                DialogService.Close(tblpovendor);
            }
            catch (Exception canErpDbAt132UpdateTblPoVendorException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPoVendor");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
