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
    
    public partial class CreditStatement
    {
        public int CreditStateID { get; set; }
        public string CreditAccountNo { get; set; }
        public string CreditDescription { get; set; }
        public Nullable<System.DateTime> CreditDate { get; set; }
        public string CreditType { get; set; }
        public Nullable<float> CreditPayingAmount { get; set; }
    
        public virtual CreditAccount CreditAccount { get; set; }
    }
}