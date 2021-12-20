using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public enum SetSelector
    {
        PROBLEMSET,
        CONTESTSET,
        BLOGSET,
        SOLVEDPROBLEMSET,
        TAGSET,
        PROBLEMSTRIED
    }

    public enum DataSelector
    {
        SOLVEDINONEATTEMPT,
        AVERAGEATTEMPT,
        UNSOLVED,
        FAVOURITETAG
    }

    public enum NAVTAB
    {
        OVERVIEW,
        PROBLEM,
        CONTEST
    };
}
