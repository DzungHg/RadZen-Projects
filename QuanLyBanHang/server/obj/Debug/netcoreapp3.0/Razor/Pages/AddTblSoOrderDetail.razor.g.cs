#pragma checksum "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d05556810ad99817b9775e8398ddc754d366de5f"
// <auto-generated/>
#pragma warning disable 1591
namespace QuanLyBanHang.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\_Imports.razor"
using QuanLyBanHang.Shared;

#line default
#line hidden
#line 5 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
using QuanLyBanHang.Models.OtErp;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-so-order-detail")]
    public class AddTblSoOrderDetail : QuanLyBanHang.Pages.AddTblSoOrderDetailComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<TblSoOrderDetail>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TblSoOrderDetail>(
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                                 tblsoorderdetail

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                                                               tblsoorderdetail != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TblSoOrderDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TblSoOrderDetail>(this, 
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
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
                    __builder3.AddAttribute(24, "Text", "Tbl So Order Detail Status");
                    __builder3.AddAttribute(25, "Component", "SODetailStatus_FK");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(27, (__value) => {
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
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
#line 20 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                                                getTblSoOrderDetailStatusesResult

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(35, "TextProperty", "SODetailStatusText");
                    __builder3.AddAttribute(36, "ValueProperty", "SODetailStatus_SEQ");
                    __builder3.AddAttribute(37, "Placeholder", "Choose TblSoOrderDetailStatus");
                    __builder3.AddAttribute(38, "style", "width: 100%");
                    __builder3.AddAttribute(39, "Name", "SODetailStatus_FK");
                    __builder3.AddComponentReferenceCapture(40, (__value) => {
#line 20 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                      soDetailStatusFk = (Radzen.Blazor.RadzenDropDown)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\n            ");
                    __builder3.OpenElement(44, "div");
                    __builder3.AddAttribute(45, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(46, "class", "row");
                    __builder3.AddMarkupContent(47, "\n              ");
                    __builder3.OpenElement(48, "div");
                    __builder3.AddAttribute(49, "class", "col-md-3");
                    __builder3.AddMarkupContent(50, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(51);
                    __builder3.AddAttribute(52, "Text", "Tbl So Sales Order");
                    __builder3.AddAttribute(53, "Component", "SO_FK");
                    __builder3.AddAttribute(54, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(55, (__value) => {
#line 26 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                   label2 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(57, "\n              ");
                    __builder3.OpenElement(58, "div");
                    __builder3.AddAttribute(59, "class", "col-md-9");
                    __builder3.AddMarkupContent(60, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDropDown>(61);
                    __builder3.AddAttribute(62, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#line 30 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                                    getTblSoSalesOrdersResult

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(63, "TextProperty", "SO_ID");
                    __builder3.AddAttribute(64, "ValueProperty", "SO_SEQ");
                    __builder3.AddAttribute(65, "Placeholder", "Choose TblSoSalesOrder");
                    __builder3.AddAttribute(66, "style", "width: 100%");
                    __builder3.AddAttribute(67, "Name", "SO_FK");
                    __builder3.AddComponentReferenceCapture(68, (__value) => {
#line 30 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                      soFk = (Radzen.Blazor.RadzenDropDown)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\n            ");
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(74, "class", "row");
                    __builder3.AddMarkupContent(75, "\n              ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "class", "col-md-3");
                    __builder3.AddMarkupContent(78, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(79);
                    __builder3.AddAttribute(80, "Text", "Inventory Fk");
                    __builder3.AddAttribute(81, "Component", "Inventory_FK");
                    __builder3.AddAttribute(82, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(83, (__value) => {
#line 36 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                   label3 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\n              ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "col-md-9");
                    __builder3.AddMarkupContent(88, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<int?>>(89);
                    __builder3.AddAttribute(90, "style", "width: 100%");
                    __builder3.AddAttribute(91, "Name", "Inventory_FK");
                    __builder3.AddComponentReferenceCapture(92, (__value) => {
#line 40 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                     inventoryFk = (Radzen.Blazor.RadzenNumeric<int?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(94, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(95, "\n            ");
                    __builder3.OpenElement(96, "div");
                    __builder3.AddAttribute(97, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(98, "class", "row");
                    __builder3.AddMarkupContent(99, "\n              ");
                    __builder3.OpenElement(100, "div");
                    __builder3.AddAttribute(101, "class", "col-md-3");
                    __builder3.AddMarkupContent(102, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(103);
                    __builder3.AddAttribute(104, "Text", "Unit Price");
                    __builder3.AddAttribute(105, "Component", "UnitPrice");
                    __builder3.AddAttribute(106, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(107, (__value) => {
#line 46 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                   label4 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(108, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(109, "\n              ");
                    __builder3.OpenElement(110, "div");
                    __builder3.AddAttribute(111, "class", "col-md-9");
                    __builder3.AddMarkupContent(112, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<decimal?>>(113);
                    __builder3.AddAttribute(114, "style", "width: 100%");
                    __builder3.AddAttribute(115, "Name", "UnitPrice");
                    __builder3.AddComponentReferenceCapture(116, (__value) => {
#line 50 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                     unitPrice = (Radzen.Blazor.RadzenNumeric<decimal?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(117, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(118, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(119, "\n            ");
                    __builder3.OpenElement(120, "div");
                    __builder3.AddAttribute(121, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(122, "class", "row");
                    __builder3.AddMarkupContent(123, "\n              ");
                    __builder3.OpenElement(124, "div");
                    __builder3.AddAttribute(125, "class", "col-md-3");
                    __builder3.AddMarkupContent(126, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(127);
                    __builder3.AddAttribute(128, "Text", "Qty On Hand");
                    __builder3.AddAttribute(129, "Component", "QtyOnHand");
                    __builder3.AddAttribute(130, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(131, (__value) => {
#line 56 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                   label5 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(132, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(133, "\n              ");
                    __builder3.OpenElement(134, "div");
                    __builder3.AddAttribute(135, "class", "col-md-9");
                    __builder3.AddMarkupContent(136, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<int?>>(137);
                    __builder3.AddAttribute(138, "style", "width: 100%");
                    __builder3.AddAttribute(139, "Name", "QtyOnHand");
                    __builder3.AddComponentReferenceCapture(140, (__value) => {
#line 60 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                     qtyOnHand = (Radzen.Blazor.RadzenNumeric<int?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(141, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(142, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(143, "\n            ");
                    __builder3.OpenElement(144, "div");
                    __builder3.AddAttribute(145, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(146, "class", "row");
                    __builder3.AddMarkupContent(147, "\n              ");
                    __builder3.OpenElement(148, "div");
                    __builder3.AddAttribute(149, "class", "col-md-3");
                    __builder3.AddMarkupContent(150, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(151);
                    __builder3.AddAttribute(152, "Text", "Qty Ordered");
                    __builder3.AddAttribute(153, "Component", "QtyOrdered");
                    __builder3.AddAttribute(154, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(155, (__value) => {
#line 66 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                   label6 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(156, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(157, "\n              ");
                    __builder3.OpenElement(158, "div");
                    __builder3.AddAttribute(159, "class", "col-md-9");
                    __builder3.AddMarkupContent(160, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<int?>>(161);
                    __builder3.AddAttribute(162, "style", "width: 100%");
                    __builder3.AddAttribute(163, "Name", "QtyOrdered");
                    __builder3.AddComponentReferenceCapture(164, (__value) => {
#line 70 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                     qtyOrdered = (Radzen.Blazor.RadzenNumeric<int?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(165, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(166, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(167, "\n            ");
                    __builder3.OpenElement(168, "div");
                    __builder3.AddAttribute(169, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(170, "class", "row");
                    __builder3.AddMarkupContent(171, "\n              ");
                    __builder3.OpenElement(172, "div");
                    __builder3.AddAttribute(173, "class", "col-md-3");
                    __builder3.AddMarkupContent(174, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(175);
                    __builder3.AddAttribute(176, "Text", "Qty Ordered Now");
                    __builder3.AddAttribute(177, "Component", "QtyOrderedNow");
                    __builder3.AddAttribute(178, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(179, (__value) => {
#line 76 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                   label7 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(180, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(181, "\n              ");
                    __builder3.OpenElement(182, "div");
                    __builder3.AddAttribute(183, "class", "col-md-9");
                    __builder3.AddMarkupContent(184, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<int?>>(185);
                    __builder3.AddAttribute(186, "style", "width: 100%");
                    __builder3.AddAttribute(187, "Name", "QtyOrderedNow");
                    __builder3.AddComponentReferenceCapture(188, (__value) => {
#line 80 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                     qtyOrderedNow = (Radzen.Blazor.RadzenNumeric<int?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(189, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(190, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(191, "\n            ");
                    __builder3.OpenElement(192, "div");
                    __builder3.AddAttribute(193, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(194, "class", "row");
                    __builder3.AddMarkupContent(195, "\n              ");
                    __builder3.OpenElement(196, "div");
                    __builder3.AddAttribute(197, "class", "col-md-3");
                    __builder3.AddMarkupContent(198, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(199);
                    __builder3.AddAttribute(200, "Text", "Qty Back Ordered");
                    __builder3.AddAttribute(201, "Component", "QtyBackOrdered");
                    __builder3.AddAttribute(202, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(203, (__value) => {
#line 86 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                   label8 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(204, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(205, "\n              ");
                    __builder3.OpenElement(206, "div");
                    __builder3.AddAttribute(207, "class", "col-md-9");
                    __builder3.AddMarkupContent(208, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<int?>>(209);
                    __builder3.AddAttribute(210, "style", "width: 100%");
                    __builder3.AddAttribute(211, "Name", "QtyBackOrdered");
                    __builder3.AddComponentReferenceCapture(212, (__value) => {
#line 90 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                     qtyBackOrdered = (Radzen.Blazor.RadzenNumeric<int?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(213, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(214, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(215, "\n            ");
                    __builder3.OpenElement(216, "div");
                    __builder3.AddAttribute(217, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(218, "class", "row");
                    __builder3.AddMarkupContent(219, "\n              ");
                    __builder3.OpenElement(220, "div");
                    __builder3.AddAttribute(221, "class", "col-md-3");
                    __builder3.AddMarkupContent(222, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(223);
                    __builder3.AddAttribute(224, "Text", "Qty Picked");
                    __builder3.AddAttribute(225, "Component", "QtyPicked");
                    __builder3.AddAttribute(226, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(227, (__value) => {
#line 96 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                   label9 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(228, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(229, "\n              ");
                    __builder3.OpenElement(230, "div");
                    __builder3.AddAttribute(231, "class", "col-md-9");
                    __builder3.AddMarkupContent(232, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<int?>>(233);
                    __builder3.AddAttribute(234, "style", "width: 100%");
                    __builder3.AddAttribute(235, "Name", "QtyPicked");
                    __builder3.AddComponentReferenceCapture(236, (__value) => {
#line 100 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                     qtyPicked = (Radzen.Blazor.RadzenNumeric<int?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(237, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(238, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(239, "\n            ");
                    __builder3.OpenElement(240, "div");
                    __builder3.AddAttribute(241, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(242, "class", "row");
                    __builder3.AddMarkupContent(243, "\n              ");
                    __builder3.OpenElement(244, "div");
                    __builder3.AddAttribute(245, "class", "col-md-3");
                    __builder3.AddMarkupContent(246, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(247);
                    __builder3.AddAttribute(248, "Text", "Discount Percent");
                    __builder3.AddAttribute(249, "Component", "DiscountPercent");
                    __builder3.AddAttribute(250, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(251, (__value) => {
#line 106 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                   label10 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(252, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(253, "\n              ");
                    __builder3.OpenElement(254, "div");
                    __builder3.AddAttribute(255, "class", "col-md-9");
                    __builder3.AddMarkupContent(256, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<decimal?>>(257);
                    __builder3.AddAttribute(258, "style", "width: 100%");
                    __builder3.AddAttribute(259, "Name", "DiscountPercent");
                    __builder3.AddComponentReferenceCapture(260, (__value) => {
#line 110 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                     discountPercent = (Radzen.Blazor.RadzenNumeric<decimal?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(261, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(262, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(263, "\n            ");
                    __builder3.OpenElement(264, "div");
                    __builder3.AddAttribute(265, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(266, "class", "row");
                    __builder3.AddMarkupContent(267, "\n              ");
                    __builder3.OpenElement(268, "div");
                    __builder3.AddAttribute(269, "class", "col-md-3");
                    __builder3.AddMarkupContent(270, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(271);
                    __builder3.AddAttribute(272, "Text", "Tax Rate");
                    __builder3.AddAttribute(273, "Component", "TaxRate");
                    __builder3.AddAttribute(274, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(275, (__value) => {
#line 116 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                   label11 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(276, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(277, "\n              ");
                    __builder3.OpenElement(278, "div");
                    __builder3.AddAttribute(279, "class", "col-md-9");
                    __builder3.AddMarkupContent(280, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenNumeric<decimal?>>(281);
                    __builder3.AddAttribute(282, "style", "width: 100%");
                    __builder3.AddAttribute(283, "Name", "TaxRate");
                    __builder3.AddComponentReferenceCapture(284, (__value) => {
#line 120 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                     taxRate = (Radzen.Blazor.RadzenNumeric<decimal?>)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(285, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(286, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(287, "\n            ");
                    __builder3.OpenElement(288, "div");
                    __builder3.AddAttribute(289, "class", "row");
                    __builder3.AddMarkupContent(290, "\n              ");
                    __builder3.OpenElement(291, "div");
                    __builder3.AddAttribute(292, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(293, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(294);
                    __builder3.AddAttribute(295, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 126 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                                         ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(296, "Icon", "save");
                    __builder3.AddAttribute(297, "Text", "Save");
                    __builder3.AddAttribute(298, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 126 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                                                                                                 ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddComponentReferenceCapture(299, (__value) => {
#line 126 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                    button1 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(300, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(301);
                    __builder3.AddAttribute(302, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 128 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                                          ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(303, "Text", "Cancel");
                    __builder3.AddAttribute(304, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 128 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                                                                                   Button2Click

#line default
#line hidden
                    )));
                    __builder3.AddComponentReferenceCapture(305, (__value) => {
#line 128 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                    button2 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(306, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(307, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(308, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(309, (__value) => {
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
                                  form0 = (Radzen.Blazor.RadzenTemplateForm<TblSoOrderDetail>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(310, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(311, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(312, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(313, (__value) => {
#line 8 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblSoOrderDetail.razor"
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
