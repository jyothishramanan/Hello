using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProductWebApp.Models
{
    
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Product_Id { get; set; }
        public string ProductName { get; set; }
        public string EntryDate { get; set; }
        public string Price { get; set; }
    }
}
