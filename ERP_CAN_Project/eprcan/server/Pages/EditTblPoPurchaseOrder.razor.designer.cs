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
    public partial class EditTblPoPurchaseOrderComponent : ComponentBase
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
        public string PO_ID { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder> form0;

        protected RadzenLabel label2;

        protected RadzenTextBox poId;

        protected RadzenRequiredValidator poIdRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenDatePicker poDate;

        protected RadzenLabel label4;

        protected RadzenDropDown createdByFk;

        protected RadzenLabel label5;

        protected RadzenDropDown poStatusFk;

        protected RadzenLabel label6;

        protected RadzenDropDown vendorFk;

        protected RadzenLabel label7;

        protected RadzenTextBox description;

        protected RadzenLabel label8;

        protected RadzenTextBox incotermId;

        protected RadzenLabel label9;

        protected RadzenDropDown shipViaFk;

        protected RadzenLabel label10;

        protected RadzenDropDown paymentTermFk;

        protected RadzenLabel label11;

        protected RadzenDropDown paymentTypeFk;

        protected RadzenLabel label12;

        protected dynamic buyerFk;

        protected RadzenLabel label13;

        protected RadzenCheckBox taxYn;

        protected RadzenLabel label14;

        protected dynamic taxtRate;

        protected RadzenLabel label15;

        protected RadzenTextBox departmentFk;

        protected RadzenLabel label16;

        protected dynamic poAmount;

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

        ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder _tblpopurchaseorder;
        protected ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder tblpopurchaseorder
        {
            get
            {
                return _tblpopurchaseorder;
            }
            set
            {
                if(_tblpopurchaseorder != value)
                {
                    _tblpopurchaseorder = value;
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

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoOrderStatus> _getTblPoOrderStatusesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoOrderStatus> getTblPoOrderStatusesResult
        {
            get
            {
                return _getTblPoOrderStatusesResult;
            }
            set
            {
                if(_getTblPoOrderStatusesResult != value)
                {
                    _getTblPoOrderStatusesResult = value;
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

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnShipVium> _getTblGnShipViaResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnShipVium> getTblGnShipViaResult
        {
            get
            {
                return _getTblGnShipViaResult;
            }
            set
            {
                if(_getTblGnShipViaResult != value)
                {
                    _getTblGnShipViaResult = value;
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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            canEdit = true;

            var canErpDbAt132GetTblPoPurchaseOrderByPoIdResult = await CanErpDbAt132.GetTblPoPurchaseOrderByPoId($"{PO_ID}");
            tblpopurchaseorder = canErpDbAt132GetTblPoPurchaseOrderByPoIdResult;

            var canErpDbAt132GetTblGnAddressBooksResult = await CanErpDbAt132.GetTblGnAddressBooks();
            getTblGnAddressBooksResult = canErpDbAt132GetTblGnAddressBooksResult;

            var canErpDbAt132GetTblPoOrderStatusesResult = await CanErpDbAt132.GetTblPoOrderStatuses();
            getTblPoOrderStatusesResult = canErpDbAt132GetTblPoOrderStatusesResult;

            var canErpDbAt132GetTblPoVendorsResult = await CanErpDbAt132.GetTblPoVendors();
            getTblPoVendorsResult = canErpDbAt132GetTblPoVendorsResult;

            var canErpDbAt132GetTblGnShipViaResult = await CanErpDbAt132.GetTblGnShipVia();
            getTblGnShipViaResult = canErpDbAt132GetTblGnShipViaResult;

            var canErpDbAt132GetTblGnPaymentTermsResult = await CanErpDbAt132.GetTblGnPaymentTerms();
            getTblGnPaymentTermsResult = canErpDbAt132GetTblGnPaymentTermsResult;

            var canErpDbAt132GetTblGnPaymentTypesResult = await CanErpDbAt132.GetTblGnPaymentTypes();
            getTblGnPaymentTypesResult = canErpDbAt132GetTblGnPaymentTypesResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder args)
        {
            try
            {
                var canErpDbAt132UpdateTblPoPurchaseOrderResult = await CanErpDbAt132.UpdateTblPoPurchaseOrder($"{PO_ID}", tblpopurchaseorder);
                DialogService.Close(tblpopurchaseorder);
            }
            catch (Exception canErpDbAt132UpdateTblPoPurchaseOrderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPoPurchaseOrder");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
