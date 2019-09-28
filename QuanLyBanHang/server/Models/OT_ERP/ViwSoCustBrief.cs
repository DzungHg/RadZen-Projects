using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Models.OtErp
{
  [Table("viwSO_CustBrief", Schema = "dbo")]
  public partial class ViwSoCustBrief
  {
    [Key]
    public int Customer_SEQ
    {
      get;
      set;
    }
    public string Customer_ID
    {
      get;
      set;
    }
    public string LastName
    {
      get;
      set;
    }
    public string FirstName
    {
      get;
      set;
    }
  }
}
