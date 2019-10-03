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
    public partial class AddTblGnGenderComponent : ComponentBase
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

        protected RadzenTemplateForm<TblGnGender> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox genderId;

        protected RadzenLabel label2;

        protected RadzenTextBox gender;

        protected RadzenButton button1;

        protected RadzenButton button2;

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
            tblgngender = new TblGnGender();
        }

        protected async void Form0Submit(TblGnGender args)
        {
            try
            {
                var otErpCreateTblGnGenderResult = await OtErp.CreateTblGnGender(tblgngender);
                DialogService.Close(tblgngender);
            }
            catch (Exception otErpCreateTblGnGenderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblGnGender!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
