string str1 = "Hola Mundo!";
string str2 = "Hola estoy aprendiendo c#";
string str3 = "Hola,Usuario,X";

Console.WriteLine($"Métodos de Strings");

//ToUpper()
string upperCaseStr = str1.ToUpper();
Console.WriteLine($"ToUpper() -> {upperCaseStr}");

//ToLower()
string lowerCaseStr = str1.ToLower();
Console.WriteLine($"ToLower() -> {lowerCaseStr}");

//IndexOf()
int index = str2.IndexOf("aprendiendo");
Console.WriteLine($"IndexOf() -> {index}");

//LastIndexOf()
int lastIndex = str2.LastIndexOf("estoy");
Console.WriteLine($"LastIndexOf() -> {lastIndex}");

//Substring()
string subStr = str1.Substring(6);
Console.WriteLine($"Substring() -> {subStr}");

//Replace()
string newStr = str1.Replace("Mundo", "A Todos");
Console.WriteLine($"Replace() -> {newStr}");

//Trim()
string trimmedStr = str1.Trim();
Console.WriteLine($"Trim() -> {trimmedStr}");

//StartsWith()
bool startsWithHello = str1.StartsWith("Hola");
Console.WriteLine($"StartsWith() -> {startsWithHello}");

//EndsWith()
bool endsWithWorld = str1.EndsWith("Mundo!");
Console.WriteLine($"EndsWith() -> {endsWithWorld}");

//Split(), 
string[] parts = str3.Split(',');
Console.WriteLine($"Split() -> {parts}");
for (int i = 0; i < parts.Length; i++)
{
    Console.WriteLine($@"       parts[{i}] -> {parts[i]}");
}

//Contains()
bool containsHola = str1.Contains("Hola");
Console.WriteLine($"Contains() -> {containsHola}");

//Equals()
bool areEqual = str1.Equals(str2);
Console.WriteLine($"Equals() -> {areEqual}");