//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examdata
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subject
    {
        public int suid { get; set; }
        public string sname { get; set; }
        public int Course_cid { get; set; }
    
        public virtual Course Course { get; set; }
    }
}
