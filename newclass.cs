using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class newclass
    {
        
            public static void Main(string[] args)
            {

            
            // I NEED DUPLICATE PROGRAM
             string input = "swamiiii";
             string result = new string(input.ToCharArray().Distinct().ToArray());
             Console.WriteLine(result);

        }
            
    }
}
