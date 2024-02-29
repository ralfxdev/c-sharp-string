string str1 = "Hola Mundo!";
string? str2 = null;
string str3 = "";
string str4 = "   ";

Console.WriteLine($"Propiedades de Strings");

//Length
int length = str1.Length;
Console.WriteLine($"Length -> {length}");

//Chars
char[] chars = str1.ToCharArray();
Console.WriteLine($"Chars() -> {chars}");
for (int i = 0; i < chars.Length; i++)
{
    Console.WriteLine($@"       parts[{i}] -> {chars[i]}");
}

//IsNullOrEmpty
bool isNullOrEmpty = string.IsNullOrEmpty(str2);
Console.WriteLine($"IsNullOrEmpty(str2) -> {isNullOrEmpty}");

//IsNullOrWhiteSpace
bool isNullOrWhiteSpace1 = string.IsNullOrWhiteSpace(str3);
bool isNullOrWhiteSpace2 = string.IsNullOrWhiteSpace(str4);
Console.WriteLine($"IsNullOrWhiteSpace(str3) -> {isNullOrWhiteSpace1}");
Console.WriteLine($"IsNullOrWhiteSpace(str4) -> {isNullOrWhiteSpace2}");

//Empty
string emptyStr = string.Empty;
Console.WriteLine($"Empty -> {emptyStr}");