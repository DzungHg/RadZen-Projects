#pragma checksum "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d586336c5906fbd92235cf88fa48563a49efbe4d"
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
#line 5 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-po-rr-order-detail")]
    public class AddTblPoRrOrderDetail : ErpCan.Pages.AddTblPoRrOrderDetailComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "contentContainer0");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>(
#line 12 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                                 tblporrorderdetail

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                                                                 tblporrorderdetail != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>(this, 
#line 12 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                                                                                                                                                              Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "Text", "Tbl Po Rec Report");
                    __builder3.AddAttribute(25, "Component", "RR_FK");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(27, (__value) => {
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                   label1 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(29, "\n              ");
                    __builder3.OpenElement(30, "div");
                    __builder3.AddAttribute(31, "class", "col-md-9");
                    __builder3.AddMarkupContent(32, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDropDown>(33);
                    __builder3.AddAttribute(34, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#line 20 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                                    getTblPoRecReportsResult

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(35, "TextProperty", "PO_ID");
                    __builder3.AddAttribute(36, "ValueProperty", "RR_No");
                    __builder3.AddAttribute(37, "Placeholder", "Choose TblPoRecReport");
                    __builder3.AddAttribute(38, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(39, "Name", "RR_FK");
                    __builder3.AddComponentReferenceCapture(40, (__value) => {
#line 20 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                      rrFk = (Radzen.Blazor.RadzenDropDown)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(42);
                    __builder3.AddAttribute(43, "Component", "RR_FK");
                    __builder3.AddAttribute(44, "Text", "RR_FK is required");
                    __builder3.AddAttribute(45, "style", "position: absolute");
                    __builder3.AddComponentReferenceCapture(46, (__value) => {
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                               rrFkRequiredValidator = (Radzen.Blazor.RadzenRequiredValidator)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(48, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(49, "\n            ");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(52, "class", "row");
                    __builder3.AddMarkupContent(53, "\n              ");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col-md-3");
                    __builder3.AddMarkupContent(56, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(57);
                    __builder3.AddAttribute(58, "Text", "Tbl Ic Inventory");
                    __builder3.AddAttribute(59, "Component", "Inventory_FK");
                    __builder3.AddAttribute(60, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(61, (__value) => {
#line 28 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                   label2 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(63, "\n              ");
                    __builder3.OpenElement(64, "div");
                    __builder3.AddAttribute(65, "class", "col-md-9");
                    __builder3.AddMarkupContent(66, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDropDown>(67);
                    __builder3.AddAttribute(68, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#line 32 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                                           getTblIcInventoriesResult

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(69, "TextProperty", "Warehouse_FK");
                    __builder3.AddAttribute(70, "ValueProperty", "Inventory_SEQ");
                    __builder3.AddAttribute(71, "Placeholder", "Choose TblIcInventory");
                    __builder3.AddAttribute(72, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(73, "Name", "Inventory_FK");
                    __builder3.AddComponentReferenceCapture(74, (__value) => {
#line 32 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                      inventoryFk = (Radzen.Blazor.RadzenDropDown)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(76);
                    __builder3.AddAttribute(77, "Component", "Inventory_FK");
                    __builder3.AddAttribute(78, "Text", "Inventory_FK is required");
                    __builder3.AddAttribute(79, "style", "position: absolute");
                    __builder3.AddComponentReferenceCapture(80, (__value) => {
#line 34 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                               inventoryFkRequiredValidator = (Radzen.Blazor.RadzenRequiredValidator)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(82, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\n            ");
                    __builder3.OpenElement(84, "div");
                    __builder3.AddAttribute(85, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(86, "class", "row");
                    __builder3.AddMarkupContent(87, "\n              ");
                    __builder3.OpenElement(88, "div");
                    __builder3.AddAttribute(89, "class", "col-md-3");
                    __builder3.AddMarkupContent(90, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(91);
                    __builder3.AddAttribute(92, "Text", "Unit Price");
                    __builder3.AddAttribute(93, "Component", "Unit_Price");
                    __builder3.AddAttribute(94, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(95, (__value) => {
#line 40 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                   label3 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(97, "\n              ");
                    __builder3.OpenElement(98, "div");
                    __builder3.AddAttribute(99, "class", "col-md-9");
                    __builder3.AddMarkupContent(100, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<decimal?>>(101);
                    __builder3.AddAttribute(102, "style", "width: 100%");
                    __builder3.AddAttribute(103, "Name", "Unit_Price");
                    __builder3.AddComponentReferenceCapture(104, (__value) => {
#line 44 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                     unitPrice = (Radzen.Blazor.RadzenNumeric<decimal?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(107, "\n            ");
                    __builder3.OpenElement(108, "div");
                    __builder3.AddAttribute(109, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(110, "class", "row");
                    __builder3.AddMarkupContent(111, "\n              ");
                    __builder3.OpenElement(112, "div");
                    __builder3.AddAttribute(113, "class", "col-md-3");
                    __builder3.AddMarkupContent(114, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(115);
                    __builder3.AddAttribute(116, "Text", "Qty Ordered");
                    __builder3.AddAttribute(117, "Component", "QtyOrdered");
                    __builder3.AddAttribute(118, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(119, (__value) => {
#line 50 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                   label4 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(120, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(121, "\n              ");
                    __builder3.OpenElement(122, "div");
                    __builder3.AddAttribute(123, "class", "col-md-9");
                    __builder3.AddMarkupContent(124, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<double?>>(125);
                    __builder3.AddAttribute(126, "style", "width: 100%");
                    __builder3.AddAttribute(127, "Name", "QtyOrdered");
                    __builder3.AddComponentReferenceCapture(128, (__value) => {
#line 54 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                     qtyOrdered = (Radzen.Blazor.RadzenNumeric<double?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(129, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(130, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(131, "\n            ");
                    __builder3.OpenElement(132, "div");
                    __builder3.AddAttribute(133, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(134, "class", "row");
                    __builder3.AddMarkupContent(135, "\n              ");
                    __builder3.OpenElement(136, "div");
                    __builder3.AddAttribute(137, "class", "col-md-3");
                    __builder3.AddMarkupContent(138, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(139);
                    __builder3.AddAttribute(140, "Text", "Qty Received");
                    __builder3.AddAttribute(141, "Component", "QtyReceived");
                    __builder3.AddAttribute(142, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(143, (__value) => {
#line 60 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                   label5 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(144, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(145, "\n              ");
                    __builder3.OpenElement(146, "div");
                    __builder3.AddAttribute(147, "class", "col-md-9");
                    __builder3.AddMarkupContent(148, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<double?>>(149);
                    __builder3.AddAttribute(150, "style", "width: 100%");
                    __builder3.AddAttribute(151, "Name", "QtyReceived");
                    __builder3.AddComponentReferenceCapture(152, (__value) => {
#line 64 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                     qtyReceived = (Radzen.Blazor.RadzenNumeric<double?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(153, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(154, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(155, "\n            ");
                    __builder3.OpenElement(156, "div");
                    __builder3.AddAttribute(157, "class", "row");
                    __builder3.AddMarkupContent(158, "\n              ");
                    __builder3.OpenElement(159, "div");
                    __builder3.AddAttribute(160, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(161, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(162);
                    __builder3.AddAttribute(163, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 70 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                                         ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(164, "Icon", "save");
                    __builder3.AddAttribute(165, "Text", "Save");
                    __builder3.AddAttribute(166, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 70 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                                                                                                 ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddComponentReferenceCapture(167, (__value) => {
#line 70 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                    button1 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(168, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(169);
                    __builder3.AddAttribute(170, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 72 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                                          ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(171, "Text", "Cancel");
                    __builder3.AddAttribute(172, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 72 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                                                                                   Button2Click

#line default
#line hidden
                    )));
                    __builder3.AddComponentReferenceCapture(173, (__value) => {
#line 72 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                    button2 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(174, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(175, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(176, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(177, (__value) => {
#line 12 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
                                  form0 = (Radzen.Blazor.RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(178, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(179, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(180, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(181, (__value) => {
#line 8 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblPoRrOrderDetail.razor"
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
