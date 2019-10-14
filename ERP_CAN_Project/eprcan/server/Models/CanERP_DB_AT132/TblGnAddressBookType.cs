using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpCan.Models.CanErpDbAt132
{
  [Table("tblGN_AddressBookType", Schema = "dbo")]
  public partial class TblGnAddressBookType
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AddressBookType_SEQ
    {
      get;
      set;
    }


    [InverseProperty("TblGnAddressBookType")]
    public ICollection<TblGnAddressBook> TblGnAddressBooks { get; set; }
    public string AddressBookType_ID
    {
      get;
      set;
    }
    public string AddressBookTypeText
    {
      get;
      set;
    }
  }
}