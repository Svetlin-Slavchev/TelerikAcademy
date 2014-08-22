using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNewVersionOfOurConsoleGame.Interfaces
{
    public interface IPrintable
    {
        void Print(TimeSpan RemainingTime, int coordinateX, int coordinateY);
    }
}
