int num, tab = 1;
Console.WriteLine("Tabuada");
Console.WriteLine("digite um numero para saber sua tabuada:");
num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A tabuada do {num} é:");
while (tab < 11)
{
    Console.WriteLine($"{num} X {tab} = {num * tab}");
    tab++;
}