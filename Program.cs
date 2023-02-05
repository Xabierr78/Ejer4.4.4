using System;

Console.WriteLine("cuantos alumnos quieres calificar ?");

int x = int.Parse(Console.ReadLine());



String Resultado = ""; 

for (int i=0;i<x; i++)
{
    Console.WriteLine("como se llama el alumno numero:? " + (i+1));
    string nombre = Console.ReadLine();


    Console.WriteLine("Cual ha sido la nota 1 del alumno:" + nombre);
    double nota1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Cual ha sido la nota 2 del alumno: " + nombre);
    double nota2 = double.Parse(Console.ReadLine());

    double media = (nota1 + nota2) / 2;

    Resultado += "NOMBRE: " + nombre + "\nNOTA 1: " + nota1 + "\nNOTA 2:" + nota2 + "\nPROMEDIO: " + media + "\n"; 
}


Console.WriteLine(Resultado);
