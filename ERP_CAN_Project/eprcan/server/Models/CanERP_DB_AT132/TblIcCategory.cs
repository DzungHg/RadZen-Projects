using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpCan.Models.CanErpDbAt132
{
  [Table("tblIC_Category", Schema = "dbo")]
  public partial class TblIcCategory
  {
    [Key]
    public string Category_ID
    {
      get;
      set;
    }


    [InverseProperty("TblIcCategory")]
    public ICollection<TblIcInventory> TblIcInventories { get; set; }
    public string CategoryText
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
