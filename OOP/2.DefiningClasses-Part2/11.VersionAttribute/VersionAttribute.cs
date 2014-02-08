using System;

// Task 11
// Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods
// and holds a version in the format major.minor (e.g. 2.11).
// Apply the version attribute to a sample class and display its version at runtime.

namespace _11.VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface
    | AttributeTargets.Enum | AttributeTargets.Method,
    AllowMultiple = true)]
    public class VersionAttribute : System.Attribute
    {
        public string Version { get; set; }

        public VersionAttribute(string version)
        {
            this.Version = version;
        }
    }
}
