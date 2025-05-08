using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

public class Exercicio11Model : PageModel
{
    [BindProperty]
    public string Nome { get; set; } = string.Empty;

    [BindProperty]
    public string Sobrenome { get; set; } = string.Empty;

    public string Resultado { get; private set; } = "";

    public void OnPost()
    {
        // Delegate principal para concatenar nome e sobrenome
        Func<string, string, string> concatenarNome = (n, s) => $"{n} {s}";

        // Delegates auxiliares para transformação
        Func<string, string> paraMaiusculas = str => str.ToUpper();
        Func<string, string> removerEspacos = str => str.Trim();

        // Aplicando todas as transformações corretamente
        string nomeCompleto = concatenarNome(Nome, Sobrenome);
        nomeCompleto = paraMaiusculas(nomeCompleto);
        nomeCompleto = removerEspacos(nomeCompleto);

        Resultado = nomeCompleto;
    }
}