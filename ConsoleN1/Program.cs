// See https://aka.ms/new-console-template for more information
// Seleccionamos variables.

int valor1;
int valor2;

float resultado;

//Ingresar nuestro nombre y edad
Console.Write("Ingresa tu nombre: ");
string nombre = Convert.ToString(Console.ReadLine());

Console.Write("Ingresa tu edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

//Saludar por el nombre y decir si es mayor o menor de edad (max 18 años).
if (edad >= 18)
{
    Console.WriteLine("Hola " + nombre + ". Bienvenido a este nuevo programa, te doy felicidades por ser mayor de edad.");
}
else if (edad <= 17)
{
    Console.WriteLine("Hola " + nombre + ". Bienvenido a este nuevo programa, eres menor de edad y tus años de vida son: " + edad);
}


//Se le declara al usuario que ingrese una opcion para continuar, si lo desea se continua con lo acordado, en caso que no , se finaliza el programa.
Console.WriteLine();
Console.WriteLine("Comenzemos con unas cuentas sencillas, ingresaras dos valores, luego elegiras si deseas sumarlos, restarlos ,dividirlos y multiplicarlos.");
Console.WriteLine();
Console.WriteLine("Ingresa 1 para continuar o 2 para rechazar: ");
int acepDen = Convert.ToInt32(Console.ReadLine());
if (acepDen == 1)
{
    //Cuentas

    Console.WriteLine("¡Genial Comenzamos!");
    //Pedimos ingresar valores
    Console.WriteLine("Ya que seleccionaste el 1 comenzemos con las cuentas :)");
    Console.WriteLine();
    Console.Write("Ingresa tu primer valor: ");
    valor1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingresa tu segundo valor: ");
    valor2 = Convert.ToInt32(Console.ReadLine());


    //Pedimos ingresar un numero para escoger entre sumar, restar, multiplicar y dividir

    Console.WriteLine("Ingrese un numero");
    Console.WriteLine("1- SUMA");
    Console.WriteLine("2- RESTA");
    Console.WriteLine("3- MULTIPLICAR");
    Console.WriteLine("4- DIVIDIR");
    int opcion = Convert.ToInt32(Console.ReadLine());

    if (opcion == 1) //Suma
    {
        Console.WriteLine("Genial , seleccionaste SUMA , tus valores mecionados anteriormente se sumaran y te mostraremos el resultado:");

        resultado = valor1 + valor2;
        Console.WriteLine("Tu primer valor: " + valor1);
        Console.WriteLine("Tu segundo valor: " + valor2);
        Console.WriteLine("Tu resultado es: " + resultado);

    }
    if (opcion == 2) //Resta
    {
        Console.WriteLine("Genial , seleccionaste RESTA , tus valores mencionados anteriormente se restaran y te mostraremos el resultado:");

        resultado = valor1 - valor2;
        Console.WriteLine("Tu primer valor: " + valor1);
        Console.WriteLine("Tu segundo valor: " + valor2);
        Console.WriteLine("Tu resultado es: " + resultado);

    }
    if (opcion == 3) //Multiplicacion
    {
        Console.WriteLine("Genial , seleccionaste MULTIPLICACION , tus valores mencionados anteriormente se multiplicaran y te mostraremos el resultado:");

        resultado = valor1 * valor2;
        Console.WriteLine("Tu primer valor: " + valor1);
        Console.WriteLine("Tu segundo valor: " + valor2);
        Console.WriteLine("Tu resultado es: " + resultado);

    }
    if (opcion == 4) //Division
    {
        Console.WriteLine("Genial , seleccionaste DIVISION , tus valores mencionados anteriormente se dividiran y te mostraremos el resultado:");
        Console.WriteLine();
        Console.WriteLine("Solo ten en cuenta una cosa, y es que no puedes seleccionar un divisor con igual a 0 ");

        //Ingresa nuevos valores
        Console.WriteLine("Procura reingresar nuevos valores y que el segundo valor no sea 0");
        Console.WriteLine();
        Console.Write("Ingresa tu primer valor: ");
        int valor3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa tu segundo valor: ");
        int valor4 = Convert.ToInt32(Console.ReadLine());

        if (valor4 != 0)
        {
            double respuesta = valor3 / valor4;
            Console.WriteLine("Tu primer valor: " + valor3);
            Console.WriteLine("Tu segundo valor: " + valor4);
            Console.WriteLine("Tu resultado es: " + respuesta);
        }
        if (valor4 == 0)
        {
            Console.WriteLine();
            Console.WriteLine("VALOR MAL INGRESADO");
            Console.WriteLine("Procura reingresar nuevos valores y que el segundo valor no sea 0");
            Console.WriteLine();
            Console.Write("Ingresa tu primer valor: ");
            int valor5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa tu segundo valor: ");
            int valor6 = Convert.ToInt32(Console.ReadLine());
        }






    }

