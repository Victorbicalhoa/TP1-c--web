using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class Exercicio02Model : PageModel
{
    [BindProperty]
    public string IdiomaSelecionado { get; set; } = "pt";

    public string Mensagem { get; private set; }

    // Delegate para exibir mensagens
    private Action<string> exibirMensagem;

    public void OnPost()
    {
        // Define mensagens para cada idioma usando Action<string>
        exibirMensagem = idioma =>
        {
            switch (idioma)
            {
                case "pt":
                    Mensagem = "Bem-vindo à nossa plataforma!";
                    break;
                case "en":
                    Mensagem = "Welcome to our platform!";
                    break;
                case "es":
                    Mensagem = "¡Bienvenido a nuestra plataforma!";
                    break;
                default:
                    Mensagem = "Idioma não suportado.";
                    break;
            }
        };

        // Executa a ação com o idioma selecionado
        exibirMensagem(IdiomaSelecionado);
    }
}