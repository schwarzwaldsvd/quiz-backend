using System.Collections.Generic;

namespace quiz_backend.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string OwnerId { get; set; }
        public List<Question> Questions { get; set; }
    }
}
