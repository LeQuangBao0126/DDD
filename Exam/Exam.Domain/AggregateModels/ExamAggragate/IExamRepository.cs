using Exam.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.AggregateModels.ExamAggragate
{
    public interface IExamRepository : IRepositoryBase<Exam>
    {
        Task<IEnumerable<Exam>> GetExamListAsync();
        Task<Exam> GetExamByIdAsync(string id);
    }
}
