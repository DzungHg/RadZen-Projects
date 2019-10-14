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
    public partial class EditTblSoSalesOrderComponent : ComponentBase
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
        public string SO_SEQ { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder> form0;

        protected RadzenLabel label2;

        protected RadzenTextBox soId;

        protected RadzenRequiredValidator soIdRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenDatePicker soDate;

        protected RadzenLabel label4;

        protected dynamic createdByFk;

        protected RadzenLabel label5;

        protected RadzenDropDown soStatusFk;

        protected RadzenLabel label6;

        protected RadzenDropDown customerFk;

        protected RadzenLabel label7;

        protected RadzenTextBox customerPoNumber;

        protected RadzenLabel label8;

        protected RadzenDatePicker customerPoDate;

        protected RadzenLabel label9;

        protected dynamic billToFk;

        protected RadzenLabel label10;

        protected RadzenDropDown shipToFk;

        protected RadzenLabel label11;

        protected RadzenTextBox attention;

        protected RadzenLabel label12;

        protected dynamic shipViaFk;

        protected RadzenLabel label13;

        protected RadzenDatePicker actualShipDate;

        protected RadzenLabel label14;

        protected RadzenDatePicker expectedShipDate;

        protected RadzenLabel label15;

        protected dynamic shipperFk;

        protected RadzenLabel label16;

        protected RadzenDropDown paymentTermFk;

        protected RadzenLabel label17;

        protected RadzenDropDown paymentTypeFk;

        protected RadzenLabel label18;

        protected dynamic salesPersionFk;

        protected RadzenLabel label19;

        protected dynamic commission;

        protected RadzenLabel label20;

        protected dynamic pickNo;

        protected RadzenLabel label21;

        protected dynamic shipNo;

        protected RadzenLabel label22;

        protected RadzenCheckBox taxYn;

        protected RadzenLabel label23;

        protected dynamic taxtRate;

        protected RadzenLabel label24;

        protected dynamic subtotal;

        protected RadzenLabel label25;

        protected dynamic taxtAmount;

        protected RadzenLabel label26;

        protected dynamic discountAmt;

        protected RadzenLabel label27;

        protected dynamic freight;

        protected RadzenLabel label28;

        protected RadzenTextBox description;

        protected RadzenLabel label29;

        protected RadzenTextBox changeLong;

        protected RadzenLabel label30;

        protected RadzenTextBox notes;

        protected RadzenLabel label31;

        protected RadzenDatePicker lastUpdatedDate;

        protected RadzenLabel label32;

        protected dynamic lastUpdatedByFk;

        protected RadzenLabel label33;

        protected RadzenCheckBox inactive;

        protected RadzenLabel label34;

        protected dynamic sequence;

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

        ErpCan.Models.CanErpDbAt132.TblSoSalesOrder _tblsosalesorder;
        protected ErpCan.Models.CanErpDbAt132.TblSoSalesOrder tblsosalesorder
        {
            get
            {
                return _tblsosalesorder;
            }
            set
            {
                if(_tblsosalesorder != value)
                {
                    _tblsosalesorder = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoOrderStatus> _getTblSoOrderStatusesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoOrderStatus> getTblSoOrderStatusesResult
        {
            get
            {
                return _getTblSoOrderStatusesResult;
            }
            set
            {
                if(_getTblSoOrderStatusesResult != value)
                {
                    _getTblSoOrderStatusesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoCustomer> _getTblSoCustomersResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoCustomer> getTblSoCustomersResult
        {
            get
            {
                return _getTblSoCustomersResult;
            }
            set
            {
                if(_getTblSoCustomersResult != value)
                {
                    _getTblSoCustomersResult = value;
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

            var canErpDbAt132GetTblSoSalesOrderBySoSeqResult = await CanErpDbAt132.GetTblSoSalesOrderBySoSeq(int.Parse(SO_SEQ));
            tblsosalesorder = canErpDbAt132GetTblSoSalesOrderBySoSeqResult;

            var canErpDbAt132GetTblSoOrderStatusesResult = await CanErpDbAt132.GetTblSoOrderStatuses();
            getTblSoOrderStatusesResult = canErpDbAt132GetTblSoOrderStatusesResult;

            var canErpDbAt132GetTblSoCustomersResult = await CanErpDbAt132.GetTblSoCustomers();
            getTblSoCustomersResult = canErpDbAt132GetTblSoCustomersResult;

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

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblSoSalesOrder args)
        {
            try
            {
                var canErpDbAt132UpdateTblSoSalesOrderResult = await CanErpDbAt132.UpdateTblSoSalesOrder(int.Parse(SO_SEQ), tblsosalesorder);
                DialogService.Close(tblsosalesorder);
            }
            catch (Exception canErpDbAt132UpdateTblSoSalesOrderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblSoSalesOrder");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
