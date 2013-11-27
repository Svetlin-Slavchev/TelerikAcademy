using System;

namespace  Attributes
{
    [Version("1.0")] // Attribute 
    public class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Program);
            object[] attributes = myType.GetCustomAttributes(false);
            foreach (VersionAttribute versionattribute in attributes)
            {
                Console.WriteLine("This class is version {0}.", versionattribute.Version);
            }
        }
    }
}
