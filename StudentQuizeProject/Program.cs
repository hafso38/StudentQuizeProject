// See https://aka.ms/new-console-template for more information

using System;

class StudentQuizSystem
{
    static void Main()
    {
        Console.Write("Gali magaca: ");
        string name = Console.ReadLine();

        Console.Write("Gali ID: ");
        string id = Console.ReadLine();

        Console.WriteLine("\nDooro nooca xisaabta:");
        Console.WriteLine("1) Kudar");
        Console.WriteLine("2) Kajar");
        Console.WriteLine("3) Kudhufo");
        Console.WriteLine("4) Qayb");

        Console.Write("Gali doorashada (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        int correct = 0;

        Random rnd = new Random();

        for (int i = 1; i <= 10; i++)
        {
            int a = rnd.Next(10, 50);
            int b = rnd.Next(1, 20); // b = 1-20 si aan division by 0 uga fogaanno

            int answer = 0;
            string question = "";

            switch (choice)
            {
                case 1: // Kudar
                    question = $"{a} + {b}";
                    answer = a + b;
                    break;
                case 2: // Kajar
                    question = $"{a} - {b}";
                    answer = a - b;
                    break;
                case 3: // Kudhufo
                    question = $"{a} * {b}";
                    answer = a * b;
                    break;
                case 4: // Qayb
                    while (b == 0) b = rnd.Next(1, 20); // ka fakar 0
                    question = $"{a} / {b}";
                    answer = a / b; // natiijada int
                    break;
                default:
                    Console.WriteLine("Doorasho khaldan!");
                    return;
            }

            Console.Write($"Q{i}: {question} = ");
            bool valid = int.TryParse(Console.ReadLine(), out int userAnswer);

            if (!valid)
            {
                Console.WriteLine("Fadlan geli tiro sax ah!");
                i--; // dib ugu noqo su'aasha
                continue;
            }

            if (userAnswer == answer)
            {
                Console.WriteLine("Sax ✅");
                correct++;
            }
            else
            {
                Console.WriteLine($"Khalad ❌ - Jawaabta saxda: {answer}");
            }
        }

        Console.WriteLine($"\n{name} (ID: {id}), waxaad saxday {correct} / 10.");
    }
}

