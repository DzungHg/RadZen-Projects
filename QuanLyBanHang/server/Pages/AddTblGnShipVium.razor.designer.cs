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
    public partial class AddTblGnShipViumComponent : ComponentBase
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

        protected RadzenTemplateForm<TblGnShipVium> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox shipViaId;

        protected RadzenRequiredValidator shipViaIdRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenTextBox description;

        protected RadzenButton button1;

        protected RadzenButton button2;

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
            tblgnshipvium = new TblGnShipVium();
        }

        protected async void Form0Submit(TblGnShipVium args)
        {
            try
            {
                var otErpCreateTblGnShipViumResult = await OtErp.CreateTblGnShipVium(tblgnshipvium);
                DialogService.Close(tblgnshipvium);
            }
            catch (Exception otErpCreateTblGnShipViumException)
            {
                NotificationService.Notify(new NotificationMessage() { Severity = "error", Summary = $"Error", Detail = $"Unable to create new TblGnShipVium!" });
            }
        }

        protected async void Button2Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
