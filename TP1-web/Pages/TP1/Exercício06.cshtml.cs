using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP1_web.Pages.Models;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

public class Exercicio06Model : PageModel
{
    [BindProperty]
    public string MensagemLog { get; set; } = "";

    public List<string> LogRegistrado { get; private set; } = new List<string>();

    private Logger logger;

    public Exercicio06Model()
    {
        logger = new Logger();
        logger.LogDelegate += RegistrarLogNaPagina;
    }

    public void OnPost()
    {
        if (!string.IsNullOrWhiteSpace(MensagemLog))
        {
            logger.RegistrarLog(MensagemLog);
        }
    }

    private void RegistrarLogNaPagina(string mensagem)
    {
        LogRegistrado.Add($" [Interface]: {mensagem}");
    }
}