string texto;
string textoLeet;
string textoMaiusculo;

Console.Clear();


Console.WriteLine("Escreve um texto: ");
texto = Console.ReadLine()!;
textoMaiusculo = texto.ToUpper();
textoLeet = textoMaiusculo.Replace("A", "4")
                 .Replace("E", "3")
                 .Replace("O", "0")
                 .Replace("I", "1")
;
Console.WriteLine($"Texto em Leet: {textoLeet}");