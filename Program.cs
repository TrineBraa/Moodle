using System;
using System.Runtime.ExceptionServices;

namespace myFirstProgram
{
    class Program
    {
        static void DataType(string[] args)
        {
            Console.Write("Hey!");
            Console.WriteLine("Hello!");


            Console.WriteLine("\tTrine");


            Console.ReadKey(); //Denne skjuler slutt teksten frem til du trykker en knapp.

            //Teknisk sett oppgave 1 i Moodle

            //Numbers
            int aNumberYouMake = 3;

            long aVeryLorgeNumber = 150000000000L;
            float moreAccurateNumber = 1.06F;

            decimal anEvenMoreAccurateNumber = 1.7M;
            double anotherNumber = 4.03; //No need for a letter as this is the default

            //Letters
            string aLineOfWords = "Hey, this is a string";
            char aLetter = 'B';

            //Boolean - true or false
            bool santUsant = true; //eler false

            //Arrays
            int[] numberArray = { 1, 2, 3, 4 };
            string[] textArray = { "hello", "I need fucking help", "This is very difficult!" };

            //Lists
            List<int> listWithNumbers = new List<int>(); //Creates a list with numbers.

        }
    }

    class Oppgaver
    {
        static void Main(string[] args)
        {
            int a = 5;
            decimal b = 3M;
            decimal sum = a + b; //decimal kan ikke converteres da den er så nøyaktig. int kan converteres da det bare er et tall.
            Console.WriteLine(sum);

            Console.WriteLine("");
            string variabelTilOrdning = "Oppgaver til Variabel Tilordning";
            Console.WriteLine(variabelTilOrdning);
            Console.WriteLine("");

            int OneNumber = 2;
            int NumberTwo = 8;

            int SummenAvDisseTo = OneNumber + NumberTwo;
            Console.WriteLine(SummenAvDisseTo);
            Console.WriteLine("");
            Console.WriteLine("Denne metoden returnerer ingenting!");
            Console.WriteLine("");

            Console.WriteLine("Oppgaver om If/Else");
            int NumberIf1 = 10;
            int NumberIf2 = 20;
            bool isEqual = false;

            //Oppgave 1:
            if (NumberIf1 == NumberIf2)
            {
                isEqual = true;
                Console.WriteLine("\tThe Numbers are Equal!");
            }
            else
            {
                isEqual = false;
                Console.WriteLine("\tThe Numbers are not Equal!");
            }
            Console.WriteLine("");


            //Oppgave 2:
            if (NumberIf1 == NumberIf2)
            {
                isEqual = true;
                Console.WriteLine(NumberIf1 + NumberIf2);
            }
            else
            {
                isEqual = false;
                Console.WriteLine(NumberIf1 * NumberIf2);
            }
            Console.WriteLine("");

            //Oppgave 3:
            if (NumberIf1 + NumberIf2 == 30)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.WriteLine("");

            Console.WriteLine("Random i C#");

            Random rand = new Random();
            var RandomNumber = rand.Next(0, 3);
            if (RandomNumber == 0)
            {
                Console.WriteLine("Tallet ble 0");
            }
            else if (RandomNumber == 1)
            {
                Console.WriteLine("Tallet ble 1");
            }
            else
            {
                Console.WriteLine("Tallet ble 2");
            }
            Console.WriteLine("");

            Console.WriteLine("Oppgave: Random Hobby Generator");


            while (true)
            {
                Console.WriteLine("Who would like a Hobby? if not then write 'x'");
                var Name = Console.ReadLine();
                if (Name == "x") break;
                Random NewHobby = new Random();
                var RandomHobby = NewHobby.Next(0, 6);
                if (RandomHobby == 0)
                {
                    Console.WriteLine($"You are now a Magical dancer {Name}");
                }
                else if (RandomHobby == 1)
                {
                    Console.WriteLine($"{Name}'s new hobby is marathon running!");
                }
                else if (RandomHobby == 2)
                {
                    Console.WriteLine($"{Name} has learned the dark arts! Be very afraid");
                }
                else if (RandomHobby == 3)
                {
                    Console.WriteLine($"You sure are a Pretty pretty Princess, {Name}");
                }
                else if (RandomHobby == 4)
                {
                    Console.WriteLine($"{Name} is a hardcore gamer!");
                }
                else
                {
                    Console.WriteLine($"{Name} har picked up triathalon running!");
                }

                ;
            }






            Console.ReadKey();
        }
    }
}













































