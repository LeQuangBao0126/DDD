using Exam.Domain.SeedWork;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.AggregateModels.CategoryAggregate
{
    public class Category : Entity , IAggregateRoot
    {
        [BsonElement("name")]
        public string  Name { get; set; }

        [BsonElement("urlPath")]
        public string  UrlPath { get; set; }  //domain/exam-category-1




    }
}
