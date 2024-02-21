using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new();
        //Console.WriteLine("Hello Learning04 World!");
        string student = "James MacHine";
        string subject = "Math";
        new Assignment(student, subject);
        Console.WriteLine(assignment.GetSummary());
    }
}