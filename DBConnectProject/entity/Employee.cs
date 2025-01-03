
using System.ComponentModel.DataAnnotations;


namespace DBConnectProject.entity
{
    internal class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Title { get; set; }
    }
}
