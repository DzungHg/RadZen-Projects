using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using QuanLyBanHang.Models.OtErp;

namespace QuanLyBanHang.Pages
{
    public partial class AddTblSoSalesOrderComponent : ComponentBase
    {
        [Inject]
        protected IUriHelper UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected OtErpService OtErp { get; set; }


        protected RadzenContent content1;

        protected RadzenTemplateForm<TblSoSalesOrder> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox soId;

        protected RadzenRequiredValidator soIdRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenDatePicker soDate;

        protected RadzenLabel label3;

        protected RadzenDropDown createdByFk;

        protected RadzenLabel label4;

        protected RadzenDropDown soStatusFk;

        protected RadzenLabel label5;

        protected RadzenDropDown customerFk;

        protected RadzenLabel label6;

        protected RadzenTextBox customerPoNumber;

        protected RadzenLabel label7;

        protected RadzenDatePicker customerPoDate;

        protected RadzenLabel label8;

        protected RadzenDropDown billToFk;

        protected RadzenLabel label9;

        protected RadzenDropDown shipToFk;

        protected RadzenLabel label10;

        protected RadzenTextBox attention;

        protected RadzenLabel label11;

        protected RadzenDropDown shipViaFk;

        protected RadzenLabel label12;

        protected RadzenDatePicker actualShipDate;

        protected RadzenLabel label13;

        protected RadzenDatePicker expectedShipDate;

        protected RadzenLabel label14;

        protected dynamic shipperFk;

        protected RadzenLabel label15;

        protected dynamic paymentTermFk;

        protected RadzenLabel label16;

        protected dynamic paymentTypeFk;

        protected RadzenLabel label17;

        protected dynamic salesPersionFk;

        protected RadzenLabel label18;

        protected dynamic commission;

        protected RadzenLabel label19;

        protected dynamic pickNo;

        protected RadzenLabel label20;

        protected dynamic shipNo;

        protected RadzenLabel label21;

        protected RadzenCheckBox taxYn;

        protected RadzenLabel label22;

        protected dynamic taxtRate;

        protected RadzenLabel label23;

        protected dynamic subtotal;

        protected RadzenLabel label24;

        protected dynamic taxtAmount;

        protected RadzenLabel label25;

        protected dynamic discountAmt;

        protected RadzenLabel label26;

        protected dynamic freight;

        protected RadzenLabel label27;

        protected RadzenTextBox description;

        protected RadzenLabel label28;

        protected RadzenTextBox changeLong;

        protected RadzenLabel label29;

        protected RadzenTextBox notes;

        protected RadzenLabel label30;

        protected RadzenDatePicker lastUpdatedDate;

        protected RadzenLabel label31;

        protected dynamic lastUpdatedByFk;

        protected RadzenLabel label32;

        protected RadzenCheckBox inactive;

        protected RadzenLabel label33;

        protected dynamic sequence;

        protected RadzenButton button1;

        protected RadzenButton button2;

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

        protected override async Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            var otErpGetTblGnAddressBooksResult = await OtErp.GetTblGnAddressBooks(null, null);
            getTblGnAddressBooksResult = otErpGetTblGnAddressBooksResult;

            var otErpGetTblSoOrderStatusesResult = await OtErp.GetTblSoOrderStatuses(null, null);
            getTblSoOrderStatusesResult = otErpGetTblSoOrderStatusesResult;

            var otErpGetTblSoCustomersResult = await OtErp.GetTblSoCustomers(null, null);
            getTblSoCustomersResult = otErpGetTblSoCustomersResult;

            var otErpGetTblGnShipViaResult = await OtErp.GetTblGnShipVia(null, null);
            getTblGnShipViaResult = otErpGetTblGnShipViaResult;

            tblsosalesorder = new TblSoSalesOrder();
        }

        protected async void Form0Submit(TblSoSalesOrder args)
        {
            var otErpCreateTblSoSalesOrderResult = await OtErp.CreateTblSoSalesOrder(tblsosalesorder);
            DialogService.Close(tblsosalesorder);
        }

        protected async void Button2Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
