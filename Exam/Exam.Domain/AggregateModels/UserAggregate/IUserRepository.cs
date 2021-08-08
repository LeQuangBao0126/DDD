using Exam.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.AggregateModels.UserAggregate
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<User> GetUserByIdAsync(string externalId);
    }
}
