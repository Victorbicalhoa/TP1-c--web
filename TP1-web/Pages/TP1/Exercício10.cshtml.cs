using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class Exercicio10Model : PageModel
{
    [BindProperty]
    public string Nome { get; set; } = string.Empty;

    [BindProperty]
    public decimal Preco { get; set; }

    public bool ProdutoCadastrado { get; private set; }

    public void OnPost()
    {
        ProdutoCadastrado = !string.IsNullOrWhiteSpace(Nome) && Preco > 0;
    }
}