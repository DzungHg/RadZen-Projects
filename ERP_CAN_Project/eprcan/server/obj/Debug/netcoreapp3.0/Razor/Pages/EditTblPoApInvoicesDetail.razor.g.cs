#pragma checksum "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "898e7bf17312e327f410f85912b760f56f25dd50"
// <auto-generated/>
#pragma warning disable 1591
namespace ErpCan.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using ErpCan.Shared;

#line default
#line hidden
#line 5 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-tbl-po-ap-invoices-detail/{Vendor_ID}/{Invoice_No}")]
    public class EditTblPoApInvoicesDetail : ErpCan.Pages.EditTblPoApInvoicesDetailComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "contentContainer0");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "style", true);
                __builder2.AddAttribute(6, "class", "row");
                __builder2.AddMarkupContent(7, "\n      ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-md-9");
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(11);
                __builder2.AddAttribute(12, "style", "font-weight: bold");
                __builder2.AddAttribute(13, "Text", "Item no longer available.");
                __builder2.AddAttribute(14, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                           !canEdit

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\n      ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-md-3");
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(20);
                __builder2.AddAttribute(21, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(23, "Text", "Close");
                __builder2.AddAttribute(24, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                              !canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                                                 CloseButtonClick

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "row");
                __builder2.AddMarkupContent(31, "\n      ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-md-12");
                __builder2.AddMarkupContent(34, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>>(35);
                __builder2.AddAttribute(36, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>(
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                              tblpoapinvoicesdetail

#line default
#line hidden
                ));
                __builder2.AddAttribute(37, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                                                 tblpoapinvoicesdetail != null && canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(38, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>(this, 
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                                                                                                     Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(40, "\n            ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(43, "class", "row");
                    __builder3.AddMarkupContent(44, "\n              ");
                    __builder3.OpenElement(45, "div");
                    __builder3.AddAttribute(46, "class", "col-md-3");
                    __builder3.AddMarkupContent(47, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(48);
                    __builder3.AddAttribute(49, "Text", "Tbl Po Vendor");
                    __builder3.AddAttribute(50, "Component", "Vendor_ID");
                    __builder3.AddAttribute(51, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\n              ");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col-md-9");
                    __builder3.AddMarkupContent(56, "\n                ");
                    __Blazor.ErpCan.Pages.EditTblPoApInvoicesDetail.TypeInference.CreateRadzenDropDown_0(__builder3, 57, 58, 
#line 30 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                        getTblPoVendorsResult

#line default
#line hidden
                    , 59, "LastName", 60, "Vendor_ID", 61, "Choose TblPoVendor", 62, "display: block; width: 100%", 63, "Vendor_ID", 64, 
#line 30 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                                                                                                                      tblpoapinvoicesdetail.Vendor_ID

#line default
#line hidden
                    , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpoapinvoicesdetail.Vendor_ID = __value, tblpoapinvoicesdetail.Vendor_ID)));
                    __builder3.AddMarkupContent(66, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(67);
                    __builder3.AddAttribute(68, "Component", "Vendor_ID");
                    __builder3.AddAttribute(69, "Text", "Vendor_ID is required");
                    __builder3.AddAttribute(70, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\n            ");
                    __builder3.OpenElement(74, "div");
                    __builder3.AddAttribute(75, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(76, "class", "row");
                    __builder3.AddMarkupContent(77, "\n              ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "class", "col-md-3");
                    __builder3.AddMarkupContent(80, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(81);
                    __builder3.AddAttribute(82, "Text", "Invoice No");
                    __builder3.AddAttribute(83, "Component", "Invoice_No");
                    __builder3.AddAttribute(84, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(85, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(86, "\n              ");
                    __builder3.OpenElement(87, "div");
                    __builder3.AddAttribute(88, "class", "col-md-9");
                    __builder3.AddMarkupContent(89, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(90);
                    __builder3.AddAttribute(91, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 42 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                          15

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(92, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(93, "Name", "Invoice_No");
                    __builder3.AddAttribute(94, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 42 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                 tblpoapinvoicesdetail.Invoice_No

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(95, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpoapinvoicesdetail.Invoice_No = __value, tblpoapinvoicesdetail.Invoice_No))));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(97);
                    __builder3.AddAttribute(98, "Component", "Invoice_No");
                    __builder3.AddAttribute(99, "Text", "Invoice_No is required");
                    __builder3.AddAttribute(100, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(102, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(103, "\n            ");
                    __builder3.OpenElement(104, "div");
                    __builder3.AddAttribute(105, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(106, "class", "row");
                    __builder3.AddMarkupContent(107, "\n              ");
                    __builder3.OpenElement(108, "div");
                    __builder3.AddAttribute(109, "class", "col-md-3");
                    __builder3.AddMarkupContent(110, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(111);
                    __builder3.AddAttribute(112, "Text", "Invoice Date");
                    __builder3.AddAttribute(113, "Component", "Invoice_Date");
                    __builder3.AddAttribute(114, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(115, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(116, "\n              ");
                    __builder3.OpenElement(117, "div");
                    __builder3.AddAttribute(118, "class", "col-md-9");
                    __builder3.AddMarkupContent(119, "\n                ");
                    __Blazor.ErpCan.Pages.EditTblPoApInvoicesDetail.TypeInference.CreateRadzenDatePicker_1(__builder3, 120, 121, "MM/dd/yyyy", 122, "width: 100%", 123, "Invoice_Date", 124, 
#line 54 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                             tblpoapinvoicesdetail.Invoice_Date

#line default
#line hidden
                    , 125, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpoapinvoicesdetail.Invoice_Date = __value, tblpoapinvoicesdetail.Invoice_Date)));
                    __builder3.AddMarkupContent(126, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(127, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(128, "\n            ");
                    __builder3.OpenElement(129, "div");
                    __builder3.AddAttribute(130, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(131, "class", "row");
                    __builder3.AddMarkupContent(132, "\n              ");
                    __builder3.OpenElement(133, "div");
                    __builder3.AddAttribute(134, "class", "col-md-3");
                    __builder3.AddMarkupContent(135, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(136);
                    __builder3.AddAttribute(137, "Text", "Tbl Ic Inventory");
                    __builder3.AddAttribute(138, "Component", "Inventory_FK");
                    __builder3.AddAttribute(139, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(140, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(141, "\n              ");
                    __builder3.OpenElement(142, "div");
                    __builder3.AddAttribute(143, "class", "col-md-9");
                    __builder3.AddMarkupContent(144, "\n                ");
                    __Blazor.ErpCan.Pages.EditTblPoApInvoicesDetail.TypeInference.CreateRadzenDropDown_2(__builder3, 145, 146, 
#line 64 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                        getTblIcInventoriesResult

#line default
#line hidden
                    , 147, "Warehouse_FK", 148, "Inventory_SEQ", 149, "Choose TblIcInventory", 150, "width: 100%", 151, "Inventory_FK", 152, 
#line 64 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                                                                                                                     tblpoapinvoicesdetail.Inventory_FK

#line default
#line hidden
                    , 153, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpoapinvoicesdetail.Inventory_FK = __value, tblpoapinvoicesdetail.Inventory_FK)));
                    __builder3.AddMarkupContent(154, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(155, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(156, "\n            ");
                    __builder3.OpenElement(157, "div");
                    __builder3.AddAttribute(158, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(159, "class", "row");
                    __builder3.AddMarkupContent(160, "\n              ");
                    __builder3.OpenElement(161, "div");
                    __builder3.AddAttribute(162, "class", "col-md-3");
                    __builder3.AddMarkupContent(163, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(164);
                    __builder3.AddAttribute(165, "Text", "Tbl Ic Unit");
                    __builder3.AddAttribute(166, "Component", "Unit_FK");
                    __builder3.AddAttribute(167, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(168, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(169, "\n              ");
                    __builder3.OpenElement(170, "div");
                    __builder3.AddAttribute(171, "class", "col-md-9");
                    __builder3.AddMarkupContent(172, "\n                ");
                    __Blazor.ErpCan.Pages.EditTblPoApInvoicesDetail.TypeInference.CreateRadzenDropDown_3(__builder3, 173, 174, 
#line 74 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                        getTblIcUnitsResult

#line default
#line hidden
                    , 175, "UnitText", 176, "Unit_SEQ", 177, "Choose TblIcUnit", 178, "width: 100%", 179, "Unit_FK", 180, 
#line 74 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                                                                                                 tblpoapinvoicesdetail.Unit_FK

#line default
#line hidden
                    , 181, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpoapinvoicesdetail.Unit_FK = __value, tblpoapinvoicesdetail.Unit_FK)));
                    __builder3.AddMarkupContent(182, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(183, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(184, "\n            ");
                    __builder3.OpenElement(185, "div");
                    __builder3.AddAttribute(186, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(187, "class", "row");
                    __builder3.AddMarkupContent(188, "\n              ");
                    __builder3.OpenElement(189, "div");
                    __builder3.AddAttribute(190, "class", "col-md-3");
                    __builder3.AddMarkupContent(191, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(192);
                    __builder3.AddAttribute(193, "Text", "Unit Price");
                    __builder3.AddAttribute(194, "Component", "Unit_Price");
                    __builder3.AddAttribute(195, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(196, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(197, "\n              ");
                    __builder3.OpenElement(198, "div");
                    __builder3.AddAttribute(199, "class", "col-md-9");
                    __builder3.AddMarkupContent(200, "\n                ");
                    __Blazor.ErpCan.Pages.EditTblPoApInvoicesDetail.TypeInference.CreateRadzenNumeric_4(__builder3, 201, 202, "width: 100%", 203, "Unit_Price", 204, 
#line 84 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                  tblpoapinvoicesdetail.Unit_Price

#line default
#line hidden
                    , 205, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpoapinvoicesdetail.Unit_Price = __value, tblpoapinvoicesdetail.Unit_Price)));
                    __builder3.AddMarkupContent(206, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(207, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(208, "\n            ");
                    __builder3.OpenElement(209, "div");
                    __builder3.AddAttribute(210, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(211, "class", "row");
                    __builder3.AddMarkupContent(212, "\n              ");
                    __builder3.OpenElement(213, "div");
                    __builder3.AddAttribute(214, "class", "col-md-3");
                    __builder3.AddMarkupContent(215, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(216);
                    __builder3.AddAttribute(217, "Text", "Qty Ordered");
                    __builder3.AddAttribute(218, "Component", "Qty_Ordered");
                    __builder3.AddAttribute(219, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(220, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(221, "\n              ");
                    __builder3.OpenElement(222, "div");
                    __builder3.AddAttribute(223, "class", "col-md-9");
                    __builder3.AddMarkupContent(224, "\n                ");
                    __Blazor.ErpCan.Pages.EditTblPoApInvoicesDetail.TypeInference.CreateRadzenNumeric_5(__builder3, 225, 226, "width: 100%", 227, "Qty_Ordered", 228, 
#line 94 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                  tblpoapinvoicesdetail.Qty_Ordered

#line default
#line hidden
                    , 229, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpoapinvoicesdetail.Qty_Ordered = __value, tblpoapinvoicesdetail.Qty_Ordered)));
                    __builder3.AddMarkupContent(230, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(231, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(232, "\n            ");
                    __builder3.OpenElement(233, "div");
                    __builder3.AddAttribute(234, "class", "row");
                    __builder3.AddMarkupContent(235, "\n              ");
                    __builder3.OpenElement(236, "div");
                    __builder3.AddAttribute(237, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(238, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(239);
                    __builder3.AddAttribute(240, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 100 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(241, "Icon", "save");
                    __builder3.AddAttribute(242, "Text", "Save");
                    __builder3.AddAttribute(243, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 100 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(244, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(245);
                    __builder3.AddAttribute(246, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 102 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(247, "Text", "Cancel");
                    __builder3.AddAttribute(248, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 102 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoApInvoicesDetail.razor"
                                                                                    Button3Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(249, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(250, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(251, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(252, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(253, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(254, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ErpCan.Pages.EditTblPoApInvoicesDetail
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<global::System.Object> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<global::System.Object> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<global::System.Object> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
