#pragma checksum "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5010e56e8d1cb2948e97e9833d6784b8c05ed162"
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
#line 5 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-po-rr-order-details")]
    public class TblPoRrOrderDetails : ErpCan.Pages.TblPoRrOrderDetailsComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "contentContainer0");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Tbl Po Rr Order Details");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
                                                                                                      getTblPoRrOrderDetailsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>(this, 
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
                                                                                                                                                                                                        Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>>(28);
                    __builder3.AddAttribute(29, "Property", "RR_FK");
                    __builder3.AddAttribute(30, "SortProperty", "TblPoRecReport.PO_ID");
                    __builder3.AddAttribute(31, "FilterProperty", "TblPoRecReport.PO_ID");
                    __builder3.AddAttribute(32, "Title", "Tbl Po Rec Report");
                    __builder3.AddAttribute(33, "Type", "string");
                    __builder3.AddAttribute(34, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(35, "\n              ");
                        __builder4.AddContent(36, 
#line 20 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
               data.TblPoRecReport?.PO_ID

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(37, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>>(39);
                    __builder3.AddAttribute(40, "Property", "Inventory_FK");
                    __builder3.AddAttribute(41, "SortProperty", "TblIcInventory.Warehouse_FK");
                    __builder3.AddAttribute(42, "FilterProperty", "TblIcInventory.Warehouse_FK");
                    __builder3.AddAttribute(43, "Title", "Tbl Ic Inventory");
                    __builder3.AddAttribute(44, "Type", "string");
                    __builder3.AddAttribute(45, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(46, "\n              ");
                        __builder4.AddContent(47, 
#line 25 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
               data.TblIcInventory?.Warehouse_FK

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(48, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>>(50);
                    __builder3.AddAttribute(51, "Format", "decimal");
                    __builder3.AddAttribute(52, "Property", "Unit_Price");
                    __builder3.AddAttribute(53, "Title", "Unit Price");
                    __builder3.AddAttribute(54, "Type", "number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>>(56);
                    __builder3.AddAttribute(57, "Format", "double");
                    __builder3.AddAttribute(58, "Property", "QtyOrdered");
                    __builder3.AddAttribute(59, "Title", "Qty Ordered");
                    __builder3.AddAttribute(60, "Type", "number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>>(62);
                    __builder3.AddAttribute(63, "Format", "double");
                    __builder3.AddAttribute(64, "Property", "QtyReceived");
                    __builder3.AddAttribute(65, "Title", "Qty Received");
                    __builder3.AddAttribute(66, "Type", "number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>>(68);
                    __builder3.AddAttribute(69, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 34 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
                                                                                                                                                       false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(70, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 34 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
                                                                                                                                                                        false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(71, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 34 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
                                                                                                                                                                                       false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(72, "Width", "70px");
                    __builder3.AddAttribute(73, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 34 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
                                                                                                                                                                                                                      TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(74, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>)((erpCanModelsCanErpDbAt132TblPoRrOrderDetail) => (__builder4) => {
                        __builder4.AddMarkupContent(75, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(76);
                        __builder4.AddAttribute(77, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 36 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(78, "Icon", "close");
                        __builder4.AddAttribute(79, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 36 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(80, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 36 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, erpCanModelsCanErpDbAt132TblPoRrOrderDetail)

#line default
#line hidden
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(81, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(82, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(83, (__value) => {
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoRrOrderDetails.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
