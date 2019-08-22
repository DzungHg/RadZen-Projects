using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Models.OtErp
{
  [Table("tblGN_City", Schema = "dbo")]
  public partial class TblGnCity
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int City_SEQ
    {
      get;
      set;
    }


    [InverseProperty("TblGnCity")]
    public ICollection<TblGnAddressBook> TblGnAddressBooks { get; set; }
    public string City_ID
    {
      get;
      set;
    }
    public string CityName
    {
      get;
      set;
    }
    public string CityAbbreviation
    {
      get;
      set;
    }
  }
}
