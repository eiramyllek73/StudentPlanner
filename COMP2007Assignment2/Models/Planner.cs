//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COMP2007Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Planner
    {
        public int Id { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Display (Name = "Name of Course:")]
        public string TaskName { get; set; }
        [Display(Name = "Name/Type of Task:")]
        public string TaskDetails { get; set; }
        [Display(Name = "Details (if any):")]
        
        public System.DateTime DueDate  { get; set; }
        
    }
}
