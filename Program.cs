// See https://aka.ms/new-console-template for more information

using RefAndOut;

Mathmatics mathmatics = new();
int Sum = 0; 
int Multiply = 0;
int result = mathmatics.Calculation(10, 20, out Sum, out Multiply);
Console.WriteLine(result);  //Sum
Console.WriteLine(Multiply);  //Multiply
Console.ReadLine();