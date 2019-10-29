using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpCan.Models.CanErpDbAt132
{
  [Table("tblIC_TransactionType", Schema = "dbo")]
  public partial class TblIcTransactionType
  {
    [Key]
    public string Transaction_ID
    {
      get;
      set;
    }


    public ICollection<TblIcTransaction> TblIcTransactions { get; set; }
    public string Transaction_Name
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
