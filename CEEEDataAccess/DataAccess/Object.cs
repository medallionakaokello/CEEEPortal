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
    
    public partial class Object
    {
        public int ObjectID { get; set; }
        public int ObjectTypeId { get; set; }
        public string FileAs { get; set; }
        public string FlagText { get; set; }
        public Nullable<int> LocationId { get; set; }
        public int CreatedUserId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedUserId { get; set; }
        public byte[] UpdatedTimestamp { get; set; }
        public string SourceId { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Location Location { get; set; }
        public virtual ObjectType ObjectType { get; set; }
        public virtual User User { get; set; }
        public virtual Person Person { get; set; }
    }
}