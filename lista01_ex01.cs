lista01_ex01
using System;
//Faça o algoritmo  para calcular a área (AREA) de uma sala, sendo que os comprimentos das paredes (L e C) são fornecidos pelo usuário. Apresente a área depois de calculada. 
class Program {
  public static void Main (string[] args) {
    double l , c , area;
    Console.Write ("digite a largura: ");
    l = double.Parse(Console.ReadLine());
    Console.Write ("digite o comprimento: ");
    c = double.Parse(Console.ReadLine());
    area= l * c ;
    Console.WriteLine ("A área é: {0}",area);
   
    
  }
}