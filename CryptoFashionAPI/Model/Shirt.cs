using System.ComponentModel.DataAnnotations;

namespace CryptoFashionAPI.Model
{
    public class Shirt
    {
        [Key]
        public int ID { get; set; }
        
        public string ShirtName { get; set; }
    }
}