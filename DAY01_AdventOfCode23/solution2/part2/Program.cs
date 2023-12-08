string senhas = @"two1nine
eightwothree
abcone2threexyz
xtwone3four
4nineeightseven2
zoneight234
7pqrstsixteen";
var numEscrito = new Dictionary<string, int>()
{
    { "one", 1 },
    { "two", 2 },
    { "three", 3 },
    { "four", 4 },
    { "five", 5 },
    { "six", 6 },
    { "seven", 7},
    { "eight", 8 },
    { "nine", 9 },
};
for (int i = 1; i < 10; i++)
{
    numEscrito.Add(i.ToString(), i);
}

long total = 0;
string[] codigos = senhas.Split("\n");


foreach(string linha in codigos)
{
    var primeiroIndice = linha.Length;
    var ultimoIndice = -1;
    var primeiroValor = 0;
    var ultimoValor = 0;

    foreach(var numero in numEscrito)
    {
        var indice = linha.IndexOf(numero.Key);
        if (indice == -1)
        {
            continue;
        }

        if (indice < primeiroIndice)
        {
            primeiroIndice = indice;
            primeiroValor = numero.Value;
        }

        indice = linha.LastIndexOf(numero.Key);

         if (indice < ultimoIndice)
        {
            ultimoIndice = indice;
            ultimoValor = numero.Value;
        }
        var numCompleto = primeiroValor * 10 + ultimoValor;
        total += numCompleto;
}
    }

    
Console.WriteLine(total);