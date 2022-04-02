int número;

Console.Write("Digite um número: ");
número = Convert.ToInt32(Console.ReadLine());

if (número < 0)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;           
    Console.WriteLine("Negativo");
}

else if (número > 0)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Positivo");
}

else
{
    Console.ForegroundColor = ConsoleColor.White; 
    Console.WriteLine("zero");
}

Console.ResetColor(); 