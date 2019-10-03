using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using QuanLyBanHang.Models.OtErp;

namespace QuanLyBanHang.Pages
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
        protected OtErpService OtErp { get; set; }


        [Parameter]
        public string SO_SEQ { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<TblSoSalesOrder> form0;

        protected RadzenLabel label2;

        protected RadzenTextBox soId;

        protected RadzenRequiredValidator soIdRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenDatePicker soDate;

        protected RadzenLabel label4;

        protected RadzenDropDown createdByFk;

        protected RadzenLabel label5;

        protected RadzenDropDown soStatusFk;

        protected RadzenLabel label6;

        protected RadzenDropDown customerFk;

        protected RadzenLabel label7;

        protected RadzenTextBox customerPoNumber;

        protected RadzenLabel label8;

        protected RadzenDatePicker customerPoDate;

        protected RadzenLabel label9;

        protected RadzenDropDown billToFk;

        protected RadzenLabel label10;

        protected RadzenDropDown shipToFk;

        protected RadzenLabel label11;

        protected RadzenTextBox attention;

        protected RadzenLabel label12;

        protected RadzenDropDown shipViaFk;

        protected RadzenLabel label13;

        protected RadzenDatePicker actualShipDate;

        protected RadzenLabel label14;

        protected RadzenDatePicker expectedShipDate;

        protected RadzenLabel label15;

        protected dynamic shipperFk;

        protected RadzenLabel label16;

        protected dynamic paymentTermFk;

        protected RadzenLabel label17;

        protected dynamic paymentTypeFk;

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

        TblSoSalesOrder _tblsosalesorder;
        protected TblSoSalesOrder tblsosalesorder
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

        IEnumerable<TblSoOrderStatus> _getTblSoOrderStatusesResult;
        protected IEnumerable<TblSoOrderStatus> getTblSoOrderStatusesResult
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

        IEnumerable<TblSoCustomer> _getTblSoCustomersResult;
        protected IEnumerable<TblSoCustomer> getTblSoCustomersResult
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

        IEnumerable<TblGnShipVium> _getTblGnShipViaResult;
        protected IEnumerable<TblGnShipVium> getTblGnShipViaResult
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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            canEdit = true;

            try
            {
                var otErpGetTblSoSalesOrderBySoSeqResult = await OtErp.GetTblSoSalesOrderBySoSeq(int.Parse(SO_SEQ));
                tblsosalesorder = otErpGetTblSoSalesOrderBySoSeqResult;
            }
            catch (Exception otErpGetTblSoSalesOrderBySoSeqException)
            {

            }

            var otErpGetTblGnAddressBooksResult = await OtErp.GetTblGnAddressBooks();
            getTblGnAddressBooksResult = otErpGetTblGnAddressBooksResult;

            var otErpGetTblSoOrderStatusesResult = await OtErp.GetTblSoOrderStatuses();
            getTblSoOrderStatusesResult = otErpGetTblSoOrderStatusesResult;

            var otErpGetTblSoCustomersResult = await OtErp.GetTblSoCustomers();
            getTblSoCustomersResult = otErpGetTblSoCustomersResult;

            var otErpGetTblGnShipViaResult = await OtErp.GetTblGnShipVia();
            getTblGnShipViaResult = otErpGetTblGnShipViaResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(TblSoSalesOrder args)
        {
            try
            {
                var otErpUpdateTblSoSalesOrderResult = await OtErp.UpdateTblSoSalesOrder(int.Parse(SO_SEQ), tblsosalesorder);
                DialogService.Close(tblsosalesorder);
            }
            catch (Exception otErpUpdateTblSoSalesOrderException)
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
