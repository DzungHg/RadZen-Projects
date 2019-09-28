using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Models.OtErp
{
  [Table("tblGN_PaymentType", Schema = "dbo")]
  public partial class TblGnPaymentType
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PaymentType_SEQ
    {
      get;
      set;
    }


    [InverseProperty("TblGnPaymentType")]
    public ICollection<TblSoCustomer> TblSoCustomers { get; set; }
    public string PaymentType_ID
    {
      get;
      set;
    }
    public string PaymentTypeText
    {
      get;
      set;
    }
  }
}
