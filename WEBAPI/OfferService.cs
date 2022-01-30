using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI
{
    public class OfferService
    {
        private  List<Product> Inventory { get; set; }
        public List<Product> _Inventory { get; set; }
        public OfferService()
        {
            _Inventory = GetAllProducts();
        }

        public List<Product> GetAllProducts()
        {
            Product P1 = new Product("P1",1000,"P1desc");
            Product P2 = new Product("P2", 200, "P2desc");
            Product P3 = new Product("P3", 200, "P3desc");
            Product P4 = new Product("P4", 200, "P4desc");
            Product P5 = new Product("P5", 200, "P5desc");
            Product P6 = new Product("P6", 200, "P6desc");
            List<Product> Inventory1 = new List<Product>();
            Inventory.Add(P1);
            Inventory.Add(P2);
            Inventory.Add(P3);
            Inventory.Add(P4);
            Inventory.Add(P5);
            Inventory.Add(P6);
            return Inventory1;
        }

        public Dictionary<string, List<Product>> GetTodaysOffers()
        {
            Dictionary<string, List<Product>> Offers = new Dictionary<string, List<Product>>();
            List<Product> Products = GetAllProducts();
            Offers.Add("ComboPackage1", Products.OrderBy(offers => System.Guid.NewGuid()).Take(3).ToList());

            Offers.Add("ComboPackage2", Products.OrderBy(offers => System.Guid.NewGuid()).Take(3).ToList());

            Offers.Add("ComboPackage3", Products.OrderBy(offers => System.Guid.NewGuid()).Take(3).ToList());

            return Offers;
        }

}
        
}
