using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrastructure.SeedWork
{
    /// <summary>
    /// chứa những cái load từ appsettings ra
    /// </summary>
    public class ExamSettings
    {
        public string IdentityUrl { get; set; }

        public DatabaseSettings DatabaseSettings { get; set; }
    }

    public class DatabaseSettings
    {
        public string ConnectionStrings { set; get; }
        public string DatabaseName { get; set; }

    }
}
