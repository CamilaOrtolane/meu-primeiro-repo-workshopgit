

Console.WriteLine("Olá, Mundo!");

Console.WriteLine("---------------------------------");
Console.WriteLine("[1] - Saudação.");
Console.WriteLine("---------------------------------");

Console.WriteLine("escolha uma opção: ");
int opc = int.Parse(Console.ReadLine());

if(opc == 1)
{
    Console.WriteLine("Qual é seu nome? ");
    string nome = Console.ReadLine();

    Console.WriteLine($"Olá {nome}!");
}
else
{
    Console.WriteLine("Tem nada aqui não");
}

