
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment1.Models
{
    [Table("Departments")]
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]   // User provide value
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Please enter a Department Name.")]
        [StringLength(100, ErrorMessage = "Department Name must not exceed 100 characters.")]
        public string? DepartmentName { get; set; }

        [Required(ErrorMessage = "Please enter Location.")]
        [StringLength(100, ErrorMessage = "Location must not exceed 100 characters.")]
        public string? Location { get; set; }

        [StringLength(500, ErrorMessage = "Description must not exceed 500 characters.")]
        public string? Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Budget must be greater than 0.")]
        public decimal Budget { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<Project> Projects { get; set; }
    }

}
