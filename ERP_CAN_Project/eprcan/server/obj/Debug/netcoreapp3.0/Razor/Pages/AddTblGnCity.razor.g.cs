#pragma checksum "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2def25cca4a16398bb261f75d867d7fd9c0b491d"
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
#line 5 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-gn-city")]
    public class AddTblGnCity : ErpCan.Pages.AddTblGnCityComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "contentContainer0");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblGnCity>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ErpCan.Models.CanErpDbAt132.TblGnCity>(
#line 12 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor"
                                    tblgncity

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor"
                                                                                                         tblgncity != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblGnCity>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblGnCity>(this, 
#line 12 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor"
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
                    __builder3.AddAttribute(24, "Component", "City_ID");
                    __builder3.AddAttribute(25, "style", "width: 100%");
                    __builder3.AddAttribute(26, "Text", "Mã Tỉnh Thành");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 20 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor"
                                          10

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "style", "width: 100%");
                    __builder3.AddAttribute(35, "Name", "City_ID");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor"
                                                                                 tblgncity.City_ID

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblgncity.City_ID = __value, tblgncity.City_ID))));
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
                    __builder3.AddAttribute(49, "Component", "CityName");
                    __builder3.AddAttribute(50, "style", "width: 100%");
                    __builder3.AddAttribute(51, "Text", "Tên Tỉnh Thành");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\n              ");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col-md-9");
                    __builder3.AddMarkupContent(56, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(57);
                    __builder3.AddAttribute(58, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 30 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(59, "style", "width: 100%");
                    __builder3.AddAttribute(60, "Name", "CityName");
                    __builder3.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 30 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor"
                                                                                 tblgncity.CityName

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblgncity.CityName = __value, tblgncity.CityName))));
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
                    __builder3.AddAttribute(74, "Component", "CityAbbreviation");
                    __builder3.AddAttribute(75, "style", "width: 100%");
                    __builder3.AddAttribute(76, "Text", "Viết Tắt");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(78, "\n              ");
                    __builder3.OpenElement(79, "div");
                    __builder3.AddAttribute(80, "class", "col-md-9");
                    __builder3.AddMarkupContent(81, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(82);
                    __builder3.AddAttribute(83, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 40 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor"
                                          10

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(84, "style", "width: 100%");
                    __builder3.AddAttribute(85, "Name", "CityAbbreviation");
                    __builder3.AddAttribute(86, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 40 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor"
                                                                                 tblgncity.CityAbbreviation

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(87, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblgncity.CityAbbreviation = __value, tblgncity.CityAbbreviation))));
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
                    __builder3.AddAttribute(98, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 46 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(99, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 46 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(100, "Icon", "save");
                    __builder3.AddAttribute(101, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(102, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(103);
                    __builder3.AddAttribute(104, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 48 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(105, "Text", "Cancel");
                    __builder3.AddAttribute(106, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 48 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblGnCity.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(107, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(108, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(109, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(110, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
