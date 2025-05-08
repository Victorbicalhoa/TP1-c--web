using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP1_web.Pages.Models;

public class Exercicio04Model : PageModel
{
    [BindProperty]
    public double TemperaturaAtual { get; set; }

    public string Mensagem { get; private set; } = "";

    private TemperatureSensor sensor;

    public Exercicio04Model()
    {
        sensor = new TemperatureSensor();
        sensor.TemperatureStatusUpdated += Sensor_TemperatureStatusUpdated;
    }

    public void OnPost()
    {
        // Simula a leitura e permite que o sensor defina a mensagem correta
        sensor.MonitorarTemperatura(TemperaturaAtual);
    }

    private void Sensor_TemperatureStatusUpdated(object? sender, string mensagem)
    {
        Mensagem = mensagem;
    }
}