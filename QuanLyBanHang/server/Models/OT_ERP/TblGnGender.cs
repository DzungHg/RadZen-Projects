using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Models.OtErp
{
  [Table("tblGN_Gender", Schema = "dbo")]
  public partial class TblGnGender
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Gender_SEQ
    {
      get;
      set;
    }


    [InverseProperty("TblGnGender")]
    public ICollection<TblGnAddressBook> TblGnAddressBooks { get; set; }
    public string Gender_ID
    {
      get;
      set;
    }
    public string Gender
    {
      get;
      set;
    }
  }
}
