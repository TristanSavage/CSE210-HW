using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Assignment assign0 = new Assignment("Tristan Savage Maughan","Quantum Mechanics");
        Console.WriteLine(assign0.GetSummary());

        MathAssignment assign1 = new MathAssignment("Tristan Maughan", "Calculus", "2.3", "5-10");
        Console.WriteLine(assign1.GetSummary());
        Console.WriteLine(assign1.GetHomeworkList());

        WritingAssignment assign2 = new WritingAssignment("Tristan Savage", "Philosophy of Science", "Origins of the Scientific Method");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetWritingInformation());

    }
}