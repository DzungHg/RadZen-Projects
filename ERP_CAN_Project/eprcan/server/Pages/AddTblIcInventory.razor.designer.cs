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
    public partial class AddTblIcInventoryComponent : ComponentBase
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

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblIcInventory> form0;

        protected RadzenLabel label1;

        protected RadzenDropDown warehouseFk;

        protected RadzenRequiredValidator warehouseFkRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenDropDown categoryFk;

        protected RadzenRequiredValidator categoryFkRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenDropDown classifiFk;

        protected RadzenLabel label4;

        protected RadzenDropDown itemSk;

        protected RadzenLabel label5;

        protected RadzenTextBox productCode;

        protected RadzenLabel label6;

        protected RadzenTextBox productDesc;

        protected RadzenLabel label7;

        protected RadzenCheckBox fixAsset;

        protected RadzenLabel label8;

        protected RadzenDropDown unitFk;

        protected RadzenLabel label9;

        protected dynamic quantityPerUnit;

        protected RadzenLabel label10;

        protected RadzenTextBox location;

        protected RadzenLabel label11;

        protected RadzenCheckBox taxable;

        protected RadzenLabel label12;

        protected dynamic taxRate;

        protected RadzenLabel label13;

        protected dynamic rop;

        protected RadzenLabel label14;

        protected dynamic eoq;

        protected RadzenLabel label15;

        protected dynamic unitPrice;

        protected RadzenLabel label16;

        protected RadzenTextBox glAsset;

        protected RadzenLabel label17;

        protected RadzenTextBox glCogs;

        protected RadzenLabel label18;

        protected RadzenTextBox glSales;

        protected RadzenLabel label19;

        protected RadzenTextBox glNonTaxSales;

        protected RadzenLabel label20;

        protected RadzenDatePicker lastSaleDate;

        protected RadzenLabel label21;

        protected RadzenDatePicker lastPoDate;

        protected RadzenLabel label22;

        protected RadzenDatePicker lastReceiptDate;

        protected RadzenLabel label23;

        protected dynamic lastCost;

        protected RadzenLabel label24;

        protected dynamic everageCost;

        protected RadzenLabel label25;

        protected dynamic qtyOnOrder;

        protected RadzenLabel label26;

        protected dynamic qtyInStock;

        protected RadzenLabel label27;

        protected dynamic qtyOnHand;

        protected RadzenLabel label28;

        protected dynamic qtyAllocated;

        protected RadzenLabel label29;

        protected dynamic mtdQtySold;

        protected RadzenLabel label30;

        protected dynamic mtdGrossSales;

        protected RadzenLabel label31;

        protected dynamic mtdCogs;

        protected RadzenLabel label32;

        protected dynamic ytdQtySold;

        protected RadzenLabel label33;

        protected dynamic ytdGrossSales;

        protected RadzenLabel label34;

        protected dynamic ytdCogs;

        protected RadzenLabel label35;

        protected dynamic ytdQtyReturned;

        protected RadzenLabel label36;

        protected dynamic ltdQtySold;

        protected RadzenLabel label37;

        protected dynamic ltdGrossSales;

        protected RadzenLabel label38;

        protected dynamic ltdCogs;

        protected RadzenLabel label39;

        protected dynamic netGrossRate;

        protected RadzenLabel label40;

        protected dynamic vendorNumberFk;

        protected RadzenLabel label41;

        protected RadzenDatePicker lastUpdatedDate;

        protected RadzenLabel label42;

        protected dynamic lastUpdatedByFk;

        protected RadzenLabel label43;

        protected RadzenTextBox notes;

        protected RadzenLabel label44;

        protected RadzenCheckBox inactive;

        protected RadzenButton button1;

        protected RadzenButton button2;

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

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcCategory> _getTblIcCategoriesResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcCategory> getTblIcCategoriesResult
        {
            get
            {
                return _getTblIcCategoriesResult;
            }
            set
            {
                if(_getTblIcCategoriesResult != value)
                {
                    _getTblIcCategoriesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcClassification> _getTblIcClassificationsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcClassification> getTblIcClassificationsResult
        {
            get
            {
                return _getTblIcClassificationsResult;
            }
            set
            {
                if(_getTblIcClassificationsResult != value)
                {
                    _getTblIcClassificationsResult = value;
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

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcUnit> _getTblIcUnitsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcUnit> getTblIcUnitsResult
        {
            get
            {
                return _getTblIcUnitsResult;
            }
            set
            {
                if(_getTblIcUnitsResult != value)
                {
                    _getTblIcUnitsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        ErpCan.Models.CanErpDbAt132.TblIcInventory _tblicinventory;
        protected ErpCan.Models.CanErpDbAt132.TblIcInventory tblicinventory
        {
            get
            {
                return _tblicinventory;
            }
            set
            {
                if(_tblicinventory != value)
                {
                    _tblicinventory = value;
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
            var canErpDbAt132GetTblIcWarehousesResult = await CanErpDbAt132.GetTblIcWarehouses();
            getTblIcWarehousesResult = canErpDbAt132GetTblIcWarehousesResult;

            var canErpDbAt132GetTblIcCategoriesResult = await CanErpDbAt132.GetTblIcCategories();
            getTblIcCategoriesResult = canErpDbAt132GetTblIcCategoriesResult;

            var canErpDbAt132GetTblIcClassificationsResult = await CanErpDbAt132.GetTblIcClassifications();
            getTblIcClassificationsResult = canErpDbAt132GetTblIcClassificationsResult;

            var canErpDbAt132GetTblGnProductsResult = await CanErpDbAt132.GetTblGnProducts();
            getTblGnProductsResult = canErpDbAt132GetTblGnProductsResult;

            var canErpDbAt132GetTblIcUnitsResult = await CanErpDbAt132.GetTblIcUnits();
            getTblIcUnitsResult = canErpDbAt132GetTblIcUnitsResult;

            tblicinventory = new ErpCan.Models.CanErpDbAt132.TblIcInventory();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblIcInventory args)
        {
            try
            {
                var canErpDbAt132CreateTblIcInventoryResult = await CanErpDbAt132.CreateTblIcInventory(tblicinventory);
                DialogService.Close(tblicinventory);
            }
            catch (Exception canErpDbAt132CreateTblIcInventoryException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblIcInventory!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
