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
    public partial class AddTblGnCityComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


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
            tblgncity = new ErpCan.Models.CanErpDbAt132.TblGnCity();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblGnCity args)
        {
            try
            {
                var canErpDbAt132CreateTblGnCityResult = await CanErpDbAt132.CreateTblGnCity(tblgncity);
                DialogService.Close(tblgncity);
            }
            catch (Exception canErpDbAt132CreateTblGnCityException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblGnCity!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
