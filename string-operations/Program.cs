//Comparación de cadenas
Console.WriteLine("Comparación de cadenas");

string skuProduct1 = "B01ABCDEF2";
string skuProduct2 = "B01ABCDEF2";
bool areEqual = (skuProduct1 == skuProduct2);
Console.WriteLine($"¿El SKU de ambos productos es igual? -> {areEqual}");

string skuProduct3 = "B07GHIJKL3";
bool areEqual2 = skuProduct2.Equals(skuProduct3);
Console.WriteLine($"¿El SKU de ambos productos es igual? -> {areEqual2}");

//Concatenación de cadenas
Console.WriteLine("Concatenación de cadenas");

string customerName = "Randy López";
string customerAddress = "Jutiapa, Guatemala";
string customerDetails = $"{customerName}: {customerAddress}";
Console.WriteLine($"Detalles del cliente -> {customerDetails}");

string[] addressParts = { "Zona 12", "Calle 02", "Jutiapa", "Guatemala" };
string fullAddress = string.Join(", ", addressParts);
Console.WriteLine($"Dirección completa -> {fullAddress}");

//Búsqueda de patrones
Console.WriteLine("Búsqueda de patrones");

string productDescription = $"El producto {skuProduct3} está disponible en diferentes tamaños y colores.";
int index = productDescription.IndexOf("producto");
Console.WriteLine($"La palabra [producto] comienza en el índice: {index}");

bool containsProduct = productDescription.Contains("producto");
Console.WriteLine($"¿La descripción contiene la palabra [producto]?: {containsProduct}");

//Formateo de cadenas
string name = "Randy";
int age = 22;
string formattedStr = string.Format("Mi nombre es {0} y tengo {1} años.", name, age);
Console.WriteLine($"Descripción del usuario -> {formattedStr}");