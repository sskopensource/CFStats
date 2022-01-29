using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public class ProblemModel
    {
        public int wrongAttempts { get; set; }
        public int correctAttempts { get; set; }
    }

    public class ContestModel
    {
        public string ContestId { get; set; }
        public string ContestName { get; set; }
        public int ContestRank { get; set; }
        public int RatingChange { get; set; }

    }
}
