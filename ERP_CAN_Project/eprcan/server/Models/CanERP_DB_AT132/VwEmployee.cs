using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpCan.Models.CanErpDbAt132
{
  [Table("vw_Employee", Schema = "dbo")]
  public partial class VwEmployee
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
    public int? AddressBookType_FK
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
    public int? Gender_FK
    {
      get;
      set;
    }
    public DateTime? DOB
    {
      get;
      set;
    }
    public string Origin
    {
      get;
      set;
    }
    public string IDNumber
    {
      get;
      set;
    }
    public string TaxIDNumber
    {
      get;
      set;
    }
    public string OrganizationName
    {
      get;
      set;
    }
    public string JobPosition
    {
      get;
      set;
    }
    public string Address
    {
      get;
      set;
    }
    public int? City_FK
    {
      get;
      set;
    }
  }
}
