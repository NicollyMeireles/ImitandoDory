Console.WriteLine("--- IMITANDO DORY ---");
Console.WriteLine("digite algo:______");
string frase = Console.ReadLine()!;

string fraseEmBaleies = frase
    .Replace("a", "aaaa")
    .Replace("A", "AAAA")
    .Replace("e", "eeee")
    .Replace("E", "EEEE")
    .Replace("i", "iiii")
    .Replace("I", "IIII")
    .Replace("o", "oooo")
    .Replace("O", "OOOO")
    .Replace("u", "uuuu")
    .Replace("U", "UUUU")
    ;

    Console.WriteLine($"\nEm baleiês:\n\n{fraseEmBaleies}");

