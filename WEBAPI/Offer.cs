using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI
{
    public class Offer
    {
        public string OfferName { get; set; }
        public List<Product> Products { get; set; }
        public Offer(string _offername, List<Product> _Products)
        {
            OfferName = _offername;
            Products = _Products;
        }
    }
}
