//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xemphim.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhimDaoDien
    {
        public int IdPhim { get; set; }
        public Nullable<int> IdDaoDien { get; set; }
    
        public virtual DaoDien DaoDien { get; set; }
        public virtual Phim Phim { get; set; }
    }
}
