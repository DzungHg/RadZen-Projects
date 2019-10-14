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

      public CanErpDbAt132Service(CanErpDbAt132Context context)
      {
        this.context = context;
      }

      public CanErpDbAt132Context context { get; set; }

        


      partial void OnTblGnAddressBooksRead(ref IQueryable<Models.CanErpDbAt132.TblGnAddressBook> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblGnAddressBook>> GetTblGnAddressBooks(string filter = null, string orderby = null)
      {
        var items = context.TblGnAddressBooks.AsQueryable();

        items = items.Include(i => i.TblGnAddressBookType);

        items = items.Include(i => i.TblGnGender);

        items = items.Include(i => i.TblGnCity);

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblGnAddressBooksRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblGnAddressBookCreated(Models.CanErpDbAt132.TblGnAddressBook item);



      public async Task<Models.CanErpDbAt132.TblGnAddressBook> CreateTblGnAddressBook(Models.CanErpDbAt132.TblGnAddressBook tblGnAddressBook)
      {
        try
        {
            OnTblGnAddressBookCreated(tblGnAddressBook);
            context.TblGnAddressBooks.Add(tblGnAddressBook);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblGnAddressBook;
      }
            


      partial void OnTblGnAddressBookTypesRead(ref IQueryable<Models.CanErpDbAt132.TblGnAddressBookType> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblGnAddressBookType>> GetTblGnAddressBookTypes(string filter = null, string orderby = null)
      {
        var items = context.TblGnAddressBookTypes.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblGnAddressBookTypesRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblGnAddressBookTypeCreated(Models.CanErpDbAt132.TblGnAddressBookType item);



      public async Task<Models.CanErpDbAt132.TblGnAddressBookType> CreateTblGnAddressBookType(Models.CanErpDbAt132.TblGnAddressBookType tblGnAddressBookType)
      {
        try
        {
            OnTblGnAddressBookTypeCreated(tblGnAddressBookType);
            context.TblGnAddressBookTypes.Add(tblGnAddressBookType);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblGnAddressBookType;
      }
            


      partial void OnTblGnCitiesRead(ref IQueryable<Models.CanErpDbAt132.TblGnCity> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblGnCity>> GetTblGnCities(string filter = null, string orderby = null)
      {
        var items = context.TblGnCities.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblGnCitiesRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblGnCityCreated(Models.CanErpDbAt132.TblGnCity item);



      public async Task<Models.CanErpDbAt132.TblGnCity> CreateTblGnCity(Models.CanErpDbAt132.TblGnCity tblGnCity)
      {
        try
        {
            OnTblGnCityCreated(tblGnCity);
            context.TblGnCities.Add(tblGnCity);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblGnCity;
      }
            


      partial void OnTblGnDepartmentsRead(ref IQueryable<Models.CanErpDbAt132.TblGnDepartment> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblGnDepartment>> GetTblGnDepartments(string filter = null, string orderby = null)
      {
        var items = context.TblGnDepartments.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblGnDepartmentsRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblGnDepartmentCreated(Models.CanErpDbAt132.TblGnDepartment item);



      public async Task<Models.CanErpDbAt132.TblGnDepartment> CreateTblGnDepartment(Models.CanErpDbAt132.TblGnDepartment tblGnDepartment)
      {
        try
        {
            OnTblGnDepartmentCreated(tblGnDepartment);
            context.TblGnDepartments.Add(tblGnDepartment);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblGnDepartment;
      }
            


      partial void OnTblGnGendersRead(ref IQueryable<Models.CanErpDbAt132.TblGnGender> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblGnGender>> GetTblGnGenders(string filter = null, string orderby = null)
      {
        var items = context.TblGnGenders.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblGnGendersRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblGnGenderCreated(Models.CanErpDbAt132.TblGnGender item);



      public async Task<Models.CanErpDbAt132.TblGnGender> CreateTblGnGender(Models.CanErpDbAt132.TblGnGender tblGnGender)
      {
        try
        {
            OnTblGnGenderCreated(tblGnGender);
            context.TblGnGenders.Add(tblGnGender);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblGnGender;
      }
            


      partial void OnTblGnIncotermsRead(ref IQueryable<Models.CanErpDbAt132.TblGnIncoterm> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblGnIncoterm>> GetTblGnIncoterms(string filter = null, string orderby = null)
      {
        var items = context.TblGnIncoterms.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblGnIncotermsRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblGnIncotermCreated(Models.CanErpDbAt132.TblGnIncoterm item);



      public async Task<Models.CanErpDbAt132.TblGnIncoterm> CreateTblGnIncoterm(Models.CanErpDbAt132.TblGnIncoterm tblGnIncoterm)
      {
        try
        {
            OnTblGnIncotermCreated(tblGnIncoterm);
            context.TblGnIncoterms.Add(tblGnIncoterm);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblGnIncoterm;
      }
            


      partial void OnTblGnPaymentTermsRead(ref IQueryable<Models.CanErpDbAt132.TblGnPaymentTerm> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblGnPaymentTerm>> GetTblGnPaymentTerms(string filter = null, string orderby = null)
      {
        var items = context.TblGnPaymentTerms.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblGnPaymentTermsRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblGnPaymentTermCreated(Models.CanErpDbAt132.TblGnPaymentTerm item);



      public async Task<Models.CanErpDbAt132.TblGnPaymentTerm> CreateTblGnPaymentTerm(Models.CanErpDbAt132.TblGnPaymentTerm tblGnPaymentTerm)
      {
        try
        {
            OnTblGnPaymentTermCreated(tblGnPaymentTerm);
            context.TblGnPaymentTerms.Add(tblGnPaymentTerm);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblGnPaymentTerm;
      }
            


      partial void OnTblGnPaymentTypesRead(ref IQueryable<Models.CanErpDbAt132.TblGnPaymentType> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblGnPaymentType>> GetTblGnPaymentTypes(string filter = null, string orderby = null)
      {
        var items = context.TblGnPaymentTypes.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblGnPaymentTypesRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblGnPaymentTypeCreated(Models.CanErpDbAt132.TblGnPaymentType item);



      public async Task<Models.CanErpDbAt132.TblGnPaymentType> CreateTblGnPaymentType(Models.CanErpDbAt132.TblGnPaymentType tblGnPaymentType)
      {
        try
        {
            OnTblGnPaymentTypeCreated(tblGnPaymentType);
            context.TblGnPaymentTypes.Add(tblGnPaymentType);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblGnPaymentType;
      }
            


      partial void OnTblGnProductsRead(ref IQueryable<Models.CanErpDbAt132.TblGnProduct> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblGnProduct>> GetTblGnProducts(string filter = null, string orderby = null)
      {
        var items = context.TblGnProducts.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblGnProductsRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblGnProductCreated(Models.CanErpDbAt132.TblGnProduct item);



      public async Task<Models.CanErpDbAt132.TblGnProduct> CreateTblGnProduct(Models.CanErpDbAt132.TblGnProduct tblGnProduct)
      {
        try
        {
            OnTblGnProductCreated(tblGnProduct);
            context.TblGnProducts.Add(tblGnProduct);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblGnProduct;
      }
            


      partial void OnTblGnShipViaRead(ref IQueryable<Models.CanErpDbAt132.TblGnShipVium> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblGnShipVium>> GetTblGnShipVia(string filter = null, string orderby = null)
      {
        var items = context.TblGnShipVia.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblGnShipViaRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblGnShipViumCreated(Models.CanErpDbAt132.TblGnShipVium item);



      public async Task<Models.CanErpDbAt132.TblGnShipVium> CreateTblGnShipVium(Models.CanErpDbAt132.TblGnShipVium tblGnShipVium)
      {
        try
        {
            OnTblGnShipViumCreated(tblGnShipVium);
            context.TblGnShipVia.Add(tblGnShipVium);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblGnShipVium;
      }
            


      partial void OnTblIcCategoriesRead(ref IQueryable<Models.CanErpDbAt132.TblIcCategory> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblIcCategory>> GetTblIcCategories(string filter = null, string orderby = null)
      {
        var items = context.TblIcCategories.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblIcCategoriesRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblIcCategoryCreated(Models.CanErpDbAt132.TblIcCategory item);



      public async Task<Models.CanErpDbAt132.TblIcCategory> CreateTblIcCategory(Models.CanErpDbAt132.TblIcCategory tblIcCategory)
      {
        try
        {
            OnTblIcCategoryCreated(tblIcCategory);
            context.TblIcCategories.Add(tblIcCategory);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblIcCategory;
      }
            


      partial void OnTblIcClassificationsRead(ref IQueryable<Models.CanErpDbAt132.TblIcClassification> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblIcClassification>> GetTblIcClassifications(string filter = null, string orderby = null)
      {
        var items = context.TblIcClassifications.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblIcClassificationsRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblIcClassificationCreated(Models.CanErpDbAt132.TblIcClassification item);



      public async Task<Models.CanErpDbAt132.TblIcClassification> CreateTblIcClassification(Models.CanErpDbAt132.TblIcClassification tblIcClassification)
      {
        try
        {
            OnTblIcClassificationCreated(tblIcClassification);
            context.TblIcClassifications.Add(tblIcClassification);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblIcClassification;
      }
            


      partial void OnTblIcInventoriesRead(ref IQueryable<Models.CanErpDbAt132.TblIcInventory> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblIcInventory>> GetTblIcInventories(string filter = null, string orderby = null)
      {
        var items = context.TblIcInventories.AsQueryable();

        items = items.Include(i => i.TblIcWarehouse);

        items = items.Include(i => i.TblIcCategory);

        items = items.Include(i => i.TblIcClassification);

        items = items.Include(i => i.TblGnProduct);

        items = items.Include(i => i.TblIcUnit);

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblIcInventoriesRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblIcInventoryCreated(Models.CanErpDbAt132.TblIcInventory item);



      public async Task<Models.CanErpDbAt132.TblIcInventory> CreateTblIcInventory(Models.CanErpDbAt132.TblIcInventory tblIcInventory)
      {
        try
        {
            OnTblIcInventoryCreated(tblIcInventory);
            context.TblIcInventories.Add(tblIcInventory);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblIcInventory;
      }
            


      partial void OnTblIcTransactionsRead(ref IQueryable<Models.CanErpDbAt132.TblIcTransaction> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblIcTransaction>> GetTblIcTransactions(string filter = null, string orderby = null)
      {
        var items = context.TblIcTransactions.AsQueryable();

        items = items.Include(i => i.TblIcTransactionType);

        items = items.Include(i => i.TblIcWarehouse);

        items = items.Include(i => i.TblGnProduct);

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblIcTransactionsRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblIcTransactionCreated(Models.CanErpDbAt132.TblIcTransaction item);



      public async Task<Models.CanErpDbAt132.TblIcTransaction> CreateTblIcTransaction(Models.CanErpDbAt132.TblIcTransaction tblIcTransaction)
      {
        try
        {
            OnTblIcTransactionCreated(tblIcTransaction);
            context.TblIcTransactions.Add(tblIcTransaction);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblIcTransaction;
      }
            


      partial void OnTblIcTransactionTypesRead(ref IQueryable<Models.CanErpDbAt132.TblIcTransactionType> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblIcTransactionType>> GetTblIcTransactionTypes(string filter = null, string orderby = null)
      {
        var items = context.TblIcTransactionTypes.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblIcTransactionTypesRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblIcTransactionTypeCreated(Models.CanErpDbAt132.TblIcTransactionType item);



      public async Task<Models.CanErpDbAt132.TblIcTransactionType> CreateTblIcTransactionType(Models.CanErpDbAt132.TblIcTransactionType tblIcTransactionType)
      {
        try
        {
            OnTblIcTransactionTypeCreated(tblIcTransactionType);
            context.TblIcTransactionTypes.Add(tblIcTransactionType);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblIcTransactionType;
      }
            


      partial void OnTblIcUnitsRead(ref IQueryable<Models.CanErpDbAt132.TblIcUnit> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblIcUnit>> GetTblIcUnits(string filter = null, string orderby = null)
      {
        var items = context.TblIcUnits.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblIcUnitsRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblIcUnitCreated(Models.CanErpDbAt132.TblIcUnit item);



      public async Task<Models.CanErpDbAt132.TblIcUnit> CreateTblIcUnit(Models.CanErpDbAt132.TblIcUnit tblIcUnit)
      {
        try
        {
            OnTblIcUnitCreated(tblIcUnit);
            context.TblIcUnits.Add(tblIcUnit);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblIcUnit;
      }
            


      partial void OnTblIcWarehousesRead(ref IQueryable<Models.CanErpDbAt132.TblIcWarehouse> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblIcWarehouse>> GetTblIcWarehouses(string filter = null, string orderby = null)
      {
        var items = context.TblIcWarehouses.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblIcWarehousesRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblIcWarehouseCreated(Models.CanErpDbAt132.TblIcWarehouse item);



      public async Task<Models.CanErpDbAt132.TblIcWarehouse> CreateTblIcWarehouse(Models.CanErpDbAt132.TblIcWarehouse tblIcWarehouse)
      {
        try
        {
            OnTblIcWarehouseCreated(tblIcWarehouse);
            context.TblIcWarehouses.Add(tblIcWarehouse);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblIcWarehouse;
      }
            


      partial void OnTblPoAccountPayablesRead(ref IQueryable<Models.CanErpDbAt132.TblPoAccountPayable> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblPoAccountPayable>> GetTblPoAccountPayables(string filter = null, string orderby = null)
      {
        var items = context.TblPoAccountPayables.AsQueryable();

        items = items.Include(i => i.TblPoVendor);

        items = items.Include(i => i.TblGnDepartment);

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblPoAccountPayablesRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblPoAccountPayableCreated(Models.CanErpDbAt132.TblPoAccountPayable item);



      public async Task<Models.CanErpDbAt132.TblPoAccountPayable> CreateTblPoAccountPayable(Models.CanErpDbAt132.TblPoAccountPayable tblPoAccountPayable)
      {
        try
        {
            OnTblPoAccountPayableCreated(tblPoAccountPayable);
            context.TblPoAccountPayables.Add(tblPoAccountPayable);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblPoAccountPayable;
      }
            


      partial void OnTblPoAccountsPayableAdjustmentsRead(ref IQueryable<Models.CanErpDbAt132.TblPoAccountsPayableAdjustment> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblPoAccountsPayableAdjustment>> GetTblPoAccountsPayableAdjustments(string filter = null, string orderby = null)
      {
        var items = context.TblPoAccountsPayableAdjustments.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblPoAccountsPayableAdjustmentsRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblPoAccountsPayableAdjustmentCreated(Models.CanErpDbAt132.TblPoAccountsPayableAdjustment item);



      public async Task<Models.CanErpDbAt132.TblPoAccountsPayableAdjustment> CreateTblPoAccountsPayableAdjustment(Models.CanErpDbAt132.TblPoAccountsPayableAdjustment tblPoAccountsPayableAdjustment)
      {
        try
        {
            OnTblPoAccountsPayableAdjustmentCreated(tblPoAccountsPayableAdjustment);
            context.TblPoAccountsPayableAdjustments.Add(tblPoAccountsPayableAdjustment);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblPoAccountsPayableAdjustment;
      }
            


      partial void OnTblPoApInvoicesRead(ref IQueryable<Models.CanErpDbAt132.TblPoApInvoice> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblPoApInvoice>> GetTblPoApInvoices(string filter = null, string orderby = null)
      {
        var items = context.TblPoApInvoices.AsQueryable();

        items = items.Include(i => i.TblPoVendor);

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblPoApInvoicesRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblPoApInvoiceCreated(Models.CanErpDbAt132.TblPoApInvoice item);



      public async Task<Models.CanErpDbAt132.TblPoApInvoice> CreateTblPoApInvoice(Models.CanErpDbAt132.TblPoApInvoice tblPoApInvoice)
      {
        try
        {
            OnTblPoApInvoiceCreated(tblPoApInvoice);
            context.TblPoApInvoices.Add(tblPoApInvoice);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblPoApInvoice;
      }
            


      partial void OnTblPoApInvoicesDetailsRead(ref IQueryable<Models.CanErpDbAt132.TblPoApInvoicesDetail> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblPoApInvoicesDetail>> GetTblPoApInvoicesDetails(string filter = null, string orderby = null)
      {
        var items = context.TblPoApInvoicesDetails.AsQueryable();

        items = items.Include(i => i.TblPoVendor);

        items = items.Include(i => i.TblIcInventory);

        items = items.Include(i => i.TblIcUnit);

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblPoApInvoicesDetailsRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblPoApInvoicesDetailCreated(Models.CanErpDbAt132.TblPoApInvoicesDetail item);



      public async Task<Models.CanErpDbAt132.TblPoApInvoicesDetail> CreateTblPoApInvoicesDetail(Models.CanErpDbAt132.TblPoApInvoicesDetail tblPoApInvoicesDetail)
      {
        try
        {
            OnTblPoApInvoicesDetailCreated(tblPoApInvoicesDetail);
            context.TblPoApInvoicesDetails.Add(tblPoApInvoicesDetail);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblPoApInvoicesDetail;
      }
            


      partial void OnTblPoCashDisbursementsRead(ref IQueryable<Models.CanErpDbAt132.TblPoCashDisbursement> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblPoCashDisbursement>> GetTblPoCashDisbursements(string filter = null, string orderby = null)
      {
        var items = context.TblPoCashDisbursements.AsQueryable();

        items = items.Include(i => i.TblGnAddressBook);

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblPoCashDisbursementsRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblPoCashDisbursementCreated(Models.CanErpDbAt132.TblPoCashDisbursement item);



      public async Task<Models.CanErpDbAt132.TblPoCashDisbursement> CreateTblPoCashDisbursement(Models.CanErpDbAt132.TblPoCashDisbursement tblPoCashDisbursement)
      {
        try
        {
            OnTblPoCashDisbursementCreated(tblPoCashDisbursement);
            context.TblPoCashDisbursements.Add(tblPoCashDisbursement);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblPoCashDisbursement;
      }
            


      partial void OnTblPoOrderStatusesRead(ref IQueryable<Models.CanErpDbAt132.TblPoOrderStatus> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblPoOrderStatus>> GetTblPoOrderStatuses(string filter = null, string orderby = null)
      {
        var items = context.TblPoOrderStatuses.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblPoOrderStatusesRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblPoOrderStatusCreated(Models.CanErpDbAt132.TblPoOrderStatus item);



      public async Task<Models.CanErpDbAt132.TblPoOrderStatus> CreateTblPoOrderStatus(Models.CanErpDbAt132.TblPoOrderStatus tblPoOrderStatus)
      {
        try
        {
            OnTblPoOrderStatusCreated(tblPoOrderStatus);
            context.TblPoOrderStatuses.Add(tblPoOrderStatus);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblPoOrderStatus;
      }
            


      partial void OnTblPoPurchaseOrdersRead(ref IQueryable<Models.CanErpDbAt132.TblPoPurchaseOrder> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblPoPurchaseOrder>> GetTblPoPurchaseOrders(string filter = null, string orderby = null)
      {
        var items = context.TblPoPurchaseOrders.AsQueryable();

        items = items.Include(i => i.TblGnAddressBook);

        items = items.Include(i => i.TblPoOrderStatus);

        items = items.Include(i => i.TblPoVendor);

        items = items.Include(i => i.TblGnShipVium);

        items = items.Include(i => i.TblGnPaymentTerm);

        items = items.Include(i => i.TblGnPaymentType);

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblPoPurchaseOrdersRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblPoPurchaseOrderCreated(Models.CanErpDbAt132.TblPoPurchaseOrder item);



      public async Task<Models.CanErpDbAt132.TblPoPurchaseOrder> CreateTblPoPurchaseOrder(Models.CanErpDbAt132.TblPoPurchaseOrder tblPoPurchaseOrder)
      {
        try
        {
            OnTblPoPurchaseOrderCreated(tblPoPurchaseOrder);
            context.TblPoPurchaseOrders.Add(tblPoPurchaseOrder);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblPoPurchaseOrder;
      }
            


      partial void OnTblPoPurchaseOrderDetailsRead(ref IQueryable<Models.CanErpDbAt132.TblPoPurchaseOrderDetail> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblPoPurchaseOrderDetail>> GetTblPoPurchaseOrderDetails(string filter = null, string orderby = null)
      {
        var items = context.TblPoPurchaseOrderDetails.AsQueryable();

        items = items.Include(i => i.TblPoPurchaseOrder);

        items = items.Include(i => i.TblIcInventory);

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblPoPurchaseOrderDetailsRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblPoPurchaseOrderDetailCreated(Models.CanErpDbAt132.TblPoPurchaseOrderDetail item);



      public async Task<Models.CanErpDbAt132.TblPoPurchaseOrderDetail> CreateTblPoPurchaseOrderDetail(Models.CanErpDbAt132.TblPoPurchaseOrderDetail tblPoPurchaseOrderDetail)
      {
        try
        {
            OnTblPoPurchaseOrderDetailCreated(tblPoPurchaseOrderDetail);
            context.TblPoPurchaseOrderDetails.Add(tblPoPurchaseOrderDetail);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblPoPurchaseOrderDetail;
      }
            


      partial void OnTblPoRecReportsRead(ref IQueryable<Models.CanErpDbAt132.TblPoRecReport> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblPoRecReport>> GetTblPoRecReports(string filter = null, string orderby = null)
      {
        var items = context.TblPoRecReports.AsQueryable();

        items = items.Include(i => i.TblGnAddressBook);

        items = items.Include(i => i.TblPoVendor);

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblPoRecReportsRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblPoRecReportCreated(Models.CanErpDbAt132.TblPoRecReport item);



      public async Task<Models.CanErpDbAt132.TblPoRecReport> CreateTblPoRecReport(Models.CanErpDbAt132.TblPoRecReport tblPoRecReport)
      {
        try
        {
            OnTblPoRecReportCreated(tblPoRecReport);
            context.TblPoRecReports.Add(tblPoRecReport);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblPoRecReport;
      }
            


      partial void OnTblPoRrOrderDetailsRead(ref IQueryable<Models.CanErpDbAt132.TblPoRrOrderDetail> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblPoRrOrderDetail>> GetTblPoRrOrderDetails(string filter = null, string orderby = null)
      {
        var items = context.TblPoRrOrderDetails.AsQueryable();

        items = items.Include(i => i.TblPoRecReport);

        items = items.Include(i => i.TblIcInventory);

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblPoRrOrderDetailsRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblPoRrOrderDetailCreated(Models.CanErpDbAt132.TblPoRrOrderDetail item);



      public async Task<Models.CanErpDbAt132.TblPoRrOrderDetail> CreateTblPoRrOrderDetail(Models.CanErpDbAt132.TblPoRrOrderDetail tblPoRrOrderDetail)
      {
        try
        {
            OnTblPoRrOrderDetailCreated(tblPoRrOrderDetail);
            context.TblPoRrOrderDetails.Add(tblPoRrOrderDetail);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblPoRrOrderDetail;
      }
            


      partial void OnTblPoVendorsRead(ref IQueryable<Models.CanErpDbAt132.TblPoVendor> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblPoVendor>> GetTblPoVendors(string filter = null, string orderby = null)
      {
        var items = context.TblPoVendors.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblPoVendorsRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblPoVendorCreated(Models.CanErpDbAt132.TblPoVendor item);



      public async Task<Models.CanErpDbAt132.TblPoVendor> CreateTblPoVendor(Models.CanErpDbAt132.TblPoVendor tblPoVendor)
      {
        try
        {
            OnTblPoVendorCreated(tblPoVendor);
            context.TblPoVendors.Add(tblPoVendor);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblPoVendor;
      }
            


      partial void OnTblSoCustomersRead(ref IQueryable<Models.CanErpDbAt132.TblSoCustomer> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblSoCustomer>> GetTblSoCustomers(string filter = null, string orderby = null)
      {
        var items = context.TblSoCustomers.AsQueryable();

        items = items.Include(i => i.TblGnAddressBook);

        items = items.Include(i => i.TblGnPaymentTerm);

        items = items.Include(i => i.TblGnPaymentType);

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblSoCustomersRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblSoCustomerCreated(Models.CanErpDbAt132.TblSoCustomer item);



      public async Task<Models.CanErpDbAt132.TblSoCustomer> CreateTblSoCustomer(Models.CanErpDbAt132.TblSoCustomer tblSoCustomer)
      {
        try
        {
            OnTblSoCustomerCreated(tblSoCustomer);
            context.TblSoCustomers.Add(tblSoCustomer);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblSoCustomer;
      }
            


      partial void OnTblSoOrderDetailsRead(ref IQueryable<Models.CanErpDbAt132.TblSoOrderDetail> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblSoOrderDetail>> GetTblSoOrderDetails(string filter = null, string orderby = null)
      {
        var items = context.TblSoOrderDetails.AsQueryable();

        items = items.Include(i => i.TblSoOrderDetailStatus);

        items = items.Include(i => i.TblSoSalesOrder);

        items = items.Include(i => i.TblIcInventory);

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblSoOrderDetailsRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblSoOrderDetailCreated(Models.CanErpDbAt132.TblSoOrderDetail item);



      public async Task<Models.CanErpDbAt132.TblSoOrderDetail> CreateTblSoOrderDetail(Models.CanErpDbAt132.TblSoOrderDetail tblSoOrderDetail)
      {
        try
        {
            OnTblSoOrderDetailCreated(tblSoOrderDetail);
            context.TblSoOrderDetails.Add(tblSoOrderDetail);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblSoOrderDetail;
      }
            


      partial void OnTblSoOrderDetailStatusesRead(ref IQueryable<Models.CanErpDbAt132.TblSoOrderDetailStatus> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblSoOrderDetailStatus>> GetTblSoOrderDetailStatuses(string filter = null, string orderby = null)
      {
        var items = context.TblSoOrderDetailStatuses.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblSoOrderDetailStatusesRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblSoOrderDetailStatusCreated(Models.CanErpDbAt132.TblSoOrderDetailStatus item);



      public async Task<Models.CanErpDbAt132.TblSoOrderDetailStatus> CreateTblSoOrderDetailStatus(Models.CanErpDbAt132.TblSoOrderDetailStatus tblSoOrderDetailStatus)
      {
        try
        {
            OnTblSoOrderDetailStatusCreated(tblSoOrderDetailStatus);
            context.TblSoOrderDetailStatuses.Add(tblSoOrderDetailStatus);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblSoOrderDetailStatus;
      }
            


      partial void OnTblSoOrderStatusesRead(ref IQueryable<Models.CanErpDbAt132.TblSoOrderStatus> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblSoOrderStatus>> GetTblSoOrderStatuses(string filter = null, string orderby = null)
      {
        var items = context.TblSoOrderStatuses.AsQueryable();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblSoOrderStatusesRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblSoOrderStatusCreated(Models.CanErpDbAt132.TblSoOrderStatus item);



      public async Task<Models.CanErpDbAt132.TblSoOrderStatus> CreateTblSoOrderStatus(Models.CanErpDbAt132.TblSoOrderStatus tblSoOrderStatus)
      {
        try
        {
            OnTblSoOrderStatusCreated(tblSoOrderStatus);
            context.TblSoOrderStatuses.Add(tblSoOrderStatus);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblSoOrderStatus;
      }
            


      partial void OnTblSoSalesOrdersRead(ref IQueryable<Models.CanErpDbAt132.TblSoSalesOrder> items);

      public async Task<IQueryable<Models.CanErpDbAt132.TblSoSalesOrder>> GetTblSoSalesOrders(string filter = null, string orderby = null)
      {
        var items = context.TblSoSalesOrders.AsQueryable();

        items = items.Include(i => i.TblSoOrderStatus);

        items = items.Include(i => i.TblSoCustomer);

        items = items.Include(i => i.TblGnShipVium);

        items = items.Include(i => i.TblGnPaymentTerm);

        items = items.Include(i => i.TblGnPaymentType);

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnTblSoSalesOrdersRead(ref items);

        return await Task.FromResult(items);
      }
    
      partial void OnTblSoSalesOrderCreated(Models.CanErpDbAt132.TblSoSalesOrder item);



      public async Task<Models.CanErpDbAt132.TblSoSalesOrder> CreateTblSoSalesOrder(Models.CanErpDbAt132.TblSoSalesOrder tblSoSalesOrder)
      {
        try
        {
            OnTblSoSalesOrderCreated(tblSoSalesOrder);
            context.TblSoSalesOrders.Add(tblSoSalesOrder);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblSoSalesOrder;
      }
            


      partial void OnVwCustomersRead(ref IQueryable<Models.CanErpDbAt132.VwCustomer> items);

      public async Task<IQueryable<Models.CanErpDbAt132.VwCustomer>> GetVwCustomers(string filter = null, string orderby = null)
      {
        var items = context.VwCustomers.AsQueryable();
        items = items.AsNoTracking();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnVwCustomersRead(ref items);

        return await Task.FromResult(items);
      }
            


      partial void OnVwEmpAndVendsRead(ref IQueryable<Models.CanErpDbAt132.VwEmpAndVend> items);

      public async Task<IQueryable<Models.CanErpDbAt132.VwEmpAndVend>> GetVwEmpAndVends(string filter = null, string orderby = null)
      {
        var items = context.VwEmpAndVends.AsQueryable();
        items = items.AsNoTracking();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnVwEmpAndVendsRead(ref items);

        return await Task.FromResult(items);
      }
            


      partial void OnVwEmployeesRead(ref IQueryable<Models.CanErpDbAt132.VwEmployee> items);

      public async Task<IQueryable<Models.CanErpDbAt132.VwEmployee>> GetVwEmployees(string filter = null, string orderby = null)
      {
        var items = context.VwEmployees.AsQueryable();
        items = items.AsNoTracking();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnVwEmployeesRead(ref items);

        return await Task.FromResult(items);
      }
            


      partial void OnVwVendorsRead(ref IQueryable<Models.CanErpDbAt132.VwVendor> items);

      public async Task<IQueryable<Models.CanErpDbAt132.VwVendor>> GetVwVendors(string filter = null, string orderby = null)
      {
        var items = context.VwVendors.AsQueryable();
        items = items.AsNoTracking();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
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
          .Include(i => i.TblSoCustomers)
          .Include(i => i.TblPoCashDisbursements)
          .FirstOrDefault();

        try
        {
            OnTblGnAddressBookDeleted(item);
            context.TblGnAddressBooks.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblGnAddressBookGet(Models.CanErpDbAt132.TblGnAddressBook item);


      public async Task<Models.CanErpDbAt132.TblGnAddressBook> GetTblGnAddressBookByAddressBookSeq(int? addressBookSeq)
      {
        var item = context.TblGnAddressBooks.Find(addressBookSeq);
        OnTblGnAddressBookGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnAddressBookUpdated(Models.CanErpDbAt132.TblGnAddressBook item);

      public async Task<Models.CanErpDbAt132.TblGnAddressBook> UpdateTblGnAddressBook(int? addressBookSeq, Models.CanErpDbAt132.TblGnAddressBook tblGnAddressBook)
      {
        try
        {
          OnTblGnAddressBookUpdated(tblGnAddressBook);
          context.TblGnAddressBooks.Update(tblGnAddressBook);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblGnAddressBook;
      }
            



      partial void OnTblGnAddressBookTypeDeleted(Models.CanErpDbAt132.TblGnAddressBookType item);

      public async Task<Models.CanErpDbAt132.TblGnAddressBookType> DeleteTblGnAddressBookType(int? addressBookTypeSeq)
      {
        var item = context.TblGnAddressBookTypes
          .Where(i => i.AddressBookType_SEQ == addressBookTypeSeq)
          .Include(i => i.TblGnAddressBooks)
          .FirstOrDefault();

        try
        {
            OnTblGnAddressBookTypeDeleted(item);
            context.TblGnAddressBookTypes.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblGnAddressBookTypeGet(Models.CanErpDbAt132.TblGnAddressBookType item);


      public async Task<Models.CanErpDbAt132.TblGnAddressBookType> GetTblGnAddressBookTypeByAddressBookTypeSeq(int? addressBookTypeSeq)
      {
        var item = context.TblGnAddressBookTypes.Find(addressBookTypeSeq);
        OnTblGnAddressBookTypeGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnAddressBookTypeUpdated(Models.CanErpDbAt132.TblGnAddressBookType item);

      public async Task<Models.CanErpDbAt132.TblGnAddressBookType> UpdateTblGnAddressBookType(int? addressBookTypeSeq, Models.CanErpDbAt132.TblGnAddressBookType tblGnAddressBookType)
      {
        try
        {
          OnTblGnAddressBookTypeUpdated(tblGnAddressBookType);
          context.TblGnAddressBookTypes.Update(tblGnAddressBookType);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblGnAddressBookType;
      }
            



      partial void OnTblGnCityDeleted(Models.CanErpDbAt132.TblGnCity item);

      public async Task<Models.CanErpDbAt132.TblGnCity> DeleteTblGnCity(int? citySeq)
      {
        var item = context.TblGnCities
          .Where(i => i.City_SEQ == citySeq)
          .Include(i => i.TblGnAddressBooks)
          .FirstOrDefault();

        try
        {
            OnTblGnCityDeleted(item);
            context.TblGnCities.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblGnCityGet(Models.CanErpDbAt132.TblGnCity item);


      public async Task<Models.CanErpDbAt132.TblGnCity> GetTblGnCityByCitySeq(int? citySeq)
      {
        var item = context.TblGnCities.Find(citySeq);
        OnTblGnCityGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnCityUpdated(Models.CanErpDbAt132.TblGnCity item);

      public async Task<Models.CanErpDbAt132.TblGnCity> UpdateTblGnCity(int? citySeq, Models.CanErpDbAt132.TblGnCity tblGnCity)
      {
        try
        {
          OnTblGnCityUpdated(tblGnCity);
          context.TblGnCities.Update(tblGnCity);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblGnCity;
      }
            



      partial void OnTblGnDepartmentDeleted(Models.CanErpDbAt132.TblGnDepartment item);

      public async Task<Models.CanErpDbAt132.TblGnDepartment> DeleteTblGnDepartment(string departmentId)
      {
        var item = context.TblGnDepartments
          .Where(i => i.Department_ID == departmentId)
          .Include(i => i.TblPoAccountPayables)
          .FirstOrDefault();

        try
        {
            OnTblGnDepartmentDeleted(item);
            context.TblGnDepartments.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblGnDepartmentGet(Models.CanErpDbAt132.TblGnDepartment item);


      public async Task<Models.CanErpDbAt132.TblGnDepartment> GetTblGnDepartmentByDepartmentId(string departmentId)
      {
        var item = context.TblGnDepartments.Find(departmentId);
        OnTblGnDepartmentGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnDepartmentUpdated(Models.CanErpDbAt132.TblGnDepartment item);

      public async Task<Models.CanErpDbAt132.TblGnDepartment> UpdateTblGnDepartment(string departmentId, Models.CanErpDbAt132.TblGnDepartment tblGnDepartment)
      {
        try
        {
          OnTblGnDepartmentUpdated(tblGnDepartment);
          context.TblGnDepartments.Update(tblGnDepartment);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblGnDepartment;
      }
            



      partial void OnTblGnGenderDeleted(Models.CanErpDbAt132.TblGnGender item);

      public async Task<Models.CanErpDbAt132.TblGnGender> DeleteTblGnGender(int? genderSeq)
      {
        var item = context.TblGnGenders
          .Where(i => i.Gender_SEQ == genderSeq)
          .Include(i => i.TblGnAddressBooks)
          .FirstOrDefault();

        try
        {
            OnTblGnGenderDeleted(item);
            context.TblGnGenders.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblGnGenderGet(Models.CanErpDbAt132.TblGnGender item);


      public async Task<Models.CanErpDbAt132.TblGnGender> GetTblGnGenderByGenderSeq(int? genderSeq)
      {
        var item = context.TblGnGenders.Find(genderSeq);
        OnTblGnGenderGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnGenderUpdated(Models.CanErpDbAt132.TblGnGender item);

      public async Task<Models.CanErpDbAt132.TblGnGender> UpdateTblGnGender(int? genderSeq, Models.CanErpDbAt132.TblGnGender tblGnGender)
      {
        try
        {
          OnTblGnGenderUpdated(tblGnGender);
          context.TblGnGenders.Update(tblGnGender);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblGnGender;
      }
            



      partial void OnTblGnIncotermDeleted(Models.CanErpDbAt132.TblGnIncoterm item);

      public async Task<Models.CanErpDbAt132.TblGnIncoterm> DeleteTblGnIncoterm(string incotermId)
      {
        var item = context.TblGnIncoterms
          .Where(i => i.Incoterm_ID == incotermId)
          .FirstOrDefault();

        try
        {
            OnTblGnIncotermDeleted(item);
            context.TblGnIncoterms.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblGnIncotermGet(Models.CanErpDbAt132.TblGnIncoterm item);


      public async Task<Models.CanErpDbAt132.TblGnIncoterm> GetTblGnIncotermByIncotermId(string incotermId)
      {
        var item = context.TblGnIncoterms.Find(incotermId);
        OnTblGnIncotermGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnIncotermUpdated(Models.CanErpDbAt132.TblGnIncoterm item);

      public async Task<Models.CanErpDbAt132.TblGnIncoterm> UpdateTblGnIncoterm(string incotermId, Models.CanErpDbAt132.TblGnIncoterm tblGnIncoterm)
      {
        try
        {
          OnTblGnIncotermUpdated(tblGnIncoterm);
          context.TblGnIncoterms.Update(tblGnIncoterm);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblGnIncoterm;
      }
            



      partial void OnTblGnPaymentTermDeleted(Models.CanErpDbAt132.TblGnPaymentTerm item);

      public async Task<Models.CanErpDbAt132.TblGnPaymentTerm> DeleteTblGnPaymentTerm(int? paymentTermSeq)
      {
        var item = context.TblGnPaymentTerms
          .Where(i => i.PaymentTerm_SEQ == paymentTermSeq)
          .Include(i => i.TblPoPurchaseOrders)
          .Include(i => i.TblSoSalesOrders)
          .Include(i => i.TblSoCustomers)
          .FirstOrDefault();

        try
        {
            OnTblGnPaymentTermDeleted(item);
            context.TblGnPaymentTerms.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblGnPaymentTermGet(Models.CanErpDbAt132.TblGnPaymentTerm item);


      public async Task<Models.CanErpDbAt132.TblGnPaymentTerm> GetTblGnPaymentTermByPaymentTermSeq(int? paymentTermSeq)
      {
        var item = context.TblGnPaymentTerms.Find(paymentTermSeq);
        OnTblGnPaymentTermGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnPaymentTermUpdated(Models.CanErpDbAt132.TblGnPaymentTerm item);

      public async Task<Models.CanErpDbAt132.TblGnPaymentTerm> UpdateTblGnPaymentTerm(int? paymentTermSeq, Models.CanErpDbAt132.TblGnPaymentTerm tblGnPaymentTerm)
      {
        try
        {
          OnTblGnPaymentTermUpdated(tblGnPaymentTerm);
          context.TblGnPaymentTerms.Update(tblGnPaymentTerm);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblGnPaymentTerm;
      }
            



      partial void OnTblGnPaymentTypeDeleted(Models.CanErpDbAt132.TblGnPaymentType item);

      public async Task<Models.CanErpDbAt132.TblGnPaymentType> DeleteTblGnPaymentType(int? paymentTypeSeq)
      {
        var item = context.TblGnPaymentTypes
          .Where(i => i.PaymentType_SEQ == paymentTypeSeq)
          .Include(i => i.TblPoPurchaseOrders)
          .Include(i => i.TblSoSalesOrders)
          .Include(i => i.TblSoCustomers)
          .FirstOrDefault();

        try
        {
            OnTblGnPaymentTypeDeleted(item);
            context.TblGnPaymentTypes.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblGnPaymentTypeGet(Models.CanErpDbAt132.TblGnPaymentType item);


      public async Task<Models.CanErpDbAt132.TblGnPaymentType> GetTblGnPaymentTypeByPaymentTypeSeq(int? paymentTypeSeq)
      {
        var item = context.TblGnPaymentTypes.Find(paymentTypeSeq);
        OnTblGnPaymentTypeGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnPaymentTypeUpdated(Models.CanErpDbAt132.TblGnPaymentType item);

      public async Task<Models.CanErpDbAt132.TblGnPaymentType> UpdateTblGnPaymentType(int? paymentTypeSeq, Models.CanErpDbAt132.TblGnPaymentType tblGnPaymentType)
      {
        try
        {
          OnTblGnPaymentTypeUpdated(tblGnPaymentType);
          context.TblGnPaymentTypes.Update(tblGnPaymentType);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblGnPaymentType;
      }
            



      partial void OnTblGnProductDeleted(Models.CanErpDbAt132.TblGnProduct item);

      public async Task<Models.CanErpDbAt132.TblGnProduct> DeleteTblGnProduct(int? productSeq)
      {
        var item = context.TblGnProducts
          .Where(i => i.Product_SEQ == productSeq)
          .Include(i => i.TblIcInventories)
          .Include(i => i.TblIcTransactions)
          .FirstOrDefault();

        try
        {
            OnTblGnProductDeleted(item);
            context.TblGnProducts.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblGnProductGet(Models.CanErpDbAt132.TblGnProduct item);


      public async Task<Models.CanErpDbAt132.TblGnProduct> GetTblGnProductByProductSeq(int? productSeq)
      {
        var item = context.TblGnProducts.Find(productSeq);
        OnTblGnProductGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnProductUpdated(Models.CanErpDbAt132.TblGnProduct item);

      public async Task<Models.CanErpDbAt132.TblGnProduct> UpdateTblGnProduct(int? productSeq, Models.CanErpDbAt132.TblGnProduct tblGnProduct)
      {
        try
        {
          OnTblGnProductUpdated(tblGnProduct);
          context.TblGnProducts.Update(tblGnProduct);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

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

        try
        {
            OnTblGnShipViumDeleted(item);
            context.TblGnShipVia.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblGnShipViumGet(Models.CanErpDbAt132.TblGnShipVium item);


      public async Task<Models.CanErpDbAt132.TblGnShipVium> GetTblGnShipViumByShipViaSeq(int? shipViaSeq)
      {
        var item = context.TblGnShipVia.Find(shipViaSeq);
        OnTblGnShipViumGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnShipViumUpdated(Models.CanErpDbAt132.TblGnShipVium item);

      public async Task<Models.CanErpDbAt132.TblGnShipVium> UpdateTblGnShipVium(int? shipViaSeq, Models.CanErpDbAt132.TblGnShipVium tblGnShipVium)
      {
        try
        {
          OnTblGnShipViumUpdated(tblGnShipVium);
          context.TblGnShipVia.Update(tblGnShipVium);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblGnShipVium;
      }
            



      partial void OnTblIcCategoryDeleted(Models.CanErpDbAt132.TblIcCategory item);

      public async Task<Models.CanErpDbAt132.TblIcCategory> DeleteTblIcCategory(string categoryId)
      {
        var item = context.TblIcCategories
          .Where(i => i.Category_ID == categoryId)
          .Include(i => i.TblIcInventories)
          .FirstOrDefault();

        try
        {
            OnTblIcCategoryDeleted(item);
            context.TblIcCategories.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblIcCategoryGet(Models.CanErpDbAt132.TblIcCategory item);


      public async Task<Models.CanErpDbAt132.TblIcCategory> GetTblIcCategoryByCategoryId(string categoryId)
      {
        var item = context.TblIcCategories.Find(categoryId);
        OnTblIcCategoryGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblIcCategoryUpdated(Models.CanErpDbAt132.TblIcCategory item);

      public async Task<Models.CanErpDbAt132.TblIcCategory> UpdateTblIcCategory(string categoryId, Models.CanErpDbAt132.TblIcCategory tblIcCategory)
      {
        try
        {
          OnTblIcCategoryUpdated(tblIcCategory);
          context.TblIcCategories.Update(tblIcCategory);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblIcCategory;
      }
            



      partial void OnTblIcClassificationDeleted(Models.CanErpDbAt132.TblIcClassification item);

      public async Task<Models.CanErpDbAt132.TblIcClassification> DeleteTblIcClassification(string classifiId)
      {
        var item = context.TblIcClassifications
          .Where(i => i.Classifi_ID == classifiId)
          .Include(i => i.TblIcInventories)
          .FirstOrDefault();

        try
        {
            OnTblIcClassificationDeleted(item);
            context.TblIcClassifications.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblIcClassificationGet(Models.CanErpDbAt132.TblIcClassification item);


      public async Task<Models.CanErpDbAt132.TblIcClassification> GetTblIcClassificationByClassifiId(string classifiId)
      {
        var item = context.TblIcClassifications.Find(classifiId);
        OnTblIcClassificationGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblIcClassificationUpdated(Models.CanErpDbAt132.TblIcClassification item);

      public async Task<Models.CanErpDbAt132.TblIcClassification> UpdateTblIcClassification(string classifiId, Models.CanErpDbAt132.TblIcClassification tblIcClassification)
      {
        try
        {
          OnTblIcClassificationUpdated(tblIcClassification);
          context.TblIcClassifications.Update(tblIcClassification);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblIcClassification;
      }
            



      partial void OnTblIcInventoryDeleted(Models.CanErpDbAt132.TblIcInventory item);

      public async Task<Models.CanErpDbAt132.TblIcInventory> DeleteTblIcInventory(int? inventorySeq)
      {
        var item = context.TblIcInventories
          .Where(i => i.Inventory_SEQ == inventorySeq)
          .Include(i => i.TblPoApInvoicesDetails)
          .Include(i => i.TblPoRrOrderDetails)
          .Include(i => i.TblSoOrderDetails)
          .Include(i => i.TblPoPurchaseOrderDetails)
          .FirstOrDefault();

        try
        {
            OnTblIcInventoryDeleted(item);
            context.TblIcInventories.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblIcInventoryGet(Models.CanErpDbAt132.TblIcInventory item);


      public async Task<Models.CanErpDbAt132.TblIcInventory> GetTblIcInventoryByInventorySeq(int? inventorySeq)
      {
        var item = context.TblIcInventories.Find(inventorySeq);
        OnTblIcInventoryGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblIcInventoryUpdated(Models.CanErpDbAt132.TblIcInventory item);

      public async Task<Models.CanErpDbAt132.TblIcInventory> UpdateTblIcInventory(int? inventorySeq, Models.CanErpDbAt132.TblIcInventory tblIcInventory)
      {
        try
        {
          OnTblIcInventoryUpdated(tblIcInventory);
          context.TblIcInventories.Update(tblIcInventory);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblIcInventory;
      }
            



      partial void OnTblIcTransactionDeleted(Models.CanErpDbAt132.TblIcTransaction item);

      public async Task<Models.CanErpDbAt132.TblIcTransaction> DeleteTblIcTransaction(string transNo)
      {
        var item = context.TblIcTransactions
          .Where(i => i.Trans_No == transNo)
          .FirstOrDefault();

        try
        {
            OnTblIcTransactionDeleted(item);
            context.TblIcTransactions.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblIcTransactionGet(Models.CanErpDbAt132.TblIcTransaction item);


      public async Task<Models.CanErpDbAt132.TblIcTransaction> GetTblIcTransactionByTransNo(string transNo)
      {
        var item = context.TblIcTransactions.Find(transNo);
        OnTblIcTransactionGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblIcTransactionUpdated(Models.CanErpDbAt132.TblIcTransaction item);

      public async Task<Models.CanErpDbAt132.TblIcTransaction> UpdateTblIcTransaction(string transNo, Models.CanErpDbAt132.TblIcTransaction tblIcTransaction)
      {
        try
        {
          OnTblIcTransactionUpdated(tblIcTransaction);
          context.TblIcTransactions.Update(tblIcTransaction);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblIcTransaction;
      }
            



      partial void OnTblIcTransactionTypeDeleted(Models.CanErpDbAt132.TblIcTransactionType item);

      public async Task<Models.CanErpDbAt132.TblIcTransactionType> DeleteTblIcTransactionType(string transactionId)
      {
        var item = context.TblIcTransactionTypes
          .Where(i => i.Transaction_ID == transactionId)
          .Include(i => i.TblIcTransactions)
          .FirstOrDefault();

        try
        {
            OnTblIcTransactionTypeDeleted(item);
            context.TblIcTransactionTypes.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblIcTransactionTypeGet(Models.CanErpDbAt132.TblIcTransactionType item);


      public async Task<Models.CanErpDbAt132.TblIcTransactionType> GetTblIcTransactionTypeByTransactionId(string transactionId)
      {
        var item = context.TblIcTransactionTypes.Find(transactionId);
        OnTblIcTransactionTypeGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblIcTransactionTypeUpdated(Models.CanErpDbAt132.TblIcTransactionType item);

      public async Task<Models.CanErpDbAt132.TblIcTransactionType> UpdateTblIcTransactionType(string transactionId, Models.CanErpDbAt132.TblIcTransactionType tblIcTransactionType)
      {
        try
        {
          OnTblIcTransactionTypeUpdated(tblIcTransactionType);
          context.TblIcTransactionTypes.Update(tblIcTransactionType);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

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

        try
        {
            OnTblIcUnitDeleted(item);
            context.TblIcUnits.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblIcUnitGet(Models.CanErpDbAt132.TblIcUnit item);


      public async Task<Models.CanErpDbAt132.TblIcUnit> GetTblIcUnitByUnitSeq(int? unitSeq)
      {
        var item = context.TblIcUnits.Find(unitSeq);
        OnTblIcUnitGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblIcUnitUpdated(Models.CanErpDbAt132.TblIcUnit item);

      public async Task<Models.CanErpDbAt132.TblIcUnit> UpdateTblIcUnit(int? unitSeq, Models.CanErpDbAt132.TblIcUnit tblIcUnit)
      {
        try
        {
          OnTblIcUnitUpdated(tblIcUnit);
          context.TblIcUnits.Update(tblIcUnit);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblIcUnit;
      }
            



      partial void OnTblIcWarehouseDeleted(Models.CanErpDbAt132.TblIcWarehouse item);

      public async Task<Models.CanErpDbAt132.TblIcWarehouse> DeleteTblIcWarehouse(string warehouseId)
      {
        var item = context.TblIcWarehouses
          .Where(i => i.Warehouse_ID == warehouseId)
          .Include(i => i.TblIcInventories)
          .Include(i => i.TblIcTransactions)
          .FirstOrDefault();

        try
        {
            OnTblIcWarehouseDeleted(item);
            context.TblIcWarehouses.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblIcWarehouseGet(Models.CanErpDbAt132.TblIcWarehouse item);


      public async Task<Models.CanErpDbAt132.TblIcWarehouse> GetTblIcWarehouseByWarehouseId(string warehouseId)
      {
        var item = context.TblIcWarehouses.Find(warehouseId);
        OnTblIcWarehouseGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblIcWarehouseUpdated(Models.CanErpDbAt132.TblIcWarehouse item);

      public async Task<Models.CanErpDbAt132.TblIcWarehouse> UpdateTblIcWarehouse(string warehouseId, Models.CanErpDbAt132.TblIcWarehouse tblIcWarehouse)
      {
        try
        {
          OnTblIcWarehouseUpdated(tblIcWarehouse);
          context.TblIcWarehouses.Update(tblIcWarehouse);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblIcWarehouse;
      }
            



      partial void OnTblPoAccountPayableDeleted(Models.CanErpDbAt132.TblPoAccountPayable item);

      public async Task<Models.CanErpDbAt132.TblPoAccountPayable> DeleteTblPoAccountPayable(string apNo)
      {
        var item = context.TblPoAccountPayables
          .Where(i => i.AP_No == apNo)
          .FirstOrDefault();

        try
        {
            OnTblPoAccountPayableDeleted(item);
            context.TblPoAccountPayables.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblPoAccountPayableGet(Models.CanErpDbAt132.TblPoAccountPayable item);


      public async Task<Models.CanErpDbAt132.TblPoAccountPayable> GetTblPoAccountPayableByApNo(string apNo)
      {
        var item = context.TblPoAccountPayables.Find(apNo);
        OnTblPoAccountPayableGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblPoAccountPayableUpdated(Models.CanErpDbAt132.TblPoAccountPayable item);

      public async Task<Models.CanErpDbAt132.TblPoAccountPayable> UpdateTblPoAccountPayable(string apNo, Models.CanErpDbAt132.TblPoAccountPayable tblPoAccountPayable)
      {
        try
        {
          OnTblPoAccountPayableUpdated(tblPoAccountPayable);
          context.TblPoAccountPayables.Update(tblPoAccountPayable);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblPoAccountPayable;
      }
            



      partial void OnTblPoAccountsPayableAdjustmentDeleted(Models.CanErpDbAt132.TblPoAccountsPayableAdjustment item);

      public async Task<Models.CanErpDbAt132.TblPoAccountsPayableAdjustment> DeleteTblPoAccountsPayableAdjustment(string voucherNo)
      {
        var item = context.TblPoAccountsPayableAdjustments
          .Where(i => i.Voucher_No == voucherNo)
          .FirstOrDefault();

        try
        {
            OnTblPoAccountsPayableAdjustmentDeleted(item);
            context.TblPoAccountsPayableAdjustments.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblPoAccountsPayableAdjustmentGet(Models.CanErpDbAt132.TblPoAccountsPayableAdjustment item);


      public async Task<Models.CanErpDbAt132.TblPoAccountsPayableAdjustment> GetTblPoAccountsPayableAdjustmentByVoucherNo(string voucherNo)
      {
        var item = context.TblPoAccountsPayableAdjustments.Find(voucherNo);
        OnTblPoAccountsPayableAdjustmentGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblPoAccountsPayableAdjustmentUpdated(Models.CanErpDbAt132.TblPoAccountsPayableAdjustment item);

      public async Task<Models.CanErpDbAt132.TblPoAccountsPayableAdjustment> UpdateTblPoAccountsPayableAdjustment(string voucherNo, Models.CanErpDbAt132.TblPoAccountsPayableAdjustment tblPoAccountsPayableAdjustment)
      {
        try
        {
          OnTblPoAccountsPayableAdjustmentUpdated(tblPoAccountsPayableAdjustment);
          context.TblPoAccountsPayableAdjustments.Update(tblPoAccountsPayableAdjustment);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblPoAccountsPayableAdjustment;
      }
            



      partial void OnTblPoApInvoiceDeleted(Models.CanErpDbAt132.TblPoApInvoice item);

      public async Task<Models.CanErpDbAt132.TblPoApInvoice> DeleteTblPoApInvoice(string vendorId, string invoiceNo)
      {
        var item = context.TblPoApInvoices
          .Where(i => i.Vendor_ID == vendorId && i.Invoice_No == invoiceNo)
          .FirstOrDefault();

        try
        {
            OnTblPoApInvoiceDeleted(item);
            context.TblPoApInvoices.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblPoApInvoiceGet(Models.CanErpDbAt132.TblPoApInvoice item);


      public async Task<Models.CanErpDbAt132.TblPoApInvoice> GetTblPoApInvoiceByVendorIdAndInvoiceNo(string vendorId, string invoiceNo)
      {
        var item = context.TblPoApInvoices.Find(vendorId, invoiceNo);
        OnTblPoApInvoiceGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblPoApInvoiceUpdated(Models.CanErpDbAt132.TblPoApInvoice item);

      public async Task<Models.CanErpDbAt132.TblPoApInvoice> UpdateTblPoApInvoice(string vendorId, string invoiceNo, Models.CanErpDbAt132.TblPoApInvoice tblPoApInvoice)
      {
        try
        {
          OnTblPoApInvoiceUpdated(tblPoApInvoice);
          context.TblPoApInvoices.Update(tblPoApInvoice);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblPoApInvoice;
      }
            



      partial void OnTblPoApInvoicesDetailDeleted(Models.CanErpDbAt132.TblPoApInvoicesDetail item);

      public async Task<Models.CanErpDbAt132.TblPoApInvoicesDetail> DeleteTblPoApInvoicesDetail(string vendorId, string invoiceNo)
      {
        var item = context.TblPoApInvoicesDetails
          .Where(i => i.Vendor_ID == vendorId && i.Invoice_No == invoiceNo)
          .FirstOrDefault();

        try
        {
            OnTblPoApInvoicesDetailDeleted(item);
            context.TblPoApInvoicesDetails.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblPoApInvoicesDetailGet(Models.CanErpDbAt132.TblPoApInvoicesDetail item);


      public async Task<Models.CanErpDbAt132.TblPoApInvoicesDetail> GetTblPoApInvoicesDetailByVendorIdAndInvoiceNo(string vendorId, string invoiceNo)
      {
        var item = context.TblPoApInvoicesDetails.Find(vendorId, invoiceNo);
        OnTblPoApInvoicesDetailGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblPoApInvoicesDetailUpdated(Models.CanErpDbAt132.TblPoApInvoicesDetail item);

      public async Task<Models.CanErpDbAt132.TblPoApInvoicesDetail> UpdateTblPoApInvoicesDetail(string vendorId, string invoiceNo, Models.CanErpDbAt132.TblPoApInvoicesDetail tblPoApInvoicesDetail)
      {
        try
        {
          OnTblPoApInvoicesDetailUpdated(tblPoApInvoicesDetail);
          context.TblPoApInvoicesDetails.Update(tblPoApInvoicesDetail);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblPoApInvoicesDetail;
      }
            



      partial void OnTblPoCashDisbursementDeleted(Models.CanErpDbAt132.TblPoCashDisbursement item);

      public async Task<Models.CanErpDbAt132.TblPoCashDisbursement> DeleteTblPoCashDisbursement(string poCashDisbNo)
      {
        var item = context.TblPoCashDisbursements
          .Where(i => i.PO_CashDisb_No == poCashDisbNo)
          .FirstOrDefault();

        try
        {
            OnTblPoCashDisbursementDeleted(item);
            context.TblPoCashDisbursements.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblPoCashDisbursementGet(Models.CanErpDbAt132.TblPoCashDisbursement item);


      public async Task<Models.CanErpDbAt132.TblPoCashDisbursement> GetTblPoCashDisbursementByPoCashDisbNo(string poCashDisbNo)
      {
        var item = context.TblPoCashDisbursements.Find(poCashDisbNo);
        OnTblPoCashDisbursementGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblPoCashDisbursementUpdated(Models.CanErpDbAt132.TblPoCashDisbursement item);

      public async Task<Models.CanErpDbAt132.TblPoCashDisbursement> UpdateTblPoCashDisbursement(string poCashDisbNo, Models.CanErpDbAt132.TblPoCashDisbursement tblPoCashDisbursement)
      {
        try
        {
          OnTblPoCashDisbursementUpdated(tblPoCashDisbursement);
          context.TblPoCashDisbursements.Update(tblPoCashDisbursement);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblPoCashDisbursement;
      }
            



      partial void OnTblPoOrderStatusDeleted(Models.CanErpDbAt132.TblPoOrderStatus item);

      public async Task<Models.CanErpDbAt132.TblPoOrderStatus> DeleteTblPoOrderStatus(string poStatusId)
      {
        var item = context.TblPoOrderStatuses
          .Where(i => i.POStatus_ID == poStatusId)
          .Include(i => i.TblPoPurchaseOrders)
          .FirstOrDefault();

        try
        {
            OnTblPoOrderStatusDeleted(item);
            context.TblPoOrderStatuses.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblPoOrderStatusGet(Models.CanErpDbAt132.TblPoOrderStatus item);


      public async Task<Models.CanErpDbAt132.TblPoOrderStatus> GetTblPoOrderStatusByPoStatusId(string poStatusId)
      {
        var item = context.TblPoOrderStatuses.Find(poStatusId);
        OnTblPoOrderStatusGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblPoOrderStatusUpdated(Models.CanErpDbAt132.TblPoOrderStatus item);

      public async Task<Models.CanErpDbAt132.TblPoOrderStatus> UpdateTblPoOrderStatus(string poStatusId, Models.CanErpDbAt132.TblPoOrderStatus tblPoOrderStatus)
      {
        try
        {
          OnTblPoOrderStatusUpdated(tblPoOrderStatus);
          context.TblPoOrderStatuses.Update(tblPoOrderStatus);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblPoOrderStatus;
      }
            



      partial void OnTblPoPurchaseOrderDeleted(Models.CanErpDbAt132.TblPoPurchaseOrder item);

      public async Task<Models.CanErpDbAt132.TblPoPurchaseOrder> DeleteTblPoPurchaseOrder(string poId)
      {
        var item = context.TblPoPurchaseOrders
          .Where(i => i.PO_ID == poId)
          .Include(i => i.TblPoPurchaseOrderDetails)
          .FirstOrDefault();

        try
        {
            OnTblPoPurchaseOrderDeleted(item);
            context.TblPoPurchaseOrders.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblPoPurchaseOrderGet(Models.CanErpDbAt132.TblPoPurchaseOrder item);


      public async Task<Models.CanErpDbAt132.TblPoPurchaseOrder> GetTblPoPurchaseOrderByPoId(string poId)
      {
        var item = context.TblPoPurchaseOrders.Find(poId);
        OnTblPoPurchaseOrderGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblPoPurchaseOrderUpdated(Models.CanErpDbAt132.TblPoPurchaseOrder item);

      public async Task<Models.CanErpDbAt132.TblPoPurchaseOrder> UpdateTblPoPurchaseOrder(string poId, Models.CanErpDbAt132.TblPoPurchaseOrder tblPoPurchaseOrder)
      {
        try
        {
          OnTblPoPurchaseOrderUpdated(tblPoPurchaseOrder);
          context.TblPoPurchaseOrders.Update(tblPoPurchaseOrder);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblPoPurchaseOrder;
      }
            



      partial void OnTblPoPurchaseOrderDetailDeleted(Models.CanErpDbAt132.TblPoPurchaseOrderDetail item);

      public async Task<Models.CanErpDbAt132.TblPoPurchaseOrderDetail> DeleteTblPoPurchaseOrderDetail(string poFk, int? inventoryFk)
      {
        var item = context.TblPoPurchaseOrderDetails
          .Where(i => i.PO_FK == poFk && i.Inventory_FK == inventoryFk)
          .FirstOrDefault();

        try
        {
            OnTblPoPurchaseOrderDetailDeleted(item);
            context.TblPoPurchaseOrderDetails.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblPoPurchaseOrderDetailGet(Models.CanErpDbAt132.TblPoPurchaseOrderDetail item);


      public async Task<Models.CanErpDbAt132.TblPoPurchaseOrderDetail> GetTblPoPurchaseOrderDetailByPoFkAndInventoryFk(string poFk, int? inventoryFk)
      {
        var item = context.TblPoPurchaseOrderDetails.Find(poFk, inventoryFk);
        OnTblPoPurchaseOrderDetailGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblPoPurchaseOrderDetailUpdated(Models.CanErpDbAt132.TblPoPurchaseOrderDetail item);

      public async Task<Models.CanErpDbAt132.TblPoPurchaseOrderDetail> UpdateTblPoPurchaseOrderDetail(string poFk, int? inventoryFk, Models.CanErpDbAt132.TblPoPurchaseOrderDetail tblPoPurchaseOrderDetail)
      {
        try
        {
          OnTblPoPurchaseOrderDetailUpdated(tblPoPurchaseOrderDetail);
          context.TblPoPurchaseOrderDetails.Update(tblPoPurchaseOrderDetail);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblPoPurchaseOrderDetail;
      }
            



      partial void OnTblPoRecReportDeleted(Models.CanErpDbAt132.TblPoRecReport item);

      public async Task<Models.CanErpDbAt132.TblPoRecReport> DeleteTblPoRecReport(string rrNo)
      {
        var item = context.TblPoRecReports
          .Where(i => i.RR_No == rrNo)
          .Include(i => i.TblPoRrOrderDetails)
          .FirstOrDefault();

        try
        {
            OnTblPoRecReportDeleted(item);
            context.TblPoRecReports.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblPoRecReportGet(Models.CanErpDbAt132.TblPoRecReport item);


      public async Task<Models.CanErpDbAt132.TblPoRecReport> GetTblPoRecReportByRrNo(string rrNo)
      {
        var item = context.TblPoRecReports.Find(rrNo);
        OnTblPoRecReportGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblPoRecReportUpdated(Models.CanErpDbAt132.TblPoRecReport item);

      public async Task<Models.CanErpDbAt132.TblPoRecReport> UpdateTblPoRecReport(string rrNo, Models.CanErpDbAt132.TblPoRecReport tblPoRecReport)
      {
        try
        {
          OnTblPoRecReportUpdated(tblPoRecReport);
          context.TblPoRecReports.Update(tblPoRecReport);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblPoRecReport;
      }
            



      partial void OnTblPoRrOrderDetailDeleted(Models.CanErpDbAt132.TblPoRrOrderDetail item);

      public async Task<Models.CanErpDbAt132.TblPoRrOrderDetail> DeleteTblPoRrOrderDetail(string rrFk, int? inventoryFk)
      {
        var item = context.TblPoRrOrderDetails
          .Where(i => i.RR_FK == rrFk && i.Inventory_FK == inventoryFk)
          .FirstOrDefault();

        try
        {
            OnTblPoRrOrderDetailDeleted(item);
            context.TblPoRrOrderDetails.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblPoRrOrderDetailGet(Models.CanErpDbAt132.TblPoRrOrderDetail item);


      public async Task<Models.CanErpDbAt132.TblPoRrOrderDetail> GetTblPoRrOrderDetailByRrFkAndInventoryFk(string rrFk, int? inventoryFk)
      {
        var item = context.TblPoRrOrderDetails.Find(rrFk, inventoryFk);
        OnTblPoRrOrderDetailGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblPoRrOrderDetailUpdated(Models.CanErpDbAt132.TblPoRrOrderDetail item);

      public async Task<Models.CanErpDbAt132.TblPoRrOrderDetail> UpdateTblPoRrOrderDetail(string rrFk, int? inventoryFk, Models.CanErpDbAt132.TblPoRrOrderDetail tblPoRrOrderDetail)
      {
        try
        {
          OnTblPoRrOrderDetailUpdated(tblPoRrOrderDetail);
          context.TblPoRrOrderDetails.Update(tblPoRrOrderDetail);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

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

        try
        {
            OnTblPoVendorDeleted(item);
            context.TblPoVendors.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblPoVendorGet(Models.CanErpDbAt132.TblPoVendor item);


      public async Task<Models.CanErpDbAt132.TblPoVendor> GetTblPoVendorByVendorId(string vendorId)
      {
        var item = context.TblPoVendors.Find(vendorId);
        OnTblPoVendorGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblPoVendorUpdated(Models.CanErpDbAt132.TblPoVendor item);

      public async Task<Models.CanErpDbAt132.TblPoVendor> UpdateTblPoVendor(string vendorId, Models.CanErpDbAt132.TblPoVendor tblPoVendor)
      {
        try
        {
          OnTblPoVendorUpdated(tblPoVendor);
          context.TblPoVendors.Update(tblPoVendor);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblPoVendor;
      }
            



      partial void OnTblSoCustomerDeleted(Models.CanErpDbAt132.TblSoCustomer item);

      public async Task<Models.CanErpDbAt132.TblSoCustomer> DeleteTblSoCustomer(int? customerSeq)
      {
        var item = context.TblSoCustomers
          .Where(i => i.Customer_SEQ == customerSeq)
          .Include(i => i.TblSoSalesOrders)
          .FirstOrDefault();

        try
        {
            OnTblSoCustomerDeleted(item);
            context.TblSoCustomers.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblSoCustomerGet(Models.CanErpDbAt132.TblSoCustomer item);


      public async Task<Models.CanErpDbAt132.TblSoCustomer> GetTblSoCustomerByCustomerSeq(int? customerSeq)
      {
        var item = context.TblSoCustomers.Find(customerSeq);
        OnTblSoCustomerGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblSoCustomerUpdated(Models.CanErpDbAt132.TblSoCustomer item);

      public async Task<Models.CanErpDbAt132.TblSoCustomer> UpdateTblSoCustomer(int? customerSeq, Models.CanErpDbAt132.TblSoCustomer tblSoCustomer)
      {
        try
        {
          OnTblSoCustomerUpdated(tblSoCustomer);
          context.TblSoCustomers.Update(tblSoCustomer);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblSoCustomer;
      }
            



      partial void OnTblSoOrderDetailDeleted(Models.CanErpDbAt132.TblSoOrderDetail item);

      public async Task<Models.CanErpDbAt132.TblSoOrderDetail> DeleteTblSoOrderDetail(int? soDetailSeq)
      {
        var item = context.TblSoOrderDetails
          .Where(i => i.SODetail_SEQ == soDetailSeq)
          .FirstOrDefault();

        try
        {
            OnTblSoOrderDetailDeleted(item);
            context.TblSoOrderDetails.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblSoOrderDetailGet(Models.CanErpDbAt132.TblSoOrderDetail item);


      public async Task<Models.CanErpDbAt132.TblSoOrderDetail> GetTblSoOrderDetailBySoDetailSeq(int? soDetailSeq)
      {
        var item = context.TblSoOrderDetails.Find(soDetailSeq);
        OnTblSoOrderDetailGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblSoOrderDetailUpdated(Models.CanErpDbAt132.TblSoOrderDetail item);

      public async Task<Models.CanErpDbAt132.TblSoOrderDetail> UpdateTblSoOrderDetail(int? soDetailSeq, Models.CanErpDbAt132.TblSoOrderDetail tblSoOrderDetail)
      {
        try
        {
          OnTblSoOrderDetailUpdated(tblSoOrderDetail);
          context.TblSoOrderDetails.Update(tblSoOrderDetail);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblSoOrderDetail;
      }
            



      partial void OnTblSoOrderDetailStatusDeleted(Models.CanErpDbAt132.TblSoOrderDetailStatus item);

      public async Task<Models.CanErpDbAt132.TblSoOrderDetailStatus> DeleteTblSoOrderDetailStatus(int? soDetailStatusSeq)
      {
        var item = context.TblSoOrderDetailStatuses
          .Where(i => i.SODetailStatus_SEQ == soDetailStatusSeq)
          .Include(i => i.TblSoOrderDetails)
          .FirstOrDefault();

        try
        {
            OnTblSoOrderDetailStatusDeleted(item);
            context.TblSoOrderDetailStatuses.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblSoOrderDetailStatusGet(Models.CanErpDbAt132.TblSoOrderDetailStatus item);


      public async Task<Models.CanErpDbAt132.TblSoOrderDetailStatus> GetTblSoOrderDetailStatusBySoDetailStatusSeq(int? soDetailStatusSeq)
      {
        var item = context.TblSoOrderDetailStatuses.Find(soDetailStatusSeq);
        OnTblSoOrderDetailStatusGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblSoOrderDetailStatusUpdated(Models.CanErpDbAt132.TblSoOrderDetailStatus item);

      public async Task<Models.CanErpDbAt132.TblSoOrderDetailStatus> UpdateTblSoOrderDetailStatus(int? soDetailStatusSeq, Models.CanErpDbAt132.TblSoOrderDetailStatus tblSoOrderDetailStatus)
      {
        try
        {
          OnTblSoOrderDetailStatusUpdated(tblSoOrderDetailStatus);
          context.TblSoOrderDetailStatuses.Update(tblSoOrderDetailStatus);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblSoOrderDetailStatus;
      }
            



      partial void OnTblSoOrderStatusDeleted(Models.CanErpDbAt132.TblSoOrderStatus item);

      public async Task<Models.CanErpDbAt132.TblSoOrderStatus> DeleteTblSoOrderStatus(int? soStatusSeq)
      {
        var item = context.TblSoOrderStatuses
          .Where(i => i.SOStatus_SEQ == soStatusSeq)
          .Include(i => i.TblSoSalesOrders)
          .FirstOrDefault();

        try
        {
            OnTblSoOrderStatusDeleted(item);
            context.TblSoOrderStatuses.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblSoOrderStatusGet(Models.CanErpDbAt132.TblSoOrderStatus item);


      public async Task<Models.CanErpDbAt132.TblSoOrderStatus> GetTblSoOrderStatusBySoStatusSeq(int? soStatusSeq)
      {
        var item = context.TblSoOrderStatuses.Find(soStatusSeq);
        OnTblSoOrderStatusGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblSoOrderStatusUpdated(Models.CanErpDbAt132.TblSoOrderStatus item);

      public async Task<Models.CanErpDbAt132.TblSoOrderStatus> UpdateTblSoOrderStatus(int? soStatusSeq, Models.CanErpDbAt132.TblSoOrderStatus tblSoOrderStatus)
      {
        try
        {
          OnTblSoOrderStatusUpdated(tblSoOrderStatus);
          context.TblSoOrderStatuses.Update(tblSoOrderStatus);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblSoOrderStatus;
      }
            



      partial void OnTblSoSalesOrderDeleted(Models.CanErpDbAt132.TblSoSalesOrder item);

      public async Task<Models.CanErpDbAt132.TblSoSalesOrder> DeleteTblSoSalesOrder(int? soSeq)
      {
        var item = context.TblSoSalesOrders
          .Where(i => i.SO_SEQ == soSeq)
          .Include(i => i.TblSoOrderDetails)
          .FirstOrDefault();

        try
        {
            OnTblSoSalesOrderDeleted(item);
            context.TblSoSalesOrders.Remove(item);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return item;
      }
    

      partial void OnTblSoSalesOrderGet(Models.CanErpDbAt132.TblSoSalesOrder item);


      public async Task<Models.CanErpDbAt132.TblSoSalesOrder> GetTblSoSalesOrderBySoSeq(int? soSeq)
      {
        var item = context.TblSoSalesOrders.Find(soSeq);
        OnTblSoSalesOrderGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblSoSalesOrderUpdated(Models.CanErpDbAt132.TblSoSalesOrder item);

      public async Task<Models.CanErpDbAt132.TblSoSalesOrder> UpdateTblSoSalesOrder(int? soSeq, Models.CanErpDbAt132.TblSoSalesOrder tblSoSalesOrder)
      {
        try
        {
          OnTblSoSalesOrderUpdated(tblSoSalesOrder);
          context.TblSoSalesOrders.Update(tblSoSalesOrder);
          context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }

        return tblSoSalesOrder;
      }
        
  }
}
