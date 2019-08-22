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
    public partial class AddTblSoOrderStatusComponent : ComponentBase
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

        protected RadzenTemplateForm<TblSoOrderStatus> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox soStatusId;

        protected RadzenRequiredValidator soStatusIdRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenTextBox soStatusText;

        protected RadzenLabel label3;

        protected RadzenTextBox description;

        protected RadzenButton button1;

        protected RadzenButton button2;

        TblSoOrderStatus _tblsoorderstatus;
        protected TblSoOrderStatus tblsoorderstatus
        {
            get
            {
                return _tblsoorderstatus;
            }
            set
            {
                if(_tblsoorderstatus != value)
                {
                    _tblsoorderstatus = value;
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
            tblsoorderstatus = new TblSoOrderStatus();
        }

        protected async void Form0Submit(TblSoOrderStatus args)
        {
            var otErpCreateTblSoOrderStatusResult = await OtErp.CreateTblSoOrderStatus(tblsoorderstatus);
            DialogService.Close(tblsoorderstatus);
        }

        protected async void Button2Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
