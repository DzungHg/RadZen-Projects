using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Models.OtErp
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
    public ICollection<TblSoSalesOrder> TblSoSalesOrders { get; set; }

    [InverseProperty("TblGnAddressBook1")]
    public ICollection<TblSoSalesOrder> TblSoSalesOrders1 { get; set; }

    [InverseProperty("TblGnAddressBook2")]
    public ICollection<TblSoSalesOrder> TblSoSalesOrders2 { get; set; }

    [InverseProperty("TblGnAddressBook")]
    public ICollection<TblSoCustomer> TblSoCustomers { get; set; }
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
