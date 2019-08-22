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
    public partial class EditTblSoOrderDetailComponent : ComponentBase
    {
        [Inject]
        protected IUriHelper UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected OtErpService OtErp { get; set; }


        [Parameter]
        public string SODetail_SEQ { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<TblSoOrderDetail> form0;

        protected RadzenLabel label2;

        protected RadzenDropDown soDetailStatusFk;

        protected RadzenLabel label3;

        protected RadzenDropDown soFk;

        protected RadzenLabel label4;

        protected dynamic inventoryFk;

        protected RadzenLabel label5;

        protected dynamic unitPrice;

        protected RadzenLabel label6;

        protected dynamic qtyOnHand;

        protected RadzenLabel label7;

        protected dynamic qtyOrdered;

        protected RadzenLabel label8;

        protected dynamic qtyOrderedNow;

        protected RadzenLabel label9;

        protected dynamic qtyBackOrdered;

        protected RadzenLabel label10;

        protected dynamic qtyPicked;

        protected RadzenLabel label11;

        protected dynamic discountPercent;

        protected RadzenLabel label12;

        protected dynamic taxRate;

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

        protected override async Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            canEdit = true;

            var otErpGetTblSoOrderDetailBySoDetailSeqResult = await OtErp.GetTblSoOrderDetailBySoDetailSeq(int.Parse(SODetail_SEQ));
            tblsoorderdetail = otErpGetTblSoOrderDetailBySoDetailSeqResult;

            var otErpGetTblSoOrderDetailStatusesResult = await OtErp.GetTblSoOrderDetailStatuses(null, null);
            getTblSoOrderDetailStatusesResult = otErpGetTblSoOrderDetailStatusesResult;

            var otErpGetTblSoSalesOrdersResult = await OtErp.GetTblSoSalesOrders(null, null);
            getTblSoSalesOrdersResult = otErpGetTblSoSalesOrdersResult;
        }

        protected async void CloseButtonClick(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(TblSoOrderDetail args)
        {
            var otErpUpdateTblSoOrderDetailResult = await OtErp.UpdateTblSoOrderDetail(int.Parse(SODetail_SEQ), tblsoorderdetail);
            DialogService.Close(tblsoorderdetail);
        }

        protected async void Button3Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
