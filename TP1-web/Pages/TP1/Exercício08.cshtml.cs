using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using TP1_web.Pages.Models;

public class Exercicio08Model : PageModel
{
    public List<Produto> ListaProdutos { get; private set; } = new();

    public void OnGet()
    {
        ListaProdutos = new List<Produto>
        {
            new Produto("Notebook", 4500.00m),
            new Produto("Smartphone", 2500.00m),
            new Produto("Monitor", 1200.00m)
        };
    }
}