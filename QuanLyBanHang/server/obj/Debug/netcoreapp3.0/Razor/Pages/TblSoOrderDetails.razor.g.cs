#pragma checksum "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70591dd41eb569ec73d7f436c3801c9a420cb5ab"
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
#line 5 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
using QuanLyBanHang.Models.OtErp;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-so-order-details")]
    public class TblSoOrderDetails : QuanLyBanHang.Pages.TblSoOrderDetailsComponent
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
                builder2.AddAttribute(6, "Text", "Tbl So Order Details");
                builder2.AddComponentReferenceCapture(7, (__value) => {
#line 10 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
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
#line 14 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
                                                                                                                                 Button0Click

#line default
#line hidden
                )));
                builder2.AddComponentReferenceCapture(20, (__value) => {
#line 14 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
                            button0 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                }
                );
                builder2.CloseComponent();
                builder2.AddMarkupContent(21, "\n        ");
                builder2.OpenComponent<Radzen.Blazor.RadzenGrid<TblSoOrderDetail>>(22);
                builder2.AddAttribute(23, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
                                                                    true

#line default
#line hidden
                ));
                builder2.AddAttribute(24, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
                                                                                       true

#line default
#line hidden
                ));
                builder2.AddAttribute(25, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
                                                                                                           true

#line default
#line hidden
                ));
                builder2.AddAttribute(26, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<TblSoOrderDetail>>(
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
                                                                                                                         getTblSoOrderDetailsResult

#line default
#line hidden
                ));
                builder2.AddAttribute(27, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TblSoOrderDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TblSoOrderDetail>(this, 
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
                                                                                                                                                                                           Grid0RowSelect

#line default
#line hidden
                )));
                builder2.AddAttribute(28, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((builder3) => {
                    builder3.AddMarkupContent(29, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoOrderDetail>>(30);
                    builder3.AddAttribute(31, "Property", "SODetail_SEQ");
                    builder3.AddAttribute(32, "Title", "SO Detail SEQ");
                    builder3.AddAttribute(33, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(34, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoOrderDetail>>(35);
                    builder3.AddAttribute(36, "Property", "SODetailStatus_FK");
                    builder3.AddAttribute(37, "SortProperty", "TblSoOrderDetailStatus.SODetailStatusText");
                    builder3.AddAttribute(38, "FilterProperty", "TblSoOrderDetailStatus.SODetailStatusText");
                    builder3.AddAttribute(39, "Title", "Tbl So Order Detail Status");
                    builder3.AddAttribute(40, "Type", "string");
                    builder3.AddAttribute(41, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TblSoOrderDetail>)((data) => (builder4) => {
                        builder4.AddMarkupContent(42, "\n              ");
                        builder4.AddContent(43, 
#line 22 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
               data.TblSoOrderDetailStatus?.SODetailStatusText

#line default
#line hidden
                        );
                        builder4.AddMarkupContent(44, "\n              ");
                    }
                    ));
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(45, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoOrderDetail>>(46);
                    builder3.AddAttribute(47, "Property", "SO_FK");
                    builder3.AddAttribute(48, "SortProperty", "TblSoSalesOrder.SO_ID");
                    builder3.AddAttribute(49, "FilterProperty", "TblSoSalesOrder.SO_ID");
                    builder3.AddAttribute(50, "Title", "Tbl So Sales Order");
                    builder3.AddAttribute(51, "Type", "string");
                    builder3.AddAttribute(52, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TblSoOrderDetail>)((data) => (builder4) => {
                        builder4.AddMarkupContent(53, "\n              ");
                        builder4.AddContent(54, 
#line 27 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
               data.TblSoSalesOrder?.SO_ID

#line default
#line hidden
                        );
                        builder4.AddMarkupContent(55, "\n              ");
                    }
                    ));
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(56, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoOrderDetail>>(57);
                    builder3.AddAttribute(58, "Property", "Inventory_FK");
                    builder3.AddAttribute(59, "Title", "Inventory FK");
                    builder3.AddAttribute(60, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(61, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoOrderDetail>>(62);
                    builder3.AddAttribute(63, "Format", "decimal");
                    builder3.AddAttribute(64, "Property", "UnitPrice");
                    builder3.AddAttribute(65, "Title", "Unit Price");
                    builder3.AddAttribute(66, "Type", "number");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(67, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoOrderDetail>>(68);
                    builder3.AddAttribute(69, "Property", "QtyOnHand");
                    builder3.AddAttribute(70, "Title", "Qty On Hand");
                    builder3.AddAttribute(71, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(72, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoOrderDetail>>(73);
                    builder3.AddAttribute(74, "Property", "QtyOrdered");
                    builder3.AddAttribute(75, "Title", "Qty Ordered");
                    builder3.AddAttribute(76, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(77, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoOrderDetail>>(78);
                    builder3.AddAttribute(79, "Property", "QtyOrderedNow");
                    builder3.AddAttribute(80, "Title", "Qty Ordered Now");
                    builder3.AddAttribute(81, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(82, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoOrderDetail>>(83);
                    builder3.AddAttribute(84, "Property", "QtyBackOrdered");
                    builder3.AddAttribute(85, "Title", "Qty Back Ordered");
                    builder3.AddAttribute(86, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(87, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoOrderDetail>>(88);
                    builder3.AddAttribute(89, "Property", "QtyPicked");
                    builder3.AddAttribute(90, "Title", "Qty Picked");
                    builder3.AddAttribute(91, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(92, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoOrderDetail>>(93);
                    builder3.AddAttribute(94, "Format", "decimal");
                    builder3.AddAttribute(95, "Property", "SubTotal");
                    builder3.AddAttribute(96, "Title", "Sub Total");
                    builder3.AddAttribute(97, "Type", "number");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(98, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoOrderDetail>>(99);
                    builder3.AddAttribute(100, "Format", "decimal");
                    builder3.AddAttribute(101, "Property", "DiscountPercent");
                    builder3.AddAttribute(102, "Title", "Discount Percent");
                    builder3.AddAttribute(103, "Type", "number");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(104, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoOrderDetail>>(105);
                    builder3.AddAttribute(106, "Format", "decimal");
                    builder3.AddAttribute(107, "Property", "Discount");
                    builder3.AddAttribute(108, "Title", "Discount");
                    builder3.AddAttribute(109, "Type", "number");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(110, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoOrderDetail>>(111);
                    builder3.AddAttribute(112, "Format", "decimal");
                    builder3.AddAttribute(113, "Property", "TaxRate");
                    builder3.AddAttribute(114, "Title", "Tax Rate");
                    builder3.AddAttribute(115, "Type", "number");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(116, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoOrderDetail>>(117);
                    builder3.AddAttribute(118, "Format", "decimal");
                    builder3.AddAttribute(119, "Property", "Tax");
                    builder3.AddAttribute(120, "Title", "Tax");
                    builder3.AddAttribute(121, "Type", "number");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(122, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblSoOrderDetail>>(123);
                    builder3.AddAttribute(124, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 54 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
                                                                                              false

#line default
#line hidden
                    ));
                    builder3.AddAttribute(125, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 54 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
                                                                                                               false

#line default
#line hidden
                    ));
                    builder3.AddAttribute(126, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 54 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
                                                                                                                              false

#line default
#line hidden
                    ));
                    builder3.AddAttribute(127, "Width", "70px");
                    builder3.AddAttribute(128, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TblSoOrderDetail>)((tblSoOrderDetail) => (builder4) => {
                        builder4.AddMarkupContent(129, "\n                ");
                        builder4.OpenComponent<Radzen.Blazor.RadzenButton>(130);
                        builder4.AddAttribute(131, "ButtonStyle", "danger");
                        builder4.AddAttribute(132, "Icon", "close");
                        builder4.AddAttribute(133, "Size", "sm");
                        builder4.AddAttribute(134, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIMouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 56 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
                                                                                                                              (args) =>GridDeleteButtonClick(args, tblSoOrderDetail)

#line default
#line hidden
                        )));
                        builder4.AddComponentReferenceCapture(135, (__value) => {
#line 56 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
                                    gridDeleteButton = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                        }
                        );
                        builder4.CloseComponent();
                        builder4.AddMarkupContent(136, "\n              ");
                    }
                    ));
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(137, "\n          ");
                }
                ));
                builder2.AddComponentReferenceCapture(138, (__value) => {
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<TblSoOrderDetail>)__value;

#line default
#line hidden
                }
                );
                builder2.CloseComponent();
                builder2.AddMarkupContent(139, "\n      ");
                builder2.CloseElement();
                builder2.AddMarkupContent(140, "\n    ");
                builder2.CloseElement();
                builder2.AddMarkupContent(141, "\n  ");
            }
            ));
            builder.AddComponentReferenceCapture(142, (__value) => {
#line 8 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblSoOrderDetails.razor"
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