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
    public partial class ThemKhachHangComponent : ComponentBase
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

        protected dynamic templateForm0;

        protected RadzenLabel label0;

        protected dynamic numeric0;

        protected RadzenLabel label1;

        protected RadzenTextBox textbox0;

        protected RadzenLabel label2;

        protected RadzenDropDown dropdown0;

        protected RadzenLabel label3;

        protected RadzenTextBox textbox1;

        protected RadzenLabel label4;

        protected RadzenTextBox textbox2;

        protected RadzenLabel label5;

        protected RadzenTextBox textbox3;

        protected RadzenLabel label6;

        protected RadzenTextBox textbox4;

        protected RadzenLabel label16;

        protected RadzenDropDown dropdown1;

        protected RadzenLabel label14;

        protected RadzenDropDown dropdown2;

        protected RadzenLabel label7;

        protected RadzenTextBox textbox5;

        protected RadzenLabel label8;

        protected RadzenTextBox textbox6;

        protected RadzenLabel label9;

        protected RadzenTextBox textbox7;

        protected RadzenLabel label10;

        protected RadzenTextBox textbox8;

        protected RadzenLabel label11;

        protected RadzenTextBox textbox9;

        protected RadzenLabel label12;

        protected RadzenTextBox textbox10;

        protected RadzenLabel label13;

        protected RadzenTextBox textbox11;

        protected RadzenLabel label18;

        protected RadzenTextBox textbox14;

        protected RadzenLabel label17;

        protected RadzenTextBox textbox13;

        protected RadzenLabel label19;

        protected RadzenTextBox textbox12;

        protected RadzenLabel label20;

        protected RadzenDropDown dropdown3;

        protected RadzenLabel label15;

        protected RadzenTextBox textbox15;

        protected RadzenLabel label21;

        protected RadzenTextBox textbox16;

        protected RadzenCheckBox checkbox0;

        protected RadzenLabel label22;

        protected RadzenCheckBox checkbox1;

        protected RadzenLabel label23;

        protected RadzenLabel label25;

        protected RadzenTextBox textbox18;

        protected RadzenLabel label24;

        protected RadzenTextBox textbox17;

        protected RadzenLabel label26;

        protected RadzenTextBox textbox19;

        protected RadzenLabel label27;

        protected RadzenDatePicker datepicker0;

        protected RadzenLabel label28;

        protected RadzenDropDown dropdown4;

        protected RadzenLabel label29;

        protected RadzenTextArea textarea0;

        protected RadzenCheckBox checkbox2;

        protected RadzenLabel label30;

        protected RadzenButton button0;

        TblSoCustomer _SoCustomer;
        protected TblSoCustomer SoCustomer
        {
            get
            {
                return _SoCustomer;
            }
            set
            {
                if(_SoCustomer != value)
                {
                    _SoCustomer = value;
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
            var otErpGetTblSoCustomersResult = await OtErp.GetTblSoCustomers(null, null);

            SoCustomer = new TblSoCustomer();
        }
    }
}
