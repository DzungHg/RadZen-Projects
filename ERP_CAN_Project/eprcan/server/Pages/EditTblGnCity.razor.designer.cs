﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using ErpCan.Models.CanErpDbAt132;

namespace ErpCan.Pages
{
    public partial class EditTblGnCityComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        [Parameter]
        public string City_SEQ { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblGnCity> form0;

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

        ErpCan.Models.CanErpDbAt132.TblGnCity _tblgncity;
        protected ErpCan.Models.CanErpDbAt132.TblGnCity tblgncity
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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            canEdit = true;

            var canErpDbAt132GetTblGnCityByCitySeqResult = await CanErpDbAt132.GetTblGnCityByCitySeq(int.Parse(City_SEQ));
            tblgncity = canErpDbAt132GetTblGnCityByCitySeqResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnCity args)
        {
            try
            {
                var canErpDbAt132UpdateTblGnCityResult = await CanErpDbAt132.UpdateTblGnCity(int.Parse(City_SEQ), tblgncity);
                DialogService.Close(tblgncity);
            }
            catch (Exception canErpDbAt132UpdateTblGnCityException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblGnCity");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}