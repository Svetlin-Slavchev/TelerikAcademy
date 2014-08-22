using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//task 4
//Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.

namespace _1.StructPoint3D
{
    public static class PathStorage
    {
        public static void Save()
        {
            using (StreamWriter writer = new StreamWriter("../../Path storage.txt"))
            {
                string points = Path.ShowPoints();
                writer.WriteLine(points);
            }
        }

        public static string Read()
        {
            string text = "";
            using (StreamReader reader = new StreamReader("../../Path storage.txt"))
            {
                text = reader.ReadToEnd();
            }

            return text;
        }
    }
}
