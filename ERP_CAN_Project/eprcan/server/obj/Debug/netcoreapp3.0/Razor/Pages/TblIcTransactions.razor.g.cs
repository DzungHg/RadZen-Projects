#pragma checksum "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdc8b817ee1d13b954e4eea7d774358d566d8a67"
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
#line 5 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-ic-transactions")]
    public class TblIcTransactions : ErpCan.Pages.TblIcTransactionsComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Ic Transactions");
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
#line 14 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
                                                                                                      getTblIcTransactionsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblIcTransaction>(this, 
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
                                                                                                                                                                                                    Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(28);
                    __builder3.AddAttribute(29, "Property", "Trans_No");
                    __builder3.AddAttribute(30, "Title", "Trans No");
                    __builder3.AddAttribute(31, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(33);
                    __builder3.AddAttribute(34, "Property", "Trans_Code");
                    __builder3.AddAttribute(35, "SortProperty", "TblIcTransactionType.Transaction_Name");
                    __builder3.AddAttribute(36, "FilterProperty", "TblIcTransactionType.Transaction_Name");
                    __builder3.AddAttribute(37, "Title", "Tbl Ic Transaction Type");
                    __builder3.AddAttribute(38, "Type", "string");
                    __builder3.AddAttribute(39, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblIcTransaction>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(40, "\n              ");
                        __builder4.AddContent(41, 
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
               data.TblIcTransactionType?.Transaction_Name

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(42, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(44);
                    __builder3.AddAttribute(45, "Format", "date-time");
                    __builder3.AddAttribute(46, "Property", "Trans_Date");
                    __builder3.AddAttribute(47, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(48, "Title", "Trans Date");
                    __builder3.AddAttribute(49, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(51);
                    __builder3.AddAttribute(52, "Property", "Warehouse_ID");
                    __builder3.AddAttribute(53, "SortProperty", "TblIcWarehouse.WarehouseName");
                    __builder3.AddAttribute(54, "FilterProperty", "TblIcWarehouse.WarehouseName");
                    __builder3.AddAttribute(55, "Title", "Tbl Ic Warehouse");
                    __builder3.AddAttribute(56, "Type", "string");
                    __builder3.AddAttribute(57, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblIcTransaction>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(58, "\n              ");
                        __builder4.AddContent(59, 
#line 29 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
               data.TblIcWarehouse?.WarehouseName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(60, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(62);
                    __builder3.AddAttribute(63, "Property", "Item_FK");
                    __builder3.AddAttribute(64, "SortProperty", "TblGnProduct.Product_ID");
                    __builder3.AddAttribute(65, "FilterProperty", "TblGnProduct.Product_ID");
                    __builder3.AddAttribute(66, "Title", "Tbl Gn Product");
                    __builder3.AddAttribute(67, "Type", "string");
                    __builder3.AddAttribute(68, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblIcTransaction>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(69, "\n              ");
                        __builder4.AddContent(70, 
#line 34 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
               data.TblGnProduct?.Product_ID

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(71, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(73);
                    __builder3.AddAttribute(74, "Property", "Reference_No");
                    __builder3.AddAttribute(75, "Title", "Reference No");
                    __builder3.AddAttribute(76, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(78);
                    __builder3.AddAttribute(79, "Format", "date-time");
                    __builder3.AddAttribute(80, "Property", "Reference_Date");
                    __builder3.AddAttribute(81, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(82, "Title", "Reference Date");
                    __builder3.AddAttribute(83, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(85);
                    __builder3.AddAttribute(86, "Property", "Taxable");
                    __builder3.AddAttribute(87, "Title", "Taxable");
                    __builder3.AddAttribute(88, "Type", "boolean");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(90);
                    __builder3.AddAttribute(91, "Property", "Cust_Vend_WarID");
                    __builder3.AddAttribute(92, "Title", "Cust Vend War ID");
                    __builder3.AddAttribute(93, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(94, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(95);
                    __builder3.AddAttribute(96, "Format", "double");
                    __builder3.AddAttribute(97, "Property", "Trans_Qty");
                    __builder3.AddAttribute(98, "Title", "Trans Qty");
                    __builder3.AddAttribute(99, "Type", "number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(100, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(101);
                    __builder3.AddAttribute(102, "Property", "UOM");
                    __builder3.AddAttribute(103, "Title", "UOM");
                    __builder3.AddAttribute(104, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(106);
                    __builder3.AddAttribute(107, "Format", "decimal");
                    __builder3.AddAttribute(108, "Property", "Trans_Amount");
                    __builder3.AddAttribute(109, "Title", "Trans Amount");
                    __builder3.AddAttribute(110, "Type", "number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(111, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(112);
                    __builder3.AddAttribute(113, "Format", "double");
                    __builder3.AddAttribute(114, "Property", "Qty_On_Hand_EOB");
                    __builder3.AddAttribute(115, "Title", "Qty On Hand EOB");
                    __builder3.AddAttribute(116, "Type", "number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(117, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(118);
                    __builder3.AddAttribute(119, "Format", "double");
                    __builder3.AddAttribute(120, "Property", "Qty_On_Order_EOB");
                    __builder3.AddAttribute(121, "Title", "Qty On Order EOB");
                    __builder3.AddAttribute(122, "Type", "number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(123, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(124);
                    __builder3.AddAttribute(125, "Format", "double");
                    __builder3.AddAttribute(126, "Property", "Qty_On_Allowed_EOB");
                    __builder3.AddAttribute(127, "Title", "Qty On Allowed EOB");
                    __builder3.AddAttribute(128, "Type", "number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(129, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(130);
                    __builder3.AddAttribute(131, "Property", "GL_Asset");
                    __builder3.AddAttribute(132, "Title", "GL Asset");
                    __builder3.AddAttribute(133, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(134, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(135);
                    __builder3.AddAttribute(136, "Property", "GL_COGS");
                    __builder3.AddAttribute(137, "Title", "GL COGS");
                    __builder3.AddAttribute(138, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(139, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(140);
                    __builder3.AddAttribute(141, "Property", "GL_Sales");
                    __builder3.AddAttribute(142, "Title", "GL Sales");
                    __builder3.AddAttribute(143, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(144, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcTransaction>>(145);
                    __builder3.AddAttribute(146, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 63 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
                                                                                                                                                   false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(147, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 63 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
                                                                                                                                                                    false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(148, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 63 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
                                                                                                                                                                                   false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(149, "Width", "70px");
                    __builder3.AddAttribute(150, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 63 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
                                                                                                                                                                                                                  TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(151, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblIcTransaction>)((erpCanModelsCanErpDbAt132TblIcTransaction) => (__builder4) => {
                        __builder4.AddMarkupContent(152, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(153);
                        __builder4.AddAttribute(154, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 65 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(155, "Icon", "close");
                        __builder4.AddAttribute(156, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 65 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(157, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 65 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, erpCanModelsCanErpDbAt132TblIcTransaction)

#line default
#line hidden
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(158, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(159, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(160, (__value) => {
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcTransactions.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblIcTransaction>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(161, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(163, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
