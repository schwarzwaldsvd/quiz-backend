using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quiz_backend.Models
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetQuestions(int quizId);
    }
}
