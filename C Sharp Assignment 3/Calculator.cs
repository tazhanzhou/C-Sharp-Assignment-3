using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assignment_3
{
    delegate int CalDelegate(int n);
    delegate int CalDelegate1(int n, int m);
    public class Calculator

    {
        public static int CircleArea(int r)
        {
            return (int)(r *r*Math.PI);
        }
        public static int Circumference(int r)
        {
            return (int)(2* r * Math.PI);
        }
        public static int LongestEdge(int l1, int l2)
        {
            return (int)Math.Sqrt(l1*l1+l2*l2);
        }
    }
}
