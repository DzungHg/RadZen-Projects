using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpCan.Models.CanErpDbAt132
{
  [Table("tblPO_RROrderDetail", Schema = "dbo")]
  public partial class TblPoRrOrderDetail
  {
    [Key]
    public string RR_FK
    {
      get;
      set;
    }

    [ForeignKey("RR_FK")]
    public TblPoRecReport TblPoRecReport { get; set; }
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
  }
}
