using System.ComponentModel.DataAnnotations;

namespace CryptoFashionAPI.Model
{
   
    public class Shoe
    {
        [Key]
        public int ID { get; set; }
        
        public string ShoeName { get; set; }

        public string Brand { get; set; }
    }
}