// See https://aka.ms/new-console-template for more information

using RefAndOut;

int Sum = 0; 
int Multiply = 0;
int result = new Mathmatics().Calculation(10, 20, out Sum, ref Multiply);
Console.WriteLine(result);  //Sum
Console.WriteLine(Multiply);  //Multiply
Console.ReadLine();