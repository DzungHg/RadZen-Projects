using Radzen;
using System;
using System.Web;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using ErpCan.Data;

namespace ErpCan
{
    public partial class CanErpDbAt132Service
    {
        private readonly CanErpDbAt132Context context;
        private readonly NavigationManager navigationManager;
        
        public CanErpDbAt132Service(CanErpDbAt132Context context, NavigationManager navigationManager)
        {
            this.context = context;
            this.navigationManager = navigationManager;
        }

        
      public async Task<IQueryable<Models.CanErpDbAt132.SpGetAddressBookByContactSeq>> GetSpGetAddressBookByContactSeqs(int? ContactSEQ)
      {
          OnSpGetAddressBookByContactSeqsDefaultParams(ref ContactSEQ);

          var items = context.SpGetAddressBookByContactSeqs.FromSqlRaw("EXEC [dbo].[sp_GetAddressBookByContactSEQ] @ContactSEQ={0}", ContactSEQ);

          OnSpGetAddressBookByContactSeqsInvoke(ref items);

          return await Task.FromResult(items);
      }

      partial void OnSpGetAddressBookByContactSeqsDefaultParams(ref int? ContactSEQ);

      partial void OnSpGetAddressBookByContactSeqsInvoke(ref IQueryable<Models.CanErpDbAt132.SpGetAddressBookByContactSeq> items);
            public async Task ExportTblGnAddressBooksToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgnaddressbooks/excel") : "/export/canerpdbat132/tblgnaddressbooks/excel", true);
        }

        public async Task ExportTblGnAddressBooksToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgnaddressbooks/csv") : "/export/canerpdbat132/tblgnaddressbooks/csv", true);
        }

        partial void OnTblGnAddressBooksRead(ref IQueryable<Models.CanErpDbAt132.TblGnAddressBook> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblGnAddressBook>> GetTblGnAddressBooks(Query query = null)
        {
            var items = context.TblGnAddressBooks.AsQueryable();

            items = items.Include(i => i.TblGnAddressBookType);

            items = items.Include(i => i.TblGnGender);

            items = items.Include(i => i.TblGnCity);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblGnAddressBooksRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblGnAddressBookCreated(Models.CanErpDbAt132.TblGnAddressBook item);

        public async Task<Models.CanErpDbAt132.TblGnAddressBook> CreateTblGnAddressBook(Models.CanErpDbAt132.TblGnAddressBook tblGnAddressBook)
        {
            OnTblGnAddressBookCreated(tblGnAddressBook);

            context.TblGnAddressBooks.Add(tblGnAddressBook);
            context.SaveChanges();

            return tblGnAddressBook;
        }
            public async Task ExportTblGnAddressBookTypesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgnaddressbooktypes/excel") : "/export/canerpdbat132/tblgnaddressbooktypes/excel", true);
        }

        public async Task ExportTblGnAddressBookTypesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgnaddressbooktypes/csv") : "/export/canerpdbat132/tblgnaddressbooktypes/csv", true);
        }

        partial void OnTblGnAddressBookTypesRead(ref IQueryable<Models.CanErpDbAt132.TblGnAddressBookType> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblGnAddressBookType>> GetTblGnAddressBookTypes(Query query = null)
        {
            var items = context.TblGnAddressBookTypes.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblGnAddressBookTypesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblGnAddressBookTypeCreated(Models.CanErpDbAt132.TblGnAddressBookType item);

        public async Task<Models.CanErpDbAt132.TblGnAddressBookType> CreateTblGnAddressBookType(Models.CanErpDbAt132.TblGnAddressBookType tblGnAddressBookType)
        {
            OnTblGnAddressBookTypeCreated(tblGnAddressBookType);

            context.TblGnAddressBookTypes.Add(tblGnAddressBookType);
            context.SaveChanges();

            return tblGnAddressBookType;
        }
            public async Task ExportTblGnCitiesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgncities/excel") : "/export/canerpdbat132/tblgncities/excel", true);
        }

        public async Task ExportTblGnCitiesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgncities/csv") : "/export/canerpdbat132/tblgncities/csv", true);
        }

        partial void OnTblGnCitiesRead(ref IQueryable<Models.CanErpDbAt132.TblGnCity> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblGnCity>> GetTblGnCities(Query query = null)
        {
            var items = context.TblGnCities.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblGnCitiesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblGnCityCreated(Models.CanErpDbAt132.TblGnCity item);

        public async Task<Models.CanErpDbAt132.TblGnCity> CreateTblGnCity(Models.CanErpDbAt132.TblGnCity tblGnCity)
        {
            OnTblGnCityCreated(tblGnCity);

            context.TblGnCities.Add(tblGnCity);
            context.SaveChanges();

            return tblGnCity;
        }
            public async Task ExportTblGnDepartmentsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgndepartments/excel") : "/export/canerpdbat132/tblgndepartments/excel", true);
        }

        public async Task ExportTblGnDepartmentsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgndepartments/csv") : "/export/canerpdbat132/tblgndepartments/csv", true);
        }

        partial void OnTblGnDepartmentsRead(ref IQueryable<Models.CanErpDbAt132.TblGnDepartment> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblGnDepartment>> GetTblGnDepartments(Query query = null)
        {
            var items = context.TblGnDepartments.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblGnDepartmentsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblGnDepartmentCreated(Models.CanErpDbAt132.TblGnDepartment item);

        public async Task<Models.CanErpDbAt132.TblGnDepartment> CreateTblGnDepartment(Models.CanErpDbAt132.TblGnDepartment tblGnDepartment)
        {
            OnTblGnDepartmentCreated(tblGnDepartment);

            context.TblGnDepartments.Add(tblGnDepartment);
            context.SaveChanges();

            return tblGnDepartment;
        }
            public async Task ExportTblGnGendersToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgngenders/excel") : "/export/canerpdbat132/tblgngenders/excel", true);
        }

        public async Task ExportTblGnGendersToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgngenders/csv") : "/export/canerpdbat132/tblgngenders/csv", true);
        }

        partial void OnTblGnGendersRead(ref IQueryable<Models.CanErpDbAt132.TblGnGender> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblGnGender>> GetTblGnGenders(Query query = null)
        {
            var items = context.TblGnGenders.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblGnGendersRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblGnGenderCreated(Models.CanErpDbAt132.TblGnGender item);

        public async Task<Models.CanErpDbAt132.TblGnGender> CreateTblGnGender(Models.CanErpDbAt132.TblGnGender tblGnGender)
        {
            OnTblGnGenderCreated(tblGnGender);

            context.TblGnGenders.Add(tblGnGender);
            context.SaveChanges();

            return tblGnGender;
        }
            public async Task ExportTblGnIncotermsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgnincoterms/excel") : "/export/canerpdbat132/tblgnincoterms/excel", true);
        }

        public async Task ExportTblGnIncotermsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgnincoterms/csv") : "/export/canerpdbat132/tblgnincoterms/csv", true);
        }

        partial void OnTblGnIncotermsRead(ref IQueryable<Models.CanErpDbAt132.TblGnIncoterm> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblGnIncoterm>> GetTblGnIncoterms(Query query = null)
        {
            var items = context.TblGnIncoterms.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblGnIncotermsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblGnIncotermCreated(Models.CanErpDbAt132.TblGnIncoterm item);

        public async Task<Models.CanErpDbAt132.TblGnIncoterm> CreateTblGnIncoterm(Models.CanErpDbAt132.TblGnIncoterm tblGnIncoterm)
        {
            OnTblGnIncotermCreated(tblGnIncoterm);

            context.TblGnIncoterms.Add(tblGnIncoterm);
            context.SaveChanges();

            return tblGnIncoterm;
        }
            public async Task ExportTblGnPaymentTermsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgnpaymentterms/excel") : "/export/canerpdbat132/tblgnpaymentterms/excel", true);
        }

        public async Task ExportTblGnPaymentTermsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgnpaymentterms/csv") : "/export/canerpdbat132/tblgnpaymentterms/csv", true);
        }

        partial void OnTblGnPaymentTermsRead(ref IQueryable<Models.CanErpDbAt132.TblGnPaymentTerm> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblGnPaymentTerm>> GetTblGnPaymentTerms(Query query = null)
        {
            var items = context.TblGnPaymentTerms.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblGnPaymentTermsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblGnPaymentTermCreated(Models.CanErpDbAt132.TblGnPaymentTerm item);

        public async Task<Models.CanErpDbAt132.TblGnPaymentTerm> CreateTblGnPaymentTerm(Models.CanErpDbAt132.TblGnPaymentTerm tblGnPaymentTerm)
        {
            OnTblGnPaymentTermCreated(tblGnPaymentTerm);

            context.TblGnPaymentTerms.Add(tblGnPaymentTerm);
            context.SaveChanges();

            return tblGnPaymentTerm;
        }
            public async Task ExportTblGnPaymentTypesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgnpaymenttypes/excel") : "/export/canerpdbat132/tblgnpaymenttypes/excel", true);
        }

        public async Task ExportTblGnPaymentTypesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgnpaymenttypes/csv") : "/export/canerpdbat132/tblgnpaymenttypes/csv", true);
        }

        partial void OnTblGnPaymentTypesRead(ref IQueryable<Models.CanErpDbAt132.TblGnPaymentType> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblGnPaymentType>> GetTblGnPaymentTypes(Query query = null)
        {
            var items = context.TblGnPaymentTypes.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblGnPaymentTypesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblGnPaymentTypeCreated(Models.CanErpDbAt132.TblGnPaymentType item);

        public async Task<Models.CanErpDbAt132.TblGnPaymentType> CreateTblGnPaymentType(Models.CanErpDbAt132.TblGnPaymentType tblGnPaymentType)
        {
            OnTblGnPaymentTypeCreated(tblGnPaymentType);

            context.TblGnPaymentTypes.Add(tblGnPaymentType);
            context.SaveChanges();

            return tblGnPaymentType;
        }
            public async Task ExportTblGnProductsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgnproducts/excel") : "/export/canerpdbat132/tblgnproducts/excel", true);
        }

        public async Task ExportTblGnProductsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgnproducts/csv") : "/export/canerpdbat132/tblgnproducts/csv", true);
        }

        partial void OnTblGnProductsRead(ref IQueryable<Models.CanErpDbAt132.TblGnProduct> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblGnProduct>> GetTblGnProducts(Query query = null)
        {
            var items = context.TblGnProducts.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblGnProductsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblGnProductCreated(Models.CanErpDbAt132.TblGnProduct item);

        public async Task<Models.CanErpDbAt132.TblGnProduct> CreateTblGnProduct(Models.CanErpDbAt132.TblGnProduct tblGnProduct)
        {
            OnTblGnProductCreated(tblGnProduct);

            context.TblGnProducts.Add(tblGnProduct);
            context.SaveChanges();

            return tblGnProduct;
        }
            public async Task ExportTblGnShipViaToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgnshipvia/excel") : "/export/canerpdbat132/tblgnshipvia/excel", true);
        }

        public async Task ExportTblGnShipViaToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblgnshipvia/csv") : "/export/canerpdbat132/tblgnshipvia/csv", true);
        }

        partial void OnTblGnShipViaRead(ref IQueryable<Models.CanErpDbAt132.TblGnShipVium> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblGnShipVium>> GetTblGnShipVia(Query query = null)
        {
            var items = context.TblGnShipVia.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblGnShipViaRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblGnShipViumCreated(Models.CanErpDbAt132.TblGnShipVium item);

        public async Task<Models.CanErpDbAt132.TblGnShipVium> CreateTblGnShipVium(Models.CanErpDbAt132.TblGnShipVium tblGnShipVium)
        {
            OnTblGnShipViumCreated(tblGnShipVium);

            context.TblGnShipVia.Add(tblGnShipVium);
            context.SaveChanges();

            return tblGnShipVium;
        }
            public async Task ExportTblIcCategoriesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tbliccategories/excel") : "/export/canerpdbat132/tbliccategories/excel", true);
        }

        public async Task ExportTblIcCategoriesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tbliccategories/csv") : "/export/canerpdbat132/tbliccategories/csv", true);
        }

        partial void OnTblIcCategoriesRead(ref IQueryable<Models.CanErpDbAt132.TblIcCategory> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblIcCategory>> GetTblIcCategories(Query query = null)
        {
            var items = context.TblIcCategories.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblIcCategoriesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblIcCategoryCreated(Models.CanErpDbAt132.TblIcCategory item);

        public async Task<Models.CanErpDbAt132.TblIcCategory> CreateTblIcCategory(Models.CanErpDbAt132.TblIcCategory tblIcCategory)
        {
            OnTblIcCategoryCreated(tblIcCategory);

            context.TblIcCategories.Add(tblIcCategory);
            context.SaveChanges();

            return tblIcCategory;
        }
            public async Task ExportTblIcClassificationsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblicclassifications/excel") : "/export/canerpdbat132/tblicclassifications/excel", true);
        }

        public async Task ExportTblIcClassificationsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblicclassifications/csv") : "/export/canerpdbat132/tblicclassifications/csv", true);
        }

        partial void OnTblIcClassificationsRead(ref IQueryable<Models.CanErpDbAt132.TblIcClassification> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblIcClassification>> GetTblIcClassifications(Query query = null)
        {
            var items = context.TblIcClassifications.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblIcClassificationsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblIcClassificationCreated(Models.CanErpDbAt132.TblIcClassification item);

        public async Task<Models.CanErpDbAt132.TblIcClassification> CreateTblIcClassification(Models.CanErpDbAt132.TblIcClassification tblIcClassification)
        {
            OnTblIcClassificationCreated(tblIcClassification);

            context.TblIcClassifications.Add(tblIcClassification);
            context.SaveChanges();

            return tblIcClassification;
        }
            public async Task ExportTblIcInventoriesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblicinventories/excel") : "/export/canerpdbat132/tblicinventories/excel", true);
        }

        public async Task ExportTblIcInventoriesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblicinventories/csv") : "/export/canerpdbat132/tblicinventories/csv", true);
        }

        partial void OnTblIcInventoriesRead(ref IQueryable<Models.CanErpDbAt132.TblIcInventory> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblIcInventory>> GetTblIcInventories(Query query = null)
        {
            var items = context.TblIcInventories.AsQueryable();

            items = items.Include(i => i.TblIcWarehouse);

            items = items.Include(i => i.TblIcCategory);

            items = items.Include(i => i.TblIcClassification);

            items = items.Include(i => i.TblGnProduct);

            items = items.Include(i => i.TblIcUnit);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblIcInventoriesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblIcInventoryCreated(Models.CanErpDbAt132.TblIcInventory item);

        public async Task<Models.CanErpDbAt132.TblIcInventory> CreateTblIcInventory(Models.CanErpDbAt132.TblIcInventory tblIcInventory)
        {
            OnTblIcInventoryCreated(tblIcInventory);

            context.TblIcInventories.Add(tblIcInventory);
            context.SaveChanges();

            return tblIcInventory;
        }
            public async Task ExportTblIcTransactionsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblictransactions/excel") : "/export/canerpdbat132/tblictransactions/excel", true);
        }

        public async Task ExportTblIcTransactionsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblictransactions/csv") : "/export/canerpdbat132/tblictransactions/csv", true);
        }

        partial void OnTblIcTransactionsRead(ref IQueryable<Models.CanErpDbAt132.TblIcTransaction> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblIcTransaction>> GetTblIcTransactions(Query query = null)
        {
            var items = context.TblIcTransactions.AsQueryable();

            items = items.Include(i => i.TblIcTransactionType);

            items = items.Include(i => i.TblIcWarehouse);

            items = items.Include(i => i.TblGnProduct);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblIcTransactionsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblIcTransactionCreated(Models.CanErpDbAt132.TblIcTransaction item);

        public async Task<Models.CanErpDbAt132.TblIcTransaction> CreateTblIcTransaction(Models.CanErpDbAt132.TblIcTransaction tblIcTransaction)
        {
            OnTblIcTransactionCreated(tblIcTransaction);

            context.TblIcTransactions.Add(tblIcTransaction);
            context.SaveChanges();

            return tblIcTransaction;
        }
            public async Task ExportTblIcTransactionTypesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblictransactiontypes/excel") : "/export/canerpdbat132/tblictransactiontypes/excel", true);
        }

        public async Task ExportTblIcTransactionTypesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblictransactiontypes/csv") : "/export/canerpdbat132/tblictransactiontypes/csv", true);
        }

        partial void OnTblIcTransactionTypesRead(ref IQueryable<Models.CanErpDbAt132.TblIcTransactionType> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblIcTransactionType>> GetTblIcTransactionTypes(Query query = null)
        {
            var items = context.TblIcTransactionTypes.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblIcTransactionTypesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblIcTransactionTypeCreated(Models.CanErpDbAt132.TblIcTransactionType item);

        public async Task<Models.CanErpDbAt132.TblIcTransactionType> CreateTblIcTransactionType(Models.CanErpDbAt132.TblIcTransactionType tblIcTransactionType)
        {
            OnTblIcTransactionTypeCreated(tblIcTransactionType);

            context.TblIcTransactionTypes.Add(tblIcTransactionType);
            context.SaveChanges();

            return tblIcTransactionType;
        }
            public async Task ExportTblIcUnitsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblicunits/excel") : "/export/canerpdbat132/tblicunits/excel", true);
        }

        public async Task ExportTblIcUnitsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblicunits/csv") : "/export/canerpdbat132/tblicunits/csv", true);
        }

        partial void OnTblIcUnitsRead(ref IQueryable<Models.CanErpDbAt132.TblIcUnit> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblIcUnit>> GetTblIcUnits(Query query = null)
        {
            var items = context.TblIcUnits.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblIcUnitsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblIcUnitCreated(Models.CanErpDbAt132.TblIcUnit item);

        public async Task<Models.CanErpDbAt132.TblIcUnit> CreateTblIcUnit(Models.CanErpDbAt132.TblIcUnit tblIcUnit)
        {
            OnTblIcUnitCreated(tblIcUnit);

            context.TblIcUnits.Add(tblIcUnit);
            context.SaveChanges();

            return tblIcUnit;
        }
            public async Task ExportTblIcWarehousesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblicwarehouses/excel") : "/export/canerpdbat132/tblicwarehouses/excel", true);
        }

        public async Task ExportTblIcWarehousesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblicwarehouses/csv") : "/export/canerpdbat132/tblicwarehouses/csv", true);
        }

        partial void OnTblIcWarehousesRead(ref IQueryable<Models.CanErpDbAt132.TblIcWarehouse> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblIcWarehouse>> GetTblIcWarehouses(Query query = null)
        {
            var items = context.TblIcWarehouses.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblIcWarehousesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblIcWarehouseCreated(Models.CanErpDbAt132.TblIcWarehouse item);

        public async Task<Models.CanErpDbAt132.TblIcWarehouse> CreateTblIcWarehouse(Models.CanErpDbAt132.TblIcWarehouse tblIcWarehouse)
        {
            OnTblIcWarehouseCreated(tblIcWarehouse);

            context.TblIcWarehouses.Add(tblIcWarehouse);
            context.SaveChanges();

            return tblIcWarehouse;
        }
            public async Task ExportTblPoAccountPayablesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpoaccountpayables/excel") : "/export/canerpdbat132/tblpoaccountpayables/excel", true);
        }

        public async Task ExportTblPoAccountPayablesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpoaccountpayables/csv") : "/export/canerpdbat132/tblpoaccountpayables/csv", true);
        }

        partial void OnTblPoAccountPayablesRead(ref IQueryable<Models.CanErpDbAt132.TblPoAccountPayable> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblPoAccountPayable>> GetTblPoAccountPayables(Query query = null)
        {
            var items = context.TblPoAccountPayables.AsQueryable();

            items = items.Include(i => i.TblPoVendor);

            items = items.Include(i => i.TblGnDepartment);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPoAccountPayablesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPoAccountPayableCreated(Models.CanErpDbAt132.TblPoAccountPayable item);

        public async Task<Models.CanErpDbAt132.TblPoAccountPayable> CreateTblPoAccountPayable(Models.CanErpDbAt132.TblPoAccountPayable tblPoAccountPayable)
        {
            OnTblPoAccountPayableCreated(tblPoAccountPayable);

            context.TblPoAccountPayables.Add(tblPoAccountPayable);
            context.SaveChanges();

            return tblPoAccountPayable;
        }
            public async Task ExportTblPoAccountsPayableAdjustmentsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpoaccountspayableadjustments/excel") : "/export/canerpdbat132/tblpoaccountspayableadjustments/excel", true);
        }

        public async Task ExportTblPoAccountsPayableAdjustmentsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpoaccountspayableadjustments/csv") : "/export/canerpdbat132/tblpoaccountspayableadjustments/csv", true);
        }

        partial void OnTblPoAccountsPayableAdjustmentsRead(ref IQueryable<Models.CanErpDbAt132.TblPoAccountsPayableAdjustment> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblPoAccountsPayableAdjustment>> GetTblPoAccountsPayableAdjustments(Query query = null)
        {
            var items = context.TblPoAccountsPayableAdjustments.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPoAccountsPayableAdjustmentsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPoAccountsPayableAdjustmentCreated(Models.CanErpDbAt132.TblPoAccountsPayableAdjustment item);

        public async Task<Models.CanErpDbAt132.TblPoAccountsPayableAdjustment> CreateTblPoAccountsPayableAdjustment(Models.CanErpDbAt132.TblPoAccountsPayableAdjustment tblPoAccountsPayableAdjustment)
        {
            OnTblPoAccountsPayableAdjustmentCreated(tblPoAccountsPayableAdjustment);

            context.TblPoAccountsPayableAdjustments.Add(tblPoAccountsPayableAdjustment);
            context.SaveChanges();

            return tblPoAccountsPayableAdjustment;
        }
            public async Task ExportTblPoApInvoicesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpoapinvoices/excel") : "/export/canerpdbat132/tblpoapinvoices/excel", true);
        }

        public async Task ExportTblPoApInvoicesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpoapinvoices/csv") : "/export/canerpdbat132/tblpoapinvoices/csv", true);
        }

        partial void OnTblPoApInvoicesRead(ref IQueryable<Models.CanErpDbAt132.TblPoApInvoice> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblPoApInvoice>> GetTblPoApInvoices(Query query = null)
        {
            var items = context.TblPoApInvoices.AsQueryable();

            items = items.Include(i => i.TblPoVendor);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPoApInvoicesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPoApInvoiceCreated(Models.CanErpDbAt132.TblPoApInvoice item);

        public async Task<Models.CanErpDbAt132.TblPoApInvoice> CreateTblPoApInvoice(Models.CanErpDbAt132.TblPoApInvoice tblPoApInvoice)
        {
            OnTblPoApInvoiceCreated(tblPoApInvoice);

            context.TblPoApInvoices.Add(tblPoApInvoice);
            context.SaveChanges();

            return tblPoApInvoice;
        }
            public async Task ExportTblPoApInvoicesDetailsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpoapinvoicesdetails/excel") : "/export/canerpdbat132/tblpoapinvoicesdetails/excel", true);
        }

        public async Task ExportTblPoApInvoicesDetailsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpoapinvoicesdetails/csv") : "/export/canerpdbat132/tblpoapinvoicesdetails/csv", true);
        }

        partial void OnTblPoApInvoicesDetailsRead(ref IQueryable<Models.CanErpDbAt132.TblPoApInvoicesDetail> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblPoApInvoicesDetail>> GetTblPoApInvoicesDetails(Query query = null)
        {
            var items = context.TblPoApInvoicesDetails.AsQueryable();

            items = items.Include(i => i.TblPoVendor);

            items = items.Include(i => i.TblIcInventory);

            items = items.Include(i => i.TblIcUnit);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPoApInvoicesDetailsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPoApInvoicesDetailCreated(Models.CanErpDbAt132.TblPoApInvoicesDetail item);

        public async Task<Models.CanErpDbAt132.TblPoApInvoicesDetail> CreateTblPoApInvoicesDetail(Models.CanErpDbAt132.TblPoApInvoicesDetail tblPoApInvoicesDetail)
        {
            OnTblPoApInvoicesDetailCreated(tblPoApInvoicesDetail);

            context.TblPoApInvoicesDetails.Add(tblPoApInvoicesDetail);
            context.SaveChanges();

            return tblPoApInvoicesDetail;
        }
            public async Task ExportTblPoCashDisbursementsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpocashdisbursements/excel") : "/export/canerpdbat132/tblpocashdisbursements/excel", true);
        }

        public async Task ExportTblPoCashDisbursementsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpocashdisbursements/csv") : "/export/canerpdbat132/tblpocashdisbursements/csv", true);
        }

        partial void OnTblPoCashDisbursementsRead(ref IQueryable<Models.CanErpDbAt132.TblPoCashDisbursement> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblPoCashDisbursement>> GetTblPoCashDisbursements(Query query = null)
        {
            var items = context.TblPoCashDisbursements.AsQueryable();

            items = items.Include(i => i.TblGnAddressBook);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPoCashDisbursementsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPoCashDisbursementCreated(Models.CanErpDbAt132.TblPoCashDisbursement item);

        public async Task<Models.CanErpDbAt132.TblPoCashDisbursement> CreateTblPoCashDisbursement(Models.CanErpDbAt132.TblPoCashDisbursement tblPoCashDisbursement)
        {
            OnTblPoCashDisbursementCreated(tblPoCashDisbursement);

            context.TblPoCashDisbursements.Add(tblPoCashDisbursement);
            context.SaveChanges();

            return tblPoCashDisbursement;
        }
            public async Task ExportTblPoOrderStatusesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpoorderstatuses/excel") : "/export/canerpdbat132/tblpoorderstatuses/excel", true);
        }

        public async Task ExportTblPoOrderStatusesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpoorderstatuses/csv") : "/export/canerpdbat132/tblpoorderstatuses/csv", true);
        }

        partial void OnTblPoOrderStatusesRead(ref IQueryable<Models.CanErpDbAt132.TblPoOrderStatus> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblPoOrderStatus>> GetTblPoOrderStatuses(Query query = null)
        {
            var items = context.TblPoOrderStatuses.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPoOrderStatusesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPoOrderStatusCreated(Models.CanErpDbAt132.TblPoOrderStatus item);

        public async Task<Models.CanErpDbAt132.TblPoOrderStatus> CreateTblPoOrderStatus(Models.CanErpDbAt132.TblPoOrderStatus tblPoOrderStatus)
        {
            OnTblPoOrderStatusCreated(tblPoOrderStatus);

            context.TblPoOrderStatuses.Add(tblPoOrderStatus);
            context.SaveChanges();

            return tblPoOrderStatus;
        }
            public async Task ExportTblPoPurchaseOrdersToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpopurchaseorders/excel") : "/export/canerpdbat132/tblpopurchaseorders/excel", true);
        }

        public async Task ExportTblPoPurchaseOrdersToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpopurchaseorders/csv") : "/export/canerpdbat132/tblpopurchaseorders/csv", true);
        }

        partial void OnTblPoPurchaseOrdersRead(ref IQueryable<Models.CanErpDbAt132.TblPoPurchaseOrder> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblPoPurchaseOrder>> GetTblPoPurchaseOrders(Query query = null)
        {
            var items = context.TblPoPurchaseOrders.AsQueryable();

            items = items.Include(i => i.TblGnAddressBook);

            items = items.Include(i => i.TblPoOrderStatus);

            items = items.Include(i => i.TblPoVendor);

            items = items.Include(i => i.TblGnShipVium);

            items = items.Include(i => i.TblGnPaymentTerm);

            items = items.Include(i => i.TblGnPaymentType);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPoPurchaseOrdersRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPoPurchaseOrderCreated(Models.CanErpDbAt132.TblPoPurchaseOrder item);

        public async Task<Models.CanErpDbAt132.TblPoPurchaseOrder> CreateTblPoPurchaseOrder(Models.CanErpDbAt132.TblPoPurchaseOrder tblPoPurchaseOrder)
        {
            OnTblPoPurchaseOrderCreated(tblPoPurchaseOrder);

            context.TblPoPurchaseOrders.Add(tblPoPurchaseOrder);
            context.SaveChanges();

            return tblPoPurchaseOrder;
        }
            public async Task ExportTblPoPurchaseOrderDetailsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpopurchaseorderdetails/excel") : "/export/canerpdbat132/tblpopurchaseorderdetails/excel", true);
        }

        public async Task ExportTblPoPurchaseOrderDetailsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpopurchaseorderdetails/csv") : "/export/canerpdbat132/tblpopurchaseorderdetails/csv", true);
        }

        partial void OnTblPoPurchaseOrderDetailsRead(ref IQueryable<Models.CanErpDbAt132.TblPoPurchaseOrderDetail> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblPoPurchaseOrderDetail>> GetTblPoPurchaseOrderDetails(Query query = null)
        {
            var items = context.TblPoPurchaseOrderDetails.AsQueryable();

            items = items.Include(i => i.TblPoPurchaseOrder);

            items = items.Include(i => i.TblIcInventory);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPoPurchaseOrderDetailsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPoPurchaseOrderDetailCreated(Models.CanErpDbAt132.TblPoPurchaseOrderDetail item);

        public async Task<Models.CanErpDbAt132.TblPoPurchaseOrderDetail> CreateTblPoPurchaseOrderDetail(Models.CanErpDbAt132.TblPoPurchaseOrderDetail tblPoPurchaseOrderDetail)
        {
            OnTblPoPurchaseOrderDetailCreated(tblPoPurchaseOrderDetail);

            context.TblPoPurchaseOrderDetails.Add(tblPoPurchaseOrderDetail);
            context.SaveChanges();

            return tblPoPurchaseOrderDetail;
        }
            public async Task ExportTblPoRecReportsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblporecreports/excel") : "/export/canerpdbat132/tblporecreports/excel", true);
        }

        public async Task ExportTblPoRecReportsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblporecreports/csv") : "/export/canerpdbat132/tblporecreports/csv", true);
        }

        partial void OnTblPoRecReportsRead(ref IQueryable<Models.CanErpDbAt132.TblPoRecReport> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblPoRecReport>> GetTblPoRecReports(Query query = null)
        {
            var items = context.TblPoRecReports.AsQueryable();

            items = items.Include(i => i.TblGnAddressBook);

            items = items.Include(i => i.TblPoVendor);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPoRecReportsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPoRecReportCreated(Models.CanErpDbAt132.TblPoRecReport item);

        public async Task<Models.CanErpDbAt132.TblPoRecReport> CreateTblPoRecReport(Models.CanErpDbAt132.TblPoRecReport tblPoRecReport)
        {
            OnTblPoRecReportCreated(tblPoRecReport);

            context.TblPoRecReports.Add(tblPoRecReport);
            context.SaveChanges();

            return tblPoRecReport;
        }
            public async Task ExportTblPoRrOrderDetailsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblporrorderdetails/excel") : "/export/canerpdbat132/tblporrorderdetails/excel", true);
        }

        public async Task ExportTblPoRrOrderDetailsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblporrorderdetails/csv") : "/export/canerpdbat132/tblporrorderdetails/csv", true);
        }

        partial void OnTblPoRrOrderDetailsRead(ref IQueryable<Models.CanErpDbAt132.TblPoRrOrderDetail> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblPoRrOrderDetail>> GetTblPoRrOrderDetails(Query query = null)
        {
            var items = context.TblPoRrOrderDetails.AsQueryable();

            items = items.Include(i => i.TblPoRecReport);

            items = items.Include(i => i.TblIcInventory);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPoRrOrderDetailsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPoRrOrderDetailCreated(Models.CanErpDbAt132.TblPoRrOrderDetail item);

        public async Task<Models.CanErpDbAt132.TblPoRrOrderDetail> CreateTblPoRrOrderDetail(Models.CanErpDbAt132.TblPoRrOrderDetail tblPoRrOrderDetail)
        {
            OnTblPoRrOrderDetailCreated(tblPoRrOrderDetail);

            context.TblPoRrOrderDetails.Add(tblPoRrOrderDetail);
            context.SaveChanges();

            return tblPoRrOrderDetail;
        }
            public async Task ExportTblPoVendorsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpovendors/excel") : "/export/canerpdbat132/tblpovendors/excel", true);
        }

        public async Task ExportTblPoVendorsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblpovendors/csv") : "/export/canerpdbat132/tblpovendors/csv", true);
        }

        partial void OnTblPoVendorsRead(ref IQueryable<Models.CanErpDbAt132.TblPoVendor> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblPoVendor>> GetTblPoVendors(Query query = null)
        {
            var items = context.TblPoVendors.AsQueryable();

            items = items.Include(i => i.TblGnAddressBook);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblPoVendorsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblPoVendorCreated(Models.CanErpDbAt132.TblPoVendor item);

        public async Task<Models.CanErpDbAt132.TblPoVendor> CreateTblPoVendor(Models.CanErpDbAt132.TblPoVendor tblPoVendor)
        {
            OnTblPoVendorCreated(tblPoVendor);

            context.TblPoVendors.Add(tblPoVendor);
            context.SaveChanges();

            return tblPoVendor;
        }
            public async Task ExportTblSoCustomersToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblsocustomers/excel") : "/export/canerpdbat132/tblsocustomers/excel", true);
        }

        public async Task ExportTblSoCustomersToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblsocustomers/csv") : "/export/canerpdbat132/tblsocustomers/csv", true);
        }

        partial void OnTblSoCustomersRead(ref IQueryable<Models.CanErpDbAt132.TblSoCustomer> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblSoCustomer>> GetTblSoCustomers(Query query = null)
        {
            var items = context.TblSoCustomers.AsQueryable();

            items = items.Include(i => i.TblGnAddressBook);

            items = items.Include(i => i.TblGnPaymentTerm);

            items = items.Include(i => i.TblGnPaymentType);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblSoCustomersRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblSoCustomerCreated(Models.CanErpDbAt132.TblSoCustomer item);

        public async Task<Models.CanErpDbAt132.TblSoCustomer> CreateTblSoCustomer(Models.CanErpDbAt132.TblSoCustomer tblSoCustomer)
        {
            OnTblSoCustomerCreated(tblSoCustomer);

            context.TblSoCustomers.Add(tblSoCustomer);
            context.SaveChanges();

            return tblSoCustomer;
        }
            public async Task ExportTblSoOrderDetailsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblsoorderdetails/excel") : "/export/canerpdbat132/tblsoorderdetails/excel", true);
        }

        public async Task ExportTblSoOrderDetailsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblsoorderdetails/csv") : "/export/canerpdbat132/tblsoorderdetails/csv", true);
        }

        partial void OnTblSoOrderDetailsRead(ref IQueryable<Models.CanErpDbAt132.TblSoOrderDetail> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblSoOrderDetail>> GetTblSoOrderDetails(Query query = null)
        {
            var items = context.TblSoOrderDetails.AsQueryable();

            items = items.Include(i => i.TblSoOrderDetailStatus);

            items = items.Include(i => i.TblSoSalesOrder);

            items = items.Include(i => i.TblIcInventory);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblSoOrderDetailsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblSoOrderDetailCreated(Models.CanErpDbAt132.TblSoOrderDetail item);

        public async Task<Models.CanErpDbAt132.TblSoOrderDetail> CreateTblSoOrderDetail(Models.CanErpDbAt132.TblSoOrderDetail tblSoOrderDetail)
        {
            OnTblSoOrderDetailCreated(tblSoOrderDetail);

            context.TblSoOrderDetails.Add(tblSoOrderDetail);
            context.SaveChanges();

            return tblSoOrderDetail;
        }
            public async Task ExportTblSoOrderDetailStatusesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblsoorderdetailstatuses/excel") : "/export/canerpdbat132/tblsoorderdetailstatuses/excel", true);
        }

        public async Task ExportTblSoOrderDetailStatusesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblsoorderdetailstatuses/csv") : "/export/canerpdbat132/tblsoorderdetailstatuses/csv", true);
        }

        partial void OnTblSoOrderDetailStatusesRead(ref IQueryable<Models.CanErpDbAt132.TblSoOrderDetailStatus> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblSoOrderDetailStatus>> GetTblSoOrderDetailStatuses(Query query = null)
        {
            var items = context.TblSoOrderDetailStatuses.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblSoOrderDetailStatusesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblSoOrderDetailStatusCreated(Models.CanErpDbAt132.TblSoOrderDetailStatus item);

        public async Task<Models.CanErpDbAt132.TblSoOrderDetailStatus> CreateTblSoOrderDetailStatus(Models.CanErpDbAt132.TblSoOrderDetailStatus tblSoOrderDetailStatus)
        {
            OnTblSoOrderDetailStatusCreated(tblSoOrderDetailStatus);

            context.TblSoOrderDetailStatuses.Add(tblSoOrderDetailStatus);
            context.SaveChanges();

            return tblSoOrderDetailStatus;
        }
            public async Task ExportTblSoOrderStatusesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblsoorderstatuses/excel") : "/export/canerpdbat132/tblsoorderstatuses/excel", true);
        }

        public async Task ExportTblSoOrderStatusesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblsoorderstatuses/csv") : "/export/canerpdbat132/tblsoorderstatuses/csv", true);
        }

        partial void OnTblSoOrderStatusesRead(ref IQueryable<Models.CanErpDbAt132.TblSoOrderStatus> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblSoOrderStatus>> GetTblSoOrderStatuses(Query query = null)
        {
            var items = context.TblSoOrderStatuses.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblSoOrderStatusesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblSoOrderStatusCreated(Models.CanErpDbAt132.TblSoOrderStatus item);

        public async Task<Models.CanErpDbAt132.TblSoOrderStatus> CreateTblSoOrderStatus(Models.CanErpDbAt132.TblSoOrderStatus tblSoOrderStatus)
        {
            OnTblSoOrderStatusCreated(tblSoOrderStatus);

            context.TblSoOrderStatuses.Add(tblSoOrderStatus);
            context.SaveChanges();

            return tblSoOrderStatus;
        }
            public async Task ExportTblSoSalesOrdersToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblsosalesorders/excel") : "/export/canerpdbat132/tblsosalesorders/excel", true);
        }

        public async Task ExportTblSoSalesOrdersToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/tblsosalesorders/csv") : "/export/canerpdbat132/tblsosalesorders/csv", true);
        }

        partial void OnTblSoSalesOrdersRead(ref IQueryable<Models.CanErpDbAt132.TblSoSalesOrder> items);

        public async Task<IQueryable<Models.CanErpDbAt132.TblSoSalesOrder>> GetTblSoSalesOrders(Query query = null)
        {
            var items = context.TblSoSalesOrders.AsQueryable();

            items = items.Include(i => i.TblSoOrderStatus);

            items = items.Include(i => i.TblSoCustomer);

            items = items.Include(i => i.TblGnShipVium);

            items = items.Include(i => i.TblGnPaymentTerm);

            items = items.Include(i => i.TblGnPaymentType);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnTblSoSalesOrdersRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnTblSoSalesOrderCreated(Models.CanErpDbAt132.TblSoSalesOrder item);

        public async Task<Models.CanErpDbAt132.TblSoSalesOrder> CreateTblSoSalesOrder(Models.CanErpDbAt132.TblSoSalesOrder tblSoSalesOrder)
        {
            OnTblSoSalesOrderCreated(tblSoSalesOrder);

            context.TblSoSalesOrders.Add(tblSoSalesOrder);
            context.SaveChanges();

            return tblSoSalesOrder;
        }
            public async Task ExportVwCustomersToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/vwcustomers/excel") : "/export/canerpdbat132/vwcustomers/excel", true);
        }

        public async Task ExportVwCustomersToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/vwcustomers/csv") : "/export/canerpdbat132/vwcustomers/csv", true);
        }

        partial void OnVwCustomersRead(ref IQueryable<Models.CanErpDbAt132.VwCustomer> items);

        public async Task<IQueryable<Models.CanErpDbAt132.VwCustomer>> GetVwCustomers(Query query = null)
        {
            var items = context.VwCustomers.AsQueryable();
            items = items.AsNoTracking();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnVwCustomersRead(ref items);

            return await Task.FromResult(items);
        }
            public async Task ExportVwEmpAndVendsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/vwempandvends/excel") : "/export/canerpdbat132/vwempandvends/excel", true);
        }

        public async Task ExportVwEmpAndVendsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/vwempandvends/csv") : "/export/canerpdbat132/vwempandvends/csv", true);
        }

        partial void OnVwEmpAndVendsRead(ref IQueryable<Models.CanErpDbAt132.VwEmpAndVend> items);

        public async Task<IQueryable<Models.CanErpDbAt132.VwEmpAndVend>> GetVwEmpAndVends(Query query = null)
        {
            var items = context.VwEmpAndVends.AsQueryable();
            items = items.AsNoTracking();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnVwEmpAndVendsRead(ref items);

            return await Task.FromResult(items);
        }
            public async Task ExportVwEmployeesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/vwemployees/excel") : "/export/canerpdbat132/vwemployees/excel", true);
        }

        public async Task ExportVwEmployeesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/vwemployees/csv") : "/export/canerpdbat132/vwemployees/csv", true);
        }

        partial void OnVwEmployeesRead(ref IQueryable<Models.CanErpDbAt132.VwEmployee> items);

        public async Task<IQueryable<Models.CanErpDbAt132.VwEmployee>> GetVwEmployees(Query query = null)
        {
            var items = context.VwEmployees.AsQueryable();
            items = items.AsNoTracking();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnVwEmployeesRead(ref items);

            return await Task.FromResult(items);
        }
            public async Task ExportVwVendorsToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/vwvendors/excel") : "/export/canerpdbat132/vwvendors/excel", true);
        }

        public async Task ExportVwVendorsToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("/export/canerpdbat132/vwvendors/csv") : "/export/canerpdbat132/vwvendors/csv", true);
        }

        partial void OnVwVendorsRead(ref IQueryable<Models.CanErpDbAt132.VwVendor> items);

        public async Task<IQueryable<Models.CanErpDbAt132.VwVendor>> GetVwVendors(Query query = null)
        {
            var items = context.VwVendors.AsQueryable();
            items = items.AsNoTracking();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnVwVendorsRead(ref items);

            return await Task.FromResult(items);
        }
    
        partial void OnTblGnAddressBookDeleted(Models.CanErpDbAt132.TblGnAddressBook item);

        public async Task<Models.CanErpDbAt132.TblGnAddressBook> DeleteTblGnAddressBook(int? addressBookSeq)
        {
            var item = context.TblGnAddressBooks
                              .Where(i => i.AddressBook_SEQ == addressBookSeq)
                              .Include(i => i.TblPoPurchaseOrders)
                              .Include(i => i.TblPoRecReports)
                              .Include(i => i.TblPoCashDisbursements)
                              .Include(i => i.TblSoCustomers)
                              .Include(i => i.TblPoVendors)
                              .FirstOrDefault();

            OnTblGnAddressBookDeleted(item);

            context.TblGnAddressBooks.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblGnAddressBookGet(Models.CanErpDbAt132.TblGnAddressBook item);

        public async Task<Models.CanErpDbAt132.TblGnAddressBook> GetTblGnAddressBookByAddressBookSeq(int? addressBookSeq)
        {
            var item = context.TblGnAddressBooks
                              .AsNoTracking()
                              .Where(i => i.AddressBook_SEQ == addressBookSeq)
                              .FirstOrDefault();

            OnTblGnAddressBookGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblGnAddressBook> CancelTblGnAddressBookChanges(Models.CanErpDbAt132.TblGnAddressBook item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblGnAddressBookUpdated(Models.CanErpDbAt132.TblGnAddressBook item);

        public async Task<Models.CanErpDbAt132.TblGnAddressBook> UpdateTblGnAddressBook(int? addressBookSeq, Models.CanErpDbAt132.TblGnAddressBook tblGnAddressBook)
        {
            OnTblGnAddressBookUpdated(tblGnAddressBook);

            var item = context.TblGnAddressBooks
                              .Where(i => i.AddressBook_SEQ == addressBookSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblGnAddressBook);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblGnAddressBook;
        }
        
        partial void OnTblGnAddressBookTypeDeleted(Models.CanErpDbAt132.TblGnAddressBookType item);

        public async Task<Models.CanErpDbAt132.TblGnAddressBookType> DeleteTblGnAddressBookType(int? addressBookTypeSeq)
        {
            var item = context.TblGnAddressBookTypes
                              .Where(i => i.AddressBookType_SEQ == addressBookTypeSeq)
                              .Include(i => i.TblGnAddressBooks)
                              .FirstOrDefault();

            OnTblGnAddressBookTypeDeleted(item);

            context.TblGnAddressBookTypes.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblGnAddressBookTypeGet(Models.CanErpDbAt132.TblGnAddressBookType item);

        public async Task<Models.CanErpDbAt132.TblGnAddressBookType> GetTblGnAddressBookTypeByAddressBookTypeSeq(int? addressBookTypeSeq)
        {
            var item = context.TblGnAddressBookTypes
                              .AsNoTracking()
                              .Where(i => i.AddressBookType_SEQ == addressBookTypeSeq)
                              .FirstOrDefault();

            OnTblGnAddressBookTypeGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblGnAddressBookType> CancelTblGnAddressBookTypeChanges(Models.CanErpDbAt132.TblGnAddressBookType item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblGnAddressBookTypeUpdated(Models.CanErpDbAt132.TblGnAddressBookType item);

        public async Task<Models.CanErpDbAt132.TblGnAddressBookType> UpdateTblGnAddressBookType(int? addressBookTypeSeq, Models.CanErpDbAt132.TblGnAddressBookType tblGnAddressBookType)
        {
            OnTblGnAddressBookTypeUpdated(tblGnAddressBookType);

            var item = context.TblGnAddressBookTypes
                              .Where(i => i.AddressBookType_SEQ == addressBookTypeSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblGnAddressBookType);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblGnAddressBookType;
        }
        
        partial void OnTblGnCityDeleted(Models.CanErpDbAt132.TblGnCity item);

        public async Task<Models.CanErpDbAt132.TblGnCity> DeleteTblGnCity(int? citySeq)
        {
            var item = context.TblGnCities
                              .Where(i => i.City_SEQ == citySeq)
                              .Include(i => i.TblGnAddressBooks)
                              .FirstOrDefault();

            OnTblGnCityDeleted(item);

            context.TblGnCities.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblGnCityGet(Models.CanErpDbAt132.TblGnCity item);

        public async Task<Models.CanErpDbAt132.TblGnCity> GetTblGnCityByCitySeq(int? citySeq)
        {
            var item = context.TblGnCities
                              .AsNoTracking()
                              .Where(i => i.City_SEQ == citySeq)
                              .FirstOrDefault();

            OnTblGnCityGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblGnCity> CancelTblGnCityChanges(Models.CanErpDbAt132.TblGnCity item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblGnCityUpdated(Models.CanErpDbAt132.TblGnCity item);

        public async Task<Models.CanErpDbAt132.TblGnCity> UpdateTblGnCity(int? citySeq, Models.CanErpDbAt132.TblGnCity tblGnCity)
        {
            OnTblGnCityUpdated(tblGnCity);

            var item = context.TblGnCities
                              .Where(i => i.City_SEQ == citySeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblGnCity);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblGnCity;
        }
        
        partial void OnTblGnDepartmentDeleted(Models.CanErpDbAt132.TblGnDepartment item);

        public async Task<Models.CanErpDbAt132.TblGnDepartment> DeleteTblGnDepartment(string departmentId)
        {
            var item = context.TblGnDepartments
                              .Where(i => i.Department_ID == departmentId)
                              .Include(i => i.TblPoAccountPayables)
                              .FirstOrDefault();

            OnTblGnDepartmentDeleted(item);

            context.TblGnDepartments.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblGnDepartmentGet(Models.CanErpDbAt132.TblGnDepartment item);

        public async Task<Models.CanErpDbAt132.TblGnDepartment> GetTblGnDepartmentByDepartmentId(string departmentId)
        {
            var item = context.TblGnDepartments
                              .AsNoTracking()
                              .Where(i => i.Department_ID == departmentId)
                              .FirstOrDefault();

            OnTblGnDepartmentGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblGnDepartment> CancelTblGnDepartmentChanges(Models.CanErpDbAt132.TblGnDepartment item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblGnDepartmentUpdated(Models.CanErpDbAt132.TblGnDepartment item);

        public async Task<Models.CanErpDbAt132.TblGnDepartment> UpdateTblGnDepartment(string departmentId, Models.CanErpDbAt132.TblGnDepartment tblGnDepartment)
        {
            OnTblGnDepartmentUpdated(tblGnDepartment);

            var item = context.TblGnDepartments
                              .Where(i => i.Department_ID == departmentId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblGnDepartment);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblGnDepartment;
        }
        
        partial void OnTblGnGenderDeleted(Models.CanErpDbAt132.TblGnGender item);

        public async Task<Models.CanErpDbAt132.TblGnGender> DeleteTblGnGender(int? genderSeq)
        {
            var item = context.TblGnGenders
                              .Where(i => i.Gender_SEQ == genderSeq)
                              .Include(i => i.TblGnAddressBooks)
                              .FirstOrDefault();

            OnTblGnGenderDeleted(item);

            context.TblGnGenders.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblGnGenderGet(Models.CanErpDbAt132.TblGnGender item);

        public async Task<Models.CanErpDbAt132.TblGnGender> GetTblGnGenderByGenderSeq(int? genderSeq)
        {
            var item = context.TblGnGenders
                              .AsNoTracking()
                              .Where(i => i.Gender_SEQ == genderSeq)
                              .FirstOrDefault();

            OnTblGnGenderGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblGnGender> CancelTblGnGenderChanges(Models.CanErpDbAt132.TblGnGender item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblGnGenderUpdated(Models.CanErpDbAt132.TblGnGender item);

        public async Task<Models.CanErpDbAt132.TblGnGender> UpdateTblGnGender(int? genderSeq, Models.CanErpDbAt132.TblGnGender tblGnGender)
        {
            OnTblGnGenderUpdated(tblGnGender);

            var item = context.TblGnGenders
                              .Where(i => i.Gender_SEQ == genderSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblGnGender);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblGnGender;
        }
        
        partial void OnTblGnIncotermDeleted(Models.CanErpDbAt132.TblGnIncoterm item);

        public async Task<Models.CanErpDbAt132.TblGnIncoterm> DeleteTblGnIncoterm(string incotermId)
        {
            var item = context.TblGnIncoterms
                              .Where(i => i.Incoterm_ID == incotermId)
                              .FirstOrDefault();

            OnTblGnIncotermDeleted(item);

            context.TblGnIncoterms.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblGnIncotermGet(Models.CanErpDbAt132.TblGnIncoterm item);

        public async Task<Models.CanErpDbAt132.TblGnIncoterm> GetTblGnIncotermByIncotermId(string incotermId)
        {
            var item = context.TblGnIncoterms
                              .AsNoTracking()
                              .Where(i => i.Incoterm_ID == incotermId)
                              .FirstOrDefault();

            OnTblGnIncotermGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblGnIncoterm> CancelTblGnIncotermChanges(Models.CanErpDbAt132.TblGnIncoterm item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblGnIncotermUpdated(Models.CanErpDbAt132.TblGnIncoterm item);

        public async Task<Models.CanErpDbAt132.TblGnIncoterm> UpdateTblGnIncoterm(string incotermId, Models.CanErpDbAt132.TblGnIncoterm tblGnIncoterm)
        {
            OnTblGnIncotermUpdated(tblGnIncoterm);

            var item = context.TblGnIncoterms
                              .Where(i => i.Incoterm_ID == incotermId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblGnIncoterm);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblGnIncoterm;
        }
        
        partial void OnTblGnPaymentTermDeleted(Models.CanErpDbAt132.TblGnPaymentTerm item);

        public async Task<Models.CanErpDbAt132.TblGnPaymentTerm> DeleteTblGnPaymentTerm(int? paymentTermSeq)
        {
            var item = context.TblGnPaymentTerms
                              .Where(i => i.PaymentTerm_SEQ == paymentTermSeq)
                              .Include(i => i.TblPoPurchaseOrders)
                              .Include(i => i.TblSoCustomers)
                              .Include(i => i.TblSoSalesOrders)
                              .FirstOrDefault();

            OnTblGnPaymentTermDeleted(item);

            context.TblGnPaymentTerms.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblGnPaymentTermGet(Models.CanErpDbAt132.TblGnPaymentTerm item);

        public async Task<Models.CanErpDbAt132.TblGnPaymentTerm> GetTblGnPaymentTermByPaymentTermSeq(int? paymentTermSeq)
        {
            var item = context.TblGnPaymentTerms
                              .AsNoTracking()
                              .Where(i => i.PaymentTerm_SEQ == paymentTermSeq)
                              .FirstOrDefault();

            OnTblGnPaymentTermGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblGnPaymentTerm> CancelTblGnPaymentTermChanges(Models.CanErpDbAt132.TblGnPaymentTerm item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblGnPaymentTermUpdated(Models.CanErpDbAt132.TblGnPaymentTerm item);

        public async Task<Models.CanErpDbAt132.TblGnPaymentTerm> UpdateTblGnPaymentTerm(int? paymentTermSeq, Models.CanErpDbAt132.TblGnPaymentTerm tblGnPaymentTerm)
        {
            OnTblGnPaymentTermUpdated(tblGnPaymentTerm);

            var item = context.TblGnPaymentTerms
                              .Where(i => i.PaymentTerm_SEQ == paymentTermSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblGnPaymentTerm);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblGnPaymentTerm;
        }
        
        partial void OnTblGnPaymentTypeDeleted(Models.CanErpDbAt132.TblGnPaymentType item);

        public async Task<Models.CanErpDbAt132.TblGnPaymentType> DeleteTblGnPaymentType(int? paymentTypeSeq)
        {
            var item = context.TblGnPaymentTypes
                              .Where(i => i.PaymentType_SEQ == paymentTypeSeq)
                              .Include(i => i.TblPoPurchaseOrders)
                              .Include(i => i.TblSoCustomers)
                              .Include(i => i.TblSoSalesOrders)
                              .FirstOrDefault();

            OnTblGnPaymentTypeDeleted(item);

            context.TblGnPaymentTypes.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblGnPaymentTypeGet(Models.CanErpDbAt132.TblGnPaymentType item);

        public async Task<Models.CanErpDbAt132.TblGnPaymentType> GetTblGnPaymentTypeByPaymentTypeSeq(int? paymentTypeSeq)
        {
            var item = context.TblGnPaymentTypes
                              .AsNoTracking()
                              .Where(i => i.PaymentType_SEQ == paymentTypeSeq)
                              .FirstOrDefault();

            OnTblGnPaymentTypeGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblGnPaymentType> CancelTblGnPaymentTypeChanges(Models.CanErpDbAt132.TblGnPaymentType item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblGnPaymentTypeUpdated(Models.CanErpDbAt132.TblGnPaymentType item);

        public async Task<Models.CanErpDbAt132.TblGnPaymentType> UpdateTblGnPaymentType(int? paymentTypeSeq, Models.CanErpDbAt132.TblGnPaymentType tblGnPaymentType)
        {
            OnTblGnPaymentTypeUpdated(tblGnPaymentType);

            var item = context.TblGnPaymentTypes
                              .Where(i => i.PaymentType_SEQ == paymentTypeSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblGnPaymentType);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblGnPaymentType;
        }
        
        partial void OnTblGnProductDeleted(Models.CanErpDbAt132.TblGnProduct item);

        public async Task<Models.CanErpDbAt132.TblGnProduct> DeleteTblGnProduct(int? productSeq)
        {
            var item = context.TblGnProducts
                              .Where(i => i.Product_SEQ == productSeq)
                              .Include(i => i.TblIcTransactions)
                              .Include(i => i.TblIcInventories)
                              .FirstOrDefault();

            OnTblGnProductDeleted(item);

            context.TblGnProducts.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblGnProductGet(Models.CanErpDbAt132.TblGnProduct item);

        public async Task<Models.CanErpDbAt132.TblGnProduct> GetTblGnProductByProductSeq(int? productSeq)
        {
            var item = context.TblGnProducts
                              .AsNoTracking()
                              .Where(i => i.Product_SEQ == productSeq)
                              .FirstOrDefault();

            OnTblGnProductGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblGnProduct> CancelTblGnProductChanges(Models.CanErpDbAt132.TblGnProduct item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblGnProductUpdated(Models.CanErpDbAt132.TblGnProduct item);

        public async Task<Models.CanErpDbAt132.TblGnProduct> UpdateTblGnProduct(int? productSeq, Models.CanErpDbAt132.TblGnProduct tblGnProduct)
        {
            OnTblGnProductUpdated(tblGnProduct);

            var item = context.TblGnProducts
                              .Where(i => i.Product_SEQ == productSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblGnProduct);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblGnProduct;
        }
        
        partial void OnTblGnShipViumDeleted(Models.CanErpDbAt132.TblGnShipVium item);

        public async Task<Models.CanErpDbAt132.TblGnShipVium> DeleteTblGnShipVium(int? shipViaSeq)
        {
            var item = context.TblGnShipVia
                              .Where(i => i.ShipVia_SEQ == shipViaSeq)
                              .Include(i => i.TblPoPurchaseOrders)
                              .Include(i => i.TblSoSalesOrders)
                              .FirstOrDefault();

            OnTblGnShipViumDeleted(item);

            context.TblGnShipVia.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblGnShipViumGet(Models.CanErpDbAt132.TblGnShipVium item);

        public async Task<Models.CanErpDbAt132.TblGnShipVium> GetTblGnShipViumByShipViaSeq(int? shipViaSeq)
        {
            var item = context.TblGnShipVia
                              .AsNoTracking()
                              .Where(i => i.ShipVia_SEQ == shipViaSeq)
                              .FirstOrDefault();

            OnTblGnShipViumGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblGnShipVium> CancelTblGnShipViumChanges(Models.CanErpDbAt132.TblGnShipVium item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblGnShipViumUpdated(Models.CanErpDbAt132.TblGnShipVium item);

        public async Task<Models.CanErpDbAt132.TblGnShipVium> UpdateTblGnShipVium(int? shipViaSeq, Models.CanErpDbAt132.TblGnShipVium tblGnShipVium)
        {
            OnTblGnShipViumUpdated(tblGnShipVium);

            var item = context.TblGnShipVia
                              .Where(i => i.ShipVia_SEQ == shipViaSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblGnShipVium);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblGnShipVium;
        }
        
        partial void OnTblIcCategoryDeleted(Models.CanErpDbAt132.TblIcCategory item);

        public async Task<Models.CanErpDbAt132.TblIcCategory> DeleteTblIcCategory(string categoryId)
        {
            var item = context.TblIcCategories
                              .Where(i => i.Category_ID == categoryId)
                              .Include(i => i.TblIcInventories)
                              .FirstOrDefault();

            OnTblIcCategoryDeleted(item);

            context.TblIcCategories.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblIcCategoryGet(Models.CanErpDbAt132.TblIcCategory item);

        public async Task<Models.CanErpDbAt132.TblIcCategory> GetTblIcCategoryByCategoryId(string categoryId)
        {
            var item = context.TblIcCategories
                              .AsNoTracking()
                              .Where(i => i.Category_ID == categoryId)
                              .FirstOrDefault();

            OnTblIcCategoryGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblIcCategory> CancelTblIcCategoryChanges(Models.CanErpDbAt132.TblIcCategory item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblIcCategoryUpdated(Models.CanErpDbAt132.TblIcCategory item);

        public async Task<Models.CanErpDbAt132.TblIcCategory> UpdateTblIcCategory(string categoryId, Models.CanErpDbAt132.TblIcCategory tblIcCategory)
        {
            OnTblIcCategoryUpdated(tblIcCategory);

            var item = context.TblIcCategories
                              .Where(i => i.Category_ID == categoryId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblIcCategory);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblIcCategory;
        }
        
        partial void OnTblIcClassificationDeleted(Models.CanErpDbAt132.TblIcClassification item);

        public async Task<Models.CanErpDbAt132.TblIcClassification> DeleteTblIcClassification(string classifiId)
        {
            var item = context.TblIcClassifications
                              .Where(i => i.Classifi_ID == classifiId)
                              .Include(i => i.TblIcInventories)
                              .FirstOrDefault();

            OnTblIcClassificationDeleted(item);

            context.TblIcClassifications.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblIcClassificationGet(Models.CanErpDbAt132.TblIcClassification item);

        public async Task<Models.CanErpDbAt132.TblIcClassification> GetTblIcClassificationByClassifiId(string classifiId)
        {
            var item = context.TblIcClassifications
                              .AsNoTracking()
                              .Where(i => i.Classifi_ID == classifiId)
                              .FirstOrDefault();

            OnTblIcClassificationGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblIcClassification> CancelTblIcClassificationChanges(Models.CanErpDbAt132.TblIcClassification item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblIcClassificationUpdated(Models.CanErpDbAt132.TblIcClassification item);

        public async Task<Models.CanErpDbAt132.TblIcClassification> UpdateTblIcClassification(string classifiId, Models.CanErpDbAt132.TblIcClassification tblIcClassification)
        {
            OnTblIcClassificationUpdated(tblIcClassification);

            var item = context.TblIcClassifications
                              .Where(i => i.Classifi_ID == classifiId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblIcClassification);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblIcClassification;
        }
        
        partial void OnTblIcInventoryDeleted(Models.CanErpDbAt132.TblIcInventory item);

        public async Task<Models.CanErpDbAt132.TblIcInventory> DeleteTblIcInventory(int? inventorySeq)
        {
            var item = context.TblIcInventories
                              .Where(i => i.Inventory_SEQ == inventorySeq)
                              .Include(i => i.TblPoPurchaseOrderDetails)
                              .Include(i => i.TblPoApInvoicesDetails)
                              .Include(i => i.TblPoRrOrderDetails)
                              .Include(i => i.TblSoOrderDetails)
                              .FirstOrDefault();

            OnTblIcInventoryDeleted(item);

            context.TblIcInventories.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblIcInventoryGet(Models.CanErpDbAt132.TblIcInventory item);

        public async Task<Models.CanErpDbAt132.TblIcInventory> GetTblIcInventoryByInventorySeq(int? inventorySeq)
        {
            var item = context.TblIcInventories
                              .AsNoTracking()
                              .Where(i => i.Inventory_SEQ == inventorySeq)
                              .FirstOrDefault();

            OnTblIcInventoryGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblIcInventory> CancelTblIcInventoryChanges(Models.CanErpDbAt132.TblIcInventory item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblIcInventoryUpdated(Models.CanErpDbAt132.TblIcInventory item);

        public async Task<Models.CanErpDbAt132.TblIcInventory> UpdateTblIcInventory(int? inventorySeq, Models.CanErpDbAt132.TblIcInventory tblIcInventory)
        {
            OnTblIcInventoryUpdated(tblIcInventory);

            var item = context.TblIcInventories
                              .Where(i => i.Inventory_SEQ == inventorySeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblIcInventory);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblIcInventory;
        }
        
        partial void OnTblIcTransactionDeleted(Models.CanErpDbAt132.TblIcTransaction item);

        public async Task<Models.CanErpDbAt132.TblIcTransaction> DeleteTblIcTransaction(string transNo)
        {
            var item = context.TblIcTransactions
                              .Where(i => i.Trans_No == transNo)
                              .FirstOrDefault();

            OnTblIcTransactionDeleted(item);

            context.TblIcTransactions.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblIcTransactionGet(Models.CanErpDbAt132.TblIcTransaction item);

        public async Task<Models.CanErpDbAt132.TblIcTransaction> GetTblIcTransactionByTransNo(string transNo)
        {
            var item = context.TblIcTransactions
                              .AsNoTracking()
                              .Where(i => i.Trans_No == transNo)
                              .FirstOrDefault();

            OnTblIcTransactionGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblIcTransaction> CancelTblIcTransactionChanges(Models.CanErpDbAt132.TblIcTransaction item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblIcTransactionUpdated(Models.CanErpDbAt132.TblIcTransaction item);

        public async Task<Models.CanErpDbAt132.TblIcTransaction> UpdateTblIcTransaction(string transNo, Models.CanErpDbAt132.TblIcTransaction tblIcTransaction)
        {
            OnTblIcTransactionUpdated(tblIcTransaction);

            var item = context.TblIcTransactions
                              .Where(i => i.Trans_No == transNo)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblIcTransaction);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblIcTransaction;
        }
        
        partial void OnTblIcTransactionTypeDeleted(Models.CanErpDbAt132.TblIcTransactionType item);

        public async Task<Models.CanErpDbAt132.TblIcTransactionType> DeleteTblIcTransactionType(string transactionId)
        {
            var item = context.TblIcTransactionTypes
                              .Where(i => i.Transaction_ID == transactionId)
                              .Include(i => i.TblIcTransactions)
                              .FirstOrDefault();

            OnTblIcTransactionTypeDeleted(item);

            context.TblIcTransactionTypes.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblIcTransactionTypeGet(Models.CanErpDbAt132.TblIcTransactionType item);

        public async Task<Models.CanErpDbAt132.TblIcTransactionType> GetTblIcTransactionTypeByTransactionId(string transactionId)
        {
            var item = context.TblIcTransactionTypes
                              .AsNoTracking()
                              .Where(i => i.Transaction_ID == transactionId)
                              .FirstOrDefault();

            OnTblIcTransactionTypeGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblIcTransactionType> CancelTblIcTransactionTypeChanges(Models.CanErpDbAt132.TblIcTransactionType item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblIcTransactionTypeUpdated(Models.CanErpDbAt132.TblIcTransactionType item);

        public async Task<Models.CanErpDbAt132.TblIcTransactionType> UpdateTblIcTransactionType(string transactionId, Models.CanErpDbAt132.TblIcTransactionType tblIcTransactionType)
        {
            OnTblIcTransactionTypeUpdated(tblIcTransactionType);

            var item = context.TblIcTransactionTypes
                              .Where(i => i.Transaction_ID == transactionId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblIcTransactionType);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblIcTransactionType;
        }
        
        partial void OnTblIcUnitDeleted(Models.CanErpDbAt132.TblIcUnit item);

        public async Task<Models.CanErpDbAt132.TblIcUnit> DeleteTblIcUnit(int? unitSeq)
        {
            var item = context.TblIcUnits
                              .Where(i => i.Unit_SEQ == unitSeq)
                              .Include(i => i.TblPoApInvoicesDetails)
                              .Include(i => i.TblIcInventories)
                              .FirstOrDefault();

            OnTblIcUnitDeleted(item);

            context.TblIcUnits.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblIcUnitGet(Models.CanErpDbAt132.TblIcUnit item);

        public async Task<Models.CanErpDbAt132.TblIcUnit> GetTblIcUnitByUnitSeq(int? unitSeq)
        {
            var item = context.TblIcUnits
                              .AsNoTracking()
                              .Where(i => i.Unit_SEQ == unitSeq)
                              .FirstOrDefault();

            OnTblIcUnitGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblIcUnit> CancelTblIcUnitChanges(Models.CanErpDbAt132.TblIcUnit item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblIcUnitUpdated(Models.CanErpDbAt132.TblIcUnit item);

        public async Task<Models.CanErpDbAt132.TblIcUnit> UpdateTblIcUnit(int? unitSeq, Models.CanErpDbAt132.TblIcUnit tblIcUnit)
        {
            OnTblIcUnitUpdated(tblIcUnit);

            var item = context.TblIcUnits
                              .Where(i => i.Unit_SEQ == unitSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblIcUnit);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblIcUnit;
        }
        
        partial void OnTblIcWarehouseDeleted(Models.CanErpDbAt132.TblIcWarehouse item);

        public async Task<Models.CanErpDbAt132.TblIcWarehouse> DeleteTblIcWarehouse(string warehouseId)
        {
            var item = context.TblIcWarehouses
                              .Where(i => i.Warehouse_ID == warehouseId)
                              .Include(i => i.TblIcTransactions)
                              .Include(i => i.TblIcInventories)
                              .FirstOrDefault();

            OnTblIcWarehouseDeleted(item);

            context.TblIcWarehouses.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblIcWarehouseGet(Models.CanErpDbAt132.TblIcWarehouse item);

        public async Task<Models.CanErpDbAt132.TblIcWarehouse> GetTblIcWarehouseByWarehouseId(string warehouseId)
        {
            var item = context.TblIcWarehouses
                              .AsNoTracking()
                              .Where(i => i.Warehouse_ID == warehouseId)
                              .FirstOrDefault();

            OnTblIcWarehouseGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblIcWarehouse> CancelTblIcWarehouseChanges(Models.CanErpDbAt132.TblIcWarehouse item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblIcWarehouseUpdated(Models.CanErpDbAt132.TblIcWarehouse item);

        public async Task<Models.CanErpDbAt132.TblIcWarehouse> UpdateTblIcWarehouse(string warehouseId, Models.CanErpDbAt132.TblIcWarehouse tblIcWarehouse)
        {
            OnTblIcWarehouseUpdated(tblIcWarehouse);

            var item = context.TblIcWarehouses
                              .Where(i => i.Warehouse_ID == warehouseId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblIcWarehouse);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblIcWarehouse;
        }
        
        partial void OnTblPoAccountPayableDeleted(Models.CanErpDbAt132.TblPoAccountPayable item);

        public async Task<Models.CanErpDbAt132.TblPoAccountPayable> DeleteTblPoAccountPayable(string apNo)
        {
            var item = context.TblPoAccountPayables
                              .Where(i => i.AP_No == apNo)
                              .FirstOrDefault();

            OnTblPoAccountPayableDeleted(item);

            context.TblPoAccountPayables.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblPoAccountPayableGet(Models.CanErpDbAt132.TblPoAccountPayable item);

        public async Task<Models.CanErpDbAt132.TblPoAccountPayable> GetTblPoAccountPayableByApNo(string apNo)
        {
            var item = context.TblPoAccountPayables
                              .AsNoTracking()
                              .Where(i => i.AP_No == apNo)
                              .FirstOrDefault();

            OnTblPoAccountPayableGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblPoAccountPayable> CancelTblPoAccountPayableChanges(Models.CanErpDbAt132.TblPoAccountPayable item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPoAccountPayableUpdated(Models.CanErpDbAt132.TblPoAccountPayable item);

        public async Task<Models.CanErpDbAt132.TblPoAccountPayable> UpdateTblPoAccountPayable(string apNo, Models.CanErpDbAt132.TblPoAccountPayable tblPoAccountPayable)
        {
            OnTblPoAccountPayableUpdated(tblPoAccountPayable);

            var item = context.TblPoAccountPayables
                              .Where(i => i.AP_No == apNo)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPoAccountPayable);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblPoAccountPayable;
        }
        
        partial void OnTblPoAccountsPayableAdjustmentDeleted(Models.CanErpDbAt132.TblPoAccountsPayableAdjustment item);

        public async Task<Models.CanErpDbAt132.TblPoAccountsPayableAdjustment> DeleteTblPoAccountsPayableAdjustment(string voucherNo)
        {
            var item = context.TblPoAccountsPayableAdjustments
                              .Where(i => i.Voucher_No == voucherNo)
                              .FirstOrDefault();

            OnTblPoAccountsPayableAdjustmentDeleted(item);

            context.TblPoAccountsPayableAdjustments.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblPoAccountsPayableAdjustmentGet(Models.CanErpDbAt132.TblPoAccountsPayableAdjustment item);

        public async Task<Models.CanErpDbAt132.TblPoAccountsPayableAdjustment> GetTblPoAccountsPayableAdjustmentByVoucherNo(string voucherNo)
        {
            var item = context.TblPoAccountsPayableAdjustments
                              .AsNoTracking()
                              .Where(i => i.Voucher_No == voucherNo)
                              .FirstOrDefault();

            OnTblPoAccountsPayableAdjustmentGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblPoAccountsPayableAdjustment> CancelTblPoAccountsPayableAdjustmentChanges(Models.CanErpDbAt132.TblPoAccountsPayableAdjustment item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPoAccountsPayableAdjustmentUpdated(Models.CanErpDbAt132.TblPoAccountsPayableAdjustment item);

        public async Task<Models.CanErpDbAt132.TblPoAccountsPayableAdjustment> UpdateTblPoAccountsPayableAdjustment(string voucherNo, Models.CanErpDbAt132.TblPoAccountsPayableAdjustment tblPoAccountsPayableAdjustment)
        {
            OnTblPoAccountsPayableAdjustmentUpdated(tblPoAccountsPayableAdjustment);

            var item = context.TblPoAccountsPayableAdjustments
                              .Where(i => i.Voucher_No == voucherNo)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPoAccountsPayableAdjustment);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblPoAccountsPayableAdjustment;
        }
        
        partial void OnTblPoApInvoiceDeleted(Models.CanErpDbAt132.TblPoApInvoice item);

        public async Task<Models.CanErpDbAt132.TblPoApInvoice> DeleteTblPoApInvoice(string vendorId, string invoiceNo)
        {
            var item = context.TblPoApInvoices
                              .Where(i => i.Vendor_ID == vendorId && i.Invoice_No == invoiceNo)
                              .FirstOrDefault();

            OnTblPoApInvoiceDeleted(item);

            context.TblPoApInvoices.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblPoApInvoiceGet(Models.CanErpDbAt132.TblPoApInvoice item);

        public async Task<Models.CanErpDbAt132.TblPoApInvoice> GetTblPoApInvoiceByVendorIdAndInvoiceNo(string vendorId, string invoiceNo)
        {
            var item = context.TblPoApInvoices
                              .AsNoTracking()
                              .Where(i => i.Vendor_ID == vendorId && i.Invoice_No == invoiceNo)
                              .FirstOrDefault();

            OnTblPoApInvoiceGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblPoApInvoice> CancelTblPoApInvoiceChanges(Models.CanErpDbAt132.TblPoApInvoice item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPoApInvoiceUpdated(Models.CanErpDbAt132.TblPoApInvoice item);

        public async Task<Models.CanErpDbAt132.TblPoApInvoice> UpdateTblPoApInvoice(string vendorId, string invoiceNo, Models.CanErpDbAt132.TblPoApInvoice tblPoApInvoice)
        {
            OnTblPoApInvoiceUpdated(tblPoApInvoice);

            var item = context.TblPoApInvoices
                              .Where(i => i.Vendor_ID == vendorId && i.Invoice_No == invoiceNo)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPoApInvoice);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblPoApInvoice;
        }
        
        partial void OnTblPoApInvoicesDetailDeleted(Models.CanErpDbAt132.TblPoApInvoicesDetail item);

        public async Task<Models.CanErpDbAt132.TblPoApInvoicesDetail> DeleteTblPoApInvoicesDetail(string vendorId, string invoiceNo)
        {
            var item = context.TblPoApInvoicesDetails
                              .Where(i => i.Vendor_ID == vendorId && i.Invoice_No == invoiceNo)
                              .FirstOrDefault();

            OnTblPoApInvoicesDetailDeleted(item);

            context.TblPoApInvoicesDetails.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblPoApInvoicesDetailGet(Models.CanErpDbAt132.TblPoApInvoicesDetail item);

        public async Task<Models.CanErpDbAt132.TblPoApInvoicesDetail> GetTblPoApInvoicesDetailByVendorIdAndInvoiceNo(string vendorId, string invoiceNo)
        {
            var item = context.TblPoApInvoicesDetails
                              .AsNoTracking()
                              .Where(i => i.Vendor_ID == vendorId && i.Invoice_No == invoiceNo)
                              .FirstOrDefault();

            OnTblPoApInvoicesDetailGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblPoApInvoicesDetail> CancelTblPoApInvoicesDetailChanges(Models.CanErpDbAt132.TblPoApInvoicesDetail item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPoApInvoicesDetailUpdated(Models.CanErpDbAt132.TblPoApInvoicesDetail item);

        public async Task<Models.CanErpDbAt132.TblPoApInvoicesDetail> UpdateTblPoApInvoicesDetail(string vendorId, string invoiceNo, Models.CanErpDbAt132.TblPoApInvoicesDetail tblPoApInvoicesDetail)
        {
            OnTblPoApInvoicesDetailUpdated(tblPoApInvoicesDetail);

            var item = context.TblPoApInvoicesDetails
                              .Where(i => i.Vendor_ID == vendorId && i.Invoice_No == invoiceNo)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPoApInvoicesDetail);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblPoApInvoicesDetail;
        }
        
        partial void OnTblPoCashDisbursementDeleted(Models.CanErpDbAt132.TblPoCashDisbursement item);

        public async Task<Models.CanErpDbAt132.TblPoCashDisbursement> DeleteTblPoCashDisbursement(string poCashDisbNo)
        {
            var item = context.TblPoCashDisbursements
                              .Where(i => i.PO_CashDisb_No == poCashDisbNo)
                              .FirstOrDefault();

            OnTblPoCashDisbursementDeleted(item);

            context.TblPoCashDisbursements.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblPoCashDisbursementGet(Models.CanErpDbAt132.TblPoCashDisbursement item);

        public async Task<Models.CanErpDbAt132.TblPoCashDisbursement> GetTblPoCashDisbursementByPoCashDisbNo(string poCashDisbNo)
        {
            var item = context.TblPoCashDisbursements
                              .AsNoTracking()
                              .Where(i => i.PO_CashDisb_No == poCashDisbNo)
                              .FirstOrDefault();

            OnTblPoCashDisbursementGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblPoCashDisbursement> CancelTblPoCashDisbursementChanges(Models.CanErpDbAt132.TblPoCashDisbursement item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPoCashDisbursementUpdated(Models.CanErpDbAt132.TblPoCashDisbursement item);

        public async Task<Models.CanErpDbAt132.TblPoCashDisbursement> UpdateTblPoCashDisbursement(string poCashDisbNo, Models.CanErpDbAt132.TblPoCashDisbursement tblPoCashDisbursement)
        {
            OnTblPoCashDisbursementUpdated(tblPoCashDisbursement);

            var item = context.TblPoCashDisbursements
                              .Where(i => i.PO_CashDisb_No == poCashDisbNo)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPoCashDisbursement);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblPoCashDisbursement;
        }
        
        partial void OnTblPoOrderStatusDeleted(Models.CanErpDbAt132.TblPoOrderStatus item);

        public async Task<Models.CanErpDbAt132.TblPoOrderStatus> DeleteTblPoOrderStatus(string poStatusId)
        {
            var item = context.TblPoOrderStatuses
                              .Where(i => i.POStatus_ID == poStatusId)
                              .Include(i => i.TblPoPurchaseOrders)
                              .FirstOrDefault();

            OnTblPoOrderStatusDeleted(item);

            context.TblPoOrderStatuses.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblPoOrderStatusGet(Models.CanErpDbAt132.TblPoOrderStatus item);

        public async Task<Models.CanErpDbAt132.TblPoOrderStatus> GetTblPoOrderStatusByPoStatusId(string poStatusId)
        {
            var item = context.TblPoOrderStatuses
                              .AsNoTracking()
                              .Where(i => i.POStatus_ID == poStatusId)
                              .FirstOrDefault();

            OnTblPoOrderStatusGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblPoOrderStatus> CancelTblPoOrderStatusChanges(Models.CanErpDbAt132.TblPoOrderStatus item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPoOrderStatusUpdated(Models.CanErpDbAt132.TblPoOrderStatus item);

        public async Task<Models.CanErpDbAt132.TblPoOrderStatus> UpdateTblPoOrderStatus(string poStatusId, Models.CanErpDbAt132.TblPoOrderStatus tblPoOrderStatus)
        {
            OnTblPoOrderStatusUpdated(tblPoOrderStatus);

            var item = context.TblPoOrderStatuses
                              .Where(i => i.POStatus_ID == poStatusId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPoOrderStatus);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblPoOrderStatus;
        }
        
        partial void OnTblPoPurchaseOrderDeleted(Models.CanErpDbAt132.TblPoPurchaseOrder item);

        public async Task<Models.CanErpDbAt132.TblPoPurchaseOrder> DeleteTblPoPurchaseOrder(string poId)
        {
            var item = context.TblPoPurchaseOrders
                              .Where(i => i.PO_ID == poId)
                              .Include(i => i.TblPoPurchaseOrderDetails)
                              .FirstOrDefault();

            OnTblPoPurchaseOrderDeleted(item);

            context.TblPoPurchaseOrders.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblPoPurchaseOrderGet(Models.CanErpDbAt132.TblPoPurchaseOrder item);

        public async Task<Models.CanErpDbAt132.TblPoPurchaseOrder> GetTblPoPurchaseOrderByPoId(string poId)
        {
            var item = context.TblPoPurchaseOrders
                              .AsNoTracking()
                              .Where(i => i.PO_ID == poId)
                              .FirstOrDefault();

            OnTblPoPurchaseOrderGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblPoPurchaseOrder> CancelTblPoPurchaseOrderChanges(Models.CanErpDbAt132.TblPoPurchaseOrder item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPoPurchaseOrderUpdated(Models.CanErpDbAt132.TblPoPurchaseOrder item);

        public async Task<Models.CanErpDbAt132.TblPoPurchaseOrder> UpdateTblPoPurchaseOrder(string poId, Models.CanErpDbAt132.TblPoPurchaseOrder tblPoPurchaseOrder)
        {
            OnTblPoPurchaseOrderUpdated(tblPoPurchaseOrder);

            var item = context.TblPoPurchaseOrders
                              .Where(i => i.PO_ID == poId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPoPurchaseOrder);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblPoPurchaseOrder;
        }
        
        partial void OnTblPoPurchaseOrderDetailDeleted(Models.CanErpDbAt132.TblPoPurchaseOrderDetail item);

        public async Task<Models.CanErpDbAt132.TblPoPurchaseOrderDetail> DeleteTblPoPurchaseOrderDetail(string poFk, int? inventoryFk)
        {
            var item = context.TblPoPurchaseOrderDetails
                              .Where(i => i.PO_FK == poFk && i.Inventory_FK == inventoryFk)
                              .FirstOrDefault();

            OnTblPoPurchaseOrderDetailDeleted(item);

            context.TblPoPurchaseOrderDetails.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblPoPurchaseOrderDetailGet(Models.CanErpDbAt132.TblPoPurchaseOrderDetail item);

        public async Task<Models.CanErpDbAt132.TblPoPurchaseOrderDetail> GetTblPoPurchaseOrderDetailByPoFkAndInventoryFk(string poFk, int? inventoryFk)
        {
            var item = context.TblPoPurchaseOrderDetails
                              .AsNoTracking()
                              .Where(i => i.PO_FK == poFk && i.Inventory_FK == inventoryFk)
                              .FirstOrDefault();

            OnTblPoPurchaseOrderDetailGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblPoPurchaseOrderDetail> CancelTblPoPurchaseOrderDetailChanges(Models.CanErpDbAt132.TblPoPurchaseOrderDetail item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPoPurchaseOrderDetailUpdated(Models.CanErpDbAt132.TblPoPurchaseOrderDetail item);

        public async Task<Models.CanErpDbAt132.TblPoPurchaseOrderDetail> UpdateTblPoPurchaseOrderDetail(string poFk, int? inventoryFk, Models.CanErpDbAt132.TblPoPurchaseOrderDetail tblPoPurchaseOrderDetail)
        {
            OnTblPoPurchaseOrderDetailUpdated(tblPoPurchaseOrderDetail);

            var item = context.TblPoPurchaseOrderDetails
                              .Where(i => i.PO_FK == poFk && i.Inventory_FK == inventoryFk)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPoPurchaseOrderDetail);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblPoPurchaseOrderDetail;
        }
        
        partial void OnTblPoRecReportDeleted(Models.CanErpDbAt132.TblPoRecReport item);

        public async Task<Models.CanErpDbAt132.TblPoRecReport> DeleteTblPoRecReport(string rrNo)
        {
            var item = context.TblPoRecReports
                              .Where(i => i.RR_No == rrNo)
                              .Include(i => i.TblPoRrOrderDetails)
                              .FirstOrDefault();

            OnTblPoRecReportDeleted(item);

            context.TblPoRecReports.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblPoRecReportGet(Models.CanErpDbAt132.TblPoRecReport item);

        public async Task<Models.CanErpDbAt132.TblPoRecReport> GetTblPoRecReportByRrNo(string rrNo)
        {
            var item = context.TblPoRecReports
                              .AsNoTracking()
                              .Where(i => i.RR_No == rrNo)
                              .FirstOrDefault();

            OnTblPoRecReportGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblPoRecReport> CancelTblPoRecReportChanges(Models.CanErpDbAt132.TblPoRecReport item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPoRecReportUpdated(Models.CanErpDbAt132.TblPoRecReport item);

        public async Task<Models.CanErpDbAt132.TblPoRecReport> UpdateTblPoRecReport(string rrNo, Models.CanErpDbAt132.TblPoRecReport tblPoRecReport)
        {
            OnTblPoRecReportUpdated(tblPoRecReport);

            var item = context.TblPoRecReports
                              .Where(i => i.RR_No == rrNo)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPoRecReport);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblPoRecReport;
        }
        
        partial void OnTblPoRrOrderDetailDeleted(Models.CanErpDbAt132.TblPoRrOrderDetail item);

        public async Task<Models.CanErpDbAt132.TblPoRrOrderDetail> DeleteTblPoRrOrderDetail(string rrFk, int? inventoryFk)
        {
            var item = context.TblPoRrOrderDetails
                              .Where(i => i.RR_FK == rrFk && i.Inventory_FK == inventoryFk)
                              .FirstOrDefault();

            OnTblPoRrOrderDetailDeleted(item);

            context.TblPoRrOrderDetails.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblPoRrOrderDetailGet(Models.CanErpDbAt132.TblPoRrOrderDetail item);

        public async Task<Models.CanErpDbAt132.TblPoRrOrderDetail> GetTblPoRrOrderDetailByRrFkAndInventoryFk(string rrFk, int? inventoryFk)
        {
            var item = context.TblPoRrOrderDetails
                              .AsNoTracking()
                              .Where(i => i.RR_FK == rrFk && i.Inventory_FK == inventoryFk)
                              .FirstOrDefault();

            OnTblPoRrOrderDetailGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblPoRrOrderDetail> CancelTblPoRrOrderDetailChanges(Models.CanErpDbAt132.TblPoRrOrderDetail item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPoRrOrderDetailUpdated(Models.CanErpDbAt132.TblPoRrOrderDetail item);

        public async Task<Models.CanErpDbAt132.TblPoRrOrderDetail> UpdateTblPoRrOrderDetail(string rrFk, int? inventoryFk, Models.CanErpDbAt132.TblPoRrOrderDetail tblPoRrOrderDetail)
        {
            OnTblPoRrOrderDetailUpdated(tblPoRrOrderDetail);

            var item = context.TblPoRrOrderDetails
                              .Where(i => i.RR_FK == rrFk && i.Inventory_FK == inventoryFk)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPoRrOrderDetail);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblPoRrOrderDetail;
        }
        
        partial void OnTblPoVendorDeleted(Models.CanErpDbAt132.TblPoVendor item);

        public async Task<Models.CanErpDbAt132.TblPoVendor> DeleteTblPoVendor(string vendorId)
        {
            var item = context.TblPoVendors
                              .Where(i => i.Vendor_ID == vendorId)
                              .Include(i => i.TblPoPurchaseOrders)
                              .Include(i => i.TblPoAccountPayables)
                              .Include(i => i.TblPoApInvoices)
                              .Include(i => i.TblPoApInvoicesDetails)
                              .Include(i => i.TblPoRecReports)
                              .FirstOrDefault();

            OnTblPoVendorDeleted(item);

            context.TblPoVendors.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblPoVendorGet(Models.CanErpDbAt132.TblPoVendor item);

        public async Task<Models.CanErpDbAt132.TblPoVendor> GetTblPoVendorByVendorId(string vendorId)
        {
            var item = context.TblPoVendors
                              .AsNoTracking()
                              .Where(i => i.Vendor_ID == vendorId)
                              .FirstOrDefault();

            OnTblPoVendorGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblPoVendor> CancelTblPoVendorChanges(Models.CanErpDbAt132.TblPoVendor item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblPoVendorUpdated(Models.CanErpDbAt132.TblPoVendor item);

        public async Task<Models.CanErpDbAt132.TblPoVendor> UpdateTblPoVendor(string vendorId, Models.CanErpDbAt132.TblPoVendor tblPoVendor)
        {
            OnTblPoVendorUpdated(tblPoVendor);

            var item = context.TblPoVendors
                              .Where(i => i.Vendor_ID == vendorId)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblPoVendor);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblPoVendor;
        }
        
        partial void OnTblSoCustomerDeleted(Models.CanErpDbAt132.TblSoCustomer item);

        public async Task<Models.CanErpDbAt132.TblSoCustomer> DeleteTblSoCustomer(int? customerSeq)
        {
            var item = context.TblSoCustomers
                              .Where(i => i.Customer_SEQ == customerSeq)
                              .Include(i => i.TblSoSalesOrders)
                              .FirstOrDefault();

            OnTblSoCustomerDeleted(item);

            context.TblSoCustomers.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblSoCustomerGet(Models.CanErpDbAt132.TblSoCustomer item);

        public async Task<Models.CanErpDbAt132.TblSoCustomer> GetTblSoCustomerByCustomerSeq(int? customerSeq)
        {
            var item = context.TblSoCustomers
                              .AsNoTracking()
                              .Where(i => i.Customer_SEQ == customerSeq)
                              .FirstOrDefault();

            OnTblSoCustomerGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblSoCustomer> CancelTblSoCustomerChanges(Models.CanErpDbAt132.TblSoCustomer item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblSoCustomerUpdated(Models.CanErpDbAt132.TblSoCustomer item);

        public async Task<Models.CanErpDbAt132.TblSoCustomer> UpdateTblSoCustomer(int? customerSeq, Models.CanErpDbAt132.TblSoCustomer tblSoCustomer)
        {
            OnTblSoCustomerUpdated(tblSoCustomer);

            var item = context.TblSoCustomers
                              .Where(i => i.Customer_SEQ == customerSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblSoCustomer);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblSoCustomer;
        }
        
        partial void OnTblSoOrderDetailDeleted(Models.CanErpDbAt132.TblSoOrderDetail item);

        public async Task<Models.CanErpDbAt132.TblSoOrderDetail> DeleteTblSoOrderDetail(int? soDetailSeq)
        {
            var item = context.TblSoOrderDetails
                              .Where(i => i.SODetail_SEQ == soDetailSeq)
                              .FirstOrDefault();

            OnTblSoOrderDetailDeleted(item);

            context.TblSoOrderDetails.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblSoOrderDetailGet(Models.CanErpDbAt132.TblSoOrderDetail item);

        public async Task<Models.CanErpDbAt132.TblSoOrderDetail> GetTblSoOrderDetailBySoDetailSeq(int? soDetailSeq)
        {
            var item = context.TblSoOrderDetails
                              .AsNoTracking()
                              .Where(i => i.SODetail_SEQ == soDetailSeq)
                              .FirstOrDefault();

            OnTblSoOrderDetailGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblSoOrderDetail> CancelTblSoOrderDetailChanges(Models.CanErpDbAt132.TblSoOrderDetail item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblSoOrderDetailUpdated(Models.CanErpDbAt132.TblSoOrderDetail item);

        public async Task<Models.CanErpDbAt132.TblSoOrderDetail> UpdateTblSoOrderDetail(int? soDetailSeq, Models.CanErpDbAt132.TblSoOrderDetail tblSoOrderDetail)
        {
            OnTblSoOrderDetailUpdated(tblSoOrderDetail);

            var item = context.TblSoOrderDetails
                              .Where(i => i.SODetail_SEQ == soDetailSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblSoOrderDetail);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblSoOrderDetail;
        }
        
        partial void OnTblSoOrderDetailStatusDeleted(Models.CanErpDbAt132.TblSoOrderDetailStatus item);

        public async Task<Models.CanErpDbAt132.TblSoOrderDetailStatus> DeleteTblSoOrderDetailStatus(int? soDetailStatusSeq)
        {
            var item = context.TblSoOrderDetailStatuses
                              .Where(i => i.SODetailStatus_SEQ == soDetailStatusSeq)
                              .Include(i => i.TblSoOrderDetails)
                              .FirstOrDefault();

            OnTblSoOrderDetailStatusDeleted(item);

            context.TblSoOrderDetailStatuses.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblSoOrderDetailStatusGet(Models.CanErpDbAt132.TblSoOrderDetailStatus item);

        public async Task<Models.CanErpDbAt132.TblSoOrderDetailStatus> GetTblSoOrderDetailStatusBySoDetailStatusSeq(int? soDetailStatusSeq)
        {
            var item = context.TblSoOrderDetailStatuses
                              .AsNoTracking()
                              .Where(i => i.SODetailStatus_SEQ == soDetailStatusSeq)
                              .FirstOrDefault();

            OnTblSoOrderDetailStatusGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblSoOrderDetailStatus> CancelTblSoOrderDetailStatusChanges(Models.CanErpDbAt132.TblSoOrderDetailStatus item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblSoOrderDetailStatusUpdated(Models.CanErpDbAt132.TblSoOrderDetailStatus item);

        public async Task<Models.CanErpDbAt132.TblSoOrderDetailStatus> UpdateTblSoOrderDetailStatus(int? soDetailStatusSeq, Models.CanErpDbAt132.TblSoOrderDetailStatus tblSoOrderDetailStatus)
        {
            OnTblSoOrderDetailStatusUpdated(tblSoOrderDetailStatus);

            var item = context.TblSoOrderDetailStatuses
                              .Where(i => i.SODetailStatus_SEQ == soDetailStatusSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblSoOrderDetailStatus);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblSoOrderDetailStatus;
        }
        
        partial void OnTblSoOrderStatusDeleted(Models.CanErpDbAt132.TblSoOrderStatus item);

        public async Task<Models.CanErpDbAt132.TblSoOrderStatus> DeleteTblSoOrderStatus(int? soStatusSeq)
        {
            var item = context.TblSoOrderStatuses
                              .Where(i => i.SOStatus_SEQ == soStatusSeq)
                              .Include(i => i.TblSoSalesOrders)
                              .FirstOrDefault();

            OnTblSoOrderStatusDeleted(item);

            context.TblSoOrderStatuses.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblSoOrderStatusGet(Models.CanErpDbAt132.TblSoOrderStatus item);

        public async Task<Models.CanErpDbAt132.TblSoOrderStatus> GetTblSoOrderStatusBySoStatusSeq(int? soStatusSeq)
        {
            var item = context.TblSoOrderStatuses
                              .AsNoTracking()
                              .Where(i => i.SOStatus_SEQ == soStatusSeq)
                              .FirstOrDefault();

            OnTblSoOrderStatusGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblSoOrderStatus> CancelTblSoOrderStatusChanges(Models.CanErpDbAt132.TblSoOrderStatus item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblSoOrderStatusUpdated(Models.CanErpDbAt132.TblSoOrderStatus item);

        public async Task<Models.CanErpDbAt132.TblSoOrderStatus> UpdateTblSoOrderStatus(int? soStatusSeq, Models.CanErpDbAt132.TblSoOrderStatus tblSoOrderStatus)
        {
            OnTblSoOrderStatusUpdated(tblSoOrderStatus);

            var item = context.TblSoOrderStatuses
                              .Where(i => i.SOStatus_SEQ == soStatusSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblSoOrderStatus);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblSoOrderStatus;
        }
        
        partial void OnTblSoSalesOrderDeleted(Models.CanErpDbAt132.TblSoSalesOrder item);

        public async Task<Models.CanErpDbAt132.TblSoSalesOrder> DeleteTblSoSalesOrder(int? soSeq)
        {
            var item = context.TblSoSalesOrders
                              .Where(i => i.SO_SEQ == soSeq)
                              .Include(i => i.TblSoOrderDetails)
                              .FirstOrDefault();

            OnTblSoSalesOrderDeleted(item);

            context.TblSoSalesOrders.Remove(item);
            context.SaveChanges();

            return item;
        }

        partial void OnTblSoSalesOrderGet(Models.CanErpDbAt132.TblSoSalesOrder item);

        public async Task<Models.CanErpDbAt132.TblSoSalesOrder> GetTblSoSalesOrderBySoSeq(int? soSeq)
        {
            var item = context.TblSoSalesOrders
                              .AsNoTracking()
                              .Where(i => i.SO_SEQ == soSeq)
                              .FirstOrDefault();

            OnTblSoSalesOrderGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.CanErpDbAt132.TblSoSalesOrder> CancelTblSoSalesOrderChanges(Models.CanErpDbAt132.TblSoSalesOrder item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnTblSoSalesOrderUpdated(Models.CanErpDbAt132.TblSoSalesOrder item);

        public async Task<Models.CanErpDbAt132.TblSoSalesOrder> UpdateTblSoSalesOrder(int? soSeq, Models.CanErpDbAt132.TblSoSalesOrder tblSoSalesOrder)
        {
            OnTblSoSalesOrderUpdated(tblSoSalesOrder);

            var item = context.TblSoSalesOrders
                              .Where(i => i.SO_SEQ == soSeq)
                              .First();
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(tblSoSalesOrder);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return tblSoSalesOrder;
        }
        }
}
