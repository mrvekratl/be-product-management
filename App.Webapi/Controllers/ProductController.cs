using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static private readonly List<Product> _products = new();   
                       
        [HttpGet]
        public IEnumerable<Product> GetList()
        {
            return _products;        
        }

        [HttpGet("{id}")]
        public Product? GetItem(int id)
        {           
            return _products.Find(x => x.Id == id);
        }

        [HttpPost]
        public void AddItem(Product item)
        {
            //if (_products.Count == 0)
            //{
            //    item.Id = 1;            
            //}
            //item.Id = _products.Max(x => x.Id);
            item.Id = _products.Count + 1;
            _products.Add(item);
        }

        [HttpPut("{id}")]
        public void UpdateItem(int id, string name, decimal price, string category)
        {
            var item = _products.FindIndex(x => x.Id == id);
            if(item == -1)
            {
                return;
            }
            _products[item].Name = name;
            _products[item].Price = price;
            _products[item].Category = category;

        }

        [HttpDelete("{id}")]
        public void DeleteItem(int id)
        { 
            var item = _products.FindIndex(x => x.Id == id);
            if(item == -1)
            {
                return;
            }
            _products.RemoveAt(item);
        }
        
    }
}
