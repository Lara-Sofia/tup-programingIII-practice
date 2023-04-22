//1) Crear 3 variables numéricas con el valor que quieras
//y en otra variable numérica guardar el valor de la suma de las 3 anteriores.
//Mostrar por consola.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Security.Cryptography;

string line = "--------------";
Console.WriteLine(line);

int x = 5, y = 6, z = 50;
int sum = x + y + z;
Console.WriteLine(sum);
Console.WriteLine(line);

//2) Pedir por consola un nombre de persona
//y el nombre de una ciudad (no hace falta que sean reales o comprobarlos)
//y mostrar por consola el siguiente mensaje “Hola ” <nombre> ” bienvenido a ” <ciudad>”.
//Utilizar Interpolación.


Console.WriteLine("Inset your name, please: ");
string name = Console.ReadLine();
Console.WriteLine("Inset your city, please: ");
string city = Console.ReadLine();
Console.WriteLine($"Hello {name} welcome to {city}");
Console.WriteLine(line);

//3) Pedir por consola tu nombre
//y tu edad y
//mostrar el siguiente mensaje: “Te llamas ” <nombre> ” y tienes ” <años> ” años”

Console.WriteLine("Inset your age, plaese: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your name is {name} and you are {age} years old");
Console.WriteLine(line);

//4) Pedir dos números al usuario por teclado y decir qué número es el mayor.
Console.WriteLine("Enter two numbers: ");
double n = Convert.ToDouble(Console.ReadLine());
double v  = Convert.ToDouble(Console.ReadLine());  
if (n < v)
{
    Console.WriteLine($"{v} is more than {n}");
}
else
{
    Console.WriteLine($"{n} is more than {v}");
}
Console.WriteLine(line);

//5) Pedir el nombre del día al usuario
//y decirle si es fin de semana o no.
//En caso de error, indicarlo. Se debe poder ingresar, por ejemplo, “Lunes” / “LUNES” / “lunes” / “lUnes” /
//“  lunes” y debería funcionar.
//TIP para investigar: Trim() y StringComparison.OrdinalIgnoreCase

Console.WriteLine("Enter the name of the day: ");
string namew = Console.ReadLine();
namew.Trim();
namew.Equals(StringComparison.OrdinalIgnoreCase);
if (namew == "sabado" || namew ==  "domingo")
{
    Console.WriteLine("it's weekend");
}
else
{
    Console.WriteLine("WEEk");
}
Console.WriteLine(line);


//6) Pedir al usuario el precio de un producto (valor positivo)
//y la forma de pagar (efectivo o tarjeta)
//si la forma de pago es mediante tarjeta,
//pedir el número de la misma(inventado), verificar que sean 16 dígitos
//e informar el valor a pagar con un 10% de recargo.

Console.WriteLine("Enter the price of the product: ");
int price = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Choise the form of page: 0-tarjet, 1-cash");
int choise = Convert.ToInt32(Console.ReadLine());
if (choise == 0)
{
    Console.WriteLine("Enter your bank number: ");
    string numberb = Console.ReadLine();
    if (numberb.Length >= 16)
    {
        Console.WriteLine("The price have a 10% more");
    }
    else { Console.WriteLine("Have a nice day!"); }
    Console.WriteLine(line);
}
else { Console.WriteLine("In cash$$"); }
Console.WriteLine(line);

//7) Recorrer los números del 1 al 100. Usar un bucle for.
//10) Recorrer los números del 1 al 100.
//Crear 2 listas, una con los números pares y otra con los divisibles entre 3.
//Mostrar las 2 listas.
Console.WriteLine("SHOWME ALL NUMBER SINCE 0 ULTILL 100 in two list");
List<int> listP = new List<int>();
List<int> listT = new List<int>();
for (int i = 0; i <= 100; i++)
{
    if (i%2 == 0)
    {
        listP.Add(i);
    }
    else if (i%3 == 0) { listT.Add(i); }
}
Console.WriteLine($"P: {string.Join(System.Environment.NewLine, listP)} & I: {string.Join(System.Environment.NewLine, listT)}");
Console.WriteLine(line);

//8) Recorrer los números del 1 al 100. Usar un bucle while.
//9) Recorrer los números del 1 al 100. Mostrar los números pares. Usar el tipo de bucle que quieras.
Console.WriteLine("SHOW THE NUMBER % 2");
int g = 0;
while (g <= 100)
{
    if (g % 2 == 0)
    {
        Console.WriteLine(g);
    }
    g++;
}
Console.WriteLine(line);




