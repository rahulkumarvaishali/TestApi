//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestApi.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TestTable
    {
        public int Sr_No { get; set; }
        [Required(ErrorMessage ="Name Required")]
        [Display(Name ="Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Age Required")]
        public Nullable<int> Age { get; set; }
    }
}
