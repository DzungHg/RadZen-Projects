#pragma checksum "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblSoOrderDetailStatus.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff767ab727da6a911c7537d2d37766b4d3a78337"
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
#line 5 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblSoOrderDetailStatus.razor"
using Radzen;

#line default
#line hidden
#line 6 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblSoOrderDetailStatus.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblSoOrderDetailStatus.razor"
using ErpCan.Models.CanErpDbAt132;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-so-order-detail-status")]
    public class AddTblSoOrderDetailStatus : ErpCan.Pages.AddTblSoOrderDetailStatusComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus>(
#line 12 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblSoOrderDetailStatus.razor"
                                    tblsoorderdetailstatus

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblSoOrderDetailStatus.razor"
                                                                        tblsoorderdetailstatus != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus>(this, 
#line 12 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblSoOrderDetailStatus.razor"
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
                    __builder3.AddAttribute(24, "Text", "So Detail Status Id");
                    __builder3.AddAttribute(25, "Component", "SODetailStatus_ID");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __Blazor.ErpCan.Pages.AddTblSoOrderDetailStatus.TypeInference.CreateRadzenNumeric_0(__builder3, 32, 33, "width: 100%", 34, "SODetailStatus_ID", 35, 
#line 20 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblSoOrderDetailStatus.razor"
                                                                  (tblsoorderdetailstatus.SODetailStatus_ID)

#line default
#line hidden
                    , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (tblsoorderdetailstatus.SODetailStatus_ID) = __value, (tblsoorderdetailstatus.SODetailStatus_ID))));
                    __builder3.AddMarkupContent(37, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(38, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.OpenElement(40, "div");
                    __builder3.AddAttribute(41, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(42, "class", "row");
                    __builder3.AddMarkupContent(43, "\n              ");
                    __builder3.OpenElement(44, "div");
                    __builder3.AddAttribute(45, "class", "col-md-3");
                    __builder3.AddMarkupContent(46, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(47);
                    __builder3.AddAttribute(48, "Text", "So Detail Status Text");
                    __builder3.AddAttribute(49, "Component", "SODetailStatusText");
                    __builder3.AddAttribute(50, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(52, "\n              ");
                    __builder3.OpenElement(53, "div");
                    __builder3.AddAttribute(54, "class", "col-md-9");
                    __builder3.AddMarkupContent(55, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(56);
                    __builder3.AddAttribute(57, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 30 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblSoOrderDetailStatus.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(58, "style", "width: 100%");
                    __builder3.AddAttribute(59, "Name", "SODetailStatusText");
                    __builder3.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 30 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblSoOrderDetailStatus.razor"
                                                                                 (tblsoorderdetailstatus.SODetailStatusText)

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (tblsoorderdetailstatus.SODetailStatusText) = __value, (tblsoorderdetailstatus.SODetailStatusText)))));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(63, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(64, "\n            ");
                    __builder3.OpenElement(65, "div");
                    __builder3.AddAttribute(66, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(67, "class", "row");
                    __builder3.AddMarkupContent(68, "\n              ");
                    __builder3.OpenElement(69, "div");
                    __builder3.AddAttribute(70, "class", "col-md-3");
                    __builder3.AddMarkupContent(71, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(72);
                    __builder3.AddAttribute(73, "Text", "Description");
                    __builder3.AddAttribute(74, "Component", "Description");
                    __builder3.AddAttribute(75, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\n              ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "class", "col-md-9");
                    __builder3.AddMarkupContent(80, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(81);
                    __builder3.AddAttribute(82, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 40 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblSoOrderDetailStatus.razor"
                                          255

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(83, "style", "width: 100%");
                    __builder3.AddAttribute(84, "Name", "Description");
                    __builder3.AddAttribute(85, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 40 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblSoOrderDetailStatus.razor"
                                                                                  (tblsoorderdetailstatus.Description)

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(86, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (tblsoorderdetailstatus.Description) = __value, (tblsoorderdetailstatus.Description)))));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(88, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(89, "\n            ");
                    __builder3.OpenElement(90, "div");
                    __builder3.AddAttribute(91, "class", "row");
                    __builder3.AddMarkupContent(92, "\n              ");
                    __builder3.OpenElement(93, "div");
                    __builder3.AddAttribute(94, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(95, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(96);
                    __builder3.AddAttribute(97, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 46 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblSoOrderDetailStatus.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(98, "Icon", "save");
                    __builder3.AddAttribute(99, "Text", "Save");
                    __builder3.AddAttribute(100, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 46 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblSoOrderDetailStatus.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(102);
                    __builder3.AddAttribute(103, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 48 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblSoOrderDetailStatus.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(104, "Text", "Cancel");
                    __builder3.AddAttribute(105, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 48 "F:\GitHub02\RadZen-Projects\ERP_CAN_Project\eprcan\server\Pages\AddTblSoOrderDetailStatus.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(106, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(107, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(108, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(109, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ErpCan.Pages.AddTblSoOrderDetailStatus
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
