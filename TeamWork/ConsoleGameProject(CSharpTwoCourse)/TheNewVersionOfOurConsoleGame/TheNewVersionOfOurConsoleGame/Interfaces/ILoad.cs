using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNewVersionOfOurConsoleGame.Classes;

namespace TheNewVersionOfOurConsoleGame.Interfaces
{
    public interface ILoad
    {
        int[,] Load(string fileName);
    }
}
