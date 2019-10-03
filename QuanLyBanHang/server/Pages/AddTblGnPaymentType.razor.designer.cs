using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using QuanLyBanHang.Models.OtErp;

namespace QuanLyBanHang.Pages
{
    public partial class AddTblGnPaymentTypeComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected OtErpService OtErp { get; set; }


        protected RadzenContent content1;

        protected RadzenTemplateForm<TblGnPaymentType> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox paymentTypeId;

        protected RadzenRequiredValidator paymentTypeIdRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenTextBox paymentTypeText;

        protected RadzenRequiredValidator paymentTypeTextRequiredValidator;

        protected RadzenButton button1;

        protected RadzenButton button2;

        TblGnPaymentType _tblgnpaymenttype;
        protected TblGnPaymentType tblgnpaymenttype
        {
            get
            {
                return _tblgnpaymenttype;
            }
            set
            {
                if(_tblgnpaymenttype != value)
                {
                    _tblgnpaymenttype = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            tblgnpaymenttype = new TblGnPaymentType();
        }

        protected async void Form0Submit(TblGnPaymentType args)
        {
            try
            {
                var otErpCreateTblGnPaymentTypeResult = await OtErp.CreateTblGnPaymentType(tblgnpaymenttype);
                DialogService.Close(tblgnpaymenttype);
            }
            catch (Exception otErpCreateTblGnPaymentTypeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblGnPaymentType!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
