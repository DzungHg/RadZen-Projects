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
    public partial class AddTblSoOrderDetailStatusComponent : ComponentBase
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

        protected RadzenTemplateForm<TblSoOrderDetailStatus> form0;

        protected RadzenLabel label1;

        protected dynamic soDetailStatusId;

        protected RadzenLabel label2;

        protected RadzenTextBox soDetailStatusText;

        protected RadzenLabel label3;

        protected RadzenTextBox description;

        protected RadzenButton button1;

        protected RadzenButton button2;

        TblSoOrderDetailStatus _tblsoorderdetailstatus;
        protected TblSoOrderDetailStatus tblsoorderdetailstatus
        {
            get
            {
                return _tblsoorderdetailstatus;
            }
            set
            {
                if(_tblsoorderdetailstatus != value)
                {
                    _tblsoorderdetailstatus = value;
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
            tblsoorderdetailstatus = new TblSoOrderDetailStatus();
        }

        protected async void Form0Submit(TblSoOrderDetailStatus args)
        {
            try
            {
                var otErpCreateTblSoOrderDetailStatusResult = await OtErp.CreateTblSoOrderDetailStatus(tblsoorderdetailstatus);
                DialogService.Close(tblsoorderdetailstatus);
            }
            catch (Exception otErpCreateTblSoOrderDetailStatusException)
            {
                NotificationService.Notify(new NotificationMessage() { Severity = "error", Summary = $"Error", Detail = $"Unable to create new TblSoOrderDetailStatus!" });
            }
        }

        protected async void Button2Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
