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
    public partial class AddTblIcTransactionComponent : ComponentBase
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

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblIcTransaction> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox transNo;

        protected RadzenRequiredValidator transNoRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenDropDown transCode;

        protected RadzenRequiredValidator transCodeRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenDatePicker transDate;

        protected RadzenLabel label4;

        protected RadzenDropDown warehouseId;

        protected RadzenRequiredValidator warehouseIdRequiredValidator;

        protected RadzenLabel label5;

        protected RadzenDropDown itemFk;

        protected RadzenLabel label6;

        protected RadzenTextBox referenceNo;

        protected RadzenLabel label7;

        protected RadzenDatePicker referenceDate;

        protected RadzenLabel label8;

        protected RadzenCheckBox taxable;

        protected RadzenLabel label9;

        protected RadzenTextBox custVendWarId;

        protected RadzenLabel label10;

        protected dynamic transQty;

        protected RadzenLabel label11;

        protected RadzenTextBox uom;

        protected RadzenLabel label12;

        protected dynamic transAmount;

        protected RadzenLabel label13;

        protected dynamic qtyOnHandEob;

        protected RadzenLabel label14;

        protected dynamic qtyOnOrderEob;

        protected RadzenLabel label15;

        protected dynamic qtyOnAllowedEob;

        protected RadzenLabel label16;

        protected RadzenTextBox glAsset;

        protected RadzenLabel label17;

        protected RadzenTextBox glCogs;

        protected RadzenLabel label18;

        protected RadzenTextBox glSales;

        protected RadzenButton button1;

        protected RadzenButton button2;

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcTransactionType> _getTblIcTransactionTypesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcTransactionType> getTblIcTransactionTypesResult
        {
            get
            {
                return _getTblIcTransactionTypesResult;
            }
            set
            {
                if(_getTblIcTransactionTypesResult != value)
                {
                    _getTblIcTransactionTypesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcWarehouse> _getTblIcWarehousesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcWarehouse> getTblIcWarehousesResult
        {
            get
            {
                return _getTblIcWarehousesResult;
            }
            set
            {
                if(_getTblIcWarehousesResult != value)
                {
                    _getTblIcWarehousesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnProduct> _getTblGnProductsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnProduct> getTblGnProductsResult
        {
            get
            {
                return _getTblGnProductsResult;
            }
            set
            {
                if(_getTblGnProductsResult != value)
                {
                    _getTblGnProductsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        ErpCan.Models.CanErpDbAt132.TblIcTransaction _tblictransaction;
        protected ErpCan.Models.CanErpDbAt132.TblIcTransaction tblictransaction
        {
            get
            {
                return _tblictransaction;
            }
            set
            {
                if(_tblictransaction != value)
                {
                    _tblictransaction = value;
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
            var canErpDbAt132GetTblIcTransactionTypesResult = await CanErpDbAt132.GetTblIcTransactionTypes();
            getTblIcTransactionTypesResult = canErpDbAt132GetTblIcTransactionTypesResult;

            var canErpDbAt132GetTblIcWarehousesResult = await CanErpDbAt132.GetTblIcWarehouses();
            getTblIcWarehousesResult = canErpDbAt132GetTblIcWarehousesResult;

            var canErpDbAt132GetTblGnProductsResult = await CanErpDbAt132.GetTblGnProducts();
            getTblGnProductsResult = canErpDbAt132GetTblGnProductsResult;

            tblictransaction = new ErpCan.Models.CanErpDbAt132.TblIcTransaction();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblIcTransaction args)
        {
            try
            {
                var canErpDbAt132CreateTblIcTransactionResult = await CanErpDbAt132.CreateTblIcTransaction(tblictransaction);
                DialogService.Close(tblictransaction);
            }
            catch (Exception canErpDbAt132CreateTblIcTransactionException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblIcTransaction!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
