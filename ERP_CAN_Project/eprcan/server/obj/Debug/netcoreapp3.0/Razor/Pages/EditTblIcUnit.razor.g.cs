#pragma checksum "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d3ebb83cb9ba483de27c769df2c95c457223ac7"
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
#line 5 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-tbl-ic-unit/{Unit_SEQ}")]
    public class EditTblIcUnit : ErpCan.Pages.EditTblIcUnitComponent
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
#line 12 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
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
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(23, "Text", "Close");
                __builder2.AddAttribute(24, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
                                                                                                              !canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblIcUnit>>(35);
                __builder2.AddAttribute(36, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ErpCan.Models.CanErpDbAt132.TblIcUnit>(
#line 22 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
                                                                                  tblicunit

#line default
#line hidden
                ));
                __builder2.AddAttribute(37, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
                                                                                                         tblicunit != null && canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(38, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblIcUnit>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblIcUnit>(this, 
#line 22 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
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
                    __builder3.AddAttribute(49, "Text", "Unit Text");
                    __builder3.AddAttribute(50, "Component", "UnitText");
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
#line 30 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
                                          25

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(59, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(60, "Name", "UnitText");
                    __builder3.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 30 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
                                                                                                 tblicunit.UnitText

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblicunit.UnitText = __value, tblicunit.UnitText))));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(64);
                    __builder3.AddAttribute(65, "Component", "UnitText");
                    __builder3.AddAttribute(66, "Text", "UnitText is required");
                    __builder3.AddAttribute(67, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(69, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\n            ");
                    __builder3.OpenElement(71, "div");
                    __builder3.AddAttribute(72, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(73, "class", "row");
                    __builder3.AddMarkupContent(74, "\n              ");
                    __builder3.OpenElement(75, "div");
                    __builder3.AddAttribute(76, "class", "col-md-3");
                    __builder3.AddMarkupContent(77, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(78);
                    __builder3.AddAttribute(79, "Text", "Unit Fk");
                    __builder3.AddAttribute(80, "Component", "Unit_FK");
                    __builder3.AddAttribute(81, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(82, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\n              ");
                    __builder3.OpenElement(84, "div");
                    __builder3.AddAttribute(85, "class", "col-md-9");
                    __builder3.AddMarkupContent(86, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(87);
                    __builder3.AddAttribute(88, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 42 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
                                          20

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(89, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(90, "Name", "Unit_FK");
                    __builder3.AddAttribute(91, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 42 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
                                                                                                 tblicunit.Unit_FK

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(92, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblicunit.Unit_FK = __value, tblicunit.Unit_FK))));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(94);
                    __builder3.AddAttribute(95, "Component", "Unit_FK");
                    __builder3.AddAttribute(96, "Text", "Unit_FK is required");
                    __builder3.AddAttribute(97, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(98, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(99, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(100, "\n            ");
                    __builder3.OpenElement(101, "div");
                    __builder3.AddAttribute(102, "class", "row");
                    __builder3.AddMarkupContent(103, "\n              ");
                    __builder3.OpenElement(104, "div");
                    __builder3.AddAttribute(105, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(106, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(107);
                    __builder3.AddAttribute(108, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 50 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(109, "Icon", "save");
                    __builder3.AddAttribute(110, "Text", "Save");
                    __builder3.AddAttribute(111, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 50 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(112, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(113);
                    __builder3.AddAttribute(114, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 52 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(115, "Text", "Cancel");
                    __builder3.AddAttribute(116, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 52 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblIcUnit.razor"
                                                                                    Button3Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(117, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(118, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(119, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(120, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
