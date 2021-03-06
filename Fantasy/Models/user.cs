//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fantasy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class user
    {
        public user()
        {
            this.league = new HashSet<league>();
            this.leagueparticipants = new HashSet<leagueparticipants>();
            this.squad = new HashSet<squad>();
        }
        
        public int userId { get; set; }
        [Display(Name = "First name")]
        public string firstName { get; set; }
        [Display(Name = "Last name")]
        public string lastName { get; set; }
        [Display(Name = "Date of birth")]
        public System.DateTime dateOfBirth { get; set; }
        [Display(Name = "Gender")]
        public bool gender { get; set; }
        [Display(Name = "Cellphone")]
        public string cellPhone { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Password")]
        public string password { get; set; }
        [Display(Name = "Country")]
        public string country { get; set; }
        [Display(Name = "Closest city")]
        public string closestCity { get; set; }
        public int UserGroup_idUserGroup { get; set; }
        public string image { get; set; }
       

        public virtual ICollection<league> league { get; set; }
        public virtual ICollection<leagueparticipants> leagueparticipants { get; set; }
        public virtual ICollection<squad> squad { get; set; }
        public virtual usergroup usergroup { get; set; }
    }
}
