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
    
    public partial class footballplayer
    {
        public footballplayer()
        {
            this.matchevents = new HashSet<matchevents>();
            this.playernews = new HashSet<playernews>();
            this.squadplayer = new HashSet<squadplayer>();
        }
    
        public int idFootballPlayer { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int idFootballTeam1 { get; set; }
        public int idPosition1 { get; set; }
        public decimal value { get; set; }
        public byte[] picture { get; set; }
    
        public virtual footballteam footballteam { get; set; }
        public virtual position position { get; set; }
        public virtual ICollection<matchevents> matchevents { get; set; }
        public virtual ICollection<playernews> playernews { get; set; }
        public virtual ICollection<squadplayer> squadplayer { get; set; }
    }
}
