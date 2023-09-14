// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

//Explicación
//string nombre = "";
//Console.WriteLine("Indique su nombre: ");
//nombre = Console.ReadLine();
//Console.WriteLine("Bienvendido " + nombre);
//Console.ReadKey();

//Proyecto integrador
//int radioCirculo;
//const double pi = 3.14159;

//Console.WriteLine("Ingrese el radio del circulo para calcular el area: ");
//string radioCirculoToString = Console.ReadLine();
//radioCirculo = int.Parse(radioCirculoToString);
//double areaCirculo = pi * (radioCirculo * radioCirculo);
//string mensajeAreaCirculo = "El area del círculo es ";
//Console.Write(mensajeAreaCirculo + areaCirculo);

//ACTIVIDAD 1
string nombre = "Magali";
string apellido = "Azimonti";
int DNI = 41196050;
int edad = 25;
double altura = 1.65;

//Console.WriteLine(nombre);
//Console.WriteLine(apellido);
//Console.WriteLine(DNI);
//Console.WriteLine(edad);
//Console.WriteLine(altura);


//ACTIVIDAD 2
//int num1 = 0;
//int num2 = 0;
//string mensajeNum1 = "Ingrese un numero: ";
//string mensajeNum2 = "Ingrese otro numero para sumar: ";

//Console.WriteLine(mensajeNum1);
//string num1ToString = Console.ReadLine();
//num1 = int.Parse(num1ToString);

//Console.WriteLine(mensajeNum2);
//string num2ToString = Console.ReadLine();
//num2 = int.Parse(num2ToString);

//string mensajeResultado = "El resultado de la suma de " + num1 + " + " + num2 + " es: ";

//int suma = num1 + num2;
//Console.WriteLine(mensajeResultado + suma);


//ACTIVIDAD 3

string solicitarAlias = "Escriba su alias: ";
Console.WriteLine(solicitarAlias);
string alias = Console.ReadLine();


string solicitarNombre = "Escriba su nombre: ";
Console.WriteLine(solicitarNombre);
nombre = Console.ReadLine();

string solicitarApellido = "Escriba su apellido: ";
Console.WriteLine(solicitarApellido);
apellido = Console.ReadLine();

string mensajeNombreYAlias = "Mi nombre completo es : " + nombre + " " + '"' + alias + '"' + " " + apellido;
Console.WriteLine(mensajeNombreYAlias);