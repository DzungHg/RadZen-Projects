#pragma checksum "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "735d491841c559671bed09126e65d323be94a3ce"
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
#line 5 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
using QuanLyBanHang.Models.OtErp;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-gn-city")]
    public class AddTblGnCity : QuanLyBanHang.Pages.AddTblGnCityComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<TblGnCity>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TblGnCity>(
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                                 tblgncity

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                                                        tblgncity != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TblGnCity>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TblGnCity>(this, 
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                                                                                                       Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "Text", "City Id");
                    __builder3.AddAttribute(25, "Component", "City_ID");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(27, (__value) => {
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                   label1 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(29, "\n              ");
                    __builder3.OpenElement(30, "div");
                    __builder3.AddAttribute(31, "class", "col-md-9");
                    __builder3.AddMarkupContent(32, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(33);
                    __builder3.AddAttribute(34, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 20 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                                        10

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(35, "style", "width: 100%");
                    __builder3.AddAttribute(36, "Name", "City_ID");
                    __builder3.AddComponentReferenceCapture(37, (__value) => {
#line 20 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                     cityId = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(40, "\n            ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(43, "class", "row");
                    __builder3.AddMarkupContent(44, "\n              ");
                    __builder3.OpenElement(45, "div");
                    __builder3.AddAttribute(46, "class", "col-md-3");
                    __builder3.AddMarkupContent(47, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(48);
                    __builder3.AddAttribute(49, "Text", "City Name");
                    __builder3.AddAttribute(50, "Component", "CityName");
                    __builder3.AddAttribute(51, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(52, (__value) => {
#line 26 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                   label2 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "\n              ");
                    __builder3.OpenElement(55, "div");
                    __builder3.AddAttribute(56, "class", "col-md-9");
                    __builder3.AddMarkupContent(57, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(58);
                    __builder3.AddAttribute(59, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 30 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(60, "style", "width: 100%");
                    __builder3.AddAttribute(61, "Name", "CityName");
                    __builder3.AddComponentReferenceCapture(62, (__value) => {
#line 30 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                     cityName = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(64, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\n            ");
                    __builder3.OpenElement(66, "div");
                    __builder3.AddAttribute(67, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(68, "class", "row");
                    __builder3.AddMarkupContent(69, "\n              ");
                    __builder3.OpenElement(70, "div");
                    __builder3.AddAttribute(71, "class", "col-md-3");
                    __builder3.AddMarkupContent(72, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(73);
                    __builder3.AddAttribute(74, "Text", "City Abbreviation");
                    __builder3.AddAttribute(75, "Component", "CityAbbreviation");
                    __builder3.AddAttribute(76, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(77, (__value) => {
#line 36 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                   label3 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(79, "\n              ");
                    __builder3.OpenElement(80, "div");
                    __builder3.AddAttribute(81, "class", "col-md-9");
                    __builder3.AddMarkupContent(82, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(83);
                    __builder3.AddAttribute(84, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 40 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                                                  10

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(85, "style", "width: 100%");
                    __builder3.AddAttribute(86, "Name", "CityAbbreviation");
                    __builder3.AddComponentReferenceCapture(87, (__value) => {
#line 40 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                     cityAbbreviation = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(89, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\n            ");
                    __builder3.OpenElement(91, "div");
                    __builder3.AddAttribute(92, "class", "row");
                    __builder3.AddMarkupContent(93, "\n              ");
                    __builder3.OpenElement(94, "div");
                    __builder3.AddAttribute(95, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(96, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(97);
                    __builder3.AddAttribute(98, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 46 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                                         ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(99, "Icon", "save");
                    __builder3.AddAttribute(100, "Text", "Save");
                    __builder3.AddAttribute(101, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 46 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                                                                                                 ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddComponentReferenceCapture(102, (__value) => {
#line 46 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                    button1 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(104);
                    __builder3.AddAttribute(105, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 48 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                                          ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(106, "Text", "Cancel");
                    __builder3.AddAttribute(107, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 48 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                                                                                   Button2Click

#line default
#line hidden
                    )));
                    __builder3.AddComponentReferenceCapture(108, (__value) => {
#line 48 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                    button2 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(109, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(110, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(111, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(112, (__value) => {
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
                                  form0 = (Radzen.Blazor.RadzenTemplateForm<TblGnCity>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(113, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(116, (__value) => {
#line 8 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnCity.razor"
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
