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
    public partial class EditTblIcInventoryComponent : ComponentBase
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
        public string Inventory_SEQ { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblIcInventory> form0;

        protected RadzenLabel label2;

        protected RadzenDropDown warehouseFk;

        protected RadzenRequiredValidator warehouseFkRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenDropDown categoryFk;

        protected RadzenRequiredValidator categoryFkRequiredValidator;

        protected RadzenLabel label4;

        protected RadzenDropDown classifiFk;

        protected RadzenLabel label5;

        protected RadzenDropDown itemSk;

        protected RadzenLabel label6;

        protected RadzenTextBox productCode;

        protected RadzenLabel label7;

        protected RadzenTextBox productDesc;

        protected RadzenLabel label8;

        protected RadzenCheckBox fixAsset;

        protected RadzenLabel label9;

        protected RadzenDropDown unitFk;

        protected RadzenLabel label10;

        protected dynamic quantityPerUnit;

        protected RadzenLabel label11;

        protected RadzenTextBox location;

        protected RadzenLabel label12;

        protected RadzenCheckBox taxable;

        protected RadzenLabel label13;

        protected dynamic taxRate;

        protected RadzenLabel label14;

        protected dynamic rop;

        protected RadzenLabel label15;

        protected dynamic eoq;

        protected RadzenLabel label16;

        protected dynamic unitPrice;

        protected RadzenLabel label17;

        protected RadzenTextBox glAsset;

        protected RadzenLabel label18;

        protected RadzenTextBox glCogs;

        protected RadzenLabel label19;

        protected RadzenTextBox glSales;

        protected RadzenLabel label20;

        protected RadzenTextBox glNonTaxSales;

        protected RadzenLabel label21;

        protected RadzenDatePicker lastSaleDate;

        protected RadzenLabel label22;

        protected RadzenDatePicker lastPoDate;

        protected RadzenLabel label23;

        protected RadzenDatePicker lastReceiptDate;

        protected RadzenLabel label24;

        protected dynamic lastCost;

        protected RadzenLabel label25;

        protected dynamic everageCost;

        protected RadzenLabel label26;

        protected dynamic qtyOnOrder;

        protected RadzenLabel label27;

        protected dynamic qtyInStock;

        protected RadzenLabel label28;

        protected dynamic qtyOnHand;

        protected RadzenLabel label29;

        protected dynamic qtyAllocated;

        protected RadzenLabel label30;

        protected dynamic mtdQtySold;

        protected RadzenLabel label31;

        protected dynamic mtdGrossSales;

        protected RadzenLabel label32;

        protected dynamic mtdCogs;

        protected RadzenLabel label33;

        protected dynamic ytdQtySold;

        protected RadzenLabel label34;

        protected dynamic ytdGrossSales;

        protected RadzenLabel label35;

        protected dynamic ytdCogs;

        protected RadzenLabel label36;

        protected dynamic ytdQtyReturned;

        protected RadzenLabel label37;

        protected dynamic ltdQtySold;

        protected RadzenLabel label38;

        protected dynamic ltdGrossSales;

        protected RadzenLabel label39;

        protected dynamic ltdCogs;

        protected RadzenLabel label40;

        protected dynamic netGrossRate;

        protected RadzenLabel label41;

        protected dynamic vendorNumberFk;

        protected RadzenLabel label42;

        protected RadzenDatePicker lastUpdatedDate;

        protected RadzenLabel label43;

        protected dynamic lastUpdatedByFk;

        protected RadzenLabel label44;

        protected RadzenTextBox notes;

        protected RadzenLabel label45;

        protected RadzenCheckBox inactive;

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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            canEdit = true;

            var canErpDbAt132GetTblIcInventoryByInventorySeqResult = await CanErpDbAt132.GetTblIcInventoryByInventorySeq(int.Parse(Inventory_SEQ));
            tblicinventory = canErpDbAt132GetTblIcInventoryByInventorySeqResult;

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
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblIcInventory args)
        {
            try
            {
                var canErpDbAt132UpdateTblIcInventoryResult = await CanErpDbAt132.UpdateTblIcInventory(int.Parse(Inventory_SEQ), tblicinventory);
                DialogService.Close(tblicinventory);
            }
            catch (Exception canErpDbAt132UpdateTblIcInventoryException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblIcInventory");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
