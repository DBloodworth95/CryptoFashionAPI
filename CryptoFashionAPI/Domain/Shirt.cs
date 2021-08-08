using System.Data.Common;

namespace CryptoFashionAPI.Domain
{
    public class Shirt
    {
        public int Id { get; set; }

        public string ShirtName { get; set; }

        public Shirt(int id, string shirtName)
        {
            Id = id;
            ShirtName = shirtName;
        }
    }
}