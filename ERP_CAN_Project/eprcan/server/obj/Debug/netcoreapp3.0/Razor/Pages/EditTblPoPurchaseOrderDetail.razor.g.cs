#pragma checksum "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d658c2b0a36f6f66d86b270e6a8dbc6c2aa2e639"
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
                __builder2.AddComponentReferenceCapture(15, (__value) => {
#line 12 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                           closeLabel = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\n      ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-md-3");
                __builder2.AddMarkupContent(20, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(21);
                __builder2.AddAttribute(22, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                      ButtonStyle.Secondary

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(24, "Text", "Close");
                __builder2.AddAttribute(25, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                                                                 !canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(26, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                                                                                    CloseButtonClick

#line default
#line hidden
                )));
                __builder2.AddComponentReferenceCapture(27, (__value) => {
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                            closeButton = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "row");
                __builder2.AddMarkupContent(33, "\n      ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-md-12");
                __builder2.AddMarkupContent(36, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail>>(37);
                __builder2.AddAttribute(38, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail>(
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                                              tblpopurchaseorderdetail

#line default
#line hidden
                ));
                __builder2.AddAttribute(39, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                                                                                    tblpopurchaseorderdetail != null && canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(40, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail>(this, 
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                                                                                                                                           Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(42, "\n            ");
                    __builder3.OpenElement(43, "div");
                    __builder3.AddAttribute(44, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(45, "class", "row");
                    __builder3.AddMarkupContent(46, "\n              ");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "class", "col-md-3");
                    __builder3.AddMarkupContent(49, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(50);
                    __builder3.AddAttribute(51, "Text", "Tbl Po Purchase Order");
                    __builder3.AddAttribute(52, "Component", "PO_FK");
                    __builder3.AddAttribute(53, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(54, (__value) => {
#line 26 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                   label2 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(56, "\n              ");
                    __builder3.OpenElement(57, "div");
                    __builder3.AddAttribute(58, "class", "col-md-9");
                    __builder3.AddMarkupContent(59, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDropDown>(60);
                    __builder3.AddAttribute(61, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#line 30 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                    getTblPoPurchaseOrdersResult

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(62, "TextProperty", "POStatus_FK");
                    __builder3.AddAttribute(63, "ValueProperty", "PO_ID");
                    __builder3.AddAttribute(64, "Placeholder", "Choose TblPoPurchaseOrder");
                    __builder3.AddAttribute(65, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(66, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 30 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                                                                                                                                                         tblpopurchaseorderdetail.PO_FK

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(67, "Name", "PO_FK");
                    __builder3.AddComponentReferenceCapture(68, (__value) => {
#line 30 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                      poFk = (Radzen.Blazor.RadzenDropDown)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(70);
                    __builder3.AddAttribute(71, "Component", "PO_FK");
                    __builder3.AddAttribute(72, "Text", "PO_FK is required");
                    __builder3.AddAttribute(73, "style", "position: absolute");
                    __builder3.AddComponentReferenceCapture(74, (__value) => {
#line 32 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                               poFkRequiredValidator = (Radzen.Blazor.RadzenRequiredValidator)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\n            ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(80, "class", "row");
                    __builder3.AddMarkupContent(81, "\n              ");
                    __builder3.OpenElement(82, "div");
                    __builder3.AddAttribute(83, "class", "col-md-3");
                    __builder3.AddMarkupContent(84, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(85);
                    __builder3.AddAttribute(86, "Text", "Tbl Ic Inventory");
                    __builder3.AddAttribute(87, "Component", "Inventory_FK");
                    __builder3.AddAttribute(88, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(89, (__value) => {
#line 38 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                   label3 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(90, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(91, "\n              ");
                    __builder3.OpenElement(92, "div");
                    __builder3.AddAttribute(93, "class", "col-md-9");
                    __builder3.AddMarkupContent(94, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDropDown>(95);
                    __builder3.AddAttribute(96, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#line 42 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                           getTblIcInventoriesResult

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(97, "TextProperty", "Warehouse_FK");
                    __builder3.AddAttribute(98, "ValueProperty", "Inventory_SEQ");
                    __builder3.AddAttribute(99, "Placeholder", "Choose TblIcInventory");
                    __builder3.AddAttribute(100, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(101, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 42 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                                                                                                                                                                  tblpopurchaseorderdetail.Inventory_FK

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(102, "Name", "Inventory_FK");
                    __builder3.AddComponentReferenceCapture(103, (__value) => {
#line 42 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                      inventoryFk = (Radzen.Blazor.RadzenDropDown)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(104, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(105);
                    __builder3.AddAttribute(106, "Component", "Inventory_FK");
                    __builder3.AddAttribute(107, "Text", "Inventory_FK is required");
                    __builder3.AddAttribute(108, "style", "position: absolute");
                    __builder3.AddComponentReferenceCapture(109, (__value) => {
#line 44 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                               inventoryFkRequiredValidator = (Radzen.Blazor.RadzenRequiredValidator)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(110, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(111, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(112, "\n            ");
                    __builder3.OpenElement(113, "div");
                    __builder3.AddAttribute(114, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(115, "class", "row");
                    __builder3.AddMarkupContent(116, "\n              ");
                    __builder3.OpenElement(117, "div");
                    __builder3.AddAttribute(118, "class", "col-md-3");
                    __builder3.AddMarkupContent(119, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(120);
                    __builder3.AddAttribute(121, "Text", "Unit Price");
                    __builder3.AddAttribute(122, "Component", "Unit_Price");
                    __builder3.AddAttribute(123, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(124, (__value) => {
#line 50 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                   label4 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(125, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(126, "\n              ");
                    __builder3.OpenElement(127, "div");
                    __builder3.AddAttribute(128, "class", "col-md-9");
                    __builder3.AddMarkupContent(129, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<decimal?>>(130);
                    __builder3.AddAttribute(131, "style", "width: 100%");
                    __builder3.AddAttribute(132, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<decimal?>(
#line 54 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                             tblpopurchaseorderdetail.Unit_Price

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(133, "Name", "Unit_Price");
                    __builder3.AddComponentReferenceCapture(134, (__value) => {
#line 54 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                     unitPrice = (Radzen.Blazor.RadzenNumeric<decimal?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(135, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(136, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(137, "\n            ");
                    __builder3.OpenElement(138, "div");
                    __builder3.AddAttribute(139, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(140, "class", "row");
                    __builder3.AddMarkupContent(141, "\n              ");
                    __builder3.OpenElement(142, "div");
                    __builder3.AddAttribute(143, "class", "col-md-3");
                    __builder3.AddMarkupContent(144, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(145);
                    __builder3.AddAttribute(146, "Text", "Qty Ordered");
                    __builder3.AddAttribute(147, "Component", "QtyOrdered");
                    __builder3.AddAttribute(148, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(149, (__value) => {
#line 60 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                   label5 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(150, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(151, "\n              ");
                    __builder3.OpenElement(152, "div");
                    __builder3.AddAttribute(153, "class", "col-md-9");
                    __builder3.AddMarkupContent(154, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<double?>>(155);
                    __builder3.AddAttribute(156, "style", "width: 100%");
                    __builder3.AddAttribute(157, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double?>(
#line 64 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                              tblpopurchaseorderdetail.QtyOrdered

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(158, "Name", "QtyOrdered");
                    __builder3.AddComponentReferenceCapture(159, (__value) => {
#line 64 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                     qtyOrdered = (Radzen.Blazor.RadzenNumeric<double?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(160, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(161, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(162, "\n            ");
                    __builder3.OpenElement(163, "div");
                    __builder3.AddAttribute(164, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(165, "class", "row");
                    __builder3.AddMarkupContent(166, "\n              ");
                    __builder3.OpenElement(167, "div");
                    __builder3.AddAttribute(168, "class", "col-md-3");
                    __builder3.AddMarkupContent(169, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(170);
                    __builder3.AddAttribute(171, "Text", "Qty Received");
                    __builder3.AddAttribute(172, "Component", "QtyReceived");
                    __builder3.AddAttribute(173, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(174, (__value) => {
#line 70 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                   label6 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(175, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(176, "\n              ");
                    __builder3.OpenElement(177, "div");
                    __builder3.AddAttribute(178, "class", "col-md-9");
                    __builder3.AddMarkupContent(179, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<double?>>(180);
                    __builder3.AddAttribute(181, "style", "width: 100%");
                    __builder3.AddAttribute(182, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double?>(
#line 74 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                               tblpopurchaseorderdetail.QtyReceived

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(183, "Name", "QtyReceived");
                    __builder3.AddComponentReferenceCapture(184, (__value) => {
#line 74 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                     qtyReceived = (Radzen.Blazor.RadzenNumeric<double?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(185, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(186, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(187, "\n            ");
                    __builder3.OpenElement(188, "div");
                    __builder3.AddAttribute(189, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(190, "class", "row");
                    __builder3.AddMarkupContent(191, "\n              ");
                    __builder3.OpenElement(192, "div");
                    __builder3.AddAttribute(193, "class", "col-md-3");
                    __builder3.AddMarkupContent(194, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(195);
                    __builder3.AddAttribute(196, "Text", "Tax Rate");
                    __builder3.AddAttribute(197, "Component", "TaxRate");
                    __builder3.AddAttribute(198, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(199, (__value) => {
#line 80 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                   label7 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(200, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(201, "\n              ");
                    __builder3.OpenElement(202, "div");
                    __builder3.AddAttribute(203, "class", "col-md-9");
                    __builder3.AddMarkupContent(204, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<double?>>(205);
                    __builder3.AddAttribute(206, "style", "width: 100%");
                    __builder3.AddAttribute(207, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double?>(
#line 84 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                           tblpopurchaseorderdetail.TaxRate

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(208, "Name", "TaxRate");
                    __builder3.AddComponentReferenceCapture(209, (__value) => {
#line 84 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                     taxRate = (Radzen.Blazor.RadzenNumeric<double?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(210, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(211, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(212, "\n            ");
                    __builder3.OpenElement(213, "div");
                    __builder3.AddAttribute(214, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(215, "class", "row");
                    __builder3.AddMarkupContent(216, "\n              ");
                    __builder3.OpenElement(217, "div");
                    __builder3.AddAttribute(218, "class", "col-md-3");
                    __builder3.AddMarkupContent(219, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(220);
                    __builder3.AddAttribute(221, "Text", "Discount Percent");
                    __builder3.AddAttribute(222, "Component", "DiscountPercent");
                    __builder3.AddAttribute(223, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(224, (__value) => {
#line 90 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                   label8 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(225, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(226, "\n              ");
                    __builder3.OpenElement(227, "div");
                    __builder3.AddAttribute(228, "class", "col-md-9");
                    __builder3.AddMarkupContent(229, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<double?>>(230);
                    __builder3.AddAttribute(231, "style", "width: 100%");
                    __builder3.AddAttribute(232, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double?>(
#line 94 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                   tblpopurchaseorderdetail.DiscountPercent

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(233, "Name", "DiscountPercent");
                    __builder3.AddComponentReferenceCapture(234, (__value) => {
#line 94 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                     discountPercent = (Radzen.Blazor.RadzenNumeric<double?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(235, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(236, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(237, "\n            ");
                    __builder3.OpenElement(238, "div");
                    __builder3.AddAttribute(239, "class", "row");
                    __builder3.AddMarkupContent(240, "\n              ");
                    __builder3.OpenElement(241, "div");
                    __builder3.AddAttribute(242, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(243, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(244);
                    __builder3.AddAttribute(245, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 100 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                         ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(246, "Icon", "save");
                    __builder3.AddAttribute(247, "Text", "Save");
                    __builder3.AddAttribute(248, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 100 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                                                 ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddComponentReferenceCapture(249, (__value) => {
#line 100 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                    button2 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(250, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(251);
                    __builder3.AddAttribute(252, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 102 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                          ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(253, "Text", "Cancel");
                    __builder3.AddAttribute(254, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 102 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                                                                                   Button3Click

#line default
#line hidden
                    )));
                    __builder3.AddComponentReferenceCapture(255, (__value) => {
#line 102 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                    button3 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(256, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(257, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(258, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(259, (__value) => {
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                                  form0 = (Radzen.Blazor.RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(260, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(261, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(262, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(263, (__value) => {
#line 8 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblPoPurchaseOrderDetail.razor"
                     content1 = (Radzen.Blazor.RadzenContent)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
