//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CEEEDataAccess.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class CeeeJobContractType
    {
        public CeeeJobContractType()
        {
            this.CeeeJobDescriptions = new HashSet<CeeeJobDescription>();
        }
    
        public int JobContractTypeId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<CeeeJobDescription> CeeeJobDescriptions { get; set; }
        public virtual CeeeJobContractType CeeeJobContractType1 { get; set; }
        public virtual CeeeJobContractType CeeeJobContractType2 { get; set; }
    }
}