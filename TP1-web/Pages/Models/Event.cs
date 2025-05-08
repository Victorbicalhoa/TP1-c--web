namespace TP1_web.Pages.Models
{
    public class Evento
    {
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }

        public Evento(string titulo, DateTime data, string local)
        {
            Titulo = titulo;
            Data = data;
            Local = local;
        }

        public override string ToString()
        {
            return $"Evento: {Titulo} | Data: {Data:dd/MM/yyyy} | Local: {Local}";
        }
    }
}