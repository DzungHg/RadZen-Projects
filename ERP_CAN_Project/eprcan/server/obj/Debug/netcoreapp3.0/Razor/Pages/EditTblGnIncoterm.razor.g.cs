#pragma checksum "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faf01dbe95c8a095f074dfac000e3d807ec1a012"
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
#line 5 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-tbl-gn-incoterm/{Incoterm_ID}")]
    public class EditTblGnIncoterm : ErpCan.Pages.EditTblGnIncotermComponent
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
#line 12 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                                                                                             !canEdit

#line default
#line hidden
                ));
                __builder2.AddComponentReferenceCapture(15, (__value) => {
#line 12 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
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
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                                      ButtonStyle.Secondary

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(24, "Text", "Close");
                __builder2.AddAttribute(25, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                                                                                                                 !canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(26, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                                                                                                                                    CloseButtonClick

#line default
#line hidden
                )));
                __builder2.AddComponentReferenceCapture(27, (__value) => {
#line 16 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblGnIncoterm>>(37);
                __builder2.AddAttribute(38, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ErpCan.Models.CanErpDbAt132.TblGnIncoterm>(
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                                                                                   tblgnincoterm

#line default
#line hidden
                ));
                __builder2.AddAttribute(39, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                                                                                                              tblgnincoterm != null && canEdit

#line default
#line hidden
                ));
                __builder2.AddAttribute(40, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblGnIncoterm>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblGnIncoterm>(this, 
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
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
                    __builder3.AddAttribute(51, "Text", "Incoterm Id");
                    __builder3.AddAttribute(52, "Component", "Incoterm_ID");
                    __builder3.AddAttribute(53, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(54, (__value) => {
#line 26 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
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
#line 30 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                                            3

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(62, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 30 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                                                                                            $"{tblgnincoterm.Incoterm_ID}"

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(64, "Name", "Incoterm_ID");
                    __builder3.AddComponentReferenceCapture(65, (__value) => {
#line 30 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                     incotermId = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(67);
                    __builder3.AddAttribute(68, "Component", "Incoterm_ID");
                    __builder3.AddAttribute(69, "Text", "Incoterm_ID is required");
                    __builder3.AddAttribute(70, "style", "position: absolute");
                    __builder3.AddComponentReferenceCapture(71, (__value) => {
#line 32 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                               incotermIdRequiredValidator = (Radzen.Blazor.RadzenRequiredValidator)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\n            ");
                    __builder3.OpenElement(75, "div");
                    __builder3.AddAttribute(76, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(77, "class", "row");
                    __builder3.AddMarkupContent(78, "\n              ");
                    __builder3.OpenElement(79, "div");
                    __builder3.AddAttribute(80, "class", "col-md-3");
                    __builder3.AddMarkupContent(81, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(82);
                    __builder3.AddAttribute(83, "Text", "Incoterm Name");
                    __builder3.AddAttribute(84, "Component", "Incoterm_Name");
                    __builder3.AddAttribute(85, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(86, (__value) => {
#line 38 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                   label3 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(88, "\n              ");
                    __builder3.OpenElement(89, "div");
                    __builder3.AddAttribute(90, "class", "col-md-9");
                    __builder3.AddMarkupContent(91, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(92);
                    __builder3.AddAttribute(93, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 42 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                                              15

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(94, "style", "width: 100%");
                    __builder3.AddAttribute(95, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 42 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                                                                               $"{tblgnincoterm.Incoterm_Name}"

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(96, "Name", "Incoterm_Name");
                    __builder3.AddComponentReferenceCapture(97, (__value) => {
#line 42 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                     incotermName = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(98, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(99, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(100, "\n            ");
                    __builder3.OpenElement(101, "div");
                    __builder3.AddAttribute(102, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(103, "class", "row");
                    __builder3.AddMarkupContent(104, "\n              ");
                    __builder3.OpenElement(105, "div");
                    __builder3.AddAttribute(106, "class", "col-md-3");
                    __builder3.AddMarkupContent(107, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(108);
                    __builder3.AddAttribute(109, "Text", "Description");
                    __builder3.AddAttribute(110, "Component", "Description");
                    __builder3.AddAttribute(111, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(112, (__value) => {
#line 48 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                   label4 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(113, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(114, "\n              ");
                    __builder3.OpenElement(115, "div");
                    __builder3.AddAttribute(116, "class", "col-md-9");
                    __builder3.AddMarkupContent(117, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(118);
                    __builder3.AddAttribute(119, "style", "width: 100%");
                    __builder3.AddAttribute(120, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 52 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                                                               $"{tblgnincoterm.Description}"

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(121, "Name", "Description");
                    __builder3.AddComponentReferenceCapture(122, (__value) => {
#line 52 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                     description = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(123, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(124, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(125, "\n            ");
                    __builder3.OpenElement(126, "div");
                    __builder3.AddAttribute(127, "class", "row");
                    __builder3.AddMarkupContent(128, "\n              ");
                    __builder3.OpenElement(129, "div");
                    __builder3.AddAttribute(130, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(131, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(132);
                    __builder3.AddAttribute(133, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 58 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                                         ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(134, "Icon", "save");
                    __builder3.AddAttribute(135, "Text", "Save");
                    __builder3.AddAttribute(136, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 58 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                                                                                                 ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddComponentReferenceCapture(137, (__value) => {
#line 58 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                    button2 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(138, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(139);
                    __builder3.AddAttribute(140, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 60 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                                          ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(141, "Text", "Cancel");
                    __builder3.AddAttribute(142, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 60 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                                                                                   Button3Click

#line default
#line hidden
                    )));
                    __builder3.AddComponentReferenceCapture(143, (__value) => {
#line 60 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                    button3 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(144, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(145, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(146, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(147, (__value) => {
#line 22 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
                                  form0 = (Radzen.Blazor.RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblGnIncoterm>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(148, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(150, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(151, (__value) => {
#line 8 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\EditTblGnIncoterm.razor"
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
