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
using QuanLyBanHang.Models.OtErp;

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

      public async Task<IQueryable<TblGnAddressBook>> GetTblGnAddressBooks(string filter = null, string orderby = null)
      {
        var items = context.TblGnAddressBooks.AsQueryable();

        items = items.Include(i => i.TblGnAddressBookType);

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
    
      public async Task<TblGnAddressBook> CreateTblGnAddressBook(TblGnAddressBook tblGnAddressBook)
      {
        try
        {
            context.TblGnAddressBooks.Add(tblGnAddressBook);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblGnAddressBook;
      }
    

      partial void OnTblGnAddressBookDeleted(Models.OtErp.TblGnAddressBook item);

      public async Task<TblGnAddressBook> DeleteTblGnAddressBook(int? addressBookSeq)
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
    
      public async Task<TblGnAddressBook> GetTblGnAddressBookByAddressBookSeq(int? addressBookSeq)
      {
        return await Task.FromResult(context.TblGnAddressBooks.Find(addressBookSeq));
      }
    

      partial void OnTblGnAddressBookUpdated(Models.OtErp.TblGnAddressBook item);

      public async Task<TblGnAddressBook> UpdateTblGnAddressBook(int? addressBookSeq, TblGnAddressBook tblGnAddressBook)
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
            
      partial void OnTblGnAddressBookTypesRead(ref IQueryable<Models.OtErp.TblGnAddressBookType> items);

      public async Task<IQueryable<TblGnAddressBookType>> GetTblGnAddressBookTypes(string filter = null, string orderby = null)
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
    
      public async Task<TblGnAddressBookType> CreateTblGnAddressBookType(TblGnAddressBookType tblGnAddressBookType)
      {
        try
        {
            context.TblGnAddressBookTypes.Add(tblGnAddressBookType);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblGnAddressBookType;
      }
    

      partial void OnTblGnAddressBookTypeDeleted(Models.OtErp.TblGnAddressBookType item);

      public async Task<TblGnAddressBookType> DeleteTblGnAddressBookType(int? addressBookTypeSeq)
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
    
      public async Task<TblGnAddressBookType> GetTblGnAddressBookTypeByAddressBookTypeSeq(int? addressBookTypeSeq)
      {
        return await Task.FromResult(context.TblGnAddressBookTypes.Find(addressBookTypeSeq));
      }
    

      partial void OnTblGnAddressBookTypeUpdated(Models.OtErp.TblGnAddressBookType item);

      public async Task<TblGnAddressBookType> UpdateTblGnAddressBookType(int? addressBookTypeSeq, TblGnAddressBookType tblGnAddressBookType)
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
            
      partial void OnTblGnCitiesRead(ref IQueryable<Models.OtErp.TblGnCity> items);

      public async Task<IQueryable<TblGnCity>> GetTblGnCities(string filter = null, string orderby = null)
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
    
      public async Task<TblGnCity> CreateTblGnCity(TblGnCity tblGnCity)
      {
        try
        {
            context.TblGnCities.Add(tblGnCity);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblGnCity;
      }
    

      partial void OnTblGnCityDeleted(Models.OtErp.TblGnCity item);

      public async Task<TblGnCity> DeleteTblGnCity(int? citySeq)
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
    
      public async Task<TblGnCity> GetTblGnCityByCitySeq(int? citySeq)
      {
        return await Task.FromResult(context.TblGnCities.Find(citySeq));
      }
    

      partial void OnTblGnCityUpdated(Models.OtErp.TblGnCity item);

      public async Task<TblGnCity> UpdateTblGnCity(int? citySeq, TblGnCity tblGnCity)
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
            
      partial void OnTblGnPaymentTermsRead(ref IQueryable<Models.OtErp.TblGnPaymentTerm> items);

      public async Task<IQueryable<TblGnPaymentTerm>> GetTblGnPaymentTerms(string filter = null, string orderby = null)
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
    
      public async Task<TblGnPaymentTerm> CreateTblGnPaymentTerm(TblGnPaymentTerm tblGnPaymentTerm)
      {
        try
        {
            context.TblGnPaymentTerms.Add(tblGnPaymentTerm);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblGnPaymentTerm;
      }
    

      partial void OnTblGnPaymentTermDeleted(Models.OtErp.TblGnPaymentTerm item);

      public async Task<TblGnPaymentTerm> DeleteTblGnPaymentTerm(int? paymentTermSeq)
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
    
      public async Task<TblGnPaymentTerm> GetTblGnPaymentTermByPaymentTermSeq(int? paymentTermSeq)
      {
        return await Task.FromResult(context.TblGnPaymentTerms.Find(paymentTermSeq));
      }
    

      partial void OnTblGnPaymentTermUpdated(Models.OtErp.TblGnPaymentTerm item);

      public async Task<TblGnPaymentTerm> UpdateTblGnPaymentTerm(int? paymentTermSeq, TblGnPaymentTerm tblGnPaymentTerm)
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
            
      partial void OnTblGnPaymentTypesRead(ref IQueryable<Models.OtErp.TblGnPaymentType> items);

      public async Task<IQueryable<TblGnPaymentType>> GetTblGnPaymentTypes(string filter = null, string orderby = null)
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
    
      public async Task<TblGnPaymentType> CreateTblGnPaymentType(TblGnPaymentType tblGnPaymentType)
      {
        try
        {
            context.TblGnPaymentTypes.Add(tblGnPaymentType);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblGnPaymentType;
      }
    

      partial void OnTblGnPaymentTypeDeleted(Models.OtErp.TblGnPaymentType item);

      public async Task<TblGnPaymentType> DeleteTblGnPaymentType(int? paymentTypeSeq)
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
    
      public async Task<TblGnPaymentType> GetTblGnPaymentTypeByPaymentTypeSeq(int? paymentTypeSeq)
      {
        return await Task.FromResult(context.TblGnPaymentTypes.Find(paymentTypeSeq));
      }
    

      partial void OnTblGnPaymentTypeUpdated(Models.OtErp.TblGnPaymentType item);

      public async Task<TblGnPaymentType> UpdateTblGnPaymentType(int? paymentTypeSeq, TblGnPaymentType tblGnPaymentType)
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
            
      partial void OnTblGnShipViaRead(ref IQueryable<Models.OtErp.TblGnShipVium> items);

      public async Task<IQueryable<TblGnShipVium>> GetTblGnShipVia(string filter = null, string orderby = null)
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
    
      public async Task<TblGnShipVium> CreateTblGnShipVium(TblGnShipVium tblGnShipVium)
      {
        try
        {
            context.TblGnShipVia.Add(tblGnShipVium);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblGnShipVium;
      }
    

      partial void OnTblGnShipViumDeleted(Models.OtErp.TblGnShipVium item);

      public async Task<TblGnShipVium> DeleteTblGnShipVium(int? shipViaSeq)
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
    
      public async Task<TblGnShipVium> GetTblGnShipViumByShipViaSeq(int? shipViaSeq)
      {
        return await Task.FromResult(context.TblGnShipVia.Find(shipViaSeq));
      }
    

      partial void OnTblGnShipViumUpdated(Models.OtErp.TblGnShipVium item);

      public async Task<TblGnShipVium> UpdateTblGnShipVium(int? shipViaSeq, TblGnShipVium tblGnShipVium)
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
            
      partial void OnTblSoCustomersRead(ref IQueryable<Models.OtErp.TblSoCustomer> items);

      public async Task<IQueryable<TblSoCustomer>> GetTblSoCustomers(string filter = null, string orderby = null)
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
    
      public async Task<TblSoCustomer> CreateTblSoCustomer(TblSoCustomer tblSoCustomer)
      {
        try
        {
            context.TblSoCustomers.Add(tblSoCustomer);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblSoCustomer;
      }
    

      partial void OnTblSoCustomerDeleted(Models.OtErp.TblSoCustomer item);

      public async Task<TblSoCustomer> DeleteTblSoCustomer(int? customerSeq)
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
    
      public async Task<TblSoCustomer> GetTblSoCustomerByCustomerSeq(int? customerSeq)
      {
        return await Task.FromResult(context.TblSoCustomers.Find(customerSeq));
      }
    

      partial void OnTblSoCustomerUpdated(Models.OtErp.TblSoCustomer item);

      public async Task<TblSoCustomer> UpdateTblSoCustomer(int? customerSeq, TblSoCustomer tblSoCustomer)
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
            
      partial void OnTblSoOrderDetailsRead(ref IQueryable<Models.OtErp.TblSoOrderDetail> items);

      public async Task<IQueryable<TblSoOrderDetail>> GetTblSoOrderDetails(string filter = null, string orderby = null)
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
    
      public async Task<TblSoOrderDetail> CreateTblSoOrderDetail(TblSoOrderDetail tblSoOrderDetail)
      {
        try
        {
            context.TblSoOrderDetails.Add(tblSoOrderDetail);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblSoOrderDetail;
      }
    

      partial void OnTblSoOrderDetailDeleted(Models.OtErp.TblSoOrderDetail item);

      public async Task<TblSoOrderDetail> DeleteTblSoOrderDetail(int? soDetailSeq)
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
    
      public async Task<TblSoOrderDetail> GetTblSoOrderDetailBySoDetailSeq(int? soDetailSeq)
      {
        return await Task.FromResult(context.TblSoOrderDetails.Find(soDetailSeq));
      }
    

      partial void OnTblSoOrderDetailUpdated(Models.OtErp.TblSoOrderDetail item);

      public async Task<TblSoOrderDetail> UpdateTblSoOrderDetail(int? soDetailSeq, TblSoOrderDetail tblSoOrderDetail)
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
            
      partial void OnTblSoOrderDetailStatusesRead(ref IQueryable<Models.OtErp.TblSoOrderDetailStatus> items);

      public async Task<IQueryable<TblSoOrderDetailStatus>> GetTblSoOrderDetailStatuses(string filter = null, string orderby = null)
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
    
      public async Task<TblSoOrderDetailStatus> CreateTblSoOrderDetailStatus(TblSoOrderDetailStatus tblSoOrderDetailStatus)
      {
        try
        {
            context.TblSoOrderDetailStatuses.Add(tblSoOrderDetailStatus);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblSoOrderDetailStatus;
      }
    

      partial void OnTblSoOrderDetailStatusDeleted(Models.OtErp.TblSoOrderDetailStatus item);

      public async Task<TblSoOrderDetailStatus> DeleteTblSoOrderDetailStatus(int? soDetailStatusSeq)
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
    
      public async Task<TblSoOrderDetailStatus> GetTblSoOrderDetailStatusBySoDetailStatusSeq(int? soDetailStatusSeq)
      {
        return await Task.FromResult(context.TblSoOrderDetailStatuses.Find(soDetailStatusSeq));
      }
    

      partial void OnTblSoOrderDetailStatusUpdated(Models.OtErp.TblSoOrderDetailStatus item);

      public async Task<TblSoOrderDetailStatus> UpdateTblSoOrderDetailStatus(int? soDetailStatusSeq, TblSoOrderDetailStatus tblSoOrderDetailStatus)
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
            
      partial void OnTblSoOrderStatusesRead(ref IQueryable<Models.OtErp.TblSoOrderStatus> items);

      public async Task<IQueryable<TblSoOrderStatus>> GetTblSoOrderStatuses(string filter = null, string orderby = null)
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
    
      public async Task<TblSoOrderStatus> CreateTblSoOrderStatus(TblSoOrderStatus tblSoOrderStatus)
      {
        try
        {
            context.TblSoOrderStatuses.Add(tblSoOrderStatus);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblSoOrderStatus;
      }
    

      partial void OnTblSoOrderStatusDeleted(Models.OtErp.TblSoOrderStatus item);

      public async Task<TblSoOrderStatus> DeleteTblSoOrderStatus(int? soStatusSeq)
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
    
      public async Task<TblSoOrderStatus> GetTblSoOrderStatusBySoStatusSeq(int? soStatusSeq)
      {
        return await Task.FromResult(context.TblSoOrderStatuses.Find(soStatusSeq));
      }
    

      partial void OnTblSoOrderStatusUpdated(Models.OtErp.TblSoOrderStatus item);

      public async Task<TblSoOrderStatus> UpdateTblSoOrderStatus(int? soStatusSeq, TblSoOrderStatus tblSoOrderStatus)
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
            
      partial void OnTblSoSalesOrdersRead(ref IQueryable<Models.OtErp.TblSoSalesOrder> items);

      public async Task<IQueryable<TblSoSalesOrder>> GetTblSoSalesOrders(string filter = null, string orderby = null)
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
    
      public async Task<TblSoSalesOrder> CreateTblSoSalesOrder(TblSoSalesOrder tblSoSalesOrder)
      {
        try
        {
            context.TblSoSalesOrders.Add(tblSoSalesOrder);
            context.SaveChanges();
        }
        catch(Exception ex)
        {
            return null;
        }
        return tblSoSalesOrder;
      }
    

      partial void OnTblSoSalesOrderDeleted(Models.OtErp.TblSoSalesOrder item);

      public async Task<TblSoSalesOrder> DeleteTblSoSalesOrder(int? soSeq)
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
    
      public async Task<TblSoSalesOrder> GetTblSoSalesOrderBySoSeq(int? soSeq)
      {
        return await Task.FromResult(context.TblSoSalesOrders.Find(soSeq));
      }
    

      partial void OnTblSoSalesOrderUpdated(Models.OtErp.TblSoSalesOrder item);

      public async Task<TblSoSalesOrder> UpdateTblSoSalesOrder(int? soSeq, TblSoSalesOrder tblSoSalesOrder)
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
