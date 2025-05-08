using System;
using System.Threading;

namespace TP1_web.Pages.Models
{
    public class DownloadManager
    {
        public event EventHandler<string>? DownloadCompleted;

        public void IniciarDownload()
        {
            // Simula o tempo de um download (3 segundos)
            Thread.Sleep(3000);

            // Dispara o evento ao concluir
            DownloadCompleted?.Invoke(this, "✅ Download concluído com sucesso!");
        }
    }
}