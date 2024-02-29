string str1 = "Hola";
string str2 = "Mundo";

Console.WriteLine($"Concatenación de Strings");

//Operador +
string r1 = str1 + " " + str2;
Console.WriteLine($"Operador + -> {r1}");

//Método String.Concat()
string r2 = string.Concat(str1, " ", str2);
Console.WriteLine($"String.Concat() -> {r2}");

//Interpolación de cadenas
string r3 = $"{str1} {str2}";
Console.WriteLine($"Interpolación -> {r3}");

//Método String.Join()
string[] words = { $"{str1}", $"{str2}" };
string r4 = string.Join(" ", words);
Console.WriteLine($"String.Join() -> {r4}");