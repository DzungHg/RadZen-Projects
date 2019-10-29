using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpCan.Models.CanErpDbAt132
{
  [Table("tblIC_Warehouse", Schema = "dbo")]
  public partial class TblIcWarehouse
  {
    [Key]
    public string Warehouse_ID
    {
      get;
      set;
    }


    public ICollection<TblIcInventory> TblIcInventories { get; set; }

    public ICollection<TblIcTransaction> TblIcTransactions { get; set; }
    public string WarehouseName
    {
      get;
      set;
    }
    public string WarehouseAddress
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
