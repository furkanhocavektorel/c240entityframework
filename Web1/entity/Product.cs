using System.ComponentModel.DataAnnotations;

namespace Web1.entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        
        public int Stok { get; set; }
        public int Fiyat { get; set; }
        public string CategoryName { get; set; }
        public string Desc { get; set; }

    }
}
