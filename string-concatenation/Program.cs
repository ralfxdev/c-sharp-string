string baseUrl = "https://api.example.com";
string endpoint = "/users";
string userId = "001";

Console.WriteLine($"Concatenación de Strings");

//Operador +
string getRequestUrl = baseUrl + endpoint + "/" + userId;
Console.WriteLine($"URL de solicitud GET: {getRequestUrl}");

//Método String.Concat()
string getRequestUrlConcat = string.Concat(baseUrl, endpoint, "/", userId);
Console.WriteLine($"URL de solicitud GET: {getRequestUrlConcat}");

//Interpolación de cadenas
string getRequestUrlInterpolated = $"{baseUrl}{endpoint}/{userId}";
Console.WriteLine($"URL de solicitud GET: {getRequestUrlInterpolated}");

//Método String.Join()
string[] urlParts = { baseUrl, endpoint, userId };
string getRequestUrlJoin = string.Join("/", urlParts);
Console.WriteLine($"URL de solicitud GET: {getRequestUrlJoin}");