#pragma checksum "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "850ff32c0bd84863eed575985a7aec9d0621ad6e"
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
#line 6 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
using Radzen;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 8 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-gn-address-books")]
    public class TblGnAddressBooks : ErpCan.Pages.TblGnAddressBooksComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Gn Address Books");
                __builder2.AddComponentReferenceCapture(7, (__value) => {
#line 11 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
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
#line 15 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
                                                                                                              Button0Click

#line default
#line hidden
                )));
                __builder2.AddComponentReferenceCapture(20, (__value) => {
#line 15 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
                            button0 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(22);
                __builder2.AddAttribute(23, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(26, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(
#line 17 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
                                                                                                      getTblGnAddressBooksResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(27, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>(this, 
#line 17 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
                                                                                                                                                                                                    Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(28, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(29, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(30);
                    __builder3.AddAttribute(31, "Property", "AddressBook_SEQ");
                    __builder3.AddAttribute(32, "Title", "Address Book SEQ");
                    __builder3.AddAttribute(33, "Type", "integer");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(35);
                    __builder3.AddAttribute(36, "Property", "AddressBook_ID");
                    __builder3.AddAttribute(37, "Title", "Address Book ID");
                    __builder3.AddAttribute(38, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(40);
                    __builder3.AddAttribute(41, "Property", "AddressBookType_FK");
                    __builder3.AddAttribute(42, "SortProperty", "TblGnAddressBookType.AddressBookType_ID");
                    __builder3.AddAttribute(43, "FilterProperty", "TblGnAddressBookType.AddressBookType_ID");
                    __builder3.AddAttribute(44, "Title", "Tbl Gn Address Book Type");
                    __builder3.AddAttribute(45, "Type", "string");
                    __builder3.AddAttribute(46, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(47, "\n              ");
                        __builder4.AddContent(48, 
#line 25 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
               data.TblGnAddressBookType?.AddressBookType_ID

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(49, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(51);
                    __builder3.AddAttribute(52, "Property", "LastName");
                    __builder3.AddAttribute(53, "Title", "Last Name");
                    __builder3.AddAttribute(54, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(56);
                    __builder3.AddAttribute(57, "Property", "FirstName");
                    __builder3.AddAttribute(58, "Title", "First Name");
                    __builder3.AddAttribute(59, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(61);
                    __builder3.AddAttribute(62, "Property", "Gender_FK");
                    __builder3.AddAttribute(63, "SortProperty", "TblGnGender.Gender_ID");
                    __builder3.AddAttribute(64, "FilterProperty", "TblGnGender.Gender_ID");
                    __builder3.AddAttribute(65, "Title", "Tbl Gn Gender");
                    __builder3.AddAttribute(66, "Type", "string");
                    __builder3.AddAttribute(67, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(68, "\n              ");
                        __builder4.AddContent(69, 
#line 34 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
               data.TblGnGender?.Gender_ID

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(70, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(72);
                    __builder3.AddAttribute(73, "Format", "date-time");
                    __builder3.AddAttribute(74, "Property", "DOB");
                    __builder3.AddAttribute(75, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(76, "Title", "DOB");
                    __builder3.AddAttribute(77, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(79);
                    __builder3.AddAttribute(80, "Property", "Origin");
                    __builder3.AddAttribute(81, "Title", "Origin");
                    __builder3.AddAttribute(82, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(84);
                    __builder3.AddAttribute(85, "Property", "IDNumber");
                    __builder3.AddAttribute(86, "Title", "ID Number");
                    __builder3.AddAttribute(87, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(89);
                    __builder3.AddAttribute(90, "Property", "TaxIDNumber");
                    __builder3.AddAttribute(91, "Title", "Tax ID Number");
                    __builder3.AddAttribute(92, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(94);
                    __builder3.AddAttribute(95, "Property", "OrganizationName");
                    __builder3.AddAttribute(96, "Title", "Organization Name");
                    __builder3.AddAttribute(97, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(98, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(99);
                    __builder3.AddAttribute(100, "Property", "JobPosition");
                    __builder3.AddAttribute(101, "Title", "Job Position");
                    __builder3.AddAttribute(102, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(104);
                    __builder3.AddAttribute(105, "Property", "Address");
                    __builder3.AddAttribute(106, "Title", "Address");
                    __builder3.AddAttribute(107, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(108, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(109);
                    __builder3.AddAttribute(110, "Property", "City_FK");
                    __builder3.AddAttribute(111, "SortProperty", "TblGnCity.City_ID");
                    __builder3.AddAttribute(112, "FilterProperty", "TblGnCity.City_ID");
                    __builder3.AddAttribute(113, "Title", "Tbl Gn City");
                    __builder3.AddAttribute(114, "Type", "string");
                    __builder3.AddAttribute(115, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(116, "\n              ");
                        __builder4.AddContent(117, 
#line 53 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
               data.TblGnCity?.City_ID

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(118, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(119, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>>(120);
                    __builder3.AddAttribute(121, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 56 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
                                                                                                                                                   false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(122, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 56 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
                                                                                                                                                                    false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(123, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 56 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
                                                                                                                                                                                   false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(124, "Width", "70px");
                    __builder3.AddAttribute(125, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 56 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
                                                                                                                                                                                                                  TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(126, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>)((erpCanModelsCanErpDbAt132TblGnAddressBook) => (__builder4) => {
                        __builder4.AddMarkupContent(127, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(128);
                        __builder4.AddAttribute(129, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 58 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
                                                                   ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(130, "Icon", "close");
                        __builder4.AddAttribute(131, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 58 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
                                                                                                          ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(132, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 58 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
                                                                                                                                     (args) =>GridDeleteButtonClick(args, erpCanModelsCanErpDbAt132TblGnAddressBook)

#line default
#line hidden
                        )));
                        __builder4.AddComponentReferenceCapture(133, (__value) => {
#line 58 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
                                    gridDeleteButton = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                        }
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(134, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(135, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(136, (__value) => {
#line 17 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(137, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(140, (__value) => {
#line 9 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\TblGnAddressBooks.razor"
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
