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
    public partial class AddTblGnCityComponent : ComponentBase
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

        protected RadzenTemplateForm<TblGnCity> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox cityId;

        protected RadzenLabel label2;

        protected RadzenTextBox cityName;

        protected RadzenLabel label3;

        protected RadzenTextBox cityAbbreviation;

        protected RadzenButton button1;

        protected RadzenButton button2;

        TblGnCity _tblgncity;
        protected TblGnCity tblgncity
        {
            get
            {
                return _tblgncity;
            }
            set
            {
                if(_tblgncity != value)
                {
                    _tblgncity = value;
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
            tblgncity = new TblGnCity();
        }

        protected async void Form0Submit(TblGnCity args)
        {
            var otErpCreateTblGnCityResult = await OtErp.CreateTblGnCity(tblgncity);
            DialogService.Close(tblgncity);
        }

        protected async void Button2Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
