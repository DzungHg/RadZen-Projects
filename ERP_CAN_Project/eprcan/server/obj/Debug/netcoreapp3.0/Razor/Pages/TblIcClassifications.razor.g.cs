#pragma checksum "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33b7030c1eb8e3a2aeb60d4794e4d7505aa67741"
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
#line 5 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-ic-classifications")]
    public class TblIcClassifications : ErpCan.Pages.TblIcClassificationsComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Ic Classifications");
                __builder2.AddComponentReferenceCapture(7, (__value) => {
#line 10 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
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
#line 14 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
                                                                                                              Button0Click

#line default
#line hidden
                )));
                __builder2.AddComponentReferenceCapture(20, (__value) => {
#line 14 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
                            button0 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblIcClassification>>(22);
                __builder2.AddAttribute(23, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(26, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ErpCan.Models.CanErpDbAt132.TblIcClassification>>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
                                                                                                      getTblIcClassificationsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(27, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblIcClassification>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblIcClassification>(this, 
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
                                                                                                                                                                                                          Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(28, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(29, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcClassification>>(30);
                    __builder3.AddAttribute(31, "Property", "Classifi_ID");
                    __builder3.AddAttribute(32, "Title", "Classifi ID");
                    __builder3.AddAttribute(33, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcClassification>>(35);
                    __builder3.AddAttribute(36, "Property", "Classifi_Name");
                    __builder3.AddAttribute(37, "Title", "Classifi Name");
                    __builder3.AddAttribute(38, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcClassification>>(40);
                    __builder3.AddAttribute(41, "Property", "Inactive");
                    __builder3.AddAttribute(42, "Title", "Inactive");
                    __builder3.AddAttribute(43, "Type", "boolean");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblIcClassification>>(45);
                    __builder3.AddAttribute(46, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 24 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
                                                                                                                                                         false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(47, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 24 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
                                                                                                                                                                          false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(48, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 24 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
                                                                                                                                                                                         false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(49, "Width", "70px");
                    __builder3.AddAttribute(50, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 24 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
                                                                                                                                                                                                                        TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(51, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblIcClassification>)((erpCanModelsCanErpDbAt132TblIcClassification) => (__builder4) => {
                        __builder4.AddMarkupContent(52, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(53);
                        __builder4.AddAttribute(54, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 26 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
                                                                   ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(55, "Icon", "close");
                        __builder4.AddAttribute(56, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 26 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
                                                                                                          ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(57, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 26 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
                                                                                                                                     (args) =>GridDeleteButtonClick(args, erpCanModelsCanErpDbAt132TblIcClassification)

#line default
#line hidden
                        )));
                        __builder4.AddComponentReferenceCapture(58, (__value) => {
#line 26 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
                                    gridDeleteButton = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                        }
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(59, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(61, (__value) => {
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblIcClassification>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(65, (__value) => {
#line 8 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblIcClassifications.razor"
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
