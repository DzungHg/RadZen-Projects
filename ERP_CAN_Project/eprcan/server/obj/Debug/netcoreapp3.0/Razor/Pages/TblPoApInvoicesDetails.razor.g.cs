#pragma checksum "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e807daf822c5619f9d715f2f78ea8c43e3c4f27"
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
#line 5 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-po-ap-invoices-details")]
    public class TblPoApInvoicesDetails : ErpCan.Pages.TblPoApInvoicesDetailsComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Po Ap Invoices Details");
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
#line 14 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                                      getTblPoApInvoicesDetailsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>(this, 
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                                                                                                                                              Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>>(28);
                    __builder3.AddAttribute(29, "Property", "Vendor_ID");
                    __builder3.AddAttribute(30, "SortProperty", "TblPoVendor.LastName");
                    __builder3.AddAttribute(31, "FilterProperty", "TblPoVendor.LastName");
                    __builder3.AddAttribute(32, "Title", "Tbl Po Vendor");
                    __builder3.AddAttribute(33, "Type", "string");
                    __builder3.AddAttribute(34, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(35, "\n              ");
                        __builder4.AddContent(36, 
#line 20 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
               data.TblPoVendor?.LastName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(37, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>>(39);
                    __builder3.AddAttribute(40, "Property", "Invoice_No");
                    __builder3.AddAttribute(41, "Title", "Invoice No");
                    __builder3.AddAttribute(42, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>>(44);
                    __builder3.AddAttribute(45, "Format", "date-time");
                    __builder3.AddAttribute(46, "Property", "Invoice_Date");
                    __builder3.AddAttribute(47, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(48, "Title", "Invoice Date");
                    __builder3.AddAttribute(49, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>>(51);
                    __builder3.AddAttribute(52, "Property", "Inventory_FK");
                    __builder3.AddAttribute(53, "SortProperty", "TblIcInventory.Warehouse_FK");
                    __builder3.AddAttribute(54, "FilterProperty", "TblIcInventory.Warehouse_FK");
                    __builder3.AddAttribute(55, "Title", "Tbl Ic Inventory");
                    __builder3.AddAttribute(56, "Type", "string");
                    __builder3.AddAttribute(57, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(58, "\n              ");
                        __builder4.AddContent(59, 
#line 29 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
               data.TblIcInventory?.Warehouse_FK

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(60, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>>(62);
                    __builder3.AddAttribute(63, "Property", "Unit_FK");
                    __builder3.AddAttribute(64, "SortProperty", "TblIcUnit.UnitText");
                    __builder3.AddAttribute(65, "FilterProperty", "TblIcUnit.UnitText");
                    __builder3.AddAttribute(66, "Title", "Tbl Ic Unit");
                    __builder3.AddAttribute(67, "Type", "string");
                    __builder3.AddAttribute(68, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(69, "\n              ");
                        __builder4.AddContent(70, 
#line 34 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
               data.TblIcUnit?.UnitText

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(71, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>>(73);
                    __builder3.AddAttribute(74, "Format", "decimal");
                    __builder3.AddAttribute(75, "Property", "Unit_Price");
                    __builder3.AddAttribute(76, "Title", "Unit Price");
                    __builder3.AddAttribute(77, "Type", "number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>>(79);
                    __builder3.AddAttribute(80, "Format", "double");
                    __builder3.AddAttribute(81, "Property", "Qty_Ordered");
                    __builder3.AddAttribute(82, "Title", "Qty Ordered");
                    __builder3.AddAttribute(83, "Type", "number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>>(85);
                    __builder3.AddAttribute(86, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 41 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                                                                                             false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(87, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 41 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                                                                                                              false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(88, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 41 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                                                                                                                             false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(89, "Width", "70px");
                    __builder3.AddAttribute(90, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 41 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                                                                                                                                                            TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(91, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>)((erpCanModelsCanErpDbAt132TblPoApInvoicesDetail) => (__builder4) => {
                        __builder4.AddMarkupContent(92, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(93);
                        __builder4.AddAttribute(94, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 43 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(95, "Icon", "close");
                        __builder4.AddAttribute(96, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 43 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(97, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 43 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, erpCanModelsCanErpDbAt132TblPoApInvoicesDetail)

#line default
#line hidden
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(98, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(100, (__value) => {
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoApInvoicesDetails.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
