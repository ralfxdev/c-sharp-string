//Comparación de cadenas
Console.WriteLine("Comparación de cadenas");

string str1 = "Hola";
string str2 = "Hola";
bool areEqual = (str1 == str2);
Console.WriteLine($"Operador == -> {areEqual}");

string str3 = "Mundo";
bool areEqual2 = str2.Equals(str3);
Console.WriteLine($"Equals() -> {areEqual2}");

//Concatenación de cadenas
Console.WriteLine("Concatenación de cadenas");

string combinedStr = str1 + " " + str3; 
Console.WriteLine($"Operador + -> {combinedStr}");

string[] words = { "Hola", "Mundo" };
string combinedStr2 = string.Concat(words);
Console.WriteLine($"Concat() -> {combinedStr2}");

//Búsqueda de patrones
Console.WriteLine("Búsqueda de patrones");

string str4 = "La casa es grande";
int index = str4.IndexOf("casa");
Console.WriteLine($"IndexOf() -> {index}");

bool containsCasa = str4.Contains("casa");
Console.WriteLine($"Contains() -> {containsCasa}");

//Formateo de cadenas
string name = "Randy";
int age = 22;
string formattedStr = string.Format("Mi nombre es {0} y tengo {1} años.", name, age);
Console.WriteLine($"Format() -> {formattedStr}");