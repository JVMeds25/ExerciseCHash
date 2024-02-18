using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCHash
{
    class EnvironmentSeeker
    {
        public static void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of Processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".Net Version: {0}", Environment.Version);
        }
    }
}
