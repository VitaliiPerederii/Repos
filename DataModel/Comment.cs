//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public int PostId { get; set; }
        public string Owner { get; set; }
    
        public virtual Post Post { get; set; }
    }
}