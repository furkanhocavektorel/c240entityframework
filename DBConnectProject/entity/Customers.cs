
using System.ComponentModel.DataAnnotations;

namespace DBConnectProject.entity
{
    internal class Customers
    {
        [Key]
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? Fax { get; set; }
        public string? City { get; set; }
    }
}
