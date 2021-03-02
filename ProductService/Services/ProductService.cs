using System;
using System.Collections.Generic;
using System.Text;
using Common.Models;
using MongoDB.Driver;

namespace ProductService.Services
{
    public class ProductServices
    {
        private readonly IMongoCollection<Product> _products;
        public ProductServices(IProductDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _products = database.GetCollection<Product>(settings.ProductCollectionName);

        }

        public List<Product> Get()
        {
            List<Product> products;
            products = _products.Find(prod => true).ToList();
            return products;
        }

        public Product Get(string id) =>
            _products.Find<Product>(prod => prod.Id == id).FirstOrDefault();
    }
}
