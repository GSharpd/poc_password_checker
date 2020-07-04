using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {

      int minLength = 8;

      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ";

      string lowercase = "abcdefghijklmnopqrstuvwxyzç";

      string digits = "0123456789";

      string specialChars = "!@#$%¨&*()-_=+|~[]?";

      Console.WriteLine("Choose a password (must be at least 8 characters long, have lower and upper letters, have numerical digits and special symbols");

      string userPass = Console.ReadLine();

      int score = 0;

      int length = userPass.Length;

      if (length >= 8)
      {
        score++;
      }

      if (Tools.Contains(userPass, uppercase))
      {
        score++;
      }


      if (Tools.Contains(userPass, lowercase))
      {
        score++;
      }

      if (Tools.Contains(userPass, digits))
      {
        score++;
      }

      if (Tools.Contains(userPass, specialChars))
      {
        score++;
      }

      Console.WriteLine($"Password is {score} strong!");

      switch (score)
      {
        case 5:
        case 4:
        Console.WriteLine("Password is extremely strong!");
        break;
        case 3:
        Console.WriteLine("Password is strong!");
        break;
        case 2:
        Console.WriteLine("Password is medium strength");
        break;
        case 1:
        case 0:
        Console.WriteLine("Password too weak, create a stronger password!");
        break;
      }

   

    }
  }
}
