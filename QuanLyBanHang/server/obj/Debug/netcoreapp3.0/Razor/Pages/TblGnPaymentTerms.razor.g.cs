#pragma checksum "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3c7632ec7dcb2b11355454a45d70caef964158f"
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
#line 5 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
using QuanLyBanHang.Models.OtErp;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-gn-payment-terms")]
    public class TblGnPaymentTerms : QuanLyBanHang.Pages.TblGnPaymentTermsComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            builder.AddAttribute(1, "Container", "main");
            builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(3, "\n    ");
                builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                builder2.AddAttribute(5, "Size", "H1");
                builder2.AddAttribute(6, "Text", "Tbl Gn Payment Terms");
                builder2.AddComponentReferenceCapture(7, (__value) => {
#line 10 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
                         pageTitle = (Radzen.Blazor.RadzenHeading)__value;

#line default
#line hidden
                }
                );
                builder2.CloseComponent();
                builder2.AddMarkupContent(8, "\n    ");
                builder2.OpenElement(9, "div");
                builder2.AddAttribute(10, "class", "row");
                builder2.AddMarkupContent(11, "\n      ");
                builder2.OpenElement(12, "div");
                builder2.AddAttribute(13, "class", "col-md-12");
                builder2.AddMarkupContent(14, "\n        ");
                builder2.OpenComponent<Radzen.Blazor.RadzenButton>(15);
                builder2.AddAttribute(16, "Icon", "add_circle_outline");
                builder2.AddAttribute(17, "style", "margin-bottom: 10px");
                builder2.AddAttribute(18, "Text", "Add");
                builder2.AddAttribute(19, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIMouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 14 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
                                                                                                                                 Button0Click

#line default
#line hidden
                )));
                builder2.AddComponentReferenceCapture(20, (__value) => {
#line 14 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
                            button0 = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                }
                );
                builder2.CloseComponent();
                builder2.AddMarkupContent(21, "\n        ");
                builder2.OpenComponent<Radzen.Blazor.RadzenGrid<TblGnPaymentTerm>>(22);
                builder2.AddAttribute(23, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
                                                                    true

#line default
#line hidden
                ));
                builder2.AddAttribute(24, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
                                                                                       true

#line default
#line hidden
                ));
                builder2.AddAttribute(25, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
                                                                                                           true

#line default
#line hidden
                ));
                builder2.AddAttribute(26, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<TblGnPaymentTerm>>(
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
                                                                                                                         getTblGnPaymentTermsResult

#line default
#line hidden
                ));
                builder2.AddAttribute(27, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TblGnPaymentTerm>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TblGnPaymentTerm>(this, 
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
                                                                                                                                                                                           Grid0RowSelect

#line default
#line hidden
                )));
                builder2.AddAttribute(28, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((builder3) => {
                    builder3.AddMarkupContent(29, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblGnPaymentTerm>>(30);
                    builder3.AddAttribute(31, "Property", "PaymentTerm_SEQ");
                    builder3.AddAttribute(32, "Title", "Payment Term SEQ");
                    builder3.AddAttribute(33, "Type", "integer");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(34, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblGnPaymentTerm>>(35);
                    builder3.AddAttribute(36, "Property", "PaymentTermText");
                    builder3.AddAttribute(37, "Title", "Payment Term Text");
                    builder3.AddAttribute(38, "Type", "string");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(39, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblGnPaymentTerm>>(40);
                    builder3.AddAttribute(41, "Property", "PaymentTerm_ID");
                    builder3.AddAttribute(42, "Title", "Payment Term ID");
                    builder3.AddAttribute(43, "Type", "string");
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(44, "\n            ");
                    builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TblGnPaymentTerm>>(45);
                    builder3.AddAttribute(46, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 24 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
                                                                                              false

#line default
#line hidden
                    ));
                    builder3.AddAttribute(47, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 24 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
                                                                                                               false

#line default
#line hidden
                    ));
                    builder3.AddAttribute(48, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 24 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
                                                                                                                              false

#line default
#line hidden
                    ));
                    builder3.AddAttribute(49, "Width", "70px");
                    builder3.AddAttribute(50, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TblGnPaymentTerm>)((tblGnPaymentTerm) => (builder4) => {
                        builder4.AddMarkupContent(51, "\n                ");
                        builder4.OpenComponent<Radzen.Blazor.RadzenButton>(52);
                        builder4.AddAttribute(53, "ButtonStyle", "danger");
                        builder4.AddAttribute(54, "Icon", "close");
                        builder4.AddAttribute(55, "Size", "sm");
                        builder4.AddAttribute(56, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.UIMouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 26 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
                                                                                                                              (args) =>GridDeleteButtonClick(args, tblGnPaymentTerm)

#line default
#line hidden
                        )));
                        builder4.AddComponentReferenceCapture(57, (__value) => {
#line 26 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
                                    gridDeleteButton = (Radzen.Blazor.RadzenButton)__value;

#line default
#line hidden
                        }
                        );
                        builder4.CloseComponent();
                        builder4.AddMarkupContent(58, "\n              ");
                    }
                    ));
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(59, "\n          ");
                }
                ));
                builder2.AddComponentReferenceCapture(60, (__value) => {
#line 16 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<TblGnPaymentTerm>)__value;

#line default
#line hidden
                }
                );
                builder2.CloseComponent();
                builder2.AddMarkupContent(61, "\n      ");
                builder2.CloseElement();
                builder2.AddMarkupContent(62, "\n    ");
                builder2.CloseElement();
                builder2.AddMarkupContent(63, "\n  ");
            }
            ));
            builder.AddComponentReferenceCapture(64, (__value) => {
#line 8 "F:\GitHub02\RadZen-Projects\QuanLyBanHang\server\Pages\TblGnPaymentTerms.razor"
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
