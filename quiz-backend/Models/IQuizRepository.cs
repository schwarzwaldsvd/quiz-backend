using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quiz_backend.Models
{
    public interface IQuizRepository
    {
        IEnumerable<Quiz> GetMyQuizzesQuizzes(string ownerId);
        IEnumerable<Quiz> GetAllQuizzes { get; }
    }
}
