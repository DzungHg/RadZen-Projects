#pragma checksum "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69e0ec8dc6404f6498feca3e9af82b639325abd5"
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
#line 5 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
using QuanLyBanHang.Models.OtErp;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-tbl-gn-ship-vium/{ShipVia_SEQ}")]
    public class EditTblGnShipVium : QuanLyBanHang.Pages.EditTblGnShipViumComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "style", true);
                __builder2.AddAttribute(6, "class", "row");
                __builder2.AddMarkupContent(7, "\n      ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-md-9");
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(11);
                __builder2.AddAttribute(12, "style", "font-weight: bold");
                __builder2.AddAttribute(13, "Text", "Item no longer available.");
                __builder2.AddAttribute(14, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                                                                                             !canEdit

#line default
#line hidden
                ));
                __builder2.AddComponentReferenceCapture(15, (__value) => {
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                           closeLabel = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\n      ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-md-3");
                __builder2.AddMarkupContent(20, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(21);
                __builder2.AddAttribute(22, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                                      ButtonStyle.Secondary

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(24, "Text", "Close");
                __builder2.AddAttribute(25, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                                                                                                                 !canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(26, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                                                                                                                                    CloseButtonClick

#line default
#line hidden
                )));
                __builder2.AddComponentReferenceCapture(27, (__value) => {
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                            closeButton = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "row");
                __builder2.AddMarkupContent(33, "\n      ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-md-12");
                __builder2.AddMarkupContent(36, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<TblGnShipVium>>(37);
                __builder2.AddAttribute(38, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TblGnShipVium>(
#line 22 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                                 tblgnshipvium

#line default
#line hidden
                ));
                __builder2.AddAttribute(39, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                                                            tblgnshipvium != null && canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(40, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TblGnShipVium>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TblGnShipVium>(this, 
#line 22 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                                                                                                                              Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(42, "\n            ");
                    __builder3.OpenElement(43, "div");
                    __builder3.AddAttribute(44, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(45, "class", "row");
                    __builder3.AddMarkupContent(46, "\n              ");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "class", "col-md-3");
                    __builder3.AddMarkupContent(49, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(50);
                    __builder3.AddAttribute(51, "Text", "Ship Via Id");
                    __builder3.AddAttribute(52, "Component", "ShipVia_ID");
                    __builder3.AddAttribute(53, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(54, (__value) => {
#line 26 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                   label2 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(56, "\n              ");
                    __builder3.OpenElement(57, "div");
                    __builder3.AddAttribute(58, "class", "col-md-9");
                    __builder3.AddMarkupContent(59, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(60);
                    __builder3.AddAttribute(61, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 30 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                                           25

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(62, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(63, "Name", "ShipVia_ID");
                    __builder3.AddComponentReferenceCapture(64, (__value) => {
#line 30 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                     shipViaId = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(66);
                    __builder3.AddAttribute(67, "Component", "ShipVia_ID");
                    __builder3.AddAttribute(68, "Text", "ShipVia_ID is required");
                    __builder3.AddAttribute(69, "style", "position: absolute");
                    __builder3.AddComponentReferenceCapture(70, (__value) => {
#line 32 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                               shipViaIdRequiredValidator = (Radzen.Blazor.RadzenRequiredValidator)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\n            ");
                    __builder3.OpenElement(74, "div");
                    __builder3.AddAttribute(75, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(76, "class", "row");
                    __builder3.AddMarkupContent(77, "\n              ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "class", "col-md-3");
                    __builder3.AddMarkupContent(80, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(81);
                    __builder3.AddAttribute(82, "Text", "Description");
                    __builder3.AddAttribute(83, "Component", "Description");
                    __builder3.AddAttribute(84, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(85, (__value) => {
#line 38 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                   label3 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(86, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\n              ");
                    __builder3.OpenElement(88, "div");
                    __builder3.AddAttribute(89, "class", "col-md-9");
                    __builder3.AddMarkupContent(90, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(91);
                    __builder3.AddAttribute(92, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 42 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                                             50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(93, "style", "width: 100%");
                    __builder3.AddAttribute(94, "Name", "Description");
                    __builder3.AddComponentReferenceCapture(95, (__value) => {
#line 42 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                     description = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(97, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(98, "\n            ");
                    __builder3.OpenElement(99, "div");
                    __builder3.AddAttribute(100, "class", "row");
                    __builder3.AddMarkupContent(101, "\n              ");
                    __builder3.OpenElement(102, "div");
                    __builder3.AddAttribute(103, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(104, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(105);
                    __builder3.AddAttribute(106, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 48 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                                         ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(107, "Icon", "save");
                    __builder3.AddAttribute(108, "Text", "Save");
                    __builder3.AddAttribute(109, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 48 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                                                                                                 ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddComponentReferenceCapture(110, (__value) => {
#line 48 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                    button2 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(111, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(112);
                    __builder3.AddAttribute(113, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 50 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                                          ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(114, "Text", "Cancel");
                    __builder3.AddAttribute(115, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 50 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                                                                                   Button3Click

#line default
#line hidden
                    )));
                    __builder3.AddComponentReferenceCapture(116, (__value) => {
#line 50 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                    button3 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(117, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(118, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(119, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(120, (__value) => {
#line 22 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
                                  form0 = (Radzen.Blazor.RadzenTemplateForm<TblGnShipVium>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(124, (__value) => {
#line 8 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnShipVium.razor"
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
