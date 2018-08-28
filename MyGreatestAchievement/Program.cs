using System;
using System.Threading.Tasks;

namespace MyGreatestAchievement
{
    class Program
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                Console.Beep(1047, 300);
                Console.Beep(1047, 300);
                Console.Beep(932, 300);
                Console.Beep(1047, 300);
                await Task.Delay(300);
                Console.Beep(784, 400);
                Console.Beep(784, 400);
                Console.Beep(1047, 300);
                Console.Beep(1397, 300);
                Console.Beep(1319, 300);
                Console.Beep(1047, 300);
                await Task.Delay(800);
                Console.Beep(784, 300);
                Console.Beep(784, 300);
                Console.Beep(698, 300);
                Console.Beep(784, 300);
                await Task.Delay(300);
                Console.Beep(587, 400);
                Console.Beep(587, 400);
                Console.Beep(784, 300);
                Console.Beep(1047, 300);
                Console.Beep(988, 300);
                Console.Beep(784, 300);
                await Task.Delay(800);
            }
        }
    }
}