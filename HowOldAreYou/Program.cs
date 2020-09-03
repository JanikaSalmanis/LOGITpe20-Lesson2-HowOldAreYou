using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. App greets the user
             * 2. App asks the user´s name
             * 3. App greets the user by their name
             *  4. App asks the user`s year of birth
             *  5. App calvulates the age of the user 
             *  6. The app displays the result (the user´s name)
             */
            Console.WriteLine("What`s your name?");
            String Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello,Kristina");
            Console.WriteLine("What is your year of birth?");
            string UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth;
            //parsing spring to interger (number=
            YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;
            Console.WriteLine("You are" + Age + "old.");


           
            



        }
    }
}
