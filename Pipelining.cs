using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorials
{
    public class Pipelining
    {

        // 1 - Static class to hold your methods, usually called 'Extensions'

        // 2 - Make sure all methods are static

        // 3 - 1st parameter of all methods is preceded by 'this'

        // 4 - Return type matches type of 1st parameter

        public void PipelineWork() {

            //Pipelining Demo
            int value = 5;

            int resultA = value.Squared();
            Console.WriteLine(resultA);
            
            int resultB = value.Cubed();
            Console.WriteLine(resultB);

            int resultC = value.Squared().Cubed();
            Console.WriteLine(resultC);

            int resultD = value.Squared().Squared();
            Console.WriteLine(resultC);

            int resultE = value.Cubed().Cubed();
            Console.WriteLine(resultD);

            int resultF = value.Squared().Cubed().Squared();
            Console.WriteLine(resultF);

            int resultG = value.Squared().Cubed().Cubed();
            Console.WriteLine(resultG);
        }
    }

    public static class Extensions
    {
        internal static int Squared(this int num)
        {
            return num * num;
        }
        internal static int Cubed(this int num)
        {
            return num * num * num;
        }      
    }
};
