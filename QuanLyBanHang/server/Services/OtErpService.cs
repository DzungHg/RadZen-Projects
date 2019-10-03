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
using QuanLyBanHang.Data;

namespace QuanLyBanHang
{
    public partial class OtErpService
    {

      public OtErpService(OtErpContext context)
      {
        this.context = context;
      }

      public OtErpContext context { get; set; }

        


      partial void OnTblGnAddressBooksRead(ref IQueryable<Models.OtErp.TblGnAddressBook> items);

      public async Task<IQueryable<Models.OtErp.TblGnAddressBook>> GetTblGnAddressBooks(string filter = null, string orderby = null)
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
    
      partial void OnTblGnAddressBookCreated(Models.OtErp.TblGnAddressBook item);



      public async Task<Models.OtErp.TblGnAddressBook> CreateTblGnAddressBook(Models.OtErp.TblGnAddressBook tblGnAddressBook)
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
            


      partial void OnTblGnAddressBookTypesRead(ref IQueryable<Models.OtErp.TblGnAddressBookType> items);

      public async Task<IQueryable<Models.OtErp.TblGnAddressBookType>> GetTblGnAddressBookTypes(string filter = null, string orderby = null)
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
    
      partial void OnTblGnAddressBookTypeCreated(Models.OtErp.TblGnAddressBookType item);



      public async Task<Models.OtErp.TblGnAddressBookType> CreateTblGnAddressBookType(Models.OtErp.TblGnAddressBookType tblGnAddressBookType)
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
            


      partial void OnTblGnCitiesRead(ref IQueryable<Models.OtErp.TblGnCity> items);

      public async Task<IQueryable<Models.OtErp.TblGnCity>> GetTblGnCities(string filter = null, string orderby = null)
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
    
      partial void OnTblGnCityCreated(Models.OtErp.TblGnCity item);



      public async Task<Models.OtErp.TblGnCity> CreateTblGnCity(Models.OtErp.TblGnCity tblGnCity)
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
            


      partial void OnTblGnGendersRead(ref IQueryable<Models.OtErp.TblGnGender> items);

      public async Task<IQueryable<Models.OtErp.TblGnGender>> GetTblGnGenders(string filter = null, string orderby = null)
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
    
      partial void OnTblGnGenderCreated(Models.OtErp.TblGnGender item);



      public async Task<Models.OtErp.TblGnGender> CreateTblGnGender(Models.OtErp.TblGnGender tblGnGender)
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
            


      partial void OnTblGnPaymentTermsRead(ref IQueryable<Models.OtErp.TblGnPaymentTerm> items);

      public async Task<IQueryable<Models.OtErp.TblGnPaymentTerm>> GetTblGnPaymentTerms(string filter = null, string orderby = null)
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
    
      partial void OnTblGnPaymentTermCreated(Models.OtErp.TblGnPaymentTerm item);



      public async Task<Models.OtErp.TblGnPaymentTerm> CreateTblGnPaymentTerm(Models.OtErp.TblGnPaymentTerm tblGnPaymentTerm)
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
            


      partial void OnTblGnPaymentTypesRead(ref IQueryable<Models.OtErp.TblGnPaymentType> items);

      public async Task<IQueryable<Models.OtErp.TblGnPaymentType>> GetTblGnPaymentTypes(string filter = null, string orderby = null)
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
    
      partial void OnTblGnPaymentTypeCreated(Models.OtErp.TblGnPaymentType item);



      public async Task<Models.OtErp.TblGnPaymentType> CreateTblGnPaymentType(Models.OtErp.TblGnPaymentType tblGnPaymentType)
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
            


      partial void OnTblGnShipViaRead(ref IQueryable<Models.OtErp.TblGnShipVium> items);

      public async Task<IQueryable<Models.OtErp.TblGnShipVium>> GetTblGnShipVia(string filter = null, string orderby = null)
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
    
      partial void OnTblGnShipViumCreated(Models.OtErp.TblGnShipVium item);



      public async Task<Models.OtErp.TblGnShipVium> CreateTblGnShipVium(Models.OtErp.TblGnShipVium tblGnShipVium)
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
            


      partial void OnTblSoCustomersRead(ref IQueryable<Models.OtErp.TblSoCustomer> items);

      public async Task<IQueryable<Models.OtErp.TblSoCustomer>> GetTblSoCustomers(string filter = null, string orderby = null)
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
    
      partial void OnTblSoCustomerCreated(Models.OtErp.TblSoCustomer item);



      public async Task<Models.OtErp.TblSoCustomer> CreateTblSoCustomer(Models.OtErp.TblSoCustomer tblSoCustomer)
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
            


      partial void OnTblSoOrderDetailsRead(ref IQueryable<Models.OtErp.TblSoOrderDetail> items);

      public async Task<IQueryable<Models.OtErp.TblSoOrderDetail>> GetTblSoOrderDetails(string filter = null, string orderby = null)
      {
        var items = context.TblSoOrderDetails.AsQueryable();

        items = items.Include(i => i.TblSoOrderDetailStatus);

        items = items.Include(i => i.TblSoSalesOrder);

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
    
      partial void OnTblSoOrderDetailCreated(Models.OtErp.TblSoOrderDetail item);



      public async Task<Models.OtErp.TblSoOrderDetail> CreateTblSoOrderDetail(Models.OtErp.TblSoOrderDetail tblSoOrderDetail)
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
            


      partial void OnTblSoOrderDetailStatusesRead(ref IQueryable<Models.OtErp.TblSoOrderDetailStatus> items);

      public async Task<IQueryable<Models.OtErp.TblSoOrderDetailStatus>> GetTblSoOrderDetailStatuses(string filter = null, string orderby = null)
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
    
      partial void OnTblSoOrderDetailStatusCreated(Models.OtErp.TblSoOrderDetailStatus item);



      public async Task<Models.OtErp.TblSoOrderDetailStatus> CreateTblSoOrderDetailStatus(Models.OtErp.TblSoOrderDetailStatus tblSoOrderDetailStatus)
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
            


      partial void OnTblSoOrderStatusesRead(ref IQueryable<Models.OtErp.TblSoOrderStatus> items);

      public async Task<IQueryable<Models.OtErp.TblSoOrderStatus>> GetTblSoOrderStatuses(string filter = null, string orderby = null)
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
    
      partial void OnTblSoOrderStatusCreated(Models.OtErp.TblSoOrderStatus item);



      public async Task<Models.OtErp.TblSoOrderStatus> CreateTblSoOrderStatus(Models.OtErp.TblSoOrderStatus tblSoOrderStatus)
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
            


      partial void OnTblSoSalesOrdersRead(ref IQueryable<Models.OtErp.TblSoSalesOrder> items);

      public async Task<IQueryable<Models.OtErp.TblSoSalesOrder>> GetTblSoSalesOrders(string filter = null, string orderby = null)
      {
        var items = context.TblSoSalesOrders.AsQueryable();

        items = items.Include(i => i.TblGnAddressBook);

        items = items.Include(i => i.TblSoOrderStatus);

        items = items.Include(i => i.TblSoCustomer);

        items = items.Include(i => i.TblGnAddressBook1);

        items = items.Include(i => i.TblGnAddressBook2);

        items = items.Include(i => i.TblGnShipVium);

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
    
      partial void OnTblSoSalesOrderCreated(Models.OtErp.TblSoSalesOrder item);



      public async Task<Models.OtErp.TblSoSalesOrder> CreateTblSoSalesOrder(Models.OtErp.TblSoSalesOrder tblSoSalesOrder)
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
            


      partial void OnViwGnAddBookCustsRead(ref IQueryable<Models.OtErp.ViwGnAddBookCust> items);

      public async Task<IQueryable<Models.OtErp.ViwGnAddBookCust>> GetViwGnAddBookCusts(string filter = null, string orderby = null)
      {
        var items = context.ViwGnAddBookCusts.AsQueryable();
        items = items.AsNoTracking();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnViwGnAddBookCustsRead(ref items);

        return await Task.FromResult(items);
      }
            


      partial void OnViwGnAddBookEmpsRead(ref IQueryable<Models.OtErp.ViwGnAddBookEmp> items);

      public async Task<IQueryable<Models.OtErp.ViwGnAddBookEmp>> GetViwGnAddBookEmps(string filter = null, string orderby = null)
      {
        var items = context.ViwGnAddBookEmps.AsQueryable();
        items = items.AsNoTracking();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnViwGnAddBookEmpsRead(ref items);

        return await Task.FromResult(items);
      }
            


      partial void OnViwSoCustBriefsRead(ref IQueryable<Models.OtErp.ViwSoCustBrief> items);

      public async Task<IQueryable<Models.OtErp.ViwSoCustBrief>> GetViwSoCustBriefs(string filter = null, string orderby = null)
      {
        var items = context.ViwSoCustBriefs.AsQueryable();
        items = items.AsNoTracking();

        if(!string.IsNullOrEmpty(filter))
        {
          items = items.Where(filter);
        }

        if(!string.IsNullOrEmpty(orderby))
        {
          items = items.OrderBy(orderby);
        }

        OnViwSoCustBriefsRead(ref items);

        return await Task.FromResult(items);
      }
            



      partial void OnTblGnAddressBookDeleted(Models.OtErp.TblGnAddressBook item);

      public async Task<Models.OtErp.TblGnAddressBook> DeleteTblGnAddressBook(int? addressBookSeq)
      {
        var item = context.TblGnAddressBooks
          .Where(i => i.AddressBook_SEQ == addressBookSeq)
          .Include(i => i.TblSoSalesOrders)
          .Include(i => i.TblSoSalesOrders1)
          .Include(i => i.TblSoSalesOrders2)
          .Include(i => i.TblSoCustomers)
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
    

      partial void OnTblGnAddressBookGet(Models.OtErp.TblGnAddressBook item);


      public async Task<Models.OtErp.TblGnAddressBook> GetTblGnAddressBookByAddressBookSeq(int? addressBookSeq)
      {
        var item = context.TblGnAddressBooks.Find(addressBookSeq);
        OnTblGnAddressBookGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnAddressBookUpdated(Models.OtErp.TblGnAddressBook item);

      public async Task<Models.OtErp.TblGnAddressBook> UpdateTblGnAddressBook(int? addressBookSeq, Models.OtErp.TblGnAddressBook tblGnAddressBook)
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
            



      partial void OnTblGnAddressBookTypeDeleted(Models.OtErp.TblGnAddressBookType item);

      public async Task<Models.OtErp.TblGnAddressBookType> DeleteTblGnAddressBookType(int? addressBookTypeSeq)
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
    

      partial void OnTblGnAddressBookTypeGet(Models.OtErp.TblGnAddressBookType item);


      public async Task<Models.OtErp.TblGnAddressBookType> GetTblGnAddressBookTypeByAddressBookTypeSeq(int? addressBookTypeSeq)
      {
        var item = context.TblGnAddressBookTypes.Find(addressBookTypeSeq);
        OnTblGnAddressBookTypeGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnAddressBookTypeUpdated(Models.OtErp.TblGnAddressBookType item);

      public async Task<Models.OtErp.TblGnAddressBookType> UpdateTblGnAddressBookType(int? addressBookTypeSeq, Models.OtErp.TblGnAddressBookType tblGnAddressBookType)
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
            



      partial void OnTblGnCityDeleted(Models.OtErp.TblGnCity item);

      public async Task<Models.OtErp.TblGnCity> DeleteTblGnCity(int? citySeq)
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
    

      partial void OnTblGnCityGet(Models.OtErp.TblGnCity item);


      public async Task<Models.OtErp.TblGnCity> GetTblGnCityByCitySeq(int? citySeq)
      {
        var item = context.TblGnCities.Find(citySeq);
        OnTblGnCityGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnCityUpdated(Models.OtErp.TblGnCity item);

      public async Task<Models.OtErp.TblGnCity> UpdateTblGnCity(int? citySeq, Models.OtErp.TblGnCity tblGnCity)
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
            



      partial void OnTblGnGenderDeleted(Models.OtErp.TblGnGender item);

      public async Task<Models.OtErp.TblGnGender> DeleteTblGnGender(int? genderSeq)
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
    

      partial void OnTblGnGenderGet(Models.OtErp.TblGnGender item);


      public async Task<Models.OtErp.TblGnGender> GetTblGnGenderByGenderSeq(int? genderSeq)
      {
        var item = context.TblGnGenders.Find(genderSeq);
        OnTblGnGenderGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnGenderUpdated(Models.OtErp.TblGnGender item);

      public async Task<Models.OtErp.TblGnGender> UpdateTblGnGender(int? genderSeq, Models.OtErp.TblGnGender tblGnGender)
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
            



      partial void OnTblGnPaymentTermDeleted(Models.OtErp.TblGnPaymentTerm item);

      public async Task<Models.OtErp.TblGnPaymentTerm> DeleteTblGnPaymentTerm(int? paymentTermSeq)
      {
        var item = context.TblGnPaymentTerms
          .Where(i => i.PaymentTerm_SEQ == paymentTermSeq)
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
    

      partial void OnTblGnPaymentTermGet(Models.OtErp.TblGnPaymentTerm item);


      public async Task<Models.OtErp.TblGnPaymentTerm> GetTblGnPaymentTermByPaymentTermSeq(int? paymentTermSeq)
      {
        var item = context.TblGnPaymentTerms.Find(paymentTermSeq);
        OnTblGnPaymentTermGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnPaymentTermUpdated(Models.OtErp.TblGnPaymentTerm item);

      public async Task<Models.OtErp.TblGnPaymentTerm> UpdateTblGnPaymentTerm(int? paymentTermSeq, Models.OtErp.TblGnPaymentTerm tblGnPaymentTerm)
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
            



      partial void OnTblGnPaymentTypeDeleted(Models.OtErp.TblGnPaymentType item);

      public async Task<Models.OtErp.TblGnPaymentType> DeleteTblGnPaymentType(int? paymentTypeSeq)
      {
        var item = context.TblGnPaymentTypes
          .Where(i => i.PaymentType_SEQ == paymentTypeSeq)
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
    

      partial void OnTblGnPaymentTypeGet(Models.OtErp.TblGnPaymentType item);


      public async Task<Models.OtErp.TblGnPaymentType> GetTblGnPaymentTypeByPaymentTypeSeq(int? paymentTypeSeq)
      {
        var item = context.TblGnPaymentTypes.Find(paymentTypeSeq);
        OnTblGnPaymentTypeGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnPaymentTypeUpdated(Models.OtErp.TblGnPaymentType item);

      public async Task<Models.OtErp.TblGnPaymentType> UpdateTblGnPaymentType(int? paymentTypeSeq, Models.OtErp.TblGnPaymentType tblGnPaymentType)
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
            



      partial void OnTblGnShipViumDeleted(Models.OtErp.TblGnShipVium item);

      public async Task<Models.OtErp.TblGnShipVium> DeleteTblGnShipVium(int? shipViaSeq)
      {
        var item = context.TblGnShipVia
          .Where(i => i.ShipVia_SEQ == shipViaSeq)
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
    

      partial void OnTblGnShipViumGet(Models.OtErp.TblGnShipVium item);


      public async Task<Models.OtErp.TblGnShipVium> GetTblGnShipViumByShipViaSeq(int? shipViaSeq)
      {
        var item = context.TblGnShipVia.Find(shipViaSeq);
        OnTblGnShipViumGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblGnShipViumUpdated(Models.OtErp.TblGnShipVium item);

      public async Task<Models.OtErp.TblGnShipVium> UpdateTblGnShipVium(int? shipViaSeq, Models.OtErp.TblGnShipVium tblGnShipVium)
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
            



      partial void OnTblSoCustomerDeleted(Models.OtErp.TblSoCustomer item);

      public async Task<Models.OtErp.TblSoCustomer> DeleteTblSoCustomer(int? customerSeq)
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
    

      partial void OnTblSoCustomerGet(Models.OtErp.TblSoCustomer item);


      public async Task<Models.OtErp.TblSoCustomer> GetTblSoCustomerByCustomerSeq(int? customerSeq)
      {
        var item = context.TblSoCustomers.Find(customerSeq);
        OnTblSoCustomerGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblSoCustomerUpdated(Models.OtErp.TblSoCustomer item);

      public async Task<Models.OtErp.TblSoCustomer> UpdateTblSoCustomer(int? customerSeq, Models.OtErp.TblSoCustomer tblSoCustomer)
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
            



      partial void OnTblSoOrderDetailDeleted(Models.OtErp.TblSoOrderDetail item);

      public async Task<Models.OtErp.TblSoOrderDetail> DeleteTblSoOrderDetail(int? soDetailSeq)
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
    

      partial void OnTblSoOrderDetailGet(Models.OtErp.TblSoOrderDetail item);


      public async Task<Models.OtErp.TblSoOrderDetail> GetTblSoOrderDetailBySoDetailSeq(int? soDetailSeq)
      {
        var item = context.TblSoOrderDetails.Find(soDetailSeq);
        OnTblSoOrderDetailGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblSoOrderDetailUpdated(Models.OtErp.TblSoOrderDetail item);

      public async Task<Models.OtErp.TblSoOrderDetail> UpdateTblSoOrderDetail(int? soDetailSeq, Models.OtErp.TblSoOrderDetail tblSoOrderDetail)
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
            



      partial void OnTblSoOrderDetailStatusDeleted(Models.OtErp.TblSoOrderDetailStatus item);

      public async Task<Models.OtErp.TblSoOrderDetailStatus> DeleteTblSoOrderDetailStatus(int? soDetailStatusSeq)
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
    

      partial void OnTblSoOrderDetailStatusGet(Models.OtErp.TblSoOrderDetailStatus item);


      public async Task<Models.OtErp.TblSoOrderDetailStatus> GetTblSoOrderDetailStatusBySoDetailStatusSeq(int? soDetailStatusSeq)
      {
        var item = context.TblSoOrderDetailStatuses.Find(soDetailStatusSeq);
        OnTblSoOrderDetailStatusGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblSoOrderDetailStatusUpdated(Models.OtErp.TblSoOrderDetailStatus item);

      public async Task<Models.OtErp.TblSoOrderDetailStatus> UpdateTblSoOrderDetailStatus(int? soDetailStatusSeq, Models.OtErp.TblSoOrderDetailStatus tblSoOrderDetailStatus)
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
            



      partial void OnTblSoOrderStatusDeleted(Models.OtErp.TblSoOrderStatus item);

      public async Task<Models.OtErp.TblSoOrderStatus> DeleteTblSoOrderStatus(int? soStatusSeq)
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
    

      partial void OnTblSoOrderStatusGet(Models.OtErp.TblSoOrderStatus item);


      public async Task<Models.OtErp.TblSoOrderStatus> GetTblSoOrderStatusBySoStatusSeq(int? soStatusSeq)
      {
        var item = context.TblSoOrderStatuses.Find(soStatusSeq);
        OnTblSoOrderStatusGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblSoOrderStatusUpdated(Models.OtErp.TblSoOrderStatus item);

      public async Task<Models.OtErp.TblSoOrderStatus> UpdateTblSoOrderStatus(int? soStatusSeq, Models.OtErp.TblSoOrderStatus tblSoOrderStatus)
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
            



      partial void OnTblSoSalesOrderDeleted(Models.OtErp.TblSoSalesOrder item);

      public async Task<Models.OtErp.TblSoSalesOrder> DeleteTblSoSalesOrder(int? soSeq)
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
    

      partial void OnTblSoSalesOrderGet(Models.OtErp.TblSoSalesOrder item);


      public async Task<Models.OtErp.TblSoSalesOrder> GetTblSoSalesOrderBySoSeq(int? soSeq)
      {
        var item = context.TblSoSalesOrders.Find(soSeq);
        OnTblSoSalesOrderGet(item);
        return await Task.FromResult(item);
      }
    



      partial void OnTblSoSalesOrderUpdated(Models.OtErp.TblSoSalesOrder item);

      public async Task<Models.OtErp.TblSoSalesOrder> UpdateTblSoSalesOrder(int? soSeq, Models.OtErp.TblSoSalesOrder tblSoSalesOrder)
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
