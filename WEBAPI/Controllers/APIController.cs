using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
//    3) Create an async HTTPGET function that uses OfferService.GetTodaysOffers() and
//returns the results.
//4) Create an async HTTPGET function that uses OfferService.GetAllProducts() and filters
//the results to 3 products with the lowest prices, using Linq. Return the 3 products.
//5) Create an async HTTPGET function that uses OfferService.GetAllProducts() and filters
//the results to the product with the 2nd lowest price.
//6) Create an HTTPPost function that adds a given new product to the Products list in the
//OfferService.
    public class APIController : ControllerBase
    {
        private readonly OfferService _offerservice;
        public APIController(OfferService offerService)
        {
            _offerservice = offerService;
        }
        [HttpGet]
        [Route("GetTodaysOffers")]
        public async Task<Dictionary<string, List<Product>>> GetTodaysOffers()
        {
            Dictionary<string, List<Product>> _dict = await (Task.Run(() => _offerservice.GetTodaysOffers()));

                return _dict;
        }
        [HttpGet]
        public async Task< List<Product>> GetThreeProductsWithLeastValue()
        {
            List<Product> Products = await (Task.Run(() => _offerservice.GetAllProducts()));

            Product1 = Products.OrderBy(offers => o).Take(3).ToList();

        }
        [HttpGet]
        public async Task<Dictionary<string, List<Product>>> GetTodaysOffers()
        {
            _offerservice.GetTodaysOffers();


        }
    }
}
