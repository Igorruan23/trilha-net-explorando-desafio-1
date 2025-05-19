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
           
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            bool suficiente = (Suite.Capacidade >= hospedes.Count)? true : false;
            // *IMPLEMENTE AQUI*
            if (suficiente)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception($"A suite so suporta {Suite.Capacidade} pessoas. ");
                // *IMPLEMENTE AQUI*
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidade = 0;
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            foreach (Pessoa p in Hospedes)
            {
                quantidade++;
            }
           
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            decimal calculo = DiasReservados * Suite.ValorDiaria;
            decimal valor = calculo;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
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