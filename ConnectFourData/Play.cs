//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConnectFourData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Play
    {
        public int id { get; set; }
        public int winner { get; set; }
        public int loser { get; set; }
        public int klicks { get; set; }
        public int time_in_seconds { get; set; }
    
        public virtual Player Player { get; set; }
    }
}