
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment1.Models
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    [Table("Employees")]
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]   // User provide value
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Please enter a Last Name.")]
        [StringLength(50, ErrorMessage = "Last Name must not exceed 50 characters.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter a First Name.")]
        [StringLength(50, ErrorMessage = "First Name must not exceed 50 characters.")]
        public string? FirstMidName { get; set; }

        public string FullName
        {
            get { return LastName + ", " + FirstMidName; }
        }

        [EnumDataType(typeof(Gender), ErrorMessage = "Please select a valid Gender.")]
        public Gender? Gender { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Invalid Phone Number.")]
        public string PhoneNumber { get; set; }

        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
