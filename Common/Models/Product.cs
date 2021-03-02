using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Common.Models
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
