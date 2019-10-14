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
    public partial class EditTblPoRecReportComponent : ComponentBase
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
        public string RR_No { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoRecReport> form0;

        protected RadzenLabel label2;

        protected RadzenTextBox rrNo;

        protected RadzenRequiredValidator rrNoRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenDatePicker rrDate;

        protected RadzenLabel label4;

        protected RadzenDropDown createdByFk;

        protected RadzenLabel label5;

        protected RadzenTextBox poId;

        protected RadzenLabel label6;

        protected dynamic poStatusFk;

        protected RadzenLabel label7;

        protected RadzenDatePicker poDate;

        protected RadzenLabel label8;

        protected RadzenDropDown vendorFk;

        protected RadzenLabel label9;

        protected RadzenTextBox description;

        protected RadzenLabel label10;

        protected RadzenTextBox invoiceNo;

        protected RadzenLabel label11;

        protected RadzenDatePicker invoiceDate;

        protected RadzenLabel label12;

        protected RadzenTextBox shipNo;

        protected RadzenLabel label13;

        protected RadzenDatePicker shipDate;

        protected RadzenLabel label14;

        protected dynamic receiverFk;

        protected RadzenLabel label15;

        protected RadzenTextBox billOfLoadingNo;

        protected RadzenLabel label16;

        protected dynamic poAmount;

        protected RadzenLabel label17;

        protected RadzenCheckBox inactive;

        protected RadzenLabel label18;

        protected RadzenCheckBox warhoused;

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

        ErpCan.Models.CanErpDbAt132.TblPoRecReport _tblporecreport;
        protected ErpCan.Models.CanErpDbAt132.TblPoRecReport tblporecreport
        {
            get
            {
                return _tblporecreport;
            }
            set
            {
                if(_tblporecreport != value)
                {
                    _tblporecreport = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

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

            var canErpDbAt132GetTblPoRecReportByRrNoResult = await CanErpDbAt132.GetTblPoRecReportByRrNo($"{RR_No}");
            tblporecreport = canErpDbAt132GetTblPoRecReportByRrNoResult;

            var canErpDbAt132GetTblGnAddressBooksResult = await CanErpDbAt132.GetTblGnAddressBooks();
            getTblGnAddressBooksResult = canErpDbAt132GetTblGnAddressBooksResult;

            var canErpDbAt132GetTblPoVendorsResult = await CanErpDbAt132.GetTblPoVendors();
            getTblPoVendorsResult = canErpDbAt132GetTblPoVendorsResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoRecReport args)
        {
            try
            {
                var canErpDbAt132UpdateTblPoRecReportResult = await CanErpDbAt132.UpdateTblPoRecReport($"{RR_No}", tblporecreport);
                DialogService.Close(tblporecreport);
            }
            catch (Exception canErpDbAt132UpdateTblPoRecReportException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPoRecReport");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
