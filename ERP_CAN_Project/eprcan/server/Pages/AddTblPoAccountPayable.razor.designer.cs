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
    public partial class AddTblPoAccountPayableComponent : ComponentBase
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

        protected RadzenTemplateForm<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable> form0;

        protected RadzenLabel label1;

        protected RadzenTextBox apNo;

        protected RadzenRequiredValidator apNoRequiredValidator;

        protected RadzenLabel label2;

        protected RadzenDropDown vendorFk;

        protected RadzenLabel label3;

        protected RadzenTextBox transactNo;

        protected RadzenLabel label4;

        protected RadzenTextBox recordCode;

        protected RadzenLabel label5;

        protected RadzenTextBox poNo;

        protected RadzenLabel label6;

        protected RadzenDatePicker transactDate;

        protected RadzenLabel label7;

        protected RadzenTextBox description;

        protected RadzenLabel label8;

        protected dynamic amount;

        protected RadzenLabel label9;

        protected RadzenDropDown departmentFk;

        protected RadzenButton button1;

        protected RadzenButton button2;

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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Load();
        }

        protected async void Load()
        {
            var canErpDbAt132GetTblPoVendorsResult = await CanErpDbAt132.GetTblPoVendors();
            getTblPoVendorsResult = canErpDbAt132GetTblPoVendorsResult;

            var canErpDbAt132GetTblGnDepartmentsResult = await CanErpDbAt132.GetTblGnDepartments();
            getTblGnDepartmentsResult = canErpDbAt132GetTblGnDepartmentsResult;

            tblpoaccountpayable = new ErpCan.Models.CanErpDbAt132.TblPoAccountPayable();
        }

        protected async void Form0Submit(ErpCan.Models.CanErpDbAt132.TblPoAccountPayable args)
        {
            try
            {
                var canErpDbAt132CreateTblPoAccountPayableResult = await CanErpDbAt132.CreateTblPoAccountPayable(tblpoaccountpayable);
                DialogService.Close(tblpoaccountpayable);
            }
            catch (Exception canErpDbAt132CreateTblPoAccountPayableException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblPoAccountPayable!");
            }
        }

        protected async void Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}