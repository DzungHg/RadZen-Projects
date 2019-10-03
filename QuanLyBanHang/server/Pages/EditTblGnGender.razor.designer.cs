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
    public partial class EditTblGnGenderComponent : ComponentBase
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
        public string Gender_SEQ { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<TblGnGender> form0;

        protected RadzenLabel label2;

        protected RadzenTextBox genderId;

        protected RadzenLabel label3;

        protected RadzenTextBox gender;

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

        TblGnGender _tblgngender;
        protected TblGnGender tblgngender
        {
            get
            {
                return _tblgngender;
            }
            set
            {
                if(_tblgngender != value)
                {
                    _tblgngender = value;
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
                var otErpGetTblGnGenderByGenderSeqResult = await OtErp.GetTblGnGenderByGenderSeq(int.Parse(Gender_SEQ));
                tblgngender = otErpGetTblGnGenderByGenderSeqResult;
            }
            catch (Exception otErpGetTblGnGenderByGenderSeqException)
            {

            }
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(TblGnGender args)
        {
            try
            {
                var otErpUpdateTblGnGenderResult = await OtErp.UpdateTblGnGender(int.Parse(Gender_SEQ), tblgngender);
                DialogService.Close(tblgngender);
            }
            catch (Exception otErpUpdateTblGnGenderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblGnGender");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
