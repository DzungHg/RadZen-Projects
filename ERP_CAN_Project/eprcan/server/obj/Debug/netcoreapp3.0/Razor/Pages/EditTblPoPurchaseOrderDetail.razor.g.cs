#pragma checksum "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cba94bf9300d28b1afa537c65823e20d08c3c7c"
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
#line 5 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-tbl-po-purchase-order-detail/{PO_FK}/{Inventory_FK}")]
    public class EditTblPoPurchaseOrderDetail : ErpCan.Pages.EditTblPoPurchaseOrderDetailComponent
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
#line 12 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
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
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(23, "Text", "Close");
                __builder2.AddAttribute(24, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                                              !canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail>>(35);
                __builder2.AddAttribute(36, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail>(
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                                 tblpopurchaseorderdetail

#line default
#line hidden
                ));
                __builder2.AddAttribute(37, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                                                                       tblpopurchaseorderdetail != null && canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(38, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail>(this, 
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
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
                    __builder3.AddAttribute(49, "Text", "Tbl Po Purchase Order");
                    __builder3.AddAttribute(50, "Component", "PO_FK");
                    __builder3.AddAttribute(51, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\n              ");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col-md-9");
                    __builder3.AddMarkupContent(56, "\n                ");
                    __Blazor.ErpCan.Pages.EditTblPoPurchaseOrderDetail.TypeInference.CreateRadzenDropDown_0(__builder3, 57, 58, 
#line 30 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                        getTblPoPurchaseOrdersResult

#line default
#line hidden
                    , 59, "POStatus_FK", 60, "PO_ID", 61, "Choose TblPoPurchaseOrder", 62, "display: block; width: 100%", 63, "PO_FK", 64, 
#line 30 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                                                                                                                                                   tblpopurchaseorderdetail.PO_FK

#line default
#line hidden
                    , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpopurchaseorderdetail.PO_FK = __value, tblpopurchaseorderdetail.PO_FK)));
                    __builder3.AddMarkupContent(66, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(67);
                    __builder3.AddAttribute(68, "Component", "PO_FK");
                    __builder3.AddAttribute(69, "Text", "PO_FK is required");
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
                    __builder3.AddAttribute(82, "Text", "Tbl Ic Inventory");
                    __builder3.AddAttribute(83, "Component", "Inventory_FK");
                    __builder3.AddAttribute(84, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(85, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(86, "\n              ");
                    __builder3.OpenElement(87, "div");
                    __builder3.AddAttribute(88, "class", "col-md-9");
                    __builder3.AddMarkupContent(89, "\n                ");
                    __Blazor.ErpCan.Pages.EditTblPoPurchaseOrderDetail.TypeInference.CreateRadzenDropDown_1(__builder3, 90, 91, 
#line 42 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                        getTblIcInventoriesResult

#line default
#line hidden
                    , 92, "Warehouse_FK", 93, "Inventory_SEQ", 94, "Choose TblIcInventory", 95, "display: block; width: 100%", 96, "Inventory_FK", 97, 
#line 42 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                                                                                                                                                     tblpopurchaseorderdetail.Inventory_FK

#line default
#line hidden
                    , 98, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpopurchaseorderdetail.Inventory_FK = __value, tblpopurchaseorderdetail.Inventory_FK)));
                    __builder3.AddMarkupContent(99, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(100);
                    __builder3.AddAttribute(101, "Component", "Inventory_FK");
                    __builder3.AddAttribute(102, "Text", "Inventory_FK is required");
                    __builder3.AddAttribute(103, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(104, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(105, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\n            ");
                    __builder3.OpenElement(107, "div");
                    __builder3.AddAttribute(108, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(109, "class", "row");
                    __builder3.AddMarkupContent(110, "\n              ");
                    __builder3.OpenElement(111, "div");
                    __builder3.AddAttribute(112, "class", "col-md-3");
                    __builder3.AddMarkupContent(113, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(114);
                    __builder3.AddAttribute(115, "Text", "Unit Price");
                    __builder3.AddAttribute(116, "Component", "Unit_Price");
                    __builder3.AddAttribute(117, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(118, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(119, "\n              ");
                    __builder3.OpenElement(120, "div");
                    __builder3.AddAttribute(121, "class", "col-md-9");
                    __builder3.AddMarkupContent(122, "\n                ");
                    __Blazor.ErpCan.Pages.EditTblPoPurchaseOrderDetail.TypeInference.CreateRadzenNumeric_2(__builder3, 123, 124, "width: 100%", 125, "Unit_Price", 126, 
#line 54 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                  tblpopurchaseorderdetail.Unit_Price

#line default
#line hidden
                    , 127, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpopurchaseorderdetail.Unit_Price = __value, tblpopurchaseorderdetail.Unit_Price)));
                    __builder3.AddMarkupContent(128, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(129, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(130, "\n            ");
                    __builder3.OpenElement(131, "div");
                    __builder3.AddAttribute(132, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(133, "class", "row");
                    __builder3.AddMarkupContent(134, "\n              ");
                    __builder3.OpenElement(135, "div");
                    __builder3.AddAttribute(136, "class", "col-md-3");
                    __builder3.AddMarkupContent(137, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(138);
                    __builder3.AddAttribute(139, "Text", "Qty Ordered");
                    __builder3.AddAttribute(140, "Component", "QtyOrdered");
                    __builder3.AddAttribute(141, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(142, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(143, "\n              ");
                    __builder3.OpenElement(144, "div");
                    __builder3.AddAttribute(145, "class", "col-md-9");
                    __builder3.AddMarkupContent(146, "\n                ");
                    __Blazor.ErpCan.Pages.EditTblPoPurchaseOrderDetail.TypeInference.CreateRadzenNumeric_3(__builder3, 147, 148, "width: 100%", 149, "QtyOrdered", 150, 
#line 64 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                  tblpopurchaseorderdetail.QtyOrdered

#line default
#line hidden
                    , 151, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpopurchaseorderdetail.QtyOrdered = __value, tblpopurchaseorderdetail.QtyOrdered)));
                    __builder3.AddMarkupContent(152, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(153, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(154, "\n            ");
                    __builder3.OpenElement(155, "div");
                    __builder3.AddAttribute(156, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(157, "class", "row");
                    __builder3.AddMarkupContent(158, "\n              ");
                    __builder3.OpenElement(159, "div");
                    __builder3.AddAttribute(160, "class", "col-md-3");
                    __builder3.AddMarkupContent(161, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(162);
                    __builder3.AddAttribute(163, "Text", "Qty Received");
                    __builder3.AddAttribute(164, "Component", "QtyReceived");
                    __builder3.AddAttribute(165, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(166, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(167, "\n              ");
                    __builder3.OpenElement(168, "div");
                    __builder3.AddAttribute(169, "class", "col-md-9");
                    __builder3.AddMarkupContent(170, "\n                ");
                    __Blazor.ErpCan.Pages.EditTblPoPurchaseOrderDetail.TypeInference.CreateRadzenNumeric_4(__builder3, 171, 172, "width: 100%", 173, "QtyReceived", 174, 
#line 74 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                  tblpopurchaseorderdetail.QtyReceived

#line default
#line hidden
                    , 175, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpopurchaseorderdetail.QtyReceived = __value, tblpopurchaseorderdetail.QtyReceived)));
                    __builder3.AddMarkupContent(176, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(177, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(178, "\n            ");
                    __builder3.OpenElement(179, "div");
                    __builder3.AddAttribute(180, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(181, "class", "row");
                    __builder3.AddMarkupContent(182, "\n              ");
                    __builder3.OpenElement(183, "div");
                    __builder3.AddAttribute(184, "class", "col-md-3");
                    __builder3.AddMarkupContent(185, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(186);
                    __builder3.AddAttribute(187, "Text", "Tax Rate");
                    __builder3.AddAttribute(188, "Component", "TaxRate");
                    __builder3.AddAttribute(189, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(190, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(191, "\n              ");
                    __builder3.OpenElement(192, "div");
                    __builder3.AddAttribute(193, "class", "col-md-9");
                    __builder3.AddMarkupContent(194, "\n                ");
                    __Blazor.ErpCan.Pages.EditTblPoPurchaseOrderDetail.TypeInference.CreateRadzenNumeric_5(__builder3, 195, 196, "width: 100%", 197, "TaxRate", 198, 
#line 84 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                  tblpopurchaseorderdetail.TaxRate

#line default
#line hidden
                    , 199, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpopurchaseorderdetail.TaxRate = __value, tblpopurchaseorderdetail.TaxRate)));
                    __builder3.AddMarkupContent(200, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(201, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(202, "\n            ");
                    __builder3.OpenElement(203, "div");
                    __builder3.AddAttribute(204, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(205, "class", "row");
                    __builder3.AddMarkupContent(206, "\n              ");
                    __builder3.OpenElement(207, "div");
                    __builder3.AddAttribute(208, "class", "col-md-3");
                    __builder3.AddMarkupContent(209, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(210);
                    __builder3.AddAttribute(211, "Text", "Discount Percent");
                    __builder3.AddAttribute(212, "Component", "DiscountPercent");
                    __builder3.AddAttribute(213, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(214, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(215, "\n              ");
                    __builder3.OpenElement(216, "div");
                    __builder3.AddAttribute(217, "class", "col-md-9");
                    __builder3.AddMarkupContent(218, "\n                ");
                    __Blazor.ErpCan.Pages.EditTblPoPurchaseOrderDetail.TypeInference.CreateRadzenNumeric_6(__builder3, 219, 220, "width: 100%", 221, "DiscountPercent", 222, 
#line 94 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                  tblpopurchaseorderdetail.DiscountPercent

#line default
#line hidden
                    , 223, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblpopurchaseorderdetail.DiscountPercent = __value, tblpopurchaseorderdetail.DiscountPercent)));
                    __builder3.AddMarkupContent(224, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(225, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(226, "\n            ");
                    __builder3.OpenElement(227, "div");
                    __builder3.AddAttribute(228, "class", "row");
                    __builder3.AddMarkupContent(229, "\n              ");
                    __builder3.OpenElement(230, "div");
                    __builder3.AddAttribute(231, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(232, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(233);
                    __builder3.AddAttribute(234, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 100 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(235, "Icon", "save");
                    __builder3.AddAttribute(236, "Text", "Save");
                    __builder3.AddAttribute(237, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 100 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(238, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(239);
                    __builder3.AddAttribute(240, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 102 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(241, "Text", "Cancel");
                    __builder3.AddAttribute(242, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 102 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                    Button3Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(243, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(244, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(245, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(246, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(247, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(248, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ErpCan.Pages.EditTblPoPurchaseOrderDetail
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
        public static void CreateRadzenDropDown_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<global::System.Object> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7)
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
        public static void CreateRadzenNumeric_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
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
        public static void CreateRadzenNumeric_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3)
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
