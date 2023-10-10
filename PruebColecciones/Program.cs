//Crear una coleccion generica de 5 frutas
//mostrar la informacion de la coleccion
//coleccion(elementos,tamaño)
//buscar en la coleccion la fruta naranja e imprimir
//insertar un indice una nueva fruta e imprimir
//remover ls fruts insertada
//remover la fruta con el indice 0
//imprimir
using System.Collections.ObjectModel;

Collection<string> frutas = new Collection<string>();
frutas.Add("Manzana");
frutas.Add("Melon");
frutas.Add("Wanabana");
frutas.Add("Naranja");
frutas.Add("Sandia");
Display(frutas);
Console.WriteLine(" {0} frutas:", frutas.Count);
    
Console.WriteLine("\nContains(\"Naranja\"): {0}",
           frutas.Contains("Naranja"));
frutas.Insert(3, "Kiwi");
Display(frutas);
frutas.Remove("Kiwi");
Display(frutas);
frutas.RemoveAt(0);
Display(frutas);
 void Display(Collection<string> frutas)
{
    Console.WriteLine();
    foreach (var fruta in frutas)
    {
        Console.WriteLine(fruta);
        
    }
    Console.WriteLine("-----------------------");
}
