using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace quiz_backend.Models
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly AppDbContext _appDbContext;

        public QuestionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Question> GetQuestions(int quizId)
        {
            return _appDbContext.Questions.Include(q => q.QuizId == quizId);
        }
    }
}
