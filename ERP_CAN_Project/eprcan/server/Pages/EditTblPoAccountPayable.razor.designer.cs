using System;
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
    public partial class EditTblPoAccountPayableComponent : ComponentBase
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
        public string AP_No { get; set; }

        protected RadzenContent content1;

        protected RadzenLabel closeLabel;

        protected RadzenButton closeButton;

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable> form0;

        protected RadzenLabel label2;

        protected RadzenTextBox apNo;

        protected RadzenRequiredValidator apNoRequiredValidator;

        protected RadzenLabel label3;

        protected RadzenDropDown vendorFk;

        protected RadzenLabel label4;

        protected RadzenTextBox transactNo;

        protected RadzenLabel label5;

        protected RadzenTextBox recordCode;

        protected RadzenLabel label6;

        protected RadzenTextBox poNo;

        protected RadzenLabel label7;

        protected RadzenDatePicker transactDate;

        protected RadzenLabel label8;

        protected RadzenTextBox description;

        protected RadzenLabel label9;

        protected dynamic amount;

        protected RadzenLabel label10;

        protected RadzenDropDown departmentFk;

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

        ErpCan.Models.CanErpDbAt132.TblPoAccountPayable _tblpoaccountpayable;
        protected ErpCan.Models.CanErpDbAt132.TblPoAccountPayable tblpoaccountpayable
        {
            get
            {
                return _tblpoaccountpayable;
            }
            set
            {
                if(_tblpoaccountpayable != value)
                {
                    _tblpoaccountpayable = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoVendor> _getTblPoVendorsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblPoVendor> getTblPoVendorsResult
        {
            get
            {
                return _getTblPoVendorsResult;
            }
            set
            {
                if(_getTblPoVendorsResult != value)
                {
                    _getTblPoVendorsResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnDepartment> _getTblGnDepartmentsResult;
        protected IEnumerable<ErpCan.Models.CanErpDbAt132.TblGnDepartment> getTblGnDepartmentsResult
        {
            get
            {
                return _getTblGnDepartmentsResult;
            }
            set
            {
                if(_getTblGnDepartmentsResult != value)
                {
                    _getTblGnDepartmentsResult = value;
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

            var canErpDbAt132GetTblPoAccountPayableByApNoResult = await CanErpDbAt132.GetTblPoAccountPayableByApNo($"{AP_No}");
            tblpoaccountpayable = canErpDbAt132GetTblPoAccountPayableByApNoResult;

            var canErpDbAt132GetTblPoVendorsResult = await CanErpDbAt132.GetTblPoVendors();
            getTblPoVendorsResult = canErpDbAt132GetTblPoVendorsResult;

            var canErpDbAt132GetTblGnDepartmentsResult = await CanErpDbAt132.GetTblGnDepartments();
            getTblGnDepartmentsResult = canErpDbAt132GetTblGnDepartmentsResult;
        }

        protected async void CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoAccountPayable args)
        {
            try
            {
                var canErpDbAt132UpdateTblPoAccountPayableResult = await CanErpDbAt132.UpdateTblPoAccountPayable($"{AP_No}", tblpoaccountpayable);
                DialogService.Close(tblpoaccountpayable);
            }
            catch (Exception canErpDbAt132UpdateTblPoAccountPayableException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblPoAccountPayable");
            }
        }

        protected async void Button3Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
