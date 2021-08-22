using System.Data.Common;

namespace CryptoFashionAPI.Domain
{
    public class Shoe
    {
        public int Id { get; set; }
        
        public string ShoeName { get; set; }

        public string Brand { get; set; }
        
        public Shoe(int id, string shoeName, string brand)
        {
            Id = id;
            ShoeName = shoeName;
            Brand = brand;
        }
    }
}