using System;

namespace DayOneProject_CriticalThinking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let's declare an integer called “Value1”. Let's give this variable the value of “7”.
            //        a.Let’s perform some arithmetic. Let’s divide our “Value1” variable by two.
            //        b.We should capture the result in another variable.
            //        i.What should the data type be of our “Result” variable?

            Console.WriteLine("Hello World!");
            int Value1 = 7;
            int x = 2;
            int y = Value1 / x;
            Console.WriteLine(y);//y is '3' when I print to the console.  I used 'int', and 'int' only calculates whole numbers. I need a different data type, as 7 divided by 2 is 2.5, not 3.
            

            /////second try
            Console.WriteLine("Second Try");
            double Value2 = 7;
            double x1 = 2;
            double y1 = Value2 / x1;
            Console.WriteLine(y1);//y1 is '2.5' when I print to the console.  I used 'double', and 'double' allows decimals.
            Console.ReadLine();

            //Next, let’s make some modifications to this logic.We are going need two variables, “Value1” and “Value2”. These values are going to be based off user input. We want the user to be able
            //to divide one number by another. We should be able to capture both values and use them to get a result.Once we have the result, we should print it to the console.
            //          i.When getting user input what should we always do? How does the user know what to do, what to enter?
            //          ii.When we capture user input, what data type does it come in? How can we use this to preform mathematical expressions?

            Console.WriteLine("Enter Value1 as a number");
            double x3= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x3);
            Console.ReadLine();



        }
    }
}
