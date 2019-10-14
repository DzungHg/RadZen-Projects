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
    public partial class AddTblPoApInvoiceComponent : ComponentBase
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

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoApInvoice> form0;

        protected RadzenLabel label1;

        protected RadzenDropDown vendorId;

        protected RadzenRequiredValidator vendorIdRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenTextBox invoiceNo;

        protected RadzenRequiredValidator invoiceNoRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenDatePicker invoiceDate;

        protected RadzenLabel label4;

        protected RadzenTextBox poId;

        protected RadzenLabel label5;

        protected RadzenDatePicker poDate;

        protected RadzenLabel label6;

        protected RadzenTextBox description;

        protected RadzenLabel label7;

        protected dynamic invoiceAmount;

        protected RadzenLabel label8;

        protected dynamic discountAmount;

        protected RadzenLabel label9;

        protected RadzenDatePicker dueDate;

        protected RadzenLabel label10;

        protected RadzenCheckBox paid;

        protected RadzenButton button1;

        protected RadzenButton button2;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoVendor> _getTblPoVendorsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoVendor> getTblPoVendorsResult
        {
            get
            {
                return _getTblPoVendorsResult;
            }
            set
            {
                if(_getTblPoVendorsResult != value)
                {
                    _getTblPoVendorsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        ErpCan.Models.CanErpDbAt132.TblPoApInvoice _tblpoapinvoice;
        protected ErpCan.Models.CanErpDbAt132.TblPoApInvoice tblpoapinvoice
        {
            get
            {
                return _tblpoapinvoice;
            }
            set
            {
                if(_tblpoapinvoice != value)
                {
                    _tblpoapinvoice = value;
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
            var canErpDbAt132GetTblPoVendorsResult = await CanErpDbAt132.GetTblPoVendors();
            getTblPoVendorsResult = canErpDbAt132GetTblPoVendorsResult;

            tblpoapinvoice = new ErpCan.Models.CanErpDbAt132.TblPoApInvoice();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoApInvoice args)
        {
            try
            {
                var canErpDbAt132CreateTblPoApInvoiceResult = await CanErpDbAt132.CreateTblPoApInvoice(tblpoapinvoice);
                DialogService.Close(tblpoapinvoice);
            }
            catch (Exception canErpDbAt132CreateTblPoApInvoiceException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblPoApInvoice!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
