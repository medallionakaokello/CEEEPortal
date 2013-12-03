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
    
    public partial class User
    {
        public User()
        {
            this.Clients = new HashSet<Client>();
            this.Clients1 = new HashSet<Client>();
            this.Documents = new HashSet<Document>();
            this.Documents1 = new HashSet<Document>();
            this.Objects = new HashSet<Object>();
            this.Users1 = new HashSet<User>();
            this.Users11 = new HashSet<User>();
            this.Users12 = new HashSet<User>();
            this.ClientContacts = new HashSet<ClientContact>();
            this.ClientContacts1 = new HashSet<ClientContact>();
            this.People = new HashSet<Person>();
            this.People1 = new HashSet<Person>();
        }
    
        public int UserId { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Surname { get; set; }
        public string JobTitle { get; set; }
        public string EmailAddress { get; set; }
        public string Inactive { get; set; }
        public string SecurityOption { get; set; }
        public byte[] Photograph { get; set; }
        public int CreatedUserId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedUserId { get; set; }
        public byte[] UpdatedTimestamp { get; set; }
        public Nullable<int> ReportsToUserId { get; set; }
        public Nullable<bool> UseWindowsSecurity { get; set; }
        public string Domain { get; set; }
        public Nullable<bool> HideLoginDialog { get; set; }
        public string Sid { get; set; }
    
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Client> Clients1 { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Document> Documents1 { get; set; }
        public virtual ICollection<Object> Objects { get; set; }
        public virtual ICollection<User> Users1 { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<User> Users11 { get; set; }
        public virtual User User2 { get; set; }
        public virtual ICollection<User> Users12 { get; set; }
        public virtual User User3 { get; set; }
        public virtual ICollection<ClientContact> ClientContacts { get; set; }
        public virtual ICollection<ClientContact> ClientContacts1 { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<Person> People1 { get; set; }
    }
}