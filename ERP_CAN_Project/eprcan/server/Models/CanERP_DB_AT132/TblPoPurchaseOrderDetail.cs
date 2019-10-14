using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpCan.Models.CanErpDbAt132
{
  [Table("tblPO_PurchaseOrderDetail", Schema = "dbo")]
  public partial class TblPoPurchaseOrderDetail
  {
    [Key]
    public string PO_FK
    {
      get;
      set;
    }

    [ForeignKey("PO_FK")]
    public TblPoPurchaseOrder TblPoPurchaseOrder { get; set; }
    public int Inventory_FK
    {
      get;
      set;
    }

    [ForeignKey("Inventory_FK")]
    public TblIcInventory TblIcInventory { get; set; }
    public decimal? Unit_Price
    {
      get;
      set;
    }
    public double? QtyOrdered
    {
      get;
      set;
    }
    public double? QtyReceived
    {
      get;
      set;
    }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public double SubTotal
    {
      get;
      set;
    }
    public double? TaxRate
    {
      get;
      set;
    }
    public double? DiscountPercent
    {
      get;
      set;
    }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public double Discount
    {
      get;
      set;
    }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public double Tax
    {
      get;
      set;
    }
  }
}
