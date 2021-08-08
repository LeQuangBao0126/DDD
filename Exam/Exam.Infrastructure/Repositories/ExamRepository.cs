using Exam.Domain.AggregateModels.ExamAggragate;
using Exam.Infrastructure.SeedWork;
using MediatR;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrastructure.Repositories
{
    public class ExamRepository : BaseRepository<Exams>, IExamRepository
    {
        public ExamRepository(IMongoClient mongoClient,
            IClientSessionHandle clientSessionHandle,
            IOptions<ExamSettings> settings, 
            IMediator mediator, string collection) : base(mongoClient, clientSessionHandle, settings, mediator, collection)
        {

        }

        public async Task<Exams> GetExamByIdAsync(string id)
        {
            var filter = Builders<Exams>.Filter.Eq(x => x.Id, id);
            return await Collection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Exams>> GetExamListAsync()
        {
            return await Collection.AsQueryable().ToListAsync();
        }
    }
}
