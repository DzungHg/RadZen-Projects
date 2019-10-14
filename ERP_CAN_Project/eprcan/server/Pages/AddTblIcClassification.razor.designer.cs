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
    public partial class AddTblIcClassificationComponent : ComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected CanErpDbAt132Service CanErpDbAt132 { get; set; }


        protected RadzenContent content1;

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblIcClassification> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox classifiId;

        protected RadzenRequiredValidator classifiIdRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenTextBox classifiName;

        protected RadzenLabel label3;

        protected RadzenCheckBox inactive;

        protected RadzenButton button1;

        protected RadzenButton button2;

        ErpCan.Models.CanErpDbAt132.TblIcClassification _tblicclassification;
        protected ErpCan.Models.CanErpDbAt132.TblIcClassification tblicclassification
        {
            get
            {
                return _tblicclassification;
            }
            set
            {
                if(_tblicclassification != value)
                {
                    _tblicclassification = value;
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
            tblicclassification = new ErpCan.Models.CanErpDbAt132.TblIcClassification();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblIcClassification args)
        {
            try
            {
                var canErpDbAt132CreateTblIcClassificationResult = await CanErpDbAt132.CreateTblIcClassification(tblicclassification);
                DialogService.Close(tblicclassification);
            }
            catch (Exception canErpDbAt132CreateTblIcClassificationException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblIcClassification!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}