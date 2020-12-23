using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace quiz_backend.Models
{
    public class QuizRepository : IQuizRepository
    {
        private readonly AppDbContext _appDbContext;

        public QuizRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        
        public IEnumerable<Quiz> GetMyQuizzesQuizzes(string ownerId)
        {
            return _appDbContext.Quizzes.Include(q => q.OwnerId == ownerId);
        }

        public IEnumerable<Quiz> GetAllQuizzes => _appDbContext.Quizzes;
    }
}
