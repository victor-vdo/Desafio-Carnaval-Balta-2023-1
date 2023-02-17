// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um texto:");
var texto = Console.ReadLine().Trim();
var palavras = texto.Split(" ");

Console.WriteLine(texto.Length +" caracteres, " + palavras.Length + " palavras");