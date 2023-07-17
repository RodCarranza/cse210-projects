using System;

class Program
{
    static void Main(string[] args)
    {

        //Base class object
         Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
         Console.WriteLine(assignment.GetSummary());

        //Derived class objects
         MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
         Console.WriteLine(mathAssignment.GetSummary());
         Console.WriteLine(mathAssignment.GetHomeworkList());

         WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
         Console.WriteLine(writingAssignment.GetSummary());
         Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
