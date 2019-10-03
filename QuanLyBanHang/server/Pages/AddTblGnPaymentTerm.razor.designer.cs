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
    public partial class AddTblGnPaymentTermComponent : ComponentBase
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

        protected RadzenTemplateForm<TblGnPaymentTerm> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox paymentTermId;

        protected RadzenRequiredValidator paymentTermIdRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenTextBox paymentTermText;

        protected RadzenRequiredValidator paymentTermTextRequiredValidator;

        protected RadzenButton button1;

        protected RadzenButton button2;

        TblGnPaymentTerm _tblgnpaymentterm;
        protected TblGnPaymentTerm tblgnpaymentterm
        {
            get
            {
                return _tblgnpaymentterm;
            }
            set
            {
                if(_tblgnpaymentterm != value)
                {
                    _tblgnpaymentterm = value;
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
            tblgnpaymentterm = new TblGnPaymentTerm();
        }

        protected async void Form0Submit(TblGnPaymentTerm args)
        {
            try
            {
                var otErpCreateTblGnPaymentTermResult = await OtErp.CreateTblGnPaymentTerm(tblgnpaymentterm);
                DialogService.Close(tblgnpaymentterm);
            }
            catch (Exception otErpCreateTblGnPaymentTermException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblGnPaymentTerm!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
