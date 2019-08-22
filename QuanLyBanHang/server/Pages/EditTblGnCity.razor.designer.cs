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
    public partial class EditTblGnCityComponent : ComponentBase
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
        public string City_SEQ { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<TblGnCity> form0;

        protected RadzenLabel label2;

        protected RadzenTextBox cityId;

        protected RadzenLabel label3;

        protected RadzenTextBox cityName;

        protected RadzenLabel label4;

        protected RadzenTextBox cityAbbreviation;

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
            canEdit = true;

            var otErpGetTblGnCityByCitySeqResult = await OtErp.GetTblGnCityByCitySeq(int.Parse(City_SEQ));
            tblgncity = otErpGetTblGnCityByCitySeqResult;
        }

        protected async void CloseButtonClick(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(TblGnCity args)
        {
            var otErpUpdateTblGnCityResult = await OtErp.UpdateTblGnCity(int.Parse(City_SEQ), tblgncity);
            DialogService.Close(tblgncity);
        }

        protected async void Button3Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
