static void FormatString(string stringToFormat)
{
    stringToFormat.Replace("Mundo","Marte");
}

static string FormatReturningString(string stringToFormat)
{
    return stringToFormat.Replace("Mundo", "Marte");
}

var mensagem = "Olá Mundo";

FormatString(mensagem);
Console.WriteLine(mensagem);
var Outramensagem = "Bom-Dia Mundo";
Console.WriteLine(FormatReturningString(Outramensagem));