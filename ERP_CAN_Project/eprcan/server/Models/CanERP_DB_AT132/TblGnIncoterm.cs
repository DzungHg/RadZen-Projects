using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpCan.Models.CanErpDbAt132
{
  [Table("tblGN_Incoterms", Schema = "dbo")]
  public partial class TblGnIncoterm
  {
    [Key]
    public string Incoterm_ID
    {
      get;
      set;
    }
    public string Incoterm_Name
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
