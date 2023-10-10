string[] colores = { "Magenta", "Rojo", "Blanco", "Azul", "Cyan" };
string[] eliminarColores = { "Rojo", "Blanco", "Azul" };
List<string> lista = new List<string>();
Console.WriteLine($"capacidad={lista.Capacity}");
foreach (string color in colores)
    lista.Add(color);
List<string> eliminarLista = new List<string>(eliminarColores);
MostrarInformacion(lista);
EliminarColores(lista, eliminarLista);
MostrarInformacion(lista);

void EliminarColores(List<string> lista, List<string> eliminarLista)
{
    foreach(var item in eliminarLista)
    {
        lista.Remove(item);
    }
}

void MostrarInformacion(List<string>lista)
{
    foreach(var item in lista)
    {
        Console.WriteLine($"{item} ");

    }
    Console.WriteLine($"\nTamaño={lista.Count}; "+$"Capacidad= {lista.Capacity}");
    int eliminarLista = lista.IndexOf("Azul");
    if (eliminarLista != -1)
    {

        Console.WriteLine($"la lista contoiene azul " + "en el indice {0}", eliminarLista);
    }
    else
    {
        Console.WriteLine($"La lista no contiene auzl");
    }
    
}
