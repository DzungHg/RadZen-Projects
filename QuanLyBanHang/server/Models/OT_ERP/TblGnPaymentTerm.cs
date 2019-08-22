using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Models.OtErp
{
  [Table("tblGN_PaymentTerms", Schema = "dbo")]
  public partial class TblGnPaymentTerm
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PaymentTerm_SEQ
    {
      get;
      set;
    }


    [InverseProperty("TblGnPaymentTerm")]
    public ICollection<TblSoCustomer> TblSoCustomers { get; set; }
    public string PaymentTermText
    {
      get;
      set;
    }
    public string PaymentTerm_ID
    {
      get;
      set;
    }
  }
}
