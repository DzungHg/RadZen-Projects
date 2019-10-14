using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpCan.Models.CanErpDbAt132
{
  [Table("tblGN_AddressBook", Schema = "dbo")]
  public partial class TblGnAddressBook
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AddressBook_SEQ
    {
      get;
      set;
    }


    [InverseProperty("TblGnAddressBook")]
    public ICollection<TblPoPurchaseOrder> TblPoPurchaseOrders { get; set; }

    [InverseProperty("TblGnAddressBook")]
    public ICollection<TblPoRecReport> TblPoRecReports { get; set; }

    [InverseProperty("TblGnAddressBook")]
    public ICollection<TblSoCustomer> TblSoCustomers { get; set; }

    [InverseProperty("TblGnAddressBook")]
    public ICollection<TblPoCashDisbursement> TblPoCashDisbursements { get; set; }

    [InverseProperty("TblGnAddressBook")]
    public ICollection<TblPoVendor> TblPoVendors { get; set; }
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

    [ForeignKey("AddressBookType_FK")]
    public TblGnAddressBookType TblGnAddressBookType { get; set; }
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

    [ForeignKey("Gender_FK")]
    public TblGnGender TblGnGender { get; set; }
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

    [ForeignKey("City_FK")]
    public TblGnCity TblGnCity { get; set; }
  }
}
