#pragma checksum "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57d01bf194094e5d9d31452e5f77700b84da2186"
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
#line 5 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
using QuanLyBanHang.Models.OtErp;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-gn-payment-type")]
    public class AddTblGnPaymentType : QuanLyBanHang.Pages.AddTblGnPaymentTypeComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<TblGnPaymentType>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TblGnPaymentType>(
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                                 tblgnpaymenttype

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                                                               tblgnpaymenttype != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TblGnPaymentType>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TblGnPaymentType>(this, 
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
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
                    __builder3.AddAttribute(24, "Text", "Payment Type Id");
                    __builder3.AddAttribute(25, "Component", "PaymentType_ID");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(27, (__value) => {
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
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
#line 20 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                                               20

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(35, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(36, "Name", "PaymentType_ID");
                    __builder3.AddComponentReferenceCapture(37, (__value) => {
#line 20 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                     paymentTypeId = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(39);
                    __builder3.AddAttribute(40, "Component", "PaymentType_ID");
                    __builder3.AddAttribute(41, "Text", "PaymentType_ID is required");
                    __builder3.AddAttribute(42, "style", "position: absolute");
                    __builder3.AddComponentReferenceCapture(43, (__value) => {
#line 22 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                               paymentTypeIdRequiredValidator = (Radzen.Blazor.RadzenRequiredValidator)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\n            ");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(49, "class", "row");
                    __builder3.AddMarkupContent(50, "\n              ");
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "class", "col-md-3");
                    __builder3.AddMarkupContent(53, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(54);
                    __builder3.AddAttribute(55, "Text", "Payment Type Text");
                    __builder3.AddAttribute(56, "Component", "PaymentTypeText");
                    __builder3.AddAttribute(57, "style", "width: 100%");
                    __builder3.AddComponentReferenceCapture(58, (__value) => {
#line 28 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                   label2 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(60, "\n              ");
                    __builder3.OpenElement(61, "div");
                    __builder3.AddAttribute(62, "class", "col-md-9");
                    __builder3.AddMarkupContent(63, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(64);
                    __builder3.AddAttribute(65, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 32 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                                                 50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(66, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(67, "Name", "PaymentTypeText");
                    __builder3.AddComponentReferenceCapture(68, (__value) => {
#line 32 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                     paymentTypeText = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(70);
                    __builder3.AddAttribute(71, "Component", "PaymentTypeText");
                    __builder3.AddAttribute(72, "Text", "PaymentTypeText is required");
                    __builder3.AddAttribute(73, "style", "position: absolute");
                    __builder3.AddComponentReferenceCapture(74, (__value) => {
#line 34 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                               paymentTypeTextRequiredValidator = (Radzen.Blazor.RadzenRequiredValidator)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\n            ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "class", "row");
                    __builder3.AddMarkupContent(80, "\n              ");
                    __builder3.OpenElement(81, "div");
                    __builder3.AddAttribute(82, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(83, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(84);
                    __builder3.AddAttribute(85, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 40 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                                         ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(86, "Icon", "save");
                    __builder3.AddAttribute(87, "Text", "Save");
                    __builder3.AddAttribute(88, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 40 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                                                                                                 ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddComponentReferenceCapture(89, (__value) => {
#line 40 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                    button1 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(90, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(91);
                    __builder3.AddAttribute(92, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 42 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                                          ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(93, "Text", "Cancel");
                    __builder3.AddAttribute(94, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 42 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                                                                                   Button2Click

#line default
#line hidden
                    )));
                    __builder3.AddComponentReferenceCapture(95, (__value) => {
#line 42 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                    button2 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(97, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(98, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(99, (__value) => {
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                  form0 = (Radzen.Blazor.RadzenTemplateForm<TblGnPaymentType>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(103, (__value) => {
#line 8 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
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
