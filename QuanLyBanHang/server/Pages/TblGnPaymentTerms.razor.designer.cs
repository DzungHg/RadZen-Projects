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
    public partial class TblGnPaymentTermsComponent : ComponentBase
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

        protected RadzenHeading pageTitle;

        protected RadzenButton button0;

        protected RadzenGrid<TblGnPaymentTerm> grid0;

        protected RadzenButton gridDeleteButton;

        IEnumerable<TblGnPaymentTerm> _getTblGnPaymentTermsResult;
        protected IEnumerable<TblGnPaymentTerm> getTblGnPaymentTermsResult
        {
            get
            {
                return _getTblGnPaymentTermsResult;
            }
            set
            {
                if(_getTblGnPaymentTermsResult != value)
                {
                    _getTblGnPaymentTermsResult = value;
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
            var otErpGetTblGnPaymentTermsResult = await OtErp.GetTblGnPaymentTerms(null, null);
            getTblGnPaymentTermsResult = otErpGetTblGnPaymentTermsResult;
        }

        protected async void Button0Click(UIMouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddTblGnPaymentTerm>("Add Tbl Gn Payment Term", null);
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void Grid0RowSelect(TblGnPaymentTerm args)
        {
            var result = await DialogService.OpenAsync<EditTblGnPaymentTerm>("Edit Tbl Gn Payment Term", new Dictionary<string, object>() { {"PaymentTerm_SEQ", $"{args.PaymentTerm_SEQ}"} });
              await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async void GridDeleteButtonClick(UIMouseEventArgs args, TblGnPaymentTerm data)
        {
            var otErpDeleteTblGnPaymentTermResult = await OtErp.DeleteTblGnPaymentTerm(data.PaymentTerm_SEQ);
            if (otErpDeleteTblGnPaymentTermResult != null) {
                grid0.Reload();
}
        }
    }
}
