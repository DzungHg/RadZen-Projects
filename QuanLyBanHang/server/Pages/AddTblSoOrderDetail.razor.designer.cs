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
    public partial class AddTblSoOrderDetailComponent : ComponentBase
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

        protected RadzenTemplateForm<TblSoOrderDetail> form0;

        protected RadzenLabel label1;

        protected RadzenDropDown soDetailStatusFk;

        protected RadzenLabel label2;

        protected RadzenDropDown soFk;

        protected RadzenLabel label3;

        protected dynamic inventoryFk;

        protected RadzenLabel label4;

        protected dynamic unitPrice;

        protected RadzenLabel label5;

        protected dynamic qtyOnHand;

        protected RadzenLabel label6;

        protected dynamic qtyOrdered;

        protected RadzenLabel label7;

        protected dynamic qtyOrderedNow;

        protected RadzenLabel label8;

        protected dynamic qtyBackOrdered;

        protected RadzenLabel label9;

        protected dynamic qtyPicked;

        protected RadzenLabel label10;

        protected dynamic discountPercent;

        protected RadzenLabel label11;

        protected dynamic taxRate;

        protected RadzenButton button1;

        protected RadzenButton button2;

        IEnumerable<TblSoOrderDetailStatus> _getTblSoOrderDetailStatusesResult;
        protected IEnumerable<TblSoOrderDetailStatus> getTblSoOrderDetailStatusesResult
        {
            get
            {
                return _getTblSoOrderDetailStatusesResult;
            }
            set
            {
                if(_getTblSoOrderDetailStatusesResult != value)
                {
                    _getTblSoOrderDetailStatusesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<TblSoSalesOrder> _getTblSoSalesOrdersResult;
        protected IEnumerable<TblSoSalesOrder> getTblSoSalesOrdersResult
        {
            get
            {
                return _getTblSoSalesOrdersResult;
            }
            set
            {
                if(_getTblSoSalesOrdersResult != value)
                {
                    _getTblSoSalesOrdersResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        TblSoOrderDetail _tblsoorderdetail;
        protected TblSoOrderDetail tblsoorderdetail
        {
            get
            {
                return _tblsoorderdetail;
            }
            set
            {
                if(_tblsoorderdetail != value)
                {
                    _tblsoorderdetail = value;
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
            var otErpGetTblSoOrderDetailStatusesResult = await OtErp.GetTblSoOrderDetailStatuses(null, null);
            getTblSoOrderDetailStatusesResult = otErpGetTblSoOrderDetailStatusesResult;

            var otErpGetTblSoSalesOrdersResult = await OtErp.GetTblSoSalesOrders(null, null);
            getTblSoSalesOrdersResult = otErpGetTblSoSalesOrdersResult;

            tblsoorderdetail = new TblSoOrderDetail();
        }

        protected async void Form0Submit(TblSoOrderDetail args)
        {
            var otErpCreateTblSoOrderDetailResult = await OtErp.CreateTblSoOrderDetail(tblsoorderdetail);
            DialogService.Close(tblsoorderdetail);
        }

        protected async void Button2Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
