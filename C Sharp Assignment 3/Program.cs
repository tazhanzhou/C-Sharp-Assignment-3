using System;
using System.Collections;

namespace C_Sharp_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Create a class of Student(id, name)
            //Use
            //1- List
            //2- ArrayList
            //Fill them with 5 students.
            //Navigate through them and print the name of students in the Console
            Student.StudentList();
            Student.StudentArrayList();

            //2 - Create a Generic Class name it 'MyGenericClass'
            //define generic method that prints the value of the parameter in the console.
            //call it with String and int values
            int iValue = 123;
            string sValue = "456xyz";
            MyGenericClass.MyGenericMethod<int>(iValue);
            MyGenericClass.MyGenericMethod<string>(sValue);

            //3 - Create a hashtable and add 5 dictionaries of(key, value) optional
            //iterate through them and print them out in the console.
            Hashtable ht = new Hashtable();
            ht.Add("E", "e");
            ht.Add("A", "a");
            ht.Add("C", "c");
            ht.Add("B", "b");
            ht.Add("D", "d");
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine("Key : {0} ; Value : {1}.", de.Key, de.Value);
            }
            //4 - Create a Constraint Generic Class name it 'MyconstraintGenericClass'
            //that limits the caller to use only referenced type
            int vaulueType = 123;
            MyconstraintGenericClass.MyConstraintGenericMethod<int>(vaulueType);
            //String is reference type do not match with constraint
            string referenceType = "456xyz";
            //MyconstraintGenericClass.MyConstraintGenericMethod<string>(referenceType);

            //6 - Use Delegate in a class to calculate area, circumference, biggest side, ...
            CalDelegate circleAreaDL = new CalDelegate(Calculator.CircleArea);
            CalDelegate circumferenceDL = new CalDelegate(Calculator.Circumference);
            int r = 5;
            Console.WriteLine("Area of r={0} Circle : {1}", r, circleAreaDL(r));
            Console.WriteLine("Circumference of r={0} Circle : {1}", r, circumferenceDL(r));
            CalDelegate1 longestEdgeDL = new CalDelegate1(Calculator.LongestEdge);
            int l1 = 3;
            int l2 = 4;
            Console.WriteLine("Longest edge of right-angled triangle with L1={0} L2={1}: {2}", l1, l2,longestEdgeDL(l1,l2));
        }
    }
}
