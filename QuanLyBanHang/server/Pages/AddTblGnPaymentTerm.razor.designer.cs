using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using QuanLyBanHang.Models.OtErp;

namespace QuanLyBanHang.Pages
{
    public partial class AddTblGnPaymentTermComponent : ComponentBase
    {
        [Inject]
        protected IUriHelper UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected OtErpService OtErp { get; set; }


        protected RadzenContent content1;

        protected RadzenTemplateForm<TblGnPaymentTerm> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox paymentTermText;

        protected RadzenRequiredValidator paymentTermTextRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenTextBox paymentTermId;

        protected RadzenRequiredValidator paymentTermIdRequiredValidator;

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

        protected override async Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            tblgnpaymentterm = new TblGnPaymentTerm();
        }

        protected async void Form0Submit(TblGnPaymentTerm args)
        {
            var otErpCreateTblGnPaymentTermResult = await OtErp.CreateTblGnPaymentTerm(tblgnpaymentterm);
            DialogService.Close(tblgnpaymentterm);
        }

        protected async void Button2Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
