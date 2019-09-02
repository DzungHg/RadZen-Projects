using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using QuanLyBanHang.Models.OtErp;

namespace QuanLyBanHang.Data
{
  public partial class OtErpContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public OtErpContext(DbContextOptions<OtErpContext> options):base(options)
    {
    }

    public OtErpContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<QuanLyBanHang.Models.OtErp.TblGnAddressBook>()
              .HasOne(i => i.TblGnAddressBookType)
              .WithMany(i => i.TblGnAddressBooks)
              .HasForeignKey(i => i.AddressBookType_FK)
              .HasPrincipalKey(i => i.AddressBookType_SEQ);
        builder.Entity<QuanLyBanHang.Models.OtErp.TblGnAddressBook>()
              .HasOne(i => i.TblGnGender)
              .WithMany(i => i.TblGnAddressBooks)
              .HasForeignKey(i => i.Gender_FK)
              .HasPrincipalKey(i => i.Gender_SEQ);
        builder.Entity<QuanLyBanHang.Models.OtErp.TblGnAddressBook>()
              .HasOne(i => i.TblGnCity)
              .WithMany(i => i.TblGnAddressBooks)
              .HasForeignKey(i => i.City_FK)
              .HasPrincipalKey(i => i.City_SEQ);
        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoCustomer>()
              .HasOne(i => i.TblGnAddressBook)
              .WithMany(i => i.TblSoCustomers)
              .HasForeignKey(i => i.CustomerAdressBook_FK)
              .HasPrincipalKey(i => i.AddressBook_SEQ);
        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoCustomer>()
              .HasOne(i => i.TblGnPaymentTerm)
              .WithMany(i => i.TblSoCustomers)
              .HasForeignKey(i => i.PaymentTerm_FK)
              .HasPrincipalKey(i => i.PaymentTerm_SEQ);
        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoCustomer>()
              .HasOne(i => i.TblGnPaymentType)
              .WithMany(i => i.TblSoCustomers)
              .HasForeignKey(i => i.PaymentType_FK)
              .HasPrincipalKey(i => i.PaymentType_SEQ);
        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoOrderDetail>()
              .HasOne(i => i.TblSoOrderDetailStatus)
              .WithMany(i => i.TblSoOrderDetails)
              .HasForeignKey(i => i.SODetailStatus_FK)
              .HasPrincipalKey(i => i.SODetailStatus_SEQ);
        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoOrderDetail>()
              .HasOne(i => i.TblSoSalesOrder)
              .WithMany(i => i.TblSoOrderDetails)
              .HasForeignKey(i => i.SO_FK)
              .HasPrincipalKey(i => i.SO_SEQ);
        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoSalesOrder>()
              .HasOne(i => i.TblGnAddressBook)
              .WithMany(i => i.TblSoSalesOrders)
              .HasForeignKey(i => i.CreatedBy_FK)
              .HasPrincipalKey(i => i.AddressBook_SEQ);
        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoSalesOrder>()
              .HasOne(i => i.TblSoOrderStatus)
              .WithMany(i => i.TblSoSalesOrders)
              .HasForeignKey(i => i.SOStatus_FK)
              .HasPrincipalKey(i => i.SOStatus_SEQ);
        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoSalesOrder>()
              .HasOne(i => i.TblSoCustomer)
              .WithMany(i => i.TblSoSalesOrders)
              .HasForeignKey(i => i.Customer_FK)
              .HasPrincipalKey(i => i.Customer_SEQ);
        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoSalesOrder>()
              .HasOne(i => i.TblGnAddressBook1)
              .WithMany(i => i.TblSoSalesOrders1)
              .HasForeignKey(i => i.BillTo_FK)
              .HasPrincipalKey(i => i.AddressBook_SEQ);
        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoSalesOrder>()
              .HasOne(i => i.TblGnAddressBook2)
              .WithMany(i => i.TblSoSalesOrders2)
              .HasForeignKey(i => i.ShipTo_FK)
              .HasPrincipalKey(i => i.AddressBook_SEQ);
        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoSalesOrder>()
              .HasOne(i => i.TblGnShipVium)
              .WithMany(i => i.TblSoSalesOrders)
              .HasForeignKey(i => i.ShipVia_FK)
              .HasPrincipalKey(i => i.ShipVia_SEQ);


        builder.Entity<QuanLyBanHang.Models.OtErp.TblGnAddressBook>()
              .Property(p => p.DOB)
              .HasColumnType("date");

        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoCustomer>()
              .Property(p => p.LastRevisedCreditLimitDate)
              .HasColumnType("datetime");

        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoCustomer>()
              .Property(p => p.LastUpdatedDate)
              .HasColumnType("datetime");

        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoSalesOrder>()
              .Property(p => p.SODate)
              .HasColumnType("datetime");

        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoSalesOrder>()
              .Property(p => p.CustomerPODate)
              .HasColumnType("datetime");

        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoSalesOrder>()
              .Property(p => p.ActualShipDate)
              .HasColumnType("datetime");

        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoSalesOrder>()
              .Property(p => p.ExpectedShipDate)
              .HasColumnType("datetime");

        builder.Entity<QuanLyBanHang.Models.OtErp.TblSoSalesOrder>()
              .Property(p => p.LastUpdatedDate)
              .HasColumnType("datetime");

        this.OnModelBuilding(builder);
    }


    public DbSet<QuanLyBanHang.Models.OtErp.TblGnAddressBook> TblGnAddressBooks
    {
      get;
      set;
    }

    public DbSet<QuanLyBanHang.Models.OtErp.TblGnAddressBookType> TblGnAddressBookTypes
    {
      get;
      set;
    }

    public DbSet<QuanLyBanHang.Models.OtErp.TblGnCity> TblGnCities
    {
      get;
      set;
    }

    public DbSet<QuanLyBanHang.Models.OtErp.TblGnGender> TblGnGenders
    {
      get;
      set;
    }

    public DbSet<QuanLyBanHang.Models.OtErp.TblGnPaymentTerm> TblGnPaymentTerms
    {
      get;
      set;
    }

    public DbSet<QuanLyBanHang.Models.OtErp.TblGnPaymentType> TblGnPaymentTypes
    {
      get;
      set;
    }

    public DbSet<QuanLyBanHang.Models.OtErp.TblGnShipVium> TblGnShipVia
    {
      get;
      set;
    }

    public DbSet<QuanLyBanHang.Models.OtErp.TblSoCustomer> TblSoCustomers
    {
      get;
      set;
    }

    public DbSet<QuanLyBanHang.Models.OtErp.TblSoOrderDetail> TblSoOrderDetails
    {
      get;
      set;
    }

    public DbSet<QuanLyBanHang.Models.OtErp.TblSoOrderDetailStatus> TblSoOrderDetailStatuses
    {
      get;
      set;
    }

    public DbSet<QuanLyBanHang.Models.OtErp.TblSoOrderStatus> TblSoOrderStatuses
    {
      get;
      set;
    }

    public DbSet<QuanLyBanHang.Models.OtErp.TblSoSalesOrder> TblSoSalesOrders
    {
      get;
      set;
    }

    public DbSet<QuanLyBanHang.Models.OtErp.ViwGnAddBookCust> ViwGnAddBookCusts
    {
      get;
      set;
    }

    public DbSet<QuanLyBanHang.Models.OtErp.ViwGnAddBookEmp> ViwGnAddBookEmps
    {
      get;
      set;
    }

    public DbSet<QuanLyBanHang.Models.OtErp.ViwSoCustBrief> ViwSoCustBriefs
    {
      get;
      set;
    }
  }
}
