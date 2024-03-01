string review1 = "Este producto es excelente, me encanta.";
string review2 = "No estoy satisfecho con la calidad del producto.";

Console.WriteLine($"Métodos de Strings");

//ToUpper()
string upperCaseReview = review1.ToUpper();
Console.WriteLine($"Opinión en mayúsculas: {upperCaseReview}");

//ToLower()
string lowerCaseReview = review2.ToLower();
Console.WriteLine($"Opinión en minúsculas: {lowerCaseReview}");

//IndexOf()
int index = review1.IndexOf("excelente");
if (index != -1)
{
    Console.WriteLine($"La palabra [excelente] comienza en el índice: {index}");
}
else
{
    Console.WriteLine("La palabra [excelente] no se encontró en la opinión.");
}

//LastIndexOf()
int lastIndex = review2.LastIndexOf("satisfecho");
Console.WriteLine($"Última aparición de 'satisfecho': {lastIndex}");

//Substring()
string subStr = review1.Substring(19);
Console.WriteLine($"Opinión destacada: {subStr}");

//Replace()
string filteredReview = review2.Replace("No estoy satisfecho", "***");
Console.WriteLine($"Opinión filtrada: {filteredReview}");

//Trim()
string trimmedReview = review1.Trim();
Console.WriteLine($"Opinión recortada: {trimmedReview}");

//StartsWith()
bool startsWithPositiveTerm = review1.StartsWith("Este producto es excelente");
Console.WriteLine($"La opinión comienza con término positivo: {startsWithPositiveTerm}");

//EndsWith()
bool isACompletedReview = review2.EndsWith(".");
Console.WriteLine($"La opinión esta completa: {isACompletedReview}");

//Split(), 
string[] reviewParts = review1.Split(' ');
Console.WriteLine($"Palabras en la opinión:");
foreach (string part in reviewParts)
{
    Console.WriteLine($@"       {part}");
}

//Contains()
bool containsExternalLink = review2.Contains("http://") || review2.Contains("https://");
Console.WriteLine($"La opinión contiene enlaces externos: {containsExternalLink}");

//Equals()
bool areEqual = review1.Equals(review2);
Console.WriteLine($"Las opiniones son iguales: {areEqual}");