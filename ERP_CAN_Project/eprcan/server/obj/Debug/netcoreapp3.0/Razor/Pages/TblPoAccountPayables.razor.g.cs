#pragma checksum "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a1490734cd407359d109fe2395a197462b77ebe"
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
#line 5 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-po-account-payables")]
    public class TblPoAccountPayables : ErpCan.Pages.TblPoAccountPayablesComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Po Account Payables");
                __builder2.AddComponentReferenceCapture(7, (__value) => {
#line 10 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                         pageTitle = (Radzen.Blazor.RadzenHeading)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row");
                __builder2.AddMarkupContent(11, "\n      ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-md-12");
                __builder2.AddMarkupContent(14, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(15);
                __builder2.AddAttribute(16, "Icon", "add_circle_outline");
                __builder2.AddAttribute(17, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(18, "Text", "Add");
                __builder2.AddAttribute(19, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                                                                                                              Button0Click

#line default
#line hidden
                )));
                __builder2.AddComponentReferenceCapture(20, (__value) => {
#line 14 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                            button0 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>>(22);
                __builder2.AddAttribute(23, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(26, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                                                                                                      getTblPoAccountPayablesResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(27, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>(this, 
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                                                                                                                                                                                                          Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(28, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(29, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>>(30);
                    __builder3.AddAttribute(31, "Property", "AP_No");
                    __builder3.AddAttribute(32, "Title", "AP No");
                    __builder3.AddAttribute(33, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>>(35);
                    __builder3.AddAttribute(36, "Property", "Vendor_FK");
                    __builder3.AddAttribute(37, "SortProperty", "TblPoVendor.LastName");
                    __builder3.AddAttribute(38, "FilterProperty", "TblPoVendor.LastName");
                    __builder3.AddAttribute(39, "Title", "Tbl Po Vendor");
                    __builder3.AddAttribute(40, "Type", "string");
                    __builder3.AddAttribute(41, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(42, "\n              ");
                        __builder4.AddContent(43, 
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
               data.TblPoVendor?.LastName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(44, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>>(46);
                    __builder3.AddAttribute(47, "Property", "Transact_No");
                    __builder3.AddAttribute(48, "Title", "Transact No");
                    __builder3.AddAttribute(49, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>>(51);
                    __builder3.AddAttribute(52, "Property", "Record_Code");
                    __builder3.AddAttribute(53, "Title", "Record Code");
                    __builder3.AddAttribute(54, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>>(56);
                    __builder3.AddAttribute(57, "Property", "PO_No");
                    __builder3.AddAttribute(58, "Title", "PO No");
                    __builder3.AddAttribute(59, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>>(61);
                    __builder3.AddAttribute(62, "Format", "date-time");
                    __builder3.AddAttribute(63, "Property", "Transact_Date");
                    __builder3.AddAttribute(64, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(65, "Title", "Transact Date");
                    __builder3.AddAttribute(66, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>>(68);
                    __builder3.AddAttribute(69, "Property", "Description");
                    __builder3.AddAttribute(70, "Title", "Description");
                    __builder3.AddAttribute(71, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>>(73);
                    __builder3.AddAttribute(74, "Format", "decimal");
                    __builder3.AddAttribute(75, "Property", "Amount");
                    __builder3.AddAttribute(76, "Title", "Amount");
                    __builder3.AddAttribute(77, "Type", "number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>>(79);
                    __builder3.AddAttribute(80, "Property", "Department_FK");
                    __builder3.AddAttribute(81, "SortProperty", "TblGnDepartment.Deparment_Name");
                    __builder3.AddAttribute(82, "FilterProperty", "TblGnDepartment.Deparment_Name");
                    __builder3.AddAttribute(83, "Title", "Tbl Gn Department");
                    __builder3.AddAttribute(84, "Type", "string");
                    __builder3.AddAttribute(85, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(86, "\n              ");
                        __builder4.AddContent(87, 
#line 39 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
               data.TblGnDepartment?.Deparment_Name

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(88, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>>(90);
                    __builder3.AddAttribute(91, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 42 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                                                                                                                                                         false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(92, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 42 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                                                                                                                                                                          false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(93, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 42 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                                                                                                                                                                                         false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(94, "Width", "70px");
                    __builder3.AddAttribute(95, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 42 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                                                                                                                                                                                                                        TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(96, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>)((erpCanModelsCanErpDbAt132TblPoAccountPayable) => (__builder4) => {
                        __builder4.AddMarkupContent(97, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(98);
                        __builder4.AddAttribute(99, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 44 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                                                                   ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(100, "Icon", "close");
                        __builder4.AddAttribute(101, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 44 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                                                                                                          ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(102, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 44 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                                                                                                                                     (args) =>GridDeleteButtonClick(args, erpCanModelsCanErpDbAt132TblPoAccountPayable)

#line default
#line hidden
                        )));
                        __builder4.AddComponentReferenceCapture(103, (__value) => {
#line 44 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                                    gridDeleteButton = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                        }
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(104, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(106, (__value) => {
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(110, (__value) => {
#line 8 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblPoAccountPayables.razor"
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
