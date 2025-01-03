using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectProject.entity
{
    internal class Category
    {
        [Key]
        public int CategoryID { get; set; }


        public string CategoryName { get; set; }

        public string? Description { get; set; }

    }
}
