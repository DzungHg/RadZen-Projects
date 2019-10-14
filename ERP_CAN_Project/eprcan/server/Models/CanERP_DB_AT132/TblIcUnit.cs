using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpCan.Models.CanErpDbAt132
{
  [Table("tblIC_Unit", Schema = "dbo")]
  public partial class TblIcUnit
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Unit_SEQ
    {
      get;
      set;
    }


    [InverseProperty("TblIcUnit")]
    public ICollection<TblPoApInvoicesDetail> TblPoApInvoicesDetails { get; set; }

    [InverseProperty("TblIcUnit")]
    public ICollection<TblIcInventory> TblIcInventories { get; set; }
    public string UnitText
    {
      get;
      set;
    }
    public string Unit_FK
    {
      get;
      set;
    }
  }
}
