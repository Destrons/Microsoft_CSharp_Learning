// See https://aka.ms/new-console-template for more information
int a = 2147483647;
int b = 2147483647;
long c = checked(a + b); //checked ira verificar se o número está ultrapassando o limite de armazenamento.
//int tem uma limitação de 32 bits ou 2 elevado a 32 oque limita número maximo que pode ser armazenado, já long são 64 bits.
Console.WriteLine(c);

