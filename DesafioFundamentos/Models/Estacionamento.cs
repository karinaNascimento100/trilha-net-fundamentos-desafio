namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Mensagem cordial e política de cobrança
            Console.WriteLine("Bem-vindo ao nosso estacionamento!\nPolítica de cobrança: Valor inicial R$ {0:F2} + R$ {1:F2} por hora.", precoInicial, precoPorHora);
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine()?.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("Placa não informada. Cadastro cancelado.");
                return;
            }
            // Validação simples de placa (7 caracteres alfanuméricos)
            if (placa.Length != 7 || !placa.All(char.IsLetterOrDigit))
            {
                Console.WriteLine("Placa inválida. Informe uma placa válida (7 caracteres, letras e números).");
                return;
            }
            if (veiculos.Any(x => x.StartsWith(placa + "|")))
            {
                Console.WriteLine($"O veículo com placa {placa} já está cadastrado.");
                return;
            }
            Console.WriteLine("Digite o modelo do veículo:");
            string modelo = Console.ReadLine()?.Trim();
            Console.WriteLine("Digite a cor do veículo:");
            string cor = Console.ReadLine()?.Trim();
            Console.WriteLine("Digite o ano do veículo:");
            string ano = Console.ReadLine()?.Trim();
            // Validação do ano
            int anoNum;
            int anoAtual = DateTime.Now.Year;
            if (!int.TryParse(ano, out anoNum) || anoNum < 1980 || anoNum > anoAtual)
            {
                Console.WriteLine($"Ano inválido. Informe um ano entre 1980 e {anoAtual}.");
                return;
            }
            // Armazena como string formatada: placa|modelo|cor|ano
            veiculos.Add($"{placa}|{modelo}|{cor}|{anoNum}");
            Console.WriteLine($"Veículo cadastrado com sucesso! Placa: {placa}, Modelo: {modelo}, Cor: {cor}, Ano: {anoNum}");
            Console.WriteLine("Agradecemos por escolher nosso estacionamento!");
            // Comentário: Para maior realismo, os dados do veículo são armazenados juntos em uma string. O ideal seria uma classe, mas isso exigiria mudanças no Program.cs.
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Esperamos que tenha tido uma ótima experiência!\nDigite a placa do veículo para remover:");
            string placa = Console.ReadLine()?.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("Placa não informada. Remoção cancelada.");
                return;
            }
            // Busca veículo por placa
            var veiculo = veiculos.FirstOrDefault(x => x.StartsWith(placa + "|"));
            if (veiculo != null)
            {
                var dados = veiculo.Split('|');
                Console.WriteLine($"Veículo encontrado: Placa: {dados[0]}, Modelo: {dados[1]}, Cor: {dados[2]}, Ano: {dados[3]}");
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string horasStr = Console.ReadLine();
                int horas;
                if (!int.TryParse(horasStr, out horas) || horas <= 0)
                {
                    Console.WriteLine("Quantidade de horas inválida. Remoção cancelada.");
                    return;
                }
                decimal valorCobrado = precoInicial + (precoPorHora * horas);
                Console.WriteLine("Memória de cálculo:");
                Console.WriteLine($"Valor inicial: R$ {precoInicial}");
                Console.WriteLine($"Valor por hora: R$ {precoPorHora}");
                Console.WriteLine($"Quantidade de horas: {horas}");
                Console.WriteLine($"Cálculo: R$ {precoInicial} + (R$ {precoPorHora} x {horas})");
                Console.WriteLine($"Valor total a ser pago: R$ {valorCobrado}");
                Console.WriteLine("Digite o valor pago:");
                string valorPagoStr = Console.ReadLine();
                decimal valorPago;
                if (!decimal.TryParse(valorPagoStr, out valorPago))
                {
                    Console.WriteLine("Valor inválido. Digite um número válido.");
                    return;
                }
                if (valorPago > valorCobrado)
                {
                    Console.WriteLine($"Valor superior ao devido. Diferença: {valorPago - valorCobrado}");
                    return;
                }
                if (valorPago < valorCobrado)
                {
                    Console.WriteLine($"Valor inferior ao devido. Diferença: {valorCobrado - valorPago}");
                    return;
                }
                // Valor exato
                veiculos.Remove(veiculo);
                Console.WriteLine("Recibo:");
                Console.WriteLine($"Placa: {dados[0]}");
                Console.WriteLine($"Modelo: {dados[1]}");
                Console.WriteLine($"Cor: {dados[2]}");
                Console.WriteLine($"Ano: {dados[3]}");
                Console.WriteLine($"Tempo: {horas} hora(s)");
                Console.WriteLine($"Valor pago: {valorPago}");
                Console.WriteLine("Obrigado por utilizar nosso estacionamento.");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado. Confira a placa digitada.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                int i = 1;
                foreach (var v in veiculos)
                {
                    var dados = v.Split('|');
                    Console.WriteLine($"{i++}. Placa: {dados[0]}, Modelo: {dados[1]}, Cor: {dados[2]}, Ano: {dados[3]}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
            // Comentário: A listagem exibe todos os dados cadastrados do veículo, facilitando a visualização e revisão.
        }
    }
}
