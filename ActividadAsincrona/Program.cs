// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ActividadAsincrona.Entidades;
using ActividadAsincrona.Negocio;

Datos datos = new Datos();
ClsDatos dato = new ClsDatos();

Console.WriteLine("Escriba una palabra");
string palabra = Console.ReadLine();
Console.WriteLine("El numero de caracteres es: ");


datos.palabra = palabra;

int Resultado = dato.Conteoo(datos);
Console.WriteLine(Resultado);

