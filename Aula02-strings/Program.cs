// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Thomas!");

string primeiroAmigo = "Amanda";
// Trim e usado para corrigir|cortar espaçamento que está sendo aplicado nas strings.
primeiroAmigo = primeiroAmigo.Trim();
string segundoAmigo = "Luiz";

string friends = $"Meus Amigos são {primeiroAmigo} e {segundoAmigo.Trim()}";

Console.WriteLine(friends);

// esse trecho do codigo ira substituir o valor de uma string de acordo com o valor informado.
friends = friends.Replace("Luiz","Adler");

//Verifica se na string contem um valor informado.
Console.WriteLine(friends.Contains("Amanda"));

//Nesse codigo ToUpper coloca os caracteres em maiusculo enquanto ToLower coloca em minusculo.
Console.WriteLine(friends.ToUpper());

//Length conta a quantidade de caracteres contido na string, conta espaços também.
Console.WriteLine(friends.Length);

