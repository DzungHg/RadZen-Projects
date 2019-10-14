using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using ErpCan.Models.CanErpDbAt132;

namespace ErpCan.Data
{
  public partial class CanErpDbAt132Context : Microsoft.EntityFrameworkCore.DbContext
  {
    public CanErpDbAt132Context(DbContextOptions<CanErpDbAt132Context> options):base(options)
    {
    }

    public CanErpDbAt132Context()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoApInvoice>().HasKey(table => new {
          table.Vendor_ID, table.Invoice_No
        });
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>().HasKey(table => new {
          table.Vendor_ID, table.Invoice_No
        });
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail>().HasKey(table => new {
          table.PO_FK, table.Inventory_FK
        });
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>().HasKey(table => new {
          table.RR_FK, table.Inventory_FK
        });
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>()
              .HasOne(i => i.TblGnAddressBookType)
              .WithMany(i => i.TblGnAddressBooks)
              .HasForeignKey(i => i.AddressBookType_FK)
              .HasPrincipalKey(i => i.AddressBookType_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>()
              .HasOne(i => i.TblGnGender)
              .WithMany(i => i.TblGnAddressBooks)
              .HasForeignKey(i => i.Gender_FK)
              .HasPrincipalKey(i => i.Gender_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>()
              .HasOne(i => i.TblGnCity)
              .WithMany(i => i.TblGnAddressBooks)
              .HasForeignKey(i => i.City_FK)
              .HasPrincipalKey(i => i.City_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblIcInventory>()
              .HasOne(i => i.TblIcWarehouse)
              .WithMany(i => i.TblIcInventories)
              .HasForeignKey(i => i.Warehouse_FK)
              .HasPrincipalKey(i => i.Warehouse_ID);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblIcInventory>()
              .HasOne(i => i.TblIcCategory)
              .WithMany(i => i.TblIcInventories)
              .HasForeignKey(i => i.Category_FK)
              .HasPrincipalKey(i => i.Category_ID);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblIcInventory>()
              .HasOne(i => i.TblIcClassification)
              .WithMany(i => i.TblIcInventories)
              .HasForeignKey(i => i.Classifi_FK)
              .HasPrincipalKey(i => i.Classifi_ID);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblIcInventory>()
              .HasOne(i => i.TblGnProduct)
              .WithMany(i => i.TblIcInventories)
              .HasForeignKey(i => i.Item_SK)
              .HasPrincipalKey(i => i.Product_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblIcInventory>()
              .HasOne(i => i.TblIcUnit)
              .WithMany(i => i.TblIcInventories)
              .HasForeignKey(i => i.Unit_FK)
              .HasPrincipalKey(i => i.Unit_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblIcTransaction>()
              .HasOne(i => i.TblIcTransactionType)
              .WithMany(i => i.TblIcTransactions)
              .HasForeignKey(i => i.Trans_Code)
              .HasPrincipalKey(i => i.Transaction_ID);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblIcTransaction>()
              .HasOne(i => i.TblIcWarehouse)
              .WithMany(i => i.TblIcTransactions)
              .HasForeignKey(i => i.Warehouse_ID)
              .HasPrincipalKey(i => i.Warehouse_ID);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblIcTransaction>()
              .HasOne(i => i.TblGnProduct)
              .WithMany(i => i.TblIcTransactions)
              .HasForeignKey(i => i.Item_FK)
              .HasPrincipalKey(i => i.Product_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>()
              .HasOne(i => i.TblPoVendor)
              .WithMany(i => i.TblPoAccountPayables)
              .HasForeignKey(i => i.Vendor_FK)
              .HasPrincipalKey(i => i.Vendor_ID);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>()
              .HasOne(i => i.TblGnDepartment)
              .WithMany(i => i.TblPoAccountPayables)
              .HasForeignKey(i => i.Department_FK)
              .HasPrincipalKey(i => i.Department_ID);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoApInvoice>()
              .HasOne(i => i.TblPoVendor)
              .WithMany(i => i.TblPoApInvoices)
              .HasForeignKey(i => i.Vendor_ID)
              .HasPrincipalKey(i => i.Vendor_ID);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>()
              .HasOne(i => i.TblPoVendor)
              .WithMany(i => i.TblPoApInvoicesDetails)
              .HasForeignKey(i => i.Vendor_ID)
              .HasPrincipalKey(i => i.Vendor_ID);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>()
              .HasOne(i => i.TblIcInventory)
              .WithMany(i => i.TblPoApInvoicesDetails)
              .HasForeignKey(i => i.Inventory_FK)
              .HasPrincipalKey(i => i.Inventory_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>()
              .HasOne(i => i.TblIcUnit)
              .WithMany(i => i.TblPoApInvoicesDetails)
              .HasForeignKey(i => i.Unit_FK)
              .HasPrincipalKey(i => i.Unit_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement>()
              .HasOne(i => i.TblGnAddressBook)
              .WithMany(i => i.TblPoCashDisbursements)
              .HasForeignKey(i => i.Customer_FK)
              .HasPrincipalKey(i => i.AddressBook_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>()
              .HasOne(i => i.TblGnAddressBook)
              .WithMany(i => i.TblPoPurchaseOrders)
              .HasForeignKey(i => i.CreatedBy_FK)
              .HasPrincipalKey(i => i.AddressBook_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>()
              .HasOne(i => i.TblPoOrderStatus)
              .WithMany(i => i.TblPoPurchaseOrders)
              .HasForeignKey(i => i.POStatus_FK)
              .HasPrincipalKey(i => i.POStatus_ID);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>()
              .HasOne(i => i.TblPoVendor)
              .WithMany(i => i.TblPoPurchaseOrders)
              .HasForeignKey(i => i.Vendor_FK)
              .HasPrincipalKey(i => i.Vendor_ID);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>()
              .HasOne(i => i.TblGnShipVium)
              .WithMany(i => i.TblPoPurchaseOrders)
              .HasForeignKey(i => i.ShipVia_FK)
              .HasPrincipalKey(i => i.ShipVia_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>()
              .HasOne(i => i.TblGnPaymentTerm)
              .WithMany(i => i.TblPoPurchaseOrders)
              .HasForeignKey(i => i.PaymentTerm_FK)
              .HasPrincipalKey(i => i.PaymentTerm_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>()
              .HasOne(i => i.TblGnPaymentType)
              .WithMany(i => i.TblPoPurchaseOrders)
              .HasForeignKey(i => i.PaymentType_FK)
              .HasPrincipalKey(i => i.PaymentType_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail>()
              .HasOne(i => i.TblPoPurchaseOrder)
              .WithMany(i => i.TblPoPurchaseOrderDetails)
              .HasForeignKey(i => i.PO_FK)
              .HasPrincipalKey(i => i.PO_ID);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail>()
              .HasOne(i => i.TblIcInventory)
              .WithMany(i => i.TblPoPurchaseOrderDetails)
              .HasForeignKey(i => i.Inventory_FK)
              .HasPrincipalKey(i => i.Inventory_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoRecReport>()
              .HasOne(i => i.TblGnAddressBook)
              .WithMany(i => i.TblPoRecReports)
              .HasForeignKey(i => i.CreatedBy_FK)
              .HasPrincipalKey(i => i.AddressBook_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoRecReport>()
              .HasOne(i => i.TblPoVendor)
              .WithMany(i => i.TblPoRecReports)
              .HasForeignKey(i => i.Vendor_FK)
              .HasPrincipalKey(i => i.Vendor_ID);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>()
              .HasOne(i => i.TblPoRecReport)
              .WithMany(i => i.TblPoRrOrderDetails)
              .HasForeignKey(i => i.RR_FK)
              .HasPrincipalKey(i => i.RR_No);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail>()
              .HasOne(i => i.TblIcInventory)
              .WithMany(i => i.TblPoRrOrderDetails)
              .HasForeignKey(i => i.Inventory_FK)
              .HasPrincipalKey(i => i.Inventory_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoCustomer>()
              .HasOne(i => i.TblGnAddressBook)
              .WithMany(i => i.TblSoCustomers)
              .HasForeignKey(i => i.CustomerAdressBook_FK)
              .HasPrincipalKey(i => i.AddressBook_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoCustomer>()
              .HasOne(i => i.TblGnPaymentTerm)
              .WithMany(i => i.TblSoCustomers)
              .HasForeignKey(i => i.PaymentTerm_FK)
              .HasPrincipalKey(i => i.PaymentTerm_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoCustomer>()
              .HasOne(i => i.TblGnPaymentType)
              .WithMany(i => i.TblSoCustomers)
              .HasForeignKey(i => i.PaymentType_FK)
              .HasPrincipalKey(i => i.PaymentType_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoOrderDetail>()
              .HasOne(i => i.TblSoOrderDetailStatus)
              .WithMany(i => i.TblSoOrderDetails)
              .HasForeignKey(i => i.SODetailStatus_FK)
              .HasPrincipalKey(i => i.SODetailStatus_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoOrderDetail>()
              .HasOne(i => i.TblSoSalesOrder)
              .WithMany(i => i.TblSoOrderDetails)
              .HasForeignKey(i => i.SO_FK)
              .HasPrincipalKey(i => i.SO_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoOrderDetail>()
              .HasOne(i => i.TblIcInventory)
              .WithMany(i => i.TblSoOrderDetails)
              .HasForeignKey(i => i.Inventory_FK)
              .HasPrincipalKey(i => i.Inventory_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder>()
              .HasOne(i => i.TblSoOrderStatus)
              .WithMany(i => i.TblSoSalesOrders)
              .HasForeignKey(i => i.SOStatus_FK)
              .HasPrincipalKey(i => i.SOStatus_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder>()
              .HasOne(i => i.TblSoCustomer)
              .WithMany(i => i.TblSoSalesOrders)
              .HasForeignKey(i => i.Customer_FK)
              .HasPrincipalKey(i => i.Customer_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder>()
              .HasOne(i => i.TblGnShipVium)
              .WithMany(i => i.TblSoSalesOrders)
              .HasForeignKey(i => i.ShipTo_FK)
              .HasPrincipalKey(i => i.ShipVia_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder>()
              .HasOne(i => i.TblGnPaymentTerm)
              .WithMany(i => i.TblSoSalesOrders)
              .HasForeignKey(i => i.PaymentTerm_FK)
              .HasPrincipalKey(i => i.PaymentTerm_SEQ);
        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder>()
              .HasOne(i => i.TblGnPaymentType)
              .WithMany(i => i.TblSoSalesOrders)
              .HasForeignKey(i => i.PaymentType_FK)
              .HasPrincipalKey(i => i.PaymentType_SEQ);

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblIcInventory>()
              .Property(p => p.Inactive)
              .HasDefaultValueSql("((0))");


        builder.Entity<ErpCan.Models.CanErpDbAt132.TblGnAddressBook>()
              .Property(p => p.DOB)
              .HasColumnType("date");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblIcInventory>()
              .Property(p => p.LastSaleDate)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblIcInventory>()
              .Property(p => p.LastPODate)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblIcInventory>()
              .Property(p => p.LastReceiptDate)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblIcInventory>()
              .Property(p => p.Leadtime)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblIcInventory>()
              .Property(p => p.LastUpdatedDate)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblIcTransaction>()
              .Property(p => p.Trans_Date)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblIcTransaction>()
              .Property(p => p.Reference_Date)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable>()
              .Property(p => p.Transact_Date)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment>()
              .Property(p => p.Voucher_Date)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment>()
              .Property(p => p.Invoice_Date)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoApInvoice>()
              .Property(p => p.Invoice_Date)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoApInvoice>()
              .Property(p => p.PO_Date)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoApInvoice>()
              .Property(p => p.Due_Date)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail>()
              .Property(p => p.Invoice_Date)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement>()
              .Property(p => p.PO_CashDisb_Date)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement>()
              .Property(p => p.Check_Date)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder>()
              .Property(p => p.PODate)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoRecReport>()
              .Property(p => p.RRDate)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoRecReport>()
              .Property(p => p.PODate)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoRecReport>()
              .Property(p => p.Invoice_Date)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoRecReport>()
              .Property(p => p.Ship_Date)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoVendor>()
              .Property(p => p.Last_Purchase_Date)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblPoVendor>()
              .Property(p => p.Last_Payment_Date)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoCustomer>()
              .Property(p => p.LastRevisedCreditLimitDate)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoCustomer>()
              .Property(p => p.LastUpdatedDate)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder>()
              .Property(p => p.SODate)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder>()
              .Property(p => p.CustomerPODate)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder>()
              .Property(p => p.ActualShipDate)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder>()
              .Property(p => p.ExpectedShipDate)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder>()
              .Property(p => p.LastUpdatedDate)
              .HasColumnType("datetime");

        builder.Entity<ErpCan.Models.CanErpDbAt132.VwCustomer>()
              .Property(p => p.DOB)
              .HasColumnType("date");

        builder.Entity<ErpCan.Models.CanErpDbAt132.VwEmpAndVend>()
              .Property(p => p.DOB)
              .HasColumnType("date");

        builder.Entity<ErpCan.Models.CanErpDbAt132.VwEmployee>()
              .Property(p => p.DOB)
              .HasColumnType("date");

        builder.Entity<ErpCan.Models.CanErpDbAt132.VwVendor>()
              .Property(p => p.DOB)
              .HasColumnType("date");

        this.OnModelBuilding(builder);
    }


    public DbSet<ErpCan.Models.CanErpDbAt132.TblGnAddressBook> TblGnAddressBooks
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblGnAddressBookType> TblGnAddressBookTypes
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblGnCity> TblGnCities
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblGnDepartment> TblGnDepartments
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblGnGender> TblGnGenders
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblGnIncoterm> TblGnIncoterms
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblGnPaymentTerm> TblGnPaymentTerms
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblGnPaymentType> TblGnPaymentTypes
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblGnProduct> TblGnProducts
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblGnShipVium> TblGnShipVia
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblIcCategory> TblIcCategories
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblIcClassification> TblIcClassifications
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblIcInventory> TblIcInventories
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblIcTransaction> TblIcTransactions
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblIcTransactionType> TblIcTransactionTypes
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblIcUnit> TblIcUnits
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblIcWarehouse> TblIcWarehouses
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblPoAccountPayable> TblPoAccountPayables
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblPoAccountsPayableAdjustment> TblPoAccountsPayableAdjustments
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblPoApInvoice> TblPoApInvoices
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblPoApInvoicesDetail> TblPoApInvoicesDetails
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblPoCashDisbursement> TblPoCashDisbursements
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblPoOrderStatus> TblPoOrderStatuses
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrder> TblPoPurchaseOrders
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblPoPurchaseOrderDetail> TblPoPurchaseOrderDetails
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblPoRecReport> TblPoRecReports
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblPoRrOrderDetail> TblPoRrOrderDetails
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblPoVendor> TblPoVendors
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblSoCustomer> TblSoCustomers
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblSoOrderDetail> TblSoOrderDetails
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblSoOrderDetailStatus> TblSoOrderDetailStatuses
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblSoOrderStatus> TblSoOrderStatuses
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.TblSoSalesOrder> TblSoSalesOrders
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.VwCustomer> VwCustomers
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.VwEmpAndVend> VwEmpAndVends
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.VwEmployee> VwEmployees
    {
      get;
      set;
    }

    public DbSet<ErpCan.Models.CanErpDbAt132.VwVendor> VwVendors
    {
      get;
      set;
    }
  }
}
