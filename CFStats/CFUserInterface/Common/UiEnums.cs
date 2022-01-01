using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
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
        CONTEST,
        PROBLEM_ONE,
        PROBLEM_TWO,
        EXPANDER
    };

    public enum ApiStatus
    {
        NOINTERNET,
        FAILED,
        OK
    };

    public enum Dialog
    {
        NOINTERNET,
        WRONGHANDLE
 
    };
    public enum ContestDataSelector
    {
        BESTRANK,
        WORSTRANK,
        MAXUP,
        MAXDOWN
    };
}
