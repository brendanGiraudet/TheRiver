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
        var watch = System.Diagnostics.Stopwatch.StartNew();
        var r1 = Console.ReadLine();
        var r1List = new List<int>();
        var val1 = Convert.ToInt32(r1);
        r1List.Add(val1);

        var r2 = Console.ReadLine();
        var r2List = new List<int>();
        var val2 = Convert.ToInt32(r2);
        r2List.Add(val2);

        while (!r1List.Exists( o => o.Equals(val2)) && !r2List.Exists(o => o.Equals(val1)))
        {
            val1 += r1.Select(x => Convert.ToInt32(x.ToString())).Sum();
            r1List.Add(val1);
            r1 = val1.ToString();

            val2 += r2.Select(x => Convert.ToInt32(x.ToString())).Sum();
            r2List.Add(val2);
            r2 = val2.ToString();
        }

        var rep = r1List.Intersect(r2List).FirstOrDefault();

        Console.WriteLine(rep);
        watch.Stop();
        Console.Error.WriteLine(watch.ElapsedMilliseconds);
    }
    static int SumOfDigit(int digits)
    {
        int sum = 0, b;
        while(digits != 0)
        {
            b = digits % 10;
            sum += b;
            digits /= 10;
        }
        return sum;
    }
}