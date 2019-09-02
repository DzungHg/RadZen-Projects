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
    public partial class AddCustomerComponent : ComponentBase
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

        protected dynamic form0;

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

        protected RadzenButton button1;

        IEnumerable<ViwGnAddBookCust> _CustomersResult;
        protected IEnumerable<ViwGnAddBookCust> CustomersResult
        {
            get
            {
                return _CustomersResult;
            }
            set
            {
                if(_CustomersResult != value)
                {
                    _CustomersResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<TblGnPaymentTerm> _PaymentTermsResult;
        protected IEnumerable<TblGnPaymentTerm> PaymentTermsResult
        {
            get
            {
                return _PaymentTermsResult;
            }
            set
            {
                if(_PaymentTermsResult != value)
                {
                    _PaymentTermsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<TblGnPaymentType> _PaymentTypesResult;
        protected IEnumerable<TblGnPaymentType> PaymentTypesResult
        {
            get
            {
                return _PaymentTypesResult;
            }
            set
            {
                if(_PaymentTypesResult != value)
                {
                    _PaymentTypesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ViwGnAddBookEmp> _EmployeesResult;
        protected IEnumerable<ViwGnAddBookEmp> EmployeesResult
        {
            get
            {
                return _EmployeesResult;
            }
            set
            {
                if(_EmployeesResult != value)
                {
                    _EmployeesResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        TblSoCustomer _tblsocustomer;
        protected TblSoCustomer tblsocustomer
        {
            get
            {
                return _tblsocustomer;
            }
            set
            {
                if(_tblsocustomer != value)
                {
                    _tblsocustomer = value;
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
            var otErpGetViwGnAddBookCustsResult = await OtErp.GetViwGnAddBookCusts(null, null);
            CustomersResult = otErpGetViwGnAddBookCustsResult;

            var otErpGetTblGnPaymentTermsResult = await OtErp.GetTblGnPaymentTerms(null, null);
            PaymentTermsResult = otErpGetTblGnPaymentTermsResult;

            var otErpGetTblGnPaymentTypesResult = await OtErp.GetTblGnPaymentTypes(null, null);
            PaymentTypesResult = otErpGetTblGnPaymentTypesResult;

            var otErpGetViwGnAddBookEmpsResult = await OtErp.GetViwGnAddBookEmps(null, null);
            EmployeesResult = otErpGetViwGnAddBookEmpsResult;

            tblsocustomer = new TblSoCustomer();
        }

        protected async void Form0Submit(dynamic args)
        {
            var otErpCreateTblSoCustomerResult = await OtErp.CreateTblSoCustomer(tblsocustomer);
        }

        protected async void Button1Click(UIMouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
