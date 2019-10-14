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
    public partial class AddTblPoRrOrderDetailComponent : ComponentBase
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

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail> form0;

        protected RadzenLabel label1;

        protected RadzenDropDown rrFk;

        protected RadzenRequiredValidator rrFkRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenDropDown inventoryFk;

        protected RadzenRequiredValidator inventoryFkRequiredValidator;

        protected RadzenLabel label3;

        protected dynamic unitPrice;

        protected RadzenLabel label4;

        protected dynamic qtyOrdered;

        protected RadzenLabel label5;

        protected dynamic qtyReceived;

        protected RadzenButton button1;

        protected RadzenButton button2;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoRecReport> _getTblPoRecReportsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoRecReport> getTblPoRecReportsResult
        {
            get
            {
                return _getTblPoRecReportsResult;
            }
            set
            {
                if(_getTblPoRecReportsResult != value)
                {
                    _getTblPoRecReportsResult = value;
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

        ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail _tblporrorderdetail;
        protected ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail tblporrorderdetail
        {
            get
            {
                return _tblporrorderdetail;
            }
            set
            {
                if(_tblporrorderdetail != value)
                {
                    _tblporrorderdetail = value;
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
            var canErpDbAt132GetTblPoRecReportsResult = await CanErpDbAt132.GetTblPoRecReports();
            getTblPoRecReportsResult = canErpDbAt132GetTblPoRecReportsResult;

            var canErpDbAt132GetTblIcInventoriesResult = await CanErpDbAt132.GetTblIcInventories();
            getTblIcInventoriesResult = canErpDbAt132GetTblIcInventoriesResult;

            tblporrorderdetail = new ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail args)
        {
            try
            {
                var canErpDbAt132CreateTblPoRrOrderDetailResult = await CanErpDbAt132.CreateTblPoRrOrderDetail(tblporrorderdetail);
                DialogService.Close(tblporrorderdetail);
            }
            catch (Exception canErpDbAt132CreateTblPoRrOrderDetailException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblPoRrOrderDetail!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
