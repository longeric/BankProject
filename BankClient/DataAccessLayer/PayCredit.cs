//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class PayCredit
    {
        public int PayID { get; set; }
        public string AccountNo { get; set; }
        public string CreditAccountNo { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> PayCreditDate { get; set; }
        public string PayCreditType { get; set; }
        public Nullable<float> PayCreditPayingAmount { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual CreditAccount CreditAccount { get; set; }
    }
}
