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


        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

       

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (Suite != null && hospedes.Count <= Suite.Capacidade)
            {
                Console.WriteLine("Hospedagem liberada!");
            }
            else
            {
                throw new ArgumentException("Capacidade excedida. Por favor, escolha outra suite.");
            }
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*

            if (Hospedes != null)
            {
                return (Hospedes.Count);
            }
            else
            {
                return (0);
            }
            
        }




        public decimal CalcularValorDiaria()
        {
            
            if (Suite == null)
                throw new ArgumentException("Suite não foi cadastrada");

            decimal valorDiariaT = DiasReservados * Suite.ValorDiaria;
            decimal valor = valorDiariaT;

            //Console.WriteLine($"O Valor total da diaria é {valor}");

            return valor;

            // Regra
        }
    }
}
