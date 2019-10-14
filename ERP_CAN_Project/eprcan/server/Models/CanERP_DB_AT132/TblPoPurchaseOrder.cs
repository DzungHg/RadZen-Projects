using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpCan.Models.CanErpDbAt132
{
  [Table("tblPO_PurchaseOrder", Schema = "dbo")]
  public partial class TblPoPurchaseOrder
  {
    [Key]
    public string PO_ID
    {
      get;
      set;
    }


    [InverseProperty("TblPoPurchaseOrder")]
    public ICollection<TblPoPurchaseOrderDetail> TblPoPurchaseOrderDetails { get; set; }
    public DateTime? PODate
    {
      get;
      set;
    }
    public int? CreatedBy_FK
    {
      get;
      set;
    }

    [ForeignKey("CreatedBy_FK")]
    public TblGnAddressBook TblGnAddressBook { get; set; }
    public string POStatus_FK
    {
      get;
      set;
    }

    [ForeignKey("POStatus_FK")]
    public TblPoOrderStatus TblPoOrderStatus { get; set; }
    public string Vendor_FK
    {
      get;
      set;
    }

    [ForeignKey("Vendor_FK")]
    public TblPoVendor TblPoVendor { get; set; }
    public string Description
    {
      get;
      set;
    }
    public string Incoterm_ID
    {
      get;
      set;
    }
    public int? ShipVia_FK
    {
      get;
      set;
    }

    [ForeignKey("ShipVia_FK")]
    public TblGnShipVium TblGnShipVium { get; set; }
    public int? PaymentTerm_FK
    {
      get;
      set;
    }

    [ForeignKey("PaymentTerm_FK")]
    public TblGnPaymentTerm TblGnPaymentTerm { get; set; }
    public int? PaymentType_FK
    {
      get;
      set;
    }

    [ForeignKey("PaymentType_FK")]
    public TblGnPaymentType TblGnPaymentType { get; set; }
    public int? Buyer_FK
    {
      get;
      set;
    }
    public bool? TaxYN
    {
      get;
      set;
    }
    public double? TaxtRate
    {
      get;
      set;
    }
    public string Department_FK
    {
      get;
      set;
    }
    public decimal? PO_Amount
    {
      get;
      set;
    }
  }
}
