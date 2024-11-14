using Microsoft.Extensions.Options;

namespace MauiAppTeste1.Models
{
    public class Informacoes
    {
        public Local Lugar { get; set; }
        public int TotalPessoas { get; set;}

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public string NomeEvento { get; set; }

        public int TotalDias {

            get => DataTermino.Subtract(DataInicio).Days;
        }
        public double ValoTotal {

            get  {

                double valor = Convert.ToDouble(TotalPessoas) *  Lugar.ParticipanteAdulto;

                return valor * Convert.ToDouble(TotalDias);

            }

            set { }
        }

        public double CustoParticipante
        {

            get
            {
                return Convert.ToDouble(TotalPessoas) * Lugar.ParticipanteAdulto;
            }

            set { }
        }
    }
}
