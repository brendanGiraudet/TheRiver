using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        var r1 = Console.ReadLine();
        var r1List = new List<int>();        
        var tmp1 = Convert.ToInt32(r1);
        r1List.Add(tmp1);

        var r2 = Console.ReadLine();
        var r2List = new List<int>();
        var tmp2 = Convert.ToInt32(r2);
        r2List.Add(tmp2);

        while (!r1List.Any(o => o.Equals(tmp2)) && !r2List.Any(o => o.Equals(tmp1)))
        {
            tmp1 += r1.Select(x => Convert.ToInt32(x.ToString())).Sum();
            r1List.Add(tmp1);
            r1 = tmp1.ToString();

            tmp2 += r2.Select(x => Convert.ToInt32(x.ToString())).Sum();
            r2List.Add(tmp2);
            r2 = tmp2.ToString();
        }

        var rep = r1List.Intersect(r2List).FirstOrDefault();

        Console.WriteLine(rep);
    }
}