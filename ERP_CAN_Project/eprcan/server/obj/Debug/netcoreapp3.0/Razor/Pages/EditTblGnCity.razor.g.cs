#pragma checksum "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b18c62fcee1e270957521693be820211b66f2be2"
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
#line 1 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\_Imports.razor"
using ErpCan.Shared;

#line default
#line hidden
#line 5 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-tbl-gn-city/{City_SEQ}")]
    public class EditTblGnCity : ErpCan.Pages.EditTblGnCityComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "contentContainer0");
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
#line 12 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                                                                           !canEdit

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\n      ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-md-3");
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(20);
                __builder2.AddAttribute(21, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(23, "Text", "Close");
                __builder2.AddAttribute(24, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                                                                                              !canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                                                                                                                 CloseButtonClick

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "row");
                __builder2.AddMarkupContent(31, "\n      ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-md-12");
                __builder2.AddMarkupContent(34, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblGnCity>>(35);
                __builder2.AddAttribute(36, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ErpCan.Models.CanErpDbAt132.TblGnCity>(
#line 22 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                                                                  tblgncity

#line default
#line hidden
                ));
                __builder2.AddAttribute(37, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                                                                                         tblgncity != null && canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(38, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblGnCity>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblGnCity>(this, 
#line 22 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                                                                                                                                 Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(40, "\n            ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(43, "class", "row");
                    __builder3.AddMarkupContent(44, "\n              ");
                    __builder3.OpenElement(45, "div");
                    __builder3.AddAttribute(46, "class", "col-md-3");
                    __builder3.AddMarkupContent(47, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(48);
                    __builder3.AddAttribute(49, "Text", "City Id");
                    __builder3.AddAttribute(50, "Component", "City_ID");
                    __builder3.AddAttribute(51, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\n              ");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col-md-9");
                    __builder3.AddMarkupContent(56, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(57);
                    __builder3.AddAttribute(58, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 30 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                          10

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(59, "style", "width: 100%");
                    __builder3.AddAttribute(60, "Name", "City_ID");
                    __builder3.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 30 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                                                                 tblgncity.City_ID

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblgncity.City_ID = __value, tblgncity.City_ID))));
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
                    __builder3.AddAttribute(74, "Text", "City Name");
                    __builder3.AddAttribute(75, "Component", "CityName");
                    __builder3.AddAttribute(76, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(78, "\n              ");
                    __builder3.OpenElement(79, "div");
                    __builder3.AddAttribute(80, "class", "col-md-9");
                    __builder3.AddMarkupContent(81, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(82);
                    __builder3.AddAttribute(83, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 40 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(84, "style", "width: 100%");
                    __builder3.AddAttribute(85, "Name", "CityName");
                    __builder3.AddAttribute(86, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 40 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                                                                 tblgncity.CityName

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(87, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblgncity.CityName = __value, tblgncity.CityName))));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(89, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\n            ");
                    __builder3.OpenElement(91, "div");
                    __builder3.AddAttribute(92, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(93, "class", "row");
                    __builder3.AddMarkupContent(94, "\n              ");
                    __builder3.OpenElement(95, "div");
                    __builder3.AddAttribute(96, "class", "col-md-3");
                    __builder3.AddMarkupContent(97, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(98);
                    __builder3.AddAttribute(99, "Text", "City Abbreviation");
                    __builder3.AddAttribute(100, "Component", "CityAbbreviation");
                    __builder3.AddAttribute(101, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(102, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(103, "\n              ");
                    __builder3.OpenElement(104, "div");
                    __builder3.AddAttribute(105, "class", "col-md-9");
                    __builder3.AddMarkupContent(106, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(107);
                    __builder3.AddAttribute(108, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 50 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                          10

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(109, "style", "width: 100%");
                    __builder3.AddAttribute(110, "Name", "CityAbbreviation");
                    __builder3.AddAttribute(111, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 50 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                                                                 tblgncity.CityAbbreviation

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(112, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblgncity.CityAbbreviation = __value, tblgncity.CityAbbreviation))));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(113, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(114, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(115, "\n            ");
                    __builder3.OpenElement(116, "div");
                    __builder3.AddAttribute(117, "class", "row");
                    __builder3.AddMarkupContent(118, "\n              ");
                    __builder3.OpenElement(119, "div");
                    __builder3.AddAttribute(120, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(121, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(122);
                    __builder3.AddAttribute(123, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 56 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(124, "Icon", "save");
                    __builder3.AddAttribute(125, "Text", "Save");
                    __builder3.AddAttribute(126, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 56 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(127, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(128);
                    __builder3.AddAttribute(129, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 58 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(130, "Text", "Cancel");
                    __builder3.AddAttribute(131, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 58 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnCity.razor"
                                                                                    Button3Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(132, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(133, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(134, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(135, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(137, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
