#pragma checksum "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bba837beb53dbda9c8e62706a4ab7001268e87b6"
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
#line 5 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-gn-departments")]
    public class TblGnDepartments : ErpCan.Pages.TblGnDepartmentsComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Gn Departments");
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
#line 14 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblGnDepartment>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnDepartment>>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
                                                                                                      getTblGnDepartmentsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblGnDepartment>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblGnDepartment>(this, 
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
                                                                                                                                                                                                  Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnDepartment>>(28);
                    __builder3.AddAttribute(29, "Property", "Department_ID");
                    __builder3.AddAttribute(30, "Title", "Department ID");
                    __builder3.AddAttribute(31, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnDepartment>>(33);
                    __builder3.AddAttribute(34, "Property", "Deparment_Name");
                    __builder3.AddAttribute(35, "Title", "Deparment Name");
                    __builder3.AddAttribute(36, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnDepartment>>(38);
                    __builder3.AddAttribute(39, "Property", "Description");
                    __builder3.AddAttribute(40, "Title", "Description");
                    __builder3.AddAttribute(41, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnDepartment>>(43);
                    __builder3.AddAttribute(44, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 24 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
                                                                                                                                                 false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(45, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 24 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
                                                                                                                                                                  false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(46, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 24 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
                                                                                                                                                                                 false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(47, "Width", "70px");
                    __builder3.AddAttribute(48, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 24 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
                                                                                                                                                                                                                TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(49, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblGnDepartment>)((erpCanModelsCanErpDbAt132TblGnDepartment) => (__builder4) => {
                        __builder4.AddMarkupContent(50, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(51);
                        __builder4.AddAttribute(52, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 26 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(53, "Icon", "close");
                        __builder4.AddAttribute(54, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 26 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(55, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 26 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, erpCanModelsCanErpDbAt132TblGnDepartment)

#line default
#line hidden
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(56, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(58, (__value) => {
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnDepartments.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblGnDepartment>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
