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
                engine.Evaluate("x <- 1");
                engine.Evaluate("testinglongname <- 2");
                var result = engine.Evaluate("ls()").AsCharacter().ToList();
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
