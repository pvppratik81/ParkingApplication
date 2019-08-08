using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Class1
    {
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Grade Grade { get; set; }
    }

    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }

        // Foreign Key
        public int AuthorId { get; set; }
        // Navigation property
        public Author Author { get; set; }
    }

    public class ParkingSlot
    {
        public int Id { get; set; }
        [Required]
        public string SlotName { get; set; }
        public Boolean IsAssigned { get; set; }
    }

    public class Role
    {
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }

    }


    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        // Foreign Key
        public int RoleId { get; set; }
        // Foreign Key
        public int? ParkingSlotId { get; set; }

        // Navigation property
        public ParkingSlot ParkingSlot { get; set; }
        public Role Role { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }


    public class ReleasedSlot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? ParkingSlotId { get; set; }
        public DateTime ReleasedDate { get; set; }
        // Navigation property
        public ParkingSlot ParkingSlot { get; set; }
    }

    public class RequestSlot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime RequestDate { get; set; }
        // Navigation property
        public Employee Employee { get; set; }
    }



    public class SlotAllocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? ParkingSlotId { get; set; }
        public DateTime AllocationDate { get; set; }
        public int Status { get; set; }
        public String Comment { get; set; }
        // Navigation property
        public Employee Employee { get; set; }
        public ParkingSlot ParkingSlot { get; set; }

    }

}
