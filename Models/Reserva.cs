using System.Dynamic;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva 
    {
        public List<Pessoa> Hospedes { get; private set; }
        public Suite Suite { get; private set; }
        public int DiasReservados { get;  set; }
        public decimal Desconto { get;  private set; }
        public string RetornoMsg { get; private set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            try
            {


                if (Suite != null && hospedes.Count <= Suite.Capacidade)
                {

                    Hospedes = hospedes;
                    foreach (var pessoa in hospedes)
                    {
                        Console.WriteLine($"Vaga aprovovada para: {pessoa.NomeCompleto}");
                    }


                }
                else
                {
                    

                    throw new Exception("Numero inferio para a capacida disponiveis para suite ");
                    
                }
            }
            catch (Exception ex)
            {
                RetornoMsg = $"Erro ao cadastrar hospede: {ex.Message}";
                
            }
        }
       

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
         public int SuitesVaga()
        {
            if (Suite == null || Hospedes == null)
                return 0;

            return  Suite.Capacidade - Hospedes.Count;
        }


        public int ObterQuantidadeHospedes()
        {
           
            var quantidade = Hospedes.Count;

            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
           
            decimal valor =  Suite.ValorDiaria * DiasReservados;

           
            if (DiasReservados >= 10)
            {
                Desconto = valor * 10 / 100;
                valor -= Desconto;
            }

            return valor;
        }
    }
}