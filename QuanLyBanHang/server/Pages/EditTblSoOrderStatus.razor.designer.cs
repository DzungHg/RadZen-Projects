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
    public partial class EditTblSoOrderStatusComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected OtErpService OtErp { get; set; }


        [Parameter]
        public string SOStatus_SEQ { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<TblSoOrderStatus> form0;

        protected RadzenLabel label2;

        protected RadzenTextBox soStatusId;

        protected RadzenRequiredValidator soStatusIdRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenTextBox soStatusText;

        protected RadzenLabel label4;

        protected RadzenTextBox description;

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
            canEdit = true;

            try
            {
                var otErpGetTblSoOrderStatusBySoStatusSeqResult = await OtErp.GetTblSoOrderStatusBySoStatusSeq(int.Parse(SOStatus_SEQ));
                tblsoorderstatus = otErpGetTblSoOrderStatusBySoStatusSeqResult;
            }
            catch (Exception otErpGetTblSoOrderStatusBySoStatusSeqException)
            {

            }
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(TblSoOrderStatus args)
        {
            try
            {
                var otErpUpdateTblSoOrderStatusResult = await OtErp.UpdateTblSoOrderStatus(int.Parse(SOStatus_SEQ), tblsoorderstatus);
                DialogService.Close(tblsoorderstatus);
            }
            catch (Exception otErpUpdateTblSoOrderStatusException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblSoOrderStatus");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
