using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class Exercicio03Model : PageModel
{
    [BindProperty]
    public double BaseRetangulo { get; set; }

    [BindProperty]
    public double AlturaRetangulo { get; set; }

    public double AreaCalculada { get; private set; }

    // Delegate Func para cálculo da área
    private Func<double, double, double> calcularArea;

    public void OnPost()
    {
        // Instancia o delegate com a lógica de cálculo
        calcularArea = (baseRet, alturaRet) => baseRet * alturaRet;

        // Aplica o cálculo e armazena o resultado
        AreaCalculada = calcularArea(BaseRetangulo, AlturaRetangulo);
    }
}