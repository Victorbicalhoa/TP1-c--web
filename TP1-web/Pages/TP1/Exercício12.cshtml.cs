using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using TP1_web.Pages.Models;

public class Exercicio12Model : PageModel
{
    [BindProperty]
    public string Titulo { get; set; } = string.Empty;

    [BindProperty]
    public DateTime Data { get; set; }

    [BindProperty]
    public string Local { get; set; } = string.Empty;

    public Evento? EventoCriado { get; private set; }

    // Delegate para registrar eventos no console
    public static event Action<Evento>? EventoRegistrado;

    public void OnPost()
    {
        // Criando um novo evento
        EventoCriado = new Evento(Titulo, Data, Local);

        // Disparando o delegate para registro no console
        EventoRegistrado?.Invoke(EventoCriado);
    }

    // Método para registrar no console
    public static void LogEvento(Evento evento)
    {
        Console.WriteLine($"Novo evento registrado: {evento}");
    }

    static Exercicio12Model()
    {
        // Associando o método ao evento
        EventoRegistrado += LogEvento;
    }
}