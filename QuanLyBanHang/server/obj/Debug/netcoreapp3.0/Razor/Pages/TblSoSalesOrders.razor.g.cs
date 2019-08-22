#pragma checksum "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15628aafd7147b1f29d68fd556a0b2773765545d"
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
using Microsoft.JSInterop;

#line default
#line hidden
#line 5 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\_Imports.razor"
using QuanLyBanHang.Shared;

#line default
#line hidden
#line 5 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
using QuanLyBanHang.Models.OtErp;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-so-sales-orders")]
    public class TblSoSalesOrders : QuanLyBanHang.Pages.TblSoSalesOrdersComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            builder.AddAttribute(1, "Container", "main");
            builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(3, "\n    ");
                builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                builder2.AddAttribute(5, "Size", "H1");
                builder2.AddAttribute(6, "Text", "Tbl So Sales Orders");
                builder2.AddComponentReferenceCapture(7, (__value) => {
#line 10 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
                         pageTitle = (Radzen.Blazor.RadzenHeading)__value;

#line default
#line hidden
                }
                );
                builder2.CloseComponent();
                builder2.AddMarkupContent(8, "\n    ");
                builder2.OpenElement(9, "div");
                builder2.AddAttribute(10, "class", "row");
                builder2.AddMarkupContent(11, "\n      ");
                builder2.OpenElement(12, "div");
                builder2.AddAttribute(13, "class", "col-md-12");
                builder2.AddMarkupContent(14, "\n        ");
                builder2.OpenComponent<Radzen.Blazor.RadzenButton>(15);
                builder2.AddAttribute(16, "Icon", "add_circle_outline");
                builder2.AddAttribute(17, "style", "margin-bottom: 10px");
                builder2.AddAttribute(18, "Text", "Add");
                builder2.AddAttribute(19, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIMouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 14 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
                                                                                                                                 Button0Click

#line default
#line hidden
                )));
                builder2.AddComponentReferenceCapture(20, (__value) => {
#line 14 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
                            button0 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                }
                );
                builder2.CloseComponent();
                builder2.AddMarkupContent(21, "\n        ");
                builder2.OpenComponent<Radzen.Blazor.RadzenGrid<TblSoSalesOrder>>(22);
                builder2.AddAttribute(23, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
                                                                    true

#line default
#line hidden
                ));
                builder2.AddAttribute(24, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
                                                                                       true

#line default
#line hidden
                ));
                builder2.AddAttribute(25, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
                                                                                                           true

#line default
#line hidden
                ));
                builder2.AddAttribute(26, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<TblSoSalesOrder>>(
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
                                                                                                                         getTblSoSalesOrdersResult

#line default
#line hidden
                ));
                builder2.AddAttribute(27, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TblSoSalesOrder>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TblSoSalesOrder>(this, 
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
                                                                                                                                                                                         Grid0RowSelect

#line default
#line hidden
                )));
                builder2.AddAttribute(28, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((builder3) => {
                    builder3.AddMarkupContent(29, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(30);
                    builder3.AddAttribute(31, "Property", "SO_SEQ");
                    builder3.AddAttribute(32, "Title", "SO SEQ");
                    builder3.AddAttribute(33, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(34, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(35);
                    builder3.AddAttribute(36, "Property", "SO_ID");
                    builder3.AddAttribute(37, "Title", "SO ID");
                    builder3.AddAttribute(38, "Type", "string");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(39, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(40);
                    builder3.AddAttribute(41, "Format", "date-time");
                    builder3.AddAttribute(42, "Property", "SODate");
                    builder3.AddAttribute(43, "FormatString", "{0:dd/mm/yy}");
                    builder3.AddAttribute(44, "Title", "SO Date");
                    builder3.AddAttribute(45, "Type", "string");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(46, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(47);
                    builder3.AddAttribute(48, "Property", "CreatedBy_FK");
                    builder3.AddAttribute(49, "SortProperty", "TblGnAddressBook.AddressBook_ID");
                    builder3.AddAttribute(50, "FilterProperty", "TblGnAddressBook.AddressBook_ID");
                    builder3.AddAttribute(51, "Title", "Tbl Gn Address Book");
                    builder3.AddAttribute(52, "Type", "string");
                    builder3.AddAttribute(53, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TblSoSalesOrder>)((data) => (builder4) => {
                        builder4.AddMarkupContent(54, "\n              ");
                        builder4.AddContent(55, 
#line 26 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
               data.TblGnAddressBook?.AddressBook_ID

#line default
#line hidden
                        );
                        builder4.AddMarkupContent(56, "\n              ");
                    }
                    ));
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(57, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(58);
                    builder3.AddAttribute(59, "Property", "SOStatus_FK");
                    builder3.AddAttribute(60, "SortProperty", "TblSoOrderStatus.SOStatus_ID");
                    builder3.AddAttribute(61, "FilterProperty", "TblSoOrderStatus.SOStatus_ID");
                    builder3.AddAttribute(62, "Title", "Tbl So Order Status");
                    builder3.AddAttribute(63, "Type", "string");
                    builder3.AddAttribute(64, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TblSoSalesOrder>)((data) => (builder4) => {
                        builder4.AddMarkupContent(65, "\n              ");
                        builder4.AddContent(66, 
#line 31 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
               data.TblSoOrderStatus?.SOStatus_ID

#line default
#line hidden
                        );
                        builder4.AddMarkupContent(67, "\n              ");
                    }
                    ));
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(68, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(69);
                    builder3.AddAttribute(70, "Property", "Customer_FK");
                    builder3.AddAttribute(71, "SortProperty", "TblSoCustomer.Customer_ID");
                    builder3.AddAttribute(72, "FilterProperty", "TblSoCustomer.Customer_ID");
                    builder3.AddAttribute(73, "Title", "Tbl So Customer");
                    builder3.AddAttribute(74, "Type", "string");
                    builder3.AddAttribute(75, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TblSoSalesOrder>)((data) => (builder4) => {
                        builder4.AddMarkupContent(76, "\n              ");
                        builder4.AddContent(77, 
#line 36 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
               data.TblSoCustomer?.Customer_ID

#line default
#line hidden
                        );
                        builder4.AddMarkupContent(78, "\n              ");
                    }
                    ));
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(79, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(80);
                    builder3.AddAttribute(81, "Property", "CustomerPONumber");
                    builder3.AddAttribute(82, "Title", "Customer PO Number");
                    builder3.AddAttribute(83, "Type", "string");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(84, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(85);
                    builder3.AddAttribute(86, "Format", "date-time");
                    builder3.AddAttribute(87, "Property", "CustomerPODate");
                    builder3.AddAttribute(88, "FormatString", "{0:dd/mm/yy}");
                    builder3.AddAttribute(89, "Title", "Customer PO Date");
                    builder3.AddAttribute(90, "Type", "string");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(91, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(92);
                    builder3.AddAttribute(93, "Property", "BillTo_FK");
                    builder3.AddAttribute(94, "SortProperty", "TblGnAddressBook1.AddressBook_ID");
                    builder3.AddAttribute(95, "FilterProperty", "TblGnAddressBook1.AddressBook_ID");
                    builder3.AddAttribute(96, "Title", "Tbl Gn Address Book");
                    builder3.AddAttribute(97, "Type", "string");
                    builder3.AddAttribute(98, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TblSoSalesOrder>)((data) => (builder4) => {
                        builder4.AddMarkupContent(99, "\n              ");
                        builder4.AddContent(100, 
#line 45 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
               data.TblGnAddressBook1?.AddressBook_ID

#line default
#line hidden
                        );
                        builder4.AddMarkupContent(101, "\n              ");
                    }
                    ));
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(102, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(103);
                    builder3.AddAttribute(104, "Property", "ShipTo_FK");
                    builder3.AddAttribute(105, "SortProperty", "TblGnAddressBook2.AddressBook_ID");
                    builder3.AddAttribute(106, "FilterProperty", "TblGnAddressBook2.AddressBook_ID");
                    builder3.AddAttribute(107, "Title", "Tbl Gn Address Book");
                    builder3.AddAttribute(108, "Type", "string");
                    builder3.AddAttribute(109, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TblSoSalesOrder>)((data) => (builder4) => {
                        builder4.AddMarkupContent(110, "\n              ");
                        builder4.AddContent(111, 
#line 50 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
               data.TblGnAddressBook2?.AddressBook_ID

#line default
#line hidden
                        );
                        builder4.AddMarkupContent(112, "\n              ");
                    }
                    ));
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(113, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(114);
                    builder3.AddAttribute(115, "Property", "Attention");
                    builder3.AddAttribute(116, "Title", "Attention");
                    builder3.AddAttribute(117, "Type", "string");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(118, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(119);
                    builder3.AddAttribute(120, "Property", "ShipVia_FK");
                    builder3.AddAttribute(121, "SortProperty", "TblGnShipVium.ShipVia_ID");
                    builder3.AddAttribute(122, "FilterProperty", "TblGnShipVium.ShipVia_ID");
                    builder3.AddAttribute(123, "Title", "Tbl Gn Ship Vium");
                    builder3.AddAttribute(124, "Type", "string");
                    builder3.AddAttribute(125, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TblSoSalesOrder>)((data) => (builder4) => {
                        builder4.AddMarkupContent(126, "\n              ");
                        builder4.AddContent(127, 
#line 57 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
               data.TblGnShipVium?.ShipVia_ID

#line default
#line hidden
                        );
                        builder4.AddMarkupContent(128, "\n              ");
                    }
                    ));
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(129, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(130);
                    builder3.AddAttribute(131, "Format", "date-time");
                    builder3.AddAttribute(132, "Property", "ActualShipDate");
                    builder3.AddAttribute(133, "FormatString", "{0:dd/mm/yy}");
                    builder3.AddAttribute(134, "Title", "Actual Ship Date");
                    builder3.AddAttribute(135, "Type", "string");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(136, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(137);
                    builder3.AddAttribute(138, "Format", "date-time");
                    builder3.AddAttribute(139, "Property", "ExpectedShipDate");
                    builder3.AddAttribute(140, "FormatString", "{0:dd/mm/yy}");
                    builder3.AddAttribute(141, "Title", "Expected Ship Date");
                    builder3.AddAttribute(142, "Type", "string");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(143, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(144);
                    builder3.AddAttribute(145, "Property", "Shipper_FK");
                    builder3.AddAttribute(146, "Title", "Shipper FK");
                    builder3.AddAttribute(147, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(148, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(149);
                    builder3.AddAttribute(150, "Property", "PaymentTerm_FK");
                    builder3.AddAttribute(151, "Title", "Payment Term FK");
                    builder3.AddAttribute(152, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(153, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(154);
                    builder3.AddAttribute(155, "Property", "PaymentType_FK");
                    builder3.AddAttribute(156, "Title", "Payment Type FK");
                    builder3.AddAttribute(157, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(158, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(159);
                    builder3.AddAttribute(160, "Property", "SalesPersion_FK");
                    builder3.AddAttribute(161, "Title", "Sales Persion FK");
                    builder3.AddAttribute(162, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(163, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(164);
                    builder3.AddAttribute(165, "Format", "decimal");
                    builder3.AddAttribute(166, "Property", "Commission");
                    builder3.AddAttribute(167, "Title", "Commission");
                    builder3.AddAttribute(168, "Type", "number");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(169, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(170);
                    builder3.AddAttribute(171, "Property", "Pick_No");
                    builder3.AddAttribute(172, "Title", "Pick No");
                    builder3.AddAttribute(173, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(174, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(175);
                    builder3.AddAttribute(176, "Property", "Ship_No");
                    builder3.AddAttribute(177, "Title", "Ship No");
                    builder3.AddAttribute(178, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(179, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(180);
                    builder3.AddAttribute(181, "Property", "TaxYN");
                    builder3.AddAttribute(182, "Title", "Tax YN");
                    builder3.AddAttribute(183, "Type", "boolean");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(184, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(185);
                    builder3.AddAttribute(186, "Format", "decimal");
                    builder3.AddAttribute(187, "Property", "TaxtRate");
                    builder3.AddAttribute(188, "Title", "Taxt Rate");
                    builder3.AddAttribute(189, "Type", "number");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(190, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(191);
                    builder3.AddAttribute(192, "Format", "decimal");
                    builder3.AddAttribute(193, "Property", "Subtotal");
                    builder3.AddAttribute(194, "Title", "Subtotal");
                    builder3.AddAttribute(195, "Type", "number");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(196, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(197);
                    builder3.AddAttribute(198, "Format", "decimal");
                    builder3.AddAttribute(199, "Property", "Taxt_Amount");
                    builder3.AddAttribute(200, "Title", "Taxt Amount");
                    builder3.AddAttribute(201, "Type", "number");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(202, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(203);
                    builder3.AddAttribute(204, "Format", "decimal");
                    builder3.AddAttribute(205, "Property", "Discount_Amt");
                    builder3.AddAttribute(206, "Title", "Discount Amt");
                    builder3.AddAttribute(207, "Type", "number");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(208, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(209);
                    builder3.AddAttribute(210, "Format", "decimal");
                    builder3.AddAttribute(211, "Property", "Freight");
                    builder3.AddAttribute(212, "Title", "Freight");
                    builder3.AddAttribute(213, "Type", "number");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(214, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(215);
                    builder3.AddAttribute(216, "Format", "decimal");
                    builder3.AddAttribute(217, "Property", "Total_Order");
                    builder3.AddAttribute(218, "Title", "Total Order");
                    builder3.AddAttribute(219, "Type", "number");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(220, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(221);
                    builder3.AddAttribute(222, "Property", "Description");
                    builder3.AddAttribute(223, "Title", "Description");
                    builder3.AddAttribute(224, "Type", "string");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(225, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(226);
                    builder3.AddAttribute(227, "Property", "ChangeLong");
                    builder3.AddAttribute(228, "Title", "Change Long");
                    builder3.AddAttribute(229, "Type", "string");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(230, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(231);
                    builder3.AddAttribute(232, "Property", "Notes");
                    builder3.AddAttribute(233, "Title", "Notes");
                    builder3.AddAttribute(234, "Type", "string");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(235, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(236);
                    builder3.AddAttribute(237, "Format", "date-time");
                    builder3.AddAttribute(238, "Property", "LastUpdatedDate");
                    builder3.AddAttribute(239, "FormatString", "{0:dd/mm/yy}");
                    builder3.AddAttribute(240, "Title", "Last Updated Date");
                    builder3.AddAttribute(241, "Type", "string");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(242, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(243);
                    builder3.AddAttribute(244, "Property", "LastUpdatedBy_FK");
                    builder3.AddAttribute(245, "Title", "Last Updated By FK");
                    builder3.AddAttribute(246, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(247, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(248);
                    builder3.AddAttribute(249, "Property", "Inactive");
                    builder3.AddAttribute(250, "Title", "Inactive");
                    builder3.AddAttribute(251, "Type", "boolean");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(252, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(253);
                    builder3.AddAttribute(254, "Property", "Sequence");
                    builder3.AddAttribute(255, "Title", "Sequence");
                    builder3.AddAttribute(256, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(257, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoSalesOrder>>(258);
                    builder3.AddAttribute(259, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 106 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
                                                                                            false

#line default
#line hidden
                    ));
                    builder3.AddAttribute(260, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 106 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
                                                                                                             false

#line default
#line hidden
                    ));
                    builder3.AddAttribute(261, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 106 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
                                                                                                                            false

#line default
#line hidden
                    ));
                    builder3.AddAttribute(262, "Width", "70px");
                    builder3.AddAttribute(263, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TblSoSalesOrder>)((tblSoSalesOrder) => (builder4) => {
                        builder4.AddMarkupContent(264, "\n                ");
                        builder4.OpenComponent<Radzen.Blazor.RadzenButton>(265);
                        builder4.AddAttribute(266, "ButtonStyle", "danger");
                        builder4.AddAttribute(267, "Icon", "close");
                        builder4.AddAttribute(268, "Size", "sm");
                        builder4.AddAttribute(269, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIMouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 108 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
                                                                                                                              (args) =>GridDeleteButtonClick(args, tblSoSalesOrder)

#line default
#line hidden
                        )));
                        builder4.AddComponentReferenceCapture(270, (__value) => {
#line 108 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
                                    gridDeleteButton = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                        }
                        );
                        builder4.CloseComponent();
                        builder4.AddMarkupContent(271, "\n              ");
                    }
                    ));
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(272, "\n          ");
                }
                ));
                builder2.AddComponentReferenceCapture(273, (__value) => {
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<TblSoSalesOrder>)__value;

#line default
#line hidden
                }
                );
                builder2.CloseComponent();
                builder2.AddMarkupContent(274, "\n      ");
                builder2.CloseElement();
                builder2.AddMarkupContent(275, "\n    ");
                builder2.CloseElement();
                builder2.AddMarkupContent(276, "\n  ");
            }
            ));
            builder.AddComponentReferenceCapture(277, (__value) => {
#line 8 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoSalesOrders.razor"
                     content1 = (Radzen.Blazor.RadzenContent)__value;

#line default
#line hidden
            }
            );
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
