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
            

            int capacidade = Suite.Capacidade;
            if (capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
              
                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
          
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
           
             
            decimal valor = DiasReservados * Suite.ValorDiaria;


          
            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 0.1m);
            }

            return valor;
        }
    }
}