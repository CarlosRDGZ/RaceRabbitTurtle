using System;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal bugs = new Wabbit();
            Animal franklin = new Turtle();

            while (bugs.Steps < 80 && franklin.Steps < 80)
            {
                bugs.MakeStep();
                franklin.MakeStep();
            }

            if (bugs.Steps >= 80 && franklin.Steps >= 80)
                Console.WriteLine("Empate");
            else if (bugs.Steps > franklin.Steps)
                Console.WriteLine("Liebre Gana!");
            else
                Console.WriteLine("Tortuga Gana!");

            Console.WriteLine("Liebre Pasos " + bugs.Steps);
            Console.WriteLine("Tortuga Pasos " + franklin.Steps);
        }
    }
}
