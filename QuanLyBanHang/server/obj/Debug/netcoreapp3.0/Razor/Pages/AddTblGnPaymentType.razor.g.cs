#pragma checksum "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd38a0703bd9bb663bdc798daf9e20b20cd80ca8"
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
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            builder.AddAttribute(1, "Container", "main");
            builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(3, "\n    ");
                builder2.OpenElement(4, "div");
                builder2.AddAttribute(5, "class", "row");
                builder2.AddMarkupContent(6, "\n      ");
                builder2.OpenElement(7, "div");
                builder2.AddAttribute(8, "class", "col-md-12");
                builder2.AddMarkupContent(9, "\n        ");
                builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<TblGnPaymentType>>(10);
                builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TblGnPaymentType>(
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                                                    tblgnpaymenttype

#line default
#line hidden
                ));
                builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                                                                                  tblgnpaymenttype != null

#line default
#line hidden
                ));
                builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TblGnPaymentType>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TblGnPaymentType>(this, 
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                                                                                                                                               Form0Submit

#line default
#line hidden
                )));
                builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder3) => {
                    builder3.AddMarkupContent(15, "\n            ");
                    builder3.OpenElement(16, "div");
                    builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    builder3.AddAttribute(18, "class", "row");
                    builder3.AddMarkupContent(19, "\n              ");
                    builder3.OpenElement(20, "div");
                    builder3.AddAttribute(21, "class", "col-md-3");
                    builder3.AddMarkupContent(22, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    builder3.AddAttribute(24, "Text", "Payment Type Id");
                    builder3.AddAttribute(25, "Component", "PaymentType_ID");
                    builder3.AddAttribute(26, "style", "width: 100%");
                    builder3.AddComponentReferenceCapture(27, (__value) => {
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                   label1 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(28, "\n              ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(29, "\n              ");
                    builder3.OpenElement(30, "div");
                    builder3.AddAttribute(31, "class", "col-md-9");
                    builder3.AddMarkupContent(32, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(33);
                    builder3.AddAttribute(34, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 20 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                                                                  20

#line default
#line hidden
                    ));
                    builder3.AddAttribute(35, "style", "display: block; width: 100%");
                    builder3.AddAttribute(36, "Name", "PaymentType_ID");
                    builder3.AddComponentReferenceCapture(37, (__value) => {
#line 20 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                     paymentTypeId = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(38, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(39);
                    builder3.AddAttribute(40, "Component", "PaymentType_ID");
                    builder3.AddAttribute(41, "Text", "PaymentType_ID is required");
                    builder3.AddAttribute(42, "style", "position: absolute");
                    builder3.AddComponentReferenceCapture(43, (__value) => {
#line 22 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                               paymentTypeIdRequiredValidator = (Radzen.Blazor.RadzenRequiredValidator)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(44, "\n              ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(45, "\n            ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(46, "\n            ");
                    builder3.OpenElement(47, "div");
                    builder3.AddAttribute(48, "style", "margin-bottom: 1rem");
                    builder3.AddAttribute(49, "class", "row");
                    builder3.AddMarkupContent(50, "\n              ");
                    builder3.OpenElement(51, "div");
                    builder3.AddAttribute(52, "class", "col-md-3");
                    builder3.AddMarkupContent(53, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(54);
                    builder3.AddAttribute(55, "Text", "Payment Type Text");
                    builder3.AddAttribute(56, "Component", "PaymentTypeText");
                    builder3.AddAttribute(57, "style", "width: 100%");
                    builder3.AddComponentReferenceCapture(58, (__value) => {
#line 28 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                   label2 = (Radzen.Blazor.RadzenLabel)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(59, "\n              ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(60, "\n              ");
                    builder3.OpenElement(61, "div");
                    builder3.AddAttribute(62, "class", "col-md-9");
                    builder3.AddMarkupContent(63, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(64);
                    builder3.AddAttribute(65, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 32 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                                                                    50

#line default
#line hidden
                    ));
                    builder3.AddAttribute(66, "style", "display: block; width: 100%");
                    builder3.AddAttribute(67, "Name", "PaymentTypeText");
                    builder3.AddComponentReferenceCapture(68, (__value) => {
#line 32 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                     paymentTypeText = (Radzen.Blazor.RadzenTextBox)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(69, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(70);
                    builder3.AddAttribute(71, "Component", "PaymentTypeText");
                    builder3.AddAttribute(72, "Text", "PaymentTypeText is required");
                    builder3.AddAttribute(73, "style", "position: absolute");
                    builder3.AddComponentReferenceCapture(74, (__value) => {
#line 34 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                               paymentTypeTextRequiredValidator = (Radzen.Blazor.RadzenRequiredValidator)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(75, "\n              ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(76, "\n            ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(77, "\n            ");
                    builder3.OpenElement(78, "div");
                    builder3.AddAttribute(79, "class", "row");
                    builder3.AddMarkupContent(80, "\n              ");
                    builder3.OpenElement(81, "div");
                    builder3.AddAttribute(82, "class", "col offset-sm-3");
                    builder3.AddMarkupContent(83, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenButton>(84);
                    builder3.AddAttribute(85, "ButtonType", "submit");
                    builder3.AddAttribute(86, "Icon", "save");
                    builder3.AddAttribute(87, "Text", "Save");
                    builder3.AddAttribute(88, "ButtonStyle", "primary");
                    builder3.AddComponentReferenceCapture(89, (__value) => {
#line 40 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                    button1 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(90, "\n                ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenButton>(91);
                    builder3.AddAttribute(92, "ButtonStyle", "light");
                    builder3.AddAttribute(93, "Text", "Cancel");
                    builder3.AddAttribute(94, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIMouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 42 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                                                                                          Button2Click

#line default
#line hidden
                    )));
                    builder3.AddComponentReferenceCapture(95, (__value) => {
#line 42 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                    button2 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                    }
                    );
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(96, "\n              ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(97, "\n            ");
                    builder3.CloseElement();
                    builder3.AddMarkupContent(98, "\n          ");
                }
                ));
                builder2.AddComponentReferenceCapture(99, (__value) => {
#line 12 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
                                  form0 = (Radzen.Blazor.RadzenTemplateForm<TblGnPaymentType>)__value;

#line default
#line hidden
                }
                );
                builder2.CloseComponent();
                builder2.AddMarkupContent(100, "\n      ");
                builder2.CloseElement();
                builder2.AddMarkupContent(101, "\n    ");
                builder2.CloseElement();
                builder2.AddMarkupContent(102, "\n  ");
            }
            ));
            builder.AddComponentReferenceCapture(103, (__value) => {
#line 8 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\AddTblGnPaymentType.razor"
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
