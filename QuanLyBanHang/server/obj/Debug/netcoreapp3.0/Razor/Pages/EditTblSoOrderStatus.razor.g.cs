#pragma checksum "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16983d09d31329663f897850a81a32549f7a7ae0"
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
using Microsoft.JSInterop;

#line default
#line hidden
#line 5 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\_Imports.razor"
using QuanLyBanHang.Shared;

#line default
#line hidden
#line 5 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
using QuanLyBanHang.Models.OtErp;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-tbl-so-order-status/{SOStatus_SEQ}")]
    public class EditTblSoOrderStatus : QuanLyBanHang.Pages.EditTblSoOrderStatusComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            builder.AddAttribute(1, "Container", "main");
            builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(3, "\n    ");
                builder2.OpenElement(4, "div");
                builder2.AddAttribute(5, "style", true);
                builder2.AddAttribute(6, "class", "row");
                builder2.AddMarkupContent(7, "\n      ");
                builder2.OpenElement(8, "div");
                builder2.AddAttribute(9, "class", "col-md-9");
                builder2.AddMarkupContent(10, "\n        ");
                builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(11);
                builder2.AddAttribute(12, "style", "font-weight: bold");
                builder2.AddAttribute(13, "Text", "Item no longer available.");
                builder2.AddAttribute(14, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                                                                                                                !canEdit

#line default
#line hidden
                ));
                builder2.AddComponentReferenceCapture(15, (__value) => {
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                           closeLabel = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                }
                );
                builder2.CloseComponent();
                builder2.AddMarkupContent(16, "\n      ");
                builder2.CloseElement();
                builder2.AddMarkupContent(17, "\n      ");
                builder2.OpenElement(18, "div");
                builder2.AddAttribute(19, "class", "col-md-3");
                builder2.AddMarkupContent(20, "\n        ");
                builder2.OpenComponent<Radzen.Blazor.RadzenButton>(21);
                builder2.AddAttribute(22, "ButtonStyle", "secondary");
                builder2.AddAttribute(23, "style", "margin-bottom: 20px");
                builder2.AddAttribute(24, "Text", "Close");
                builder2.AddAttribute(25, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                                                                                                                        !canEdit

#line default
#line hidden
                ));
                builder2.AddAttribute(26, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIMouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                                                                                                                                           CloseButtonClick

#line default
#line hidden
                )));
                builder2.AddComponentReferenceCapture(27, (__value) => {
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                            closeButton = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                }
                );
                builder2.CloseComponent();
                builder2.AddMarkupContent(28, "\n      ");
                builder2.CloseElement();
                builder2.AddMarkupContent(29, "\n    ");
                builder2.CloseElement();
                builder2.AddMarkupContent(30, "\n    ");
                builder2.OpenElement(31, "div");
                builder2.AddAttribute(32, "class", "row");
                builder2.AddMarkupContent(33, "\n      ");
                builder2.OpenElement(34, "div");
                builder2.AddAttribute(35, "class", "col-md-12");
                builder2.AddMarkupContent(36, "\n        ");
                builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<TblSoOrderStatus>>(37);
                builder2.AddAttribute(38, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TblSoOrderStatus>(
#line 22 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                                                    tblsoorderstatus

#line default
#line hidden
                ));
                builder2.AddAttribute(39, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                                                                                  tblsoorderstatus != null && canEdit

#line default
#line hidden
                ));
                builder2.AddAttribute(40, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TblSoOrderStatus>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TblSoOrderStatus>(this, 
#line 22 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                                                                                                                                                          Form0Submit

#line default
#line hidden
                )));
                builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder3) => {
                    builder3.AddMarkupContent(42, "\n            ");
                    builder3.OpenElement(43, "div");
                    builder3.AddAttribute(44, "style", "margin-bottom: 1rem");
                    builder3.AddAttribute(45, "class", "row");
                    builder3.AddMarkupContent(46, "\n              ");
                    builder3.OpenElement(47, "div");
                    builder3.AddAttribute(48, "class", "col-md-3");
                    builder3.AddMarkupContent(49, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(50);
                    builder3.AddAttribute(51, "Text", "So Status Id");
                    builder3.AddAttribute(52, "Component", "SOStatus_ID");
                    builder3.AddAttribute(53, "style", "width: 100%");
                    builder3.AddComponentReferenceCapture(54, (__value) => {
#line 26 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                   label2 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(55, "\n              ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(56, "\n              ");
                    builder3.OpenElement(57, "div");
                    builder3.AddAttribute(58, "class", "col-md-9");
                    builder3.AddMarkupContent(59, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(60);
                    builder3.AddAttribute(61, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 30 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                                                               20

#line default
#line hidden
                    ));
                    builder3.AddAttribute(62, "style", "display: block; width: 100%");
                    builder3.AddAttribute(63, "Name", "SOStatus_ID");
                    builder3.AddComponentReferenceCapture(64, (__value) => {
#line 30 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                     soStatusId = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(65, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(66);
                    builder3.AddAttribute(67, "Component", "SOStatus_ID");
                    builder3.AddAttribute(68, "Text", "SOStatus_ID is required");
                    builder3.AddAttribute(69, "style", "position: absolute");
                    builder3.AddComponentReferenceCapture(70, (__value) => {
#line 32 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                               soStatusIdRequiredValidator = (Radzen.Blazor.RadzenRequiredValidator)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(71, "\n              ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(72, "\n            ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(73, "\n            ");
                    builder3.OpenElement(74, "div");
                    builder3.AddAttribute(75, "style", "margin-bottom: 1rem");
                    builder3.AddAttribute(76, "class", "row");
                    builder3.AddMarkupContent(77, "\n              ");
                    builder3.OpenElement(78, "div");
                    builder3.AddAttribute(79, "class", "col-md-3");
                    builder3.AddMarkupContent(80, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(81);
                    builder3.AddAttribute(82, "Text", "So Status Text");
                    builder3.AddAttribute(83, "Component", "SOStatusText");
                    builder3.AddAttribute(84, "style", "width: 100%");
                    builder3.AddComponentReferenceCapture(85, (__value) => {
#line 38 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                   label3 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(86, "\n              ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(87, "\n              ");
                    builder3.OpenElement(88, "div");
                    builder3.AddAttribute(89, "class", "col-md-9");
                    builder3.AddMarkupContent(90, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(91);
                    builder3.AddAttribute(92, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 42 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                                                                 50

#line default
#line hidden
                    ));
                    builder3.AddAttribute(93, "style", "width: 100%");
                    builder3.AddAttribute(94, "Name", "SOStatusText");
                    builder3.AddComponentReferenceCapture(95, (__value) => {
#line 42 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                     soStatusText = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(96, "\n              ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(97, "\n            ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(98, "\n            ");
                    builder3.OpenElement(99, "div");
                    builder3.AddAttribute(100, "style", "margin-bottom: 1rem");
                    builder3.AddAttribute(101, "class", "row");
                    builder3.AddMarkupContent(102, "\n              ");
                    builder3.OpenElement(103, "div");
                    builder3.AddAttribute(104, "class", "col-md-3");
                    builder3.AddMarkupContent(105, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(106);
                    builder3.AddAttribute(107, "Text", "Description");
                    builder3.AddAttribute(108, "Component", "Description");
                    builder3.AddAttribute(109, "style", "width: 100%");
                    builder3.AddComponentReferenceCapture(110, (__value) => {
#line 48 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                   label4 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(111, "\n              ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(112, "\n              ");
                    builder3.OpenElement(113, "div");
                    builder3.AddAttribute(114, "class", "col-md-9");
                    builder3.AddMarkupContent(115, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(116);
                    builder3.AddAttribute(117, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 52 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                                                                255

#line default
#line hidden
                    ));
                    builder3.AddAttribute(118, "style", "width: 100%");
                    builder3.AddAttribute(119, "Name", "Description");
                    builder3.AddComponentReferenceCapture(120, (__value) => {
#line 52 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                     description = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(121, "\n              ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(122, "\n            ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(123, "\n            ");
                    builder3.OpenElement(124, "div");
                    builder3.AddAttribute(125, "class", "row");
                    builder3.AddMarkupContent(126, "\n              ");
                    builder3.OpenElement(127, "div");
                    builder3.AddAttribute(128, "class", "col offset-sm-3");
                    builder3.AddMarkupContent(129, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenButton>(130);
                    builder3.AddAttribute(131, "ButtonType", "submit");
                    builder3.AddAttribute(132, "Icon", "save");
                    builder3.AddAttribute(133, "Text", "Save");
                    builder3.AddAttribute(134, "ButtonStyle", "primary");
                    builder3.AddComponentReferenceCapture(135, (__value) => {
#line 58 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                    button2 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(136, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenButton>(137);
                    builder3.AddAttribute(138, "ButtonStyle", "light");
                    builder3.AddAttribute(139, "Text", "Cancel");
                    builder3.AddAttribute(140, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIMouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 60 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                                                                                          Button3Click

#line default
#line hidden
                    )));
                    builder3.AddComponentReferenceCapture(141, (__value) => {
#line 60 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                    button3 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(142, "\n              ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(143, "\n            ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(144, "\n          ");
                }
                ));
                builder2.AddComponentReferenceCapture(145, (__value) => {
#line 22 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                                  form0 = (Radzen.Blazor.RadzenTemplateForm<TblSoOrderStatus>)__value;

#line default
#line hidden
                }
                );
                builder2.CloseComponent();
                builder2.AddMarkupContent(146, "\n      ");
                builder2.CloseElement();
                builder2.AddMarkupContent(147, "\n    ");
                builder2.CloseElement();
                builder2.AddMarkupContent(148, "\n  ");
            }
            ));
            builder.AddComponentReferenceCapture(149, (__value) => {
#line 8 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblSoOrderStatus.razor"
                     content1 = (Radzen.Blazor.RadzenContent)__value;

#line default
#line hidden
            }
            );
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
