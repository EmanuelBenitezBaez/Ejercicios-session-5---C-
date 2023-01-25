
/*
 Ejercicio 1 - If

Escribe un programa que:
Pida datos a un cliente: Nombre, email, cupón
Determine si un cliente tiene un cupon descuento
Muestre un precio rebajado en función del descuento
Muestre el precio de un producto sin descuento si no hay cupón
Nota: puedes poner un precio fijo de un producto o uno variable.

*/

double descuento;
double total=0;
Console.WriteLine("Ingrese el monto:");
double monto = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese su nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese su e-mail:");
string email = Console.ReadLine();
Console.WriteLine("Tiene cupon de descuento?:");
Console.WriteLine("Presione 1 para si.");
Console.WriteLine("Presione 2 para no.");
int cupon = Convert.ToInt32(Console.ReadLine());

if(cupon==1)
{
    descuento = (monto*15)/100;
    total = monto - descuento;
    Console.WriteLine(" Nombre:"+nombre);
    Console.WriteLine(" E-mail:"+email);
    Console.WriteLine("Usted tiene un descuento del 15%, el total a pagar es:" + total); ;
   
}else
{
    Console.WriteLine("Usted no tiene cupon de descuento, el total a pagar es:" + monto);

}



/*
 Ejercicio 2 - Switch
Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++.
Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1,
2, 3 o a, b, c. Presenta el resultado en consola.
Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.*/


Console.WriteLine("A continuacion seleccione un lenguaje:");
Console.WriteLine("1 - C# :");
Console.WriteLine("2 - Java :");
Console.WriteLine("3 - C++ :");
Console.WriteLine("4 - JavaScript :");


 string opcionLenguaje =  Console.ReadLine();

switch (opcionLenguaje)
{
    case "1":
        Console.WriteLine("Haz seleccionado el lenguaje C#!!");
        break;
    case "2":
        Console.WriteLine("Haz seleccionado el lenguaje Java!!");
        break;

    case "3":
        Console.WriteLine("Haz seleccionado el lenguaje C++!!");
        break;

    case "4":
        Console.WriteLine("Haz seleccionado el lenguaje JavaScritp!!");
        break;
    default:
        Console.WriteLine("La seleccion es incorrecta.");
        break;




}

        Console.ReadKey();


