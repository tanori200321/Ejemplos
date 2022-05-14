//string nombre = "";
//Console.WriteLine(nombre.Length);

//if (string.IsNullOrWhiteSpace (nombre))
//{
//   Console.WriteLine("String vacio");
//}
//else
//{
//Console.WriteLine(nombre);
//}

//int numero = 9;
//string numeroConCeros = "9";
//numeroConCeros = numeroConCeros.PadLeft(3, '0');
//Console.WriteLine(numeroConCeros);

//string nombre = "Sebastian";
//string apellido = "Tanori";
//int edad = 18;

//string NombreyEdad = nombre + "|" + apellido + "|" + edad;
//Console.WriteLine(NombreyEdad);

//string NombreyEdad = string.Format("{0} | {1} | {2}", nombre, apellido, edad);
//Console.WriteLine(NombreyEdad);

// El mejor metodo
//string NombreyEdad = $"{nombre} | {apellido} | {edad}";
//Console.WriteLine(NombreyEdad);

//string numeroString = "5 P";
//int numeroInt = Convert.ToInt32(numeroString);

//int numeroInt = int.Parse(numeroString);
//Console.WriteLine(numeroInt);


//string numeroString = "5";
//int numeroInt = 0;
//bool pudo = int.TryParse(numeroString, out numeroInt);
//Console.WriteLine(numeroInt);

using System.Collections.Generic;

string cadena = "Hola|Mundo|Sebastian";
List<string>text = cadena.Split('|',' ').ToList();
foreach (string s in text)
{
    Console.WriteLine(s);
}
//Console.WriteLine(cadena.IndexOf(""));