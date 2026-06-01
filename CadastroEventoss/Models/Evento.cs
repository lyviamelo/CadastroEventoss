namespace CadastroEventoss.Models;

public class Evento
{
    public string NomeEvento { get; set; } = "";

    public DateTime DataInicio { get; set; }

    public DateTime DataTermino { get; set; }

    public int NumeroParticipantes { get; set; }

    public string LocalEvento { get; set; } = "";

    public double CustoPorParticipante { get; set; }

    public TimeSpan Duracao
    {
        get
        {
            return DataTermino - DataInicio;
        }
    }

    public int DuracaoDias
    {
        get
        {
            return Duracao.Days;
        }
    }

    public double CustoTotal
    {
        get
        {
            return NumeroParticipantes * CustoPorParticipante;
        }
    }
}