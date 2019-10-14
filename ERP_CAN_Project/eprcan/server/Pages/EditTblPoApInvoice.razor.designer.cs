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
    public partial class EditTblPoApInvoiceComponent : ComponentBase
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

        [Parameter]
        public string Invoice_No { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoApInvoice> form0;

        protected RadzenLabel label2;

        protected RadzenDropDown vendorId;

        protected RadzenRequiredValidator vendorIdRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenTextBox invoiceNo;

        protected RadzenRequiredValidator invoiceNoRequiredValidator;

        protected RadzenLabel label4;

        protected RadzenDatePicker invoiceDate;

        protected RadzenLabel label5;

        protected RadzenTextBox poId;

        protected RadzenLabel label6;

        protected RadzenDatePicker poDate;

        protected RadzenLabel label7;

        protected RadzenTextBox description;

        protected RadzenLabel label8;

        protected dynamic invoiceAmount;

        protected RadzenLabel label9;

        protected dynamic discountAmount;

        protected RadzenLabel label10;

        protected RadzenDatePicker dueDate;

        protected RadzenLabel label11;

        protected RadzenCheckBox paid;

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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            canEdit = true;

            var canErpDbAt132GetTblPoApInvoiceByVendorIdAndInvoiceNoResult = await CanErpDbAt132.GetTblPoApInvoiceByVendorIdAndInvoiceNo($"{Vendor_ID}", $"{Invoice_No}");
            tblpoapinvoice = canErpDbAt132GetTblPoApInvoiceByVendorIdAndInvoiceNoResult;

            var canErpDbAt132GetTblPoVendorsResult = await CanErpDbAt132.GetTblPoVendors();
            getTblPoVendorsResult = canErpDbAt132GetTblPoVendorsResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoApInvoice args)
        {
            try
            {
                var canErpDbAt132UpdateTblPoApInvoiceResult = await CanErpDbAt132.UpdateTblPoApInvoice($"{Vendor_ID}", $"{Invoice_No}", tblpoapinvoice);
                DialogService.Close(tblpoapinvoice);
            }
            catch (Exception canErpDbAt132UpdateTblPoApInvoiceException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPoApInvoice");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
