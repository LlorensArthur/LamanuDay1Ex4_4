Console.WriteLine("Ecrivez des nombres pour les multiplier ensemble. Pour écrire un nombre, tapez le nombre en chiffres et appuyez sur entrée. Quand vous avez fini, tapez STOP et appuyez sur entrée");
List<int> numbers = new List<int>();
string input = "";
while(true)
{
    Console.WriteLine("Ecrivez un nombre.");
    input = Console.ReadLine();
    if (input == "STOP")
    {
        break;
    }
    else
    {
        numbers.Add(int.Parse(input));
    }
}
int result = numbers[0];
for (int i = 1; i < numbers.Count; i++)
{
    result *= numbers[i];
}
Console.Write("Le résultat de la multiplication des nombres suivants : ");
for (int i = 0; i < numbers.Count; i++)
{
    if (i == numbers.Count - 1)
    {
        Console.Write($"et {numbers[i]} ");
    }
    else
    {
        Console.Write($"{numbers[i]}, ");
    }
}
Console.WriteLine($"est {result}");