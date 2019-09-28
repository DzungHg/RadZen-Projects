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
    public partial class EditTblGnPaymentTermComponent : ComponentBase
    {
        [Inject]
        protected IUriHelper UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected OtErpService OtErp { get; set; }


        [Parameter]
        public string PaymentTerm_SEQ { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<TblGnPaymentTerm> form0;

        protected RadzenLabel label2;

        protected RadzenTextBox paymentTermId;

        protected RadzenRequiredValidator paymentTermIdRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenTextBox paymentTermText;

        protected RadzenRequiredValidator paymentTermTextRequiredValidator;

        protected RadzenButton button2;

        protected RadzenButton button3;

        bool _canEdit;
        protected bool canEdit
        {
            get
            {
                return _canEdit;
            }
            set
            {
                if(_canEdit != value)
                {
                    _canEdit = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

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
            canEdit = true;

            try
            {
                var otErpGetTblGnPaymentTermByPaymentTermSeqResult = await OtErp.GetTblGnPaymentTermByPaymentTermSeq(int.Parse(PaymentTerm_SEQ));
                tblgnpaymentterm = otErpGetTblGnPaymentTermByPaymentTermSeqResult;
            }
            catch (Exception otErpGetTblGnPaymentTermByPaymentTermSeqException)
            {

            }
        }

        protected async void CloseButtonClick(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(TblGnPaymentTerm args)
        {
            try
            {
                var otErpUpdateTblGnPaymentTermResult = await OtErp.UpdateTblGnPaymentTerm(int.Parse(PaymentTerm_SEQ), tblgnpaymentterm);
                DialogService.Close(tblgnpaymentterm);
            }
            catch (Exception otErpUpdateTblGnPaymentTermException)
            {
                NotificationService.Notify(new NotificationMessage() { Severity = "error", Summary = $"Error", Detail = $"Unable to update TblGnPaymentTerm" });
            }
        }

        protected async void Button3Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
