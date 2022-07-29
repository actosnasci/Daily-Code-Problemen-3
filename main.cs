using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
  int[] acoes = new int[] {2,8,5,6,10,3,9}; 
  int[] ordemCrescente = acoes.OrderBy(x => x).ToArray();
  int[] ordemDecrescente = acoes.OrderByDescending(x => x).ToArray();
  int MenorNumero = ordemCrescente.First();
  int MaiorNumero = ordemDecrescente.First();
  int MaiorLucroPossivel = MaiorNumero - MenorNumero;
  Console.WriteLine($"O Maior lucro possível é: {MaiorLucroPossivel}");

  }
}