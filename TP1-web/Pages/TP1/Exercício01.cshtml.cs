using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class DescontoModel : PageModel
{
    // Propriedade para armazenar o preço original informado pelo usuário
    [BindProperty]
    public decimal PrecoOriginal { get; set; }

    // Propriedade para armazenar o preço final após o desconto
    public decimal PrecoFinal { get; private set; }

    // Delegate para cálculo do desconto
    delegate decimal CalculateDiscount(decimal originalPrice);

    public void OnPost()
    {
        // Instancia o delegate com o método ApplyDiscount
        CalculateDiscount discountDelegate = ApplyDiscount;

        // Aplica o desconto e armazena o preço final
        PrecoFinal = discountDelegate(PrecoOriginal);
    }

    // Método compatível com o delegate que aplica 10% de desconto
    private decimal ApplyDiscount(decimal originalPrice)
    {
        return originalPrice * 0.9M; // 10% de desconto
    }
}

