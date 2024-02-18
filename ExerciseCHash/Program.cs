using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseCHash
{
    class Program
    {
        static int Main(string[] args) 
        {
            Console.WriteLine("hello world");
            Console.WriteLine("hello world");
            //MessageBox.Show("All Done");
            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine("Arg: {0}",args[i]);
                }

            }
            else
            {
                Console.WriteLine("No command lines");
            }

            //ShowEnvironmentDetails();
            int[] valuesV = { 2, 7, 11, 15 };
            int[] solvedV = TwoSum(valuesV, 9);

            foreach(int i in solvedV)
            {
                Console.Write("{0}", solvedV[i]);
            }
            Console.ReadLine();
            return 0;
        }

        public static void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                //console.writeline("drive: {0}", drive);
            }

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of Processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".Net Version: {0}", Environment.Version);
            Console.WriteLine(" some where : {0}", Environment.Is64BitProcess);
        }
        public static int[] TwoSum(int[] nums, int target)
        {

            LinkedList<int> answerVal = new LinkedList<int>();
            int answerCount = 0;
            int totalAnswer = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (target >= nums[i] && target > totalAnswer)
                {
                    
                    totalAnswer += nums[i];
                    if(totalAnswer <= target)
                    {
                        answerVal.AddLast(i);
                    }
                    answerCount++;
                }
            }
            return answerVal.ToArray();
        }
    }
}

