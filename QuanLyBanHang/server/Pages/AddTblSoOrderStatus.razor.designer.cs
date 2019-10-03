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
    public partial class AddTblSoOrderStatusComponent : ComponentBase
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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            tblsoorderstatus = new TblSoOrderStatus();
        }

        protected async void Form0Submit(TblSoOrderStatus args)
        {
            try
            {
                var otErpCreateTblSoOrderStatusResult = await OtErp.CreateTblSoOrderStatus(tblsoorderstatus);
                DialogService.Close(tblsoorderstatus);
            }
            catch (Exception otErpCreateTblSoOrderStatusException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblSoOrderStatus!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
