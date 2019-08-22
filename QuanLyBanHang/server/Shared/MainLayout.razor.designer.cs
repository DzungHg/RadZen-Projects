﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using QuanLyBanHang.Models.OtErp;

namespace QuanLyBanHang.Layouts
{
    public partial class MainLayoutComponent : LayoutComponentBase
    {
        [Inject]
        protected IUriHelper UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected OtErpService OtErp { get; set; }


        protected RadzenHeader header0;

        protected RadzenSidebarToggle sidebarToggle0;

        protected RadzenLabel label0;

        protected RadzenBody body0;

        protected RadzenContentContainer main;

        protected RadzenSidebar sidebar0;

        protected RadzenPanelMenu panelmenu0;

        protected RadzenFooter footer0;

        protected RadzenLabel footerText;

        protected override async Task OnInitializedAsync()
        {
        }


        protected async void SidebarToggle0Click(dynamic args)
        {
            sidebar0.Toggle();

            body0.Toggle();
        }
    }
}
