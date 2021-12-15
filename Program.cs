Console.WriteLine("Ecrivez des nombres pour les multiplier ensemble. Pour écrire un nombre, tapez le nombre en chiffres et appuyez sur entrée. Quand vous avez fini, tapez STOP et appuyez sur entrée");
List<int> numberList = new List<int>();
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
        numberList.Add(int.Parse(input));
    }
}
int result = numberList[0];
for (int i = 1; i < numberList.Count; i++)
{
    result *= numberList[i];
}
Console.Write("Le résultat de la multiplication des nombres suivants : ");
foreach (var item in numberList)
{
    Console.Write(item + ", ");
}
Console.WriteLine($"est {result}");