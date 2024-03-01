string str1 = "Hola, Mundo!";
string str2 = "Hola, Mundo!";

//Comprueba si las dos cadenas hacen referencia al mismo objeto en la memoria
Console.WriteLine(object.ReferenceEquals(str1, str2)); // True

Console.WriteLine($"0x{str1.GetHashCode():X8}"); // 0xE428391E
Console.WriteLine($"0x{str2.GetHashCode():X8}"); // 0xE428391E

// Modifica una de las cadenas
str1 = str1.ToUpper();

// Ahora, las cadenas ya no son iguales a las referencias porque str1 es una cadena nueva
Console.WriteLine(object.ReferenceEquals(str1, str2)); // False

Console.WriteLine($"0x{str1.GetHashCode():X8}"); // 0x77D3AFA7
Console.WriteLine($"0x{str2.GetHashCode():X8}"); // 0xE428391E