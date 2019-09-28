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
    public partial class ViewCustomerBriefComponent : ComponentBase
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

        protected RadzenGrid<ViwSoCustBrief> grid0;

        IEnumerable<ViwSoCustBrief> _CustomerResult;
        protected IEnumerable<ViwSoCustBrief> CustomerResult
        {
            get
            {
                return _CustomerResult;
            }
            set
            {
                if(_CustomerResult != value)
                {
                    _CustomerResult = value;
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
            var otErpGetViwSoCustBriefsResult = await OtErp.GetViwSoCustBriefs(null, null);
            CustomerResult = otErpGetViwSoCustBriefsResult;
        }

        protected async void Button0Click(UIMouseEventArgs args)
        {
            var result = await DialogService.OpenAsync<AddCustomer>("Add Customer", null, new DialogOptions(){ Width = $"{940}px" });
              grid0.Reload();

              await InvokeAsync(() => { StateHasChanged(); });
        }
    }
}
