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
    public partial class AddTblSoOrderDetailComponent : ComponentBase
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

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblSoOrderDetail> form0;

        protected RadzenLabel label1;

        protected RadzenDropDown soDetailStatusFk;

        protected RadzenLabel label2;

        protected RadzenDropDown soFk;

        protected RadzenLabel label3;

        protected RadzenDropDown inventoryFk;

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

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus> _getTblSoOrderDetailStatusesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus> getTblSoOrderDetailStatusesResult
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

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder> _getTblSoSalesOrdersResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder> getTblSoSalesOrdersResult
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

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcInventory> _getTblIcInventoriesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcInventory> getTblIcInventoriesResult
        {
            get
            {
                return _getTblIcInventoriesResult;
            }
            set
            {
                if(_getTblIcInventoriesResult != value)
                {
                    _getTblIcInventoriesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        ErpCan.Models.CanErpDbAt132.TblSoOrderDetail _tblsoorderdetail;
        protected ErpCan.Models.CanErpDbAt132.TblSoOrderDetail tblsoorderdetail
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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            var canErpDbAt132GetTblSoOrderDetailStatusesResult = await CanErpDbAt132.GetTblSoOrderDetailStatuses();
            getTblSoOrderDetailStatusesResult = canErpDbAt132GetTblSoOrderDetailStatusesResult;

            var canErpDbAt132GetTblSoSalesOrdersResult = await CanErpDbAt132.GetTblSoSalesOrders();
            getTblSoSalesOrdersResult = canErpDbAt132GetTblSoSalesOrdersResult;

            var canErpDbAt132GetTblIcInventoriesResult = await CanErpDbAt132.GetTblIcInventories();
            getTblIcInventoriesResult = canErpDbAt132GetTblIcInventoriesResult;

            tblsoorderdetail = new ErpCan.Models.CanErpDbAt132.TblSoOrderDetail();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblSoOrderDetail args)
        {
            try
            {
                var canErpDbAt132CreateTblSoOrderDetailResult = await CanErpDbAt132.CreateTblSoOrderDetail(tblsoorderdetail);
                DialogService.Close(tblsoorderdetail);
            }
            catch (Exception canErpDbAt132CreateTblSoOrderDetailException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblSoOrderDetail!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
