#pragma checksum "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c24f35516c6d1700dedf3faa6800d9858e4ffe5"
// <auto-generated/>
#pragma warning disable 1591
namespace ErpCan.Shared
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
#line 3 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Shared\MainLayout.razor"
using Radzen;

#line default
#line hidden
#line 4 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Shared\MainLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 5 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Shared\MainLayout.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    public class MainLayout : ErpCan.Layouts.MainLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenHeader>(4);
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row justify-content-start align-items-center");
                __builder2.AddMarkupContent(9, "\n      ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-6 d-flex align-items-center");
                __builder2.AddMarkupContent(12, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSidebarToggle>(13);
                __builder2.AddAttribute(14, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.EventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#line 13 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Shared\MainLayout.razor"
                                     SidebarToggle0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(16);
                __builder2.AddAttribute(17, "Text", "ErpCan");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n      ");
                __builder2.AddMarkupContent(20, "<div class=\"col-md-6 text-lg-right\">\n      </div>\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n  ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(23);
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenContentContainer>(26);
                __builder2.AddAttribute(27, "style", "height: 21px");
                __builder2.AddAttribute(28, "Name", "contentContainer0");
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(30, "\n    ");
                    __builder3.AddContent(31, 
#line 26 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Shared\MainLayout.razor"
     Body

#line default
#line hidden
                    );
                    __builder3.AddMarkupContent(32, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(34, (__value) => {
#line 23 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Shared\MainLayout.razor"
                  body0 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenSidebar>(36);
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(38, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(39);
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(41, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(42);
                    __builder3.AddAttribute(43, "Text", "Thu Mua");
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(45, "\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(46);
                        __builder4.AddAttribute(47, "Path", "tbl-po-purchase-orders");
                        __builder4.AddAttribute(48, "Text", "PO");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(49, "\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(50);
                        __builder4.AddAttribute(51, "Path", "tbl-po-vendors");
                        __builder4.AddAttribute(52, "Text", "Vendor");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(53, "\n          ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\n      ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(56);
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(58, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(59);
                    __builder3.AddAttribute(60, "Text", "Tồn kho");
                    __builder3.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(62, "\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(63);
                        __builder4.AddAttribute(64, "Path", "tbl-ic-inventories");
                        __builder4.AddAttribute(65, "Text", "Bảng Tồn Kho");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(66, "\n          ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\n      ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(69);
                __builder2.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(71, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(72);
                    __builder3.AddAttribute(73, "Text", "Liên hệ");
                    __builder3.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(75, "\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(76);
                        __builder4.AddAttribute(77, "Path", "tbl-gn-address-books");
                        __builder4.AddAttribute(78, "Text", "DS Liên Hệ");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(79, "\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(80);
                        __builder4.AddAttribute(81, "Path", "tbl-gn-cities");
                        __builder4.AddAttribute(82, "Text", "Tỉnh Thành");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(83, "\n          ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\n      ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(86);
                __builder2.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(88, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(89);
                    __builder3.AddAttribute(90, "Text", "Cài đặt");
                    __builder3.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(92, "\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(93);
                        __builder4.AddAttribute(94, "Path", "tbl-ic-categories");
                        __builder4.AddAttribute(95, "Text", "DM Tồn Kho");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(96, "\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(97);
                        __builder4.AddAttribute(98, "Path", "tbl-ic-classifications");
                        __builder4.AddAttribute(99, "Text", "P. Loại Tồn Kho");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(100, "\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(101);
                        __builder4.AddAttribute(102, "Path", "tbl-ic-warehouses");
                        __builder4.AddAttribute(103, "Text", "DS Kho");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(104, "\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(105);
                        __builder4.AddAttribute(106, "Path", "tbl-gn-incoterms");
                        __builder4.AddAttribute(107, "Text", "Incoterm");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(108, "\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(109);
                        __builder4.AddAttribute(110, "Path", "tbl-gn-payment-terms");
                        __builder4.AddAttribute(111, "Text", "ĐK Thanh Toán");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(112, "\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(113);
                        __builder4.AddAttribute(114, "Path", "tbl-gn-payment-types");
                        __builder4.AddAttribute(115, "Text", "Kiểu Thanh Toán");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(116, "\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(117);
                        __builder4.AddAttribute(118, "Path", "tbl-gn-ship-via");
                        __builder4.AddAttribute(119, "Text", "Ship Via");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(120, "\n          ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(121, "\n      ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(122, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(123, (__value) => {
#line 30 "C:\ZDung HDD\GitHub\RadZen-Projects\ERP_CAN_Project\eprcan\server\Shared\MainLayout.razor"
                     sidebar0 = (Radzen.Blazor.RadzenSidebar)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(124, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenFooter>(125);
            __builder.AddAttribute(126, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(127, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(128);
                __builder2.AddAttribute(129, "Text", "ErpCan, Copyright © 2019");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(130, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
