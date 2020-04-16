using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assignment_3
{
    class MyconstraintGenericClass
    {
        public static void MyConstraintGenericMethod<T>(T tParameter) where T : struct
        {
            Console.WriteLine("This is parameter={0},value={1}", tParameter.GetType().Name, tParameter.ToString());
        }
    }
}
