namespace TP1_web.Pages.Models
{
    public class TemperatureSensor
    {
        public event EventHandler<string>? TemperatureStatusUpdated;

        public void MonitorarTemperatura(double temperatura)
        {
            if (temperatura > 100)
            {
                // Dispara alerta crítico
                TemperatureStatusUpdated?.Invoke(this, $"⚠️ Temperatura crítica! {temperatura}°C ultrapassou o limite seguro.");
            }
            else
            {
                // Dispara status normal
                TemperatureStatusUpdated?.Invoke(this, $"✅ Temperatura estável: {temperatura}°C.");
            }
        }
    }
}