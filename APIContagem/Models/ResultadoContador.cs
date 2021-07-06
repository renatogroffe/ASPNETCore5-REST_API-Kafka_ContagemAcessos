namespace APIContagem.Models
{
    public interface IResultadoContador
    {
        int ValorAtual { get; } 
        string Producer { get; } 
        string Kernel { get; } 
        string TargetFramework { get; } 
        string Mensagem { get; }
    }

    public class ResultadoContador : IResultadoContador
    {
        public int ValorAtual { get; set; } 
        public string Producer { get; set; } 
        public string Kernel { get; set; } 
        public string TargetFramework { get; set; } 
        public string Mensagem { get; set; }
    }
}