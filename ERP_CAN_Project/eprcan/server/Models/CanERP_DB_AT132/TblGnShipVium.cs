using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpCan.Models.CanErpDbAt132
{
  [Table("tblGN_ShipVia", Schema = "dbo")]
  public partial class TblGnShipVium
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ShipVia_SEQ
    {
      get;
      set;
    }


    [InverseProperty("TblGnShipVium")]
    public ICollection<TblPoPurchaseOrder> TblPoPurchaseOrders { get; set; }

    [InverseProperty("TblGnShipVium")]
    public ICollection<TblSoSalesOrder> TblSoSalesOrders { get; set; }
    public string ShipVia_ID
    {
      get;
      set;
    }
    public string Description
    {
      get;
      set;
    }
  }
}
