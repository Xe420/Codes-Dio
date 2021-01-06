/*

Desafio

Você terá o desafio de ler um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. 
Entrada

O arquivo de entrada contém um valor inteiro.
Saída

Imprima a saída conforme exemplo fornecido.

*/


using System;

class challange5 {
  public static void Main (string[] args) {
    var ageInDays = int.Parse(Console.ReadLine());
    var years = 1 *(ageInDays / 365); // Implemente aqui o calculo dos anos
    var months = (ageInDays % 365) / 30; // Implemente aqui o calculo dos meses 
    var days =  ((ageInDays % 365)% 30)*1 ; // Implemente aqui o calculo dos dias

    Console.WriteLine($"{years} ano(s)\n{months} mes(es)\n{days} dia(s)");
  }
}