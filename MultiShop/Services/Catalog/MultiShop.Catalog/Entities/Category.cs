﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }
    }
}
