string bookTitle = "Code Clean";
string? userFeedback = null;
string customerName = "";
string whitespaceText = "   ";

Console.WriteLine($"Propiedades de Strings");

// Length
int titleLength = bookTitle.Length;
Console.WriteLine($"Length del título del libro -> {titleLength}");

if (titleLength > 5) Console.WriteLine($"EL título del libro es demasiado largo");

// Chars
char[] titleChars = bookTitle.ToCharArray();
Console.WriteLine($"Carácteres del título del libro -> {string.Join(", ", titleChars)}");
for (int i = 0; i < titleChars.Length; i++)
{
    Console.WriteLine($"       Carácter {i + 1} del título -> {titleChars[i]}");
}

// IsNullOrEmpty
bool isFeedbackNullOrEmpty = string.IsNullOrEmpty(userFeedback);
Console.WriteLine($"¿El feedback del usuario está vacío o es nulo? -> {isFeedbackNullOrEmpty}");

// IsNullOrWhiteSpace
bool isCustomerNameNullOrWhiteSpace = string.IsNullOrWhiteSpace(customerName);
bool isWhitespaceTextNullOrWhiteSpace = string.IsNullOrWhiteSpace(whitespaceText);
Console.WriteLine($"¿El nombre del cliente está vacío o es solo espacios en blanco? -> {isCustomerNameNullOrWhiteSpace}");
Console.WriteLine($"¿El texto contiene solo espacios en blanco? -> {isWhitespaceTextNullOrWhiteSpace}");

// Empty
string emptyString = string.Empty;
Console.WriteLine($"Ejemplo de un string vacío -> '{emptyString}'");