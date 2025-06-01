using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>
{
    new Pessoa("Hóspede 1", "teste"),
    new Pessoa("Hóspede 2"),
    new Pessoa("Hóspede 3"),
    new Pessoa("Hóspede 4"),
    new Pessoa("Hóspede 5"),
    new Pessoa("Hóspede 6"),
    new Pessoa("Hóspede 7"),
    new Pessoa("Hóspede 8")
};






// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 10, valorDiaria: 50);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


// Exibe a quantidade de hóspedes e o valor da diária
if (string.IsNullOrEmpty(reserva.RetornoMsg))
{
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor diária: {suite.ValorDiaria }");
    Console.WriteLine($"Valor total da diária: {reserva.CalcularValorDiaria()}");
    Console.WriteLine($"Desconto de acima de 10 dias foi de: {reserva.Desconto}");
    Console.WriteLine($"Suites sobrando: {reserva.SuitesVaga()}");
}
else
{
    Console.WriteLine(reserva.RetornoMsg);
}