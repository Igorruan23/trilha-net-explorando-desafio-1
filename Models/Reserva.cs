namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
                   
            bool suficiente = (Suite.Capacidade >= hospedes.Count)? true : false;
            if (suficiente)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception($"A suite so suporta {Suite.Capacidade} pessoas. ");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidade = 0;
            foreach (Pessoa p in Hospedes)
            {
                quantidade++;
            }
           
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            decimal calculo = DiasReservados * Suite.ValorDiaria;
            decimal valor = calculo;

            if (DiasReservados >= 10)
            {
                return valor = valor - (valor * .10m);

            }
            else
            {

                return valor;
            }
        }
    }
}