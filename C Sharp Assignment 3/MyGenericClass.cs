using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assignment_3
{
    public class MyGenericClass
    {
        public static void MyGenericMethod<T>(T tParameter)
        {
            Console.WriteLine("This is parameter={0},value={1}",tParameter.GetType().Name, tParameter.ToString());
        }
    }
}