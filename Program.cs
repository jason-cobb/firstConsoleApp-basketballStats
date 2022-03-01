using System;

class Program
{
    static string Ask(string question)
    {
        Console.Write(question + " ");
        return Console.ReadLine();
    }

    static string AskTwo(string question)
    {
        Console.Write(question + " ");
        return Console.ReadLine();
    }


    static int FieldGoalPercentage(int shotsMade, int shotsTaken)
    {
        return shotsMade / shotsTaken * 100;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the sports statistics app!");
        string shotsTaken = Ask("How many shots have been taken?");
        //int number = int.Parse(entr);
        Console.WriteLine(shotsTaken);
        string shotsMade = AskTwo("How many shots have been made?");
        Console.WriteLine(shotsMade);
        Console.WriteLine($"The field goal percentage is {FieldGoalPercentage}%");
    }
    //Console.WriteLine(fieldGoalPercentage(shotsMade, shotsTaken));
    //Console.WriteLine(fieldGoalPercentage(8, 10));

    /*Static double freeThrowPercentage
    Static double threePointPercentage
    ?use
    public interface IShotPercentage
    {

    }*/

}