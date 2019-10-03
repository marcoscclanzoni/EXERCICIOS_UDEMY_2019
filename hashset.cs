using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
        HashSet<int> A = new HashSet<int>();
        HashSet<int> B = new HashSet<int>();
        A.Add(3);
        A.Add(5);
        A.Add(8);
        A.Add(9);
        B.Add(3);
        B.Add(5);
        B.Add(9);
        foreach (int x in A)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine("Digite um numero inteiro ....");
        int N = int.Parse(Console.ReadLine());
        if (B.Contains(N))
        {
            Console.WriteLine(N + "Pertence ao conjunto b");
        }
        else { 
            Console.WriteLine(N + " Não pertence ao conjunto b");
        }
        Console.ReadLine();
        }
    }

