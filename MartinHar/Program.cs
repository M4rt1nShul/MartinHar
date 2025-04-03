using System.Text.RegularExpressions;
using System.Text;

namespace MartinHar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. SumLINQ");
            Console.WriteLine("2. CountLINQ");
            Console.WriteLine("3. Faili meetod");
            Console.WriteLine("4. kolmnurk");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SumLINQ();
                    break;
                case "2":
                    CountLINQ();
                break;
                case "3":
                    FailiMeetod();
                    break;
                case "4":
                    kolmnurk();
                    break;

            }
        }
        public static void SumLINQ()
        {
            var sumAge = PeopleList.people
                .Sum(x => x.Age);

            Console.WriteLine(sumAge);

            Console.WriteLine("Täisealiste isikute koondarv");

            var sumAdults = PeopleList.people.Sum(x =>
            {
                if (x.Age >= 18)
                {
                    return x.Age;
                }
                else
                {
                    return 0;
                }
            });

            Console.WriteLine("Täiskasvanute isikute arv on " + sumAdults);
        }
        public static void CountLINQ()
        {
            var totalPersons = PeopleList.people.Count();

            Console.WriteLine(totalPersons);

            var adultPerson = PeopleList.people.Count(x => x.Age >= 18);

            Console.WriteLine("Täisealisi inimesi on: " + adultPerson);
        }
        public static void FailiMeetod()
        {
            Console.WriteLine("Kirjuta faili läbi konsooli");

            string filePath = @"C:\Users\opilane\rtrt/martin.txt";
            string inputText = Console.ReadLine();

            File.WriteAllText(filePath, inputText);
        }
        public static void kolmnurk()
        {
            Console.Write("\n\n");
            Console.WriteLine("Sisesta kolmnurki suurus");
            int i, j, n;

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}