// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задайте значение M и N");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int SummaElementov=0;
void Recurs (int M, int N)
{
  if (M<=N)
   {
    SummaElementov+=M;
   M++;
   Recurs (M,N);
   }
  return;
}
Recurs(M,N);
Console.Write(SummaElementov);