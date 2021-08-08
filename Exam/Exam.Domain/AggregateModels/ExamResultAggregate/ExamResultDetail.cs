using Exam.Domain.AggregateModels.QuestionAggregate;
using Exam.Domain.SeedWork;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.AggregateModels.ExamResultAggregate
{
    public class ExamResultDetail : Entity
    {
        public ExamResultDetail(Question question, IEnumerable<Answer> selectedAnswers, string explain)
        {
            (Question, SelectedAnswers) = (question, selectedAnswers);
            IsCorrect = this.SelectedAnswers.Select(x => x.Id).Except(question.Answers.Select(x => x.Id)).ToList().Count == 0;
        }

        [BsonElement("question")]
        public Question Question { get; set; }
        [BsonElement("selectedAnswers")]
        public IEnumerable<Answer> SelectedAnswers { get; set; }
        [BsonElement("isCorrect")]
        public bool IsCorrect { get; set; }
    }
}
