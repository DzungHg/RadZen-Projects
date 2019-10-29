using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErpCan.Models.CanErpDbAt132
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


    public ICollection<TblPoPurchaseOrder> TblPoPurchaseOrders { get; set; }

    public ICollection<TblSoCustomer> TblSoCustomers { get; set; }

    public ICollection<TblSoSalesOrder> TblSoSalesOrders { get; set; }
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
