using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLab
{
    static void Main(string[] args)
    {
        double i = -7.2;
        int j = 7;
        double num = Math.Log(Math.Exp(i) * Math.Exp(j));

        Console.WriteLine(num);
        
        Console.Read();
    }

}
