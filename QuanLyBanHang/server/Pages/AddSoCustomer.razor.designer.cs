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
    public partial class AddSoCustomerComponent : ComponentBase
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

        protected dynamic templateForm0;

        protected RadzenLabel label0;

        protected dynamic numeric0;

        protected RadzenLabel label1;

        protected RadzenTextBox textbox0;

        protected RadzenLabel label2;

        protected RadzenDropDown dropdown0;

        protected RadzenButton button0;

        TblSoCustomer _SoCustomer;
        protected TblSoCustomer SoCustomer
        {
            get
            {
                return _SoCustomer;
            }
            set
            {
                if(_SoCustomer != value)
                {
                    _SoCustomer = value;
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
            var otErpGetTblSoCustomersResult = await OtErp.GetTblSoCustomers(null, null);

            SoCustomer = new TblSoCustomer();
        }
    }
}
