using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RDotNet;

namespace RDotNetTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            REngine.SetEnvironmentVariables();
            using (var engine = REngine.GetInstance())
            {
                var result = engine.Evaluate("a = 10");
                PrintResult(result);
                result = engine.Evaluate("a");
                PrintResult(result);
            }
        }

        static void PrintResult(SymbolicExpression result)
        {
            var numericResult = result.AsNumeric();
            Console.WriteLine("Size of numeric vector: {0}", numericResult.Length);
            Console.WriteLine("First vector result as numeric: {0}", numericResult.FirstOrDefault());
            var characterResult = result.AsCharacter();
            Console.WriteLine("Size of result as character vector: {0}", characterResult.Length);
            Console.WriteLine("First vector result as character: {0}", characterResult.FirstOrDefault());
            Console.WriteLine("");
        }
    }
}
