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
    
    public partial class season
    {
        public season()
        {
            this.gameweek = new HashSet<gameweek>();
        }
    
        public int idSeason { get; set; }
        public string seasonName { get; set; }
        public string description { get; set; }
        public int SquadStructure_idSquadStructure { get; set; }
    
        public virtual ICollection<gameweek> gameweek { get; set; }
        public virtual squadstructure squadstructure { get; set; }
    }
}
