using System;

class TwoDigits
{
  static void Main()
  {
    Console.WriteLine("Enter a number: ");
    int inputNumber = int.Parse(Console.ReadLine());
    if (inputNumber > 9 && inputNumber < 100)
    {
        Console.WriteLine("Your number has two digits.");
    } else
    {
        Console.WriteLine("Your number does not have two digits.");
    }
  }
}