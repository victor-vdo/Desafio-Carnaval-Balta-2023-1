Console.WriteLine("Digite um texto:");
var texto = Console.ReadLine();
var novoTexto = texto;
Dictionary<char, string> dic = new Dictionary<char, string>()
{
    { '.', String.Empty}, { ',', String.Empty}, { ':', String.Empty}, { ';', String.Empty},
    { '>', String.Empty}, { '<', String.Empty}, { '{', String.Empty}, { '}', String.Empty},
    { '(', String.Empty}, { ')', String.Empty}, { '[', String.Empty}, { ']', String.Empty},
    { '?', String.Empty}, { '!', String.Empty}, { '/', String.Empty}, { '|', String.Empty}
};

foreach (var charac in texto)
{
    if (dic.ContainsKey(charac))
        novoTexto = novoTexto.Replace(charac.ToString(), String.Empty);
}

var palavras = novoTexto.Split(" ");
Console.WriteLine(texto.Length + " caracteres, " + palavras.Length + " palavras");