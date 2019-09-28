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
    public partial class EditTblGnShipViumComponent : ComponentBase
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
        public string ShipVia_SEQ { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<TblGnShipVium> form0;

        protected RadzenLabel label2;

        protected RadzenTextBox shipViaId;

        protected RadzenRequiredValidator shipViaIdRequiredValidator;

        protected RadzenLabel label3;

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

        TblGnShipVium _tblgnshipvium;
        protected TblGnShipVium tblgnshipvium
        {
            get
            {
                return _tblgnshipvium;
            }
            set
            {
                if(_tblgnshipvium != value)
                {
                    _tblgnshipvium = value;
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
                var otErpGetTblGnShipViumByShipViaSeqResult = await OtErp.GetTblGnShipViumByShipViaSeq(int.Parse(ShipVia_SEQ));
                tblgnshipvium = otErpGetTblGnShipViumByShipViaSeqResult;
            }
            catch (Exception otErpGetTblGnShipViumByShipViaSeqException)
            {

            }
        }

        protected async void CloseButtonClick(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(TblGnShipVium args)
        {
            try
            {
                var otErpUpdateTblGnShipViumResult = await OtErp.UpdateTblGnShipVium(int.Parse(ShipVia_SEQ), tblgnshipvium);
                DialogService.Close(tblgnshipvium);
            }
            catch (Exception otErpUpdateTblGnShipViumException)
            {
                NotificationService.Notify(new NotificationMessage() { Severity = "error", Summary = $"Error", Detail = $"Unable to update TblGnShipVium" });
            }
        }

        protected async void Button3Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
