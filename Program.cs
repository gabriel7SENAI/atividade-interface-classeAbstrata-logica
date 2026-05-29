using atividade_interface_classe_abstrata_logica.Models.Animais;
using atividade_interface_classe_abstrata_logica.Models.Empresa;
using atividade_interface_classe_abstrata_logica.Models.Pagamento;
using atividade_interface_classe_abstrata_logica.Models.Veiculos;

Console.Clear();

// Carro carro = new("Chevrolet", "Chevy", 0);
// Moto moto = new("Honda", "Biz", 0);

// carro.Acelerar();
// carro.Acelerar();
// carro.Acelerar();

// moto.Acelerar();

// Console.WriteLine(@$"Velocidade atual 
// Carro: {carro.VelocidadeAtual} km/h
// Moto: {moto.VelocidadeAtual} km/h");

// carro.Buzinar();
// moto.Buzinar();

// carro.Frear();
// moto.Frear();

// Console.WriteLine(@$"Velocidade atual 
// Carro: {carro.VelocidadeAtual} km/h
// Moto: {moto.VelocidadeAtual} km/h");



// Gerente gerente = new("ger", 1500);
// gerente.ExibirRelatorio();

// Desenvolvedor desenvolvedor = new("dev", 1500);
// desenvolvedor.ExibirRelatorio();

// Estagiario estagiario = new("est", 1500);
// estagiario.ExibirRelatorio();



// IPagamento formaDePagamento = new Pix();

// Pedido pedido = new PedidoLoja(1, 150, formaDePagamento);
// pedido.FinalizarPedido();



Animal cachorro = new Cachorro("achorro", 3);
Animal gato = new Gato("ato", 7);
Animal vaca = new Vaca("aca", 4);

List<Animal> animais = new();
animais.Add(cachorro);
animais.Add(gato);
animais.Add(vaca);

foreach (Animal animal in animais)
{
    animal.EmitirSom();
    animal.Comer();
    animal.Dormir();
    Console.WriteLine("");
}