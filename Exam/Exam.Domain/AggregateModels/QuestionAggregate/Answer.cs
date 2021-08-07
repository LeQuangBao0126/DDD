﻿using Exam.Domain.SeedWork;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.AggregateModels.QuestionAggregate
{
    public class Answer : Entity
    {
        public Answer(string id, string content, bool isCorrect = false) => (Id, Content, IsCorrect) = (id, content, isCorrect);

        [BsonElement("content")]
        public string Content { get; set; }

        [BsonElement("isCorrect")]
        public bool IsCorrect { get; set; }

    }
}