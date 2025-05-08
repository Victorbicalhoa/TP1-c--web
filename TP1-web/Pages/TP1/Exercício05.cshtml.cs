using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP1_web.Pages.Models;

public class Exercicio05Model : PageModel
{
    public string Status { get; private set; } = "⌛ Aguardando início do download...";

    private DownloadManager downloadManager;

    public Exercicio05Model()
    {
        downloadManager = new DownloadManager();
        downloadManager.DownloadCompleted += DownloadManager_DownloadCompleted;
    }

    public void OnPost()
    {
        Status = "🔄 Download em andamento...";

        // Simula o download e dispara o evento ao finalizar
        downloadManager.IniciarDownload();
    }

    private void DownloadManager_DownloadCompleted(object? sender, string mensagem)
    {
        Status = mensagem;
    }
}