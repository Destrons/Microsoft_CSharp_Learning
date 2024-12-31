// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Thomas!");

string primeiroAmigo = "    Amanda";
// Trim e usado para corrigir|cortar espaçamento que está sendo aplicado nas strings.
primeiroAmigo = primeiroAmigo.Trim();
string segundoAmigo = "Luiz    ";

// o $ informa que na construção do codigo tera variaveis que terão seu valor apresentado.
Console.WriteLine($"Meus Amigos são {primeiroAmigo} e {segundoAmigo.Trim()}");

// Sem o $ com o uso de inserção pelo + as variaveis serão inseridas.
Console.WriteLine("Meus Amigos são " + primeiroAmigo + " e " + segundoAmigo );