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
            this.playersteam = new HashSet<playersteam>();
            this.playersteam1 = new HashSet<playersteam>();
            this.playersteam2 = new HashSet<playersteam>();
            this.playersteam3 = new HashSet<playersteam>();
            this.playersteam4 = new HashSet<playersteam>();
            this.playersteam5 = new HashSet<playersteam>();
            this.playersteam6 = new HashSet<playersteam>();
            this.playersteam7 = new HashSet<playersteam>();
            this.playersteam8 = new HashSet<playersteam>();
            this.playersteam9 = new HashSet<playersteam>();
            this.playersteam10 = new HashSet<playersteam>();
            this.playersteam11 = new HashSet<playersteam>();
            this.playersteam12 = new HashSet<playersteam>();
            this.playersteam13 = new HashSet<playersteam>();
            this.playersteam14 = new HashSet<playersteam>();
            this.transfer = new HashSet<transfer>();
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
        public virtual ICollection<playersteam> playersteam { get; set; }
        public virtual ICollection<playersteam> playersteam1 { get; set; }
        public virtual ICollection<playersteam> playersteam2 { get; set; }
        public virtual ICollection<playersteam> playersteam3 { get; set; }
        public virtual ICollection<playersteam> playersteam4 { get; set; }
        public virtual ICollection<playersteam> playersteam5 { get; set; }
        public virtual ICollection<playersteam> playersteam6 { get; set; }
        public virtual ICollection<playersteam> playersteam7 { get; set; }
        public virtual ICollection<playersteam> playersteam8 { get; set; }
        public virtual ICollection<playersteam> playersteam9 { get; set; }
        public virtual ICollection<playersteam> playersteam10 { get; set; }
        public virtual ICollection<playersteam> playersteam11 { get; set; }
        public virtual ICollection<playersteam> playersteam12 { get; set; }
        public virtual ICollection<playersteam> playersteam13 { get; set; }
        public virtual ICollection<playersteam> playersteam14 { get; set; }
        public virtual ICollection<transfer> transfer { get; set; }
    }
}