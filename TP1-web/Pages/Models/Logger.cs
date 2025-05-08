using System;
using System.IO;

namespace TP1_web.Pages.Models
{
    public class Logger
    {
        public Action<string>? LogDelegate;

        public Logger()
        {
            // Nenhum método será registrado inicialmente
        }

        public void RegistrarLog(string mensagem)
        {
            LogDelegate?.Invoke(mensagem); // Invocação segura do delegate
        }

        private void LogToConsole(string mensagem)
        {
            Console.WriteLine($"[Console]: {mensagem}");
        }

        private void LogToFile(string mensagem)
        {
            File.AppendAllText("log.txt", $"[Arquivo]: {mensagem}{Environment.NewLine}");
        }

        private void LogToDatabase(string mensagem)
        {
            Console.WriteLine($"[Banco de Dados]: {mensagem}");
        }

        public void RegistrarSaidas()
        {
            LogDelegate += LogToConsole;
            LogDelegate += LogToFile;
            LogDelegate += LogToDatabase;
        }

        public void LimparSaidas()
        {
            LogDelegate = null;
        }
    }
}   