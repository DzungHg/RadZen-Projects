using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpCan.Models.CanErpDbAt132
{
  [Table("tblPO_Vendor", Schema = "dbo")]
  public partial class TblPoVendor
  {
    [Key]
    public string Vendor_ID
    {
      get;
      set;
    }


    [InverseProperty("TblPoVendor")]
    public ICollection<TblPoPurchaseOrder> TblPoPurchaseOrders { get; set; }

    [InverseProperty("TblPoVendor")]
    public ICollection<TblPoAccountPayable> TblPoAccountPayables { get; set; }

    [InverseProperty("TblPoVendor")]
    public ICollection<TblPoApInvoice> TblPoApInvoices { get; set; }

    [InverseProperty("TblPoVendor")]
    public ICollection<TblPoApInvoicesDetail> TblPoApInvoicesDetails { get; set; }

    [InverseProperty("TblPoVendor")]
    public ICollection<TblPoRecReport> TblPoRecReports { get; set; }
    public string LastName
    {
      get;
      set;
    }
    public string FirstName
    {
      get;
      set;
    }
    public int? VendorAdressBook_FK
    {
      get;
      set;
    }
    public string Performing_Rating
    {
      get;
      set;
    }
    public decimal? AP_Balance
    {
      get;
      set;
    }
    public decimal? Outstand_Inv_Amt
    {
      get;
      set;
    }
    public decimal? Outstand_Credit
    {
      get;
      set;
    }
    public DateTime? Last_Purchase_Date
    {
      get;
      set;
    }
    public DateTime? Last_Payment_Date
    {
      get;
      set;
    }
    public decimal? Current_MTD_Returns
    {
      get;
      set;
    }
    public decimal? MTD_Purchase
    {
      get;
      set;
    }
    public decimal? YTD_Purchase
    {
      get;
      set;
    }
    public decimal? LYR_Purchase
    {
      get;
      set;
    }
    public string Notes
    {
      get;
      set;
    }
    public bool? Inactive
    {
      get;
      set;
    }
  }
}