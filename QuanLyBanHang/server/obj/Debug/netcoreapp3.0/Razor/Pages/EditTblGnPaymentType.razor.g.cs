#pragma checksum "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ed3d8d4c9898d5df5ef2c5e8ddfdf1fb73cd5a4"
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
#line 5 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
using QuanLyBanHang.Models.OtErp;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-tbl-gn-payment-type/{PaymentType_SEQ}")]
    public class EditTblGnPaymentType : QuanLyBanHang.Pages.EditTblGnPaymentTypeComponent
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
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
                                                                                                                                !canEdit

#line default
#line hidden
                ));
                builder2.AddComponentReferenceCapture(15, (__value) => {
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
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
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
                                                                                                                                        !canEdit

#line default
#line hidden
                ));
                builder2.AddAttribute(26, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIMouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
                                                                                                                                                           CloseButtonClick

#line default
#line hidden
                )));
                builder2.AddComponentReferenceCapture(27, (__value) => {
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
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
                builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<TblGnPaymentType>>(37);
                builder2.AddAttribute(38, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TblGnPaymentType>(
#line 22 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
                                                                    tblgnpaymenttype

#line default
#line hidden
                ));
                builder2.AddAttribute(39, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
                                                                                                  tblgnpaymenttype != null && canEdit

#line default
#line hidden
                ));
                builder2.AddAttribute(40, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TblGnPaymentType>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TblGnPaymentType>(this, 
#line 22 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
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
                    builder3.AddAttribute(51, "Text", "Payment Type Id");
                    builder3.AddAttribute(52, "Component", "PaymentType_ID");
                    builder3.AddAttribute(53, "style", "width: 100%");
                    builder3.AddComponentReferenceCapture(54, (__value) => {
#line 26 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
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
#line 30 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
                                                                                  20

#line default
#line hidden
                    ));
                    builder3.AddAttribute(62, "style", "display: block; width: 100%");
                    builder3.AddAttribute(63, "Name", "PaymentType_ID");
                    builder3.AddComponentReferenceCapture(64, (__value) => {
#line 30 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
                                     paymentTypeId = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(65, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(66);
                    builder3.AddAttribute(67, "Component", "PaymentType_ID");
                    builder3.AddAttribute(68, "Text", "PaymentType_ID is required");
                    builder3.AddAttribute(69, "style", "position: absolute");
                    builder3.AddComponentReferenceCapture(70, (__value) => {
#line 32 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
                                               paymentTypeIdRequiredValidator = (Radzen.Blazor.RadzenRequiredValidator)__value;

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
                    builder3.AddAttribute(82, "Text", "Payment Type Text");
                    builder3.AddAttribute(83, "Component", "PaymentTypeText");
                    builder3.AddAttribute(84, "style", "width: 100%");
                    builder3.AddComponentReferenceCapture(85, (__value) => {
#line 38 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
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
#line 42 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
                                                                                    50

#line default
#line hidden
                    ));
                    builder3.AddAttribute(93, "style", "display: block; width: 100%");
                    builder3.AddAttribute(94, "Name", "PaymentTypeText");
                    builder3.AddComponentReferenceCapture(95, (__value) => {
#line 42 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
                                     paymentTypeText = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(96, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(97);
                    builder3.AddAttribute(98, "Component", "PaymentTypeText");
                    builder3.AddAttribute(99, "Text", "PaymentTypeText is required");
                    builder3.AddAttribute(100, "style", "position: absolute");
                    builder3.AddComponentReferenceCapture(101, (__value) => {
#line 44 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
                                               paymentTypeTextRequiredValidator = (Radzen.Blazor.RadzenRequiredValidator)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(102, "\n              ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(103, "\n            ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(104, "\n            ");
                    builder3.OpenElement(105, "div");
                    builder3.AddAttribute(106, "class", "row");
                    builder3.AddMarkupContent(107, "\n              ");
                    builder3.OpenElement(108, "div");
                    builder3.AddAttribute(109, "class", "col offset-sm-3");
                    builder3.AddMarkupContent(110, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenButton>(111);
                    builder3.AddAttribute(112, "ButtonType", "submit");
                    builder3.AddAttribute(113, "Icon", "save");
                    builder3.AddAttribute(114, "Text", "Save");
                    builder3.AddAttribute(115, "ButtonStyle", "primary");
                    builder3.AddComponentReferenceCapture(116, (__value) => {
#line 50 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
                                    button2 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(117, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenButton>(118);
                    builder3.AddAttribute(119, "ButtonStyle", "light");
                    builder3.AddAttribute(120, "Text", "Cancel");
                    builder3.AddAttribute(121, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIMouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 52 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
                                                                                                          Button3Click

#line default
#line hidden
                    )));
                    builder3.AddComponentReferenceCapture(122, (__value) => {
#line 52 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
                                    button3 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(123, "\n              ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(124, "\n            ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(125, "\n          ");
                }
                ));
                builder2.AddComponentReferenceCapture(126, (__value) => {
#line 22 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
                                  form0 = (Radzen.Blazor.RadzenTemplateForm<TblGnPaymentType>)__value;

#line default
#line hidden
                }
                );
                builder2.CloseComponent();
                builder2.AddMarkupContent(127, "\n      ");
                builder2.CloseElement();
                builder2.AddMarkupContent(128, "\n    ");
                builder2.CloseElement();
                builder2.AddMarkupContent(129, "\n  ");
            }
            ));
            builder.AddComponentReferenceCapture(130, (__value) => {
#line 8 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\EditTblGnPaymentType.razor"
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
