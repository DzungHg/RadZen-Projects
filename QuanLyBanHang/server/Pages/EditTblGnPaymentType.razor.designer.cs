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
    public partial class EditTblGnPaymentTypeComponent : ComponentBase
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
        public string PaymentType_SEQ { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<TblGnPaymentType> form0;

        protected RadzenLabel label2;

        protected RadzenTextBox paymentTypeId;

        protected RadzenRequiredValidator paymentTypeIdRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenTextBox paymentTypeText;

        protected RadzenRequiredValidator paymentTypeTextRequiredValidator;

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

        protected override async Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            canEdit = true;

            try
            {
                var otErpGetTblGnPaymentTypeByPaymentTypeSeqResult = await OtErp.GetTblGnPaymentTypeByPaymentTypeSeq(int.Parse(PaymentType_SEQ));
                tblgnpaymenttype = otErpGetTblGnPaymentTypeByPaymentTypeSeqResult;
            }
            catch (Exception otErpGetTblGnPaymentTypeByPaymentTypeSeqException)
            {

            }
        }

        protected async void CloseButtonClick(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(TblGnPaymentType args)
        {
            try
            {
                var otErpUpdateTblGnPaymentTypeResult = await OtErp.UpdateTblGnPaymentType(int.Parse(PaymentType_SEQ), tblgnpaymenttype);
                DialogService.Close(tblgnpaymenttype);
            }
            catch (Exception otErpUpdateTblGnPaymentTypeException)
            {
                NotificationService.Notify(new NotificationMessage() { Severity = "error", Summary = $"Error", Detail = $"Unable to update TblGnPaymentType" });
            }
        }

        protected async void Button3Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
