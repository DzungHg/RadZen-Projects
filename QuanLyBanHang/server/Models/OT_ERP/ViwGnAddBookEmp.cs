using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Models.OtErp
{
  [Table("viwGN_AddBookEmp", Schema = "dbo")]
  public partial class ViwGnAddBookEmp
  {
    [Key]
    public int AddressBook_SEQ
    {
      get;
      set;
    }
    public string AddressBook_ID
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
