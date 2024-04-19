// Faça um programa que leia um número inicial e um número final, mostrando entre eles quais são os valores pares e impares.
int init = 0, final = 0; 

Console.WriteLine("Amostragem de números pares e impares.");

Console.Write("Fale o valor inicial: ");
init = int.Parse(Console.ReadLine());

Console.Write("Fale o valor final: ");
final = int.Parse(Console.ReadLine());

for  (int i = init + 1; i < final; i++)
{
    if ((i % 2 ) == 0)
    {
        Console.WriteLine($"O númeor {i} é par.");
    }
    else 
    {
        Console.WriteLine($"O númeor {i} é impar.");
    }
}
