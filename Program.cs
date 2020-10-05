using System;

namespace C__atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 11;
            for (int i = 0 ; i < n ; i++){
                int x = 8 * i;
                System.Console.WriteLine($"8x{i} = {x}");
            }
        }
    }
}