#pragma checksum "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblIcUnit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f31b8a0ea1567b351eb1ac725a7340caa753cb6"
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
#line 5 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblIcUnit.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblIcUnit.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblIcUnit.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-ic-unit")]
    public class AddTblIcUnit : ErpCan.Pages.AddTblIcUnitComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblIcUnit>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ErpCan.Models.CanErpDbAt132.TblIcUnit>(
#line 12 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblIcUnit.razor"
                                    tblicunit

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblIcUnit.razor"
                                                           tblicunit != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblIcUnit>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblIcUnit>(this, 
#line 12 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblIcUnit.razor"
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
                    __builder3.AddAttribute(24, "Text", "Unit Text");
                    __builder3.AddAttribute(25, "Component", "UnitText");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 20 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblIcUnit.razor"
                                          25

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(35, "Name", "UnitText");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblIcUnit.razor"
                                                                                                 tblicunit.UnitText

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblicunit.UnitText = __value, tblicunit.UnitText))));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(39);
                    __builder3.AddAttribute(40, "Component", "UnitText");
                    __builder3.AddAttribute(41, "Text", "UnitText is required");
                    __builder3.AddAttribute(42, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(48, "class", "row");
                    __builder3.AddMarkupContent(49, "\n              ");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "class", "col-md-3");
                    __builder3.AddMarkupContent(52, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(53);
                    __builder3.AddAttribute(54, "Text", "Unit Fk");
                    __builder3.AddAttribute(55, "Component", "Unit_FK");
                    __builder3.AddAttribute(56, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "col-md-9");
                    __builder3.AddMarkupContent(61, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(62);
                    __builder3.AddAttribute(63, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 32 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblIcUnit.razor"
                                          20

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(64, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(65, "Name", "Unit_FK");
                    __builder3.AddAttribute(66, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 32 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblIcUnit.razor"
                                                                                                 tblicunit.Unit_FK

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(67, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblicunit.Unit_FK = __value, tblicunit.Unit_FK))));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(69);
                    __builder3.AddAttribute(70, "Component", "Unit_FK");
                    __builder3.AddAttribute(71, "Text", "Unit_FK is required");
                    __builder3.AddAttribute(72, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\n            ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "class", "row");
                    __builder3.AddMarkupContent(78, "\n              ");
                    __builder3.OpenElement(79, "div");
                    __builder3.AddAttribute(80, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(81, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(82);
                    __builder3.AddAttribute(83, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 40 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblIcUnit.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(84, "Icon", "save");
                    __builder3.AddAttribute(85, "Text", "Save");
                    __builder3.AddAttribute(86, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 40 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblIcUnit.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(88);
                    __builder3.AddAttribute(89, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 42 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblIcUnit.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(90, "Text", "Cancel");
                    __builder3.AddAttribute(91, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 42 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblIcUnit.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(92, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(93, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(94, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(95, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
