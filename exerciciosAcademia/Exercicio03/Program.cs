// 3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
// si os valores de duas variáveis A e B.

string primeiraVariavel = "Melancia";
string segundaVariavel = "Abacaxi";

Console.WriteLine("A primeira variável é: " + primeiraVariavel);
Console.WriteLine("A segunda variável é: " + segundaVariavel);

Console.WriteLine();

string auxiliar = primeiraVariavel;
primeiraVariavel = segundaVariavel;
segundaVariavel = auxiliar;

Console.WriteLine("A primeira variável é: " + primeiraVariavel);
Console.WriteLine("A segunda variável é: " + segundaVariavel);