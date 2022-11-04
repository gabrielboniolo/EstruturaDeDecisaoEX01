using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Digite um número qualquer: ");
      int n1 = int.Parse(Console.ReadLine());
      if(n1>0) {
        Console.WriteLine("Número Positivo");
      }
      else if (n1<0) {
        Console.WriteLine("Número Negativo");
      }
    else {
      Console.WriteLine("Número zerado");
    }
    }
  }
