using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Models.OtErp
{
  [Table("tblSO_SalesOrder", Schema = "dbo")]
  public partial class TblSoSalesOrder
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SO_SEQ
    {
      get;
      set;
    }


    [InverseProperty("TblSoSalesOrder")]
    public ICollection<TblSoOrderDetail> TblSoOrderDetails { get; set; }
    public string SO_ID
    {
      get;
      set;
    }
    public DateTime? SODate
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
    public int? SOStatus_FK
    {
      get;
      set;
    }

    [ForeignKey("SOStatus_FK")]
    public TblSoOrderStatus TblSoOrderStatus { get; set; }
    public int? Customer_FK
    {
      get;
      set;
    }

    [ForeignKey("Customer_FK")]
    public TblSoCustomer TblSoCustomer { get; set; }
    public string CustomerPONumber
    {
      get;
      set;
    }
    public DateTime? CustomerPODate
    {
      get;
      set;
    }
    public int? BillTo_FK
    {
      get;
      set;
    }

    [ForeignKey("BillTo_FK")]
    public TblGnAddressBook TblGnAddressBook1 { get; set; }
    public int? ShipTo_FK
    {
      get;
      set;
    }

    [ForeignKey("ShipTo_FK")]
    public TblGnAddressBook TblGnAddressBook2 { get; set; }
    public string Attention
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
    public DateTime? ActualShipDate
    {
      get;
      set;
    }
    public DateTime? ExpectedShipDate
    {
      get;
      set;
    }
    public int? Shipper_FK
    {
      get;
      set;
    }
    public int? PaymentTerm_FK
    {
      get;
      set;
    }
    public int? PaymentType_FK
    {
      get;
      set;
    }
    public int? SalesPersion_FK
    {
      get;
      set;
    }
    public decimal? Commission
    {
      get;
      set;
    }
    public int? Pick_No
    {
      get;
      set;
    }
    public int? Ship_No
    {
      get;
      set;
    }
    public bool? TaxYN
    {
      get;
      set;
    }
    public decimal? TaxtRate
    {
      get;
      set;
    }
    public decimal? Subtotal
    {
      get;
      set;
    }
    public decimal? Taxt_Amount
    {
      get;
      set;
    }
    public decimal? Discount_Amt
    {
      get;
      set;
    }
    public decimal? Freight
    {
      get;
      set;
    }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public decimal? Total_Order
    {
      get;
      set;
    }
    public string Description
    {
      get;
      set;
    }
    public string ChangeLong
    {
      get;
      set;
    }
    public string Notes
    {
      get;
      set;
    }
    public DateTime? LastUpdatedDate
    {
      get;
      set;
    }
    public int? LastUpdatedBy_FK
    {
      get;
      set;
    }
    public bool? Inactive
    {
      get;
      set;
    }
    public int? Sequence
    {
      get;
      set;
    }
  }
}
