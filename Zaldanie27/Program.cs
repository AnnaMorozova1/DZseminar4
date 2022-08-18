// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

  
System.Console.WriteLine("Введите число: ");
string number = Convert.ToString(Console.ReadLine());
int sum = 0;
for (int i = 0; i < number.Length; i++)
{
    sum= sum+ int.Parse(Convert.ToString(number[i])); 
}
System.Console.WriteLine(sum);
