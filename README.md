# Requisitos
- .NET 6.0 ou superior instalado
- Terminal PowerShell ou CMD

# Sistema de Estacionamento

Desafio de projeto proposto pela DIO - Trilha .NET - Fundamentos  
www.dio.me

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar operações como adicionar, remover (com cálculo do valor cobrado) e listar veículos.

## Diagrama de Funcionamento
![Diagrama de Classe Estacionamento](diagrama_classe_estacionamento.png)

## Estrutura da Classe
A classe `Estacionamento` contém:
- **precoInicial**: decimal. Preço cobrado para deixar o veículo estacionado.
- **precoPorHora**: decimal. Preço por hora de permanência.
- **veiculos**: lista de string, representando as placas dos veículos estacionados.

### Métodos
- **AdicionarVeiculo**: Recebe a placa digitada pelo usuário e guarda na lista de veículos.
- **RemoverVeiculo**: Verifica se o veículo está estacionado, pede a quantidade de horas, calcula o valor e exibe ao usuário.
- **ListarVeiculos**: Lista todos os veículos presentes. Se não houver, exibe "Não há veículos estacionados".

## Execução

O sistema apresenta um menu interativo. Basta digitar o número da opção desejada e seguir as instruções na tela:

1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar

## Como Executar o Projeto
1. Abra o terminal (PowerShell) e navegue até a raiz do projeto:
   ```powershell
   cd c:\Users\Karina\projetos\trilha-net-fundamentos-desafio
   ```
2. Execute o projeto com o comando:
   ```powershell
   dotnet run --project .\DesafioFundamentos\DesafioFundamentos.csproj
   ```

## Exemplo de Uso

### Cadastro de veículo
```
Bem-vindo ao nosso estacionamento!
Política de cobrança: Valor inicial R$ 5,00 + R$ 2,00 por hora.
Digite a placa do veículo para estacionar:
ABC1234
Digite o modelo do veículo:
...
```

### Remoção de veículo
```
Digite a placa do veículo para remover:
ABC1234
Veículo encontrado: Placa: ABC1234, Modelo: ..., Cor: ..., Ano: ...
Digite a quantidade de horas que o veículo permaneceu estacionado:
4
Memória de cálculo:
Valor inicial: R$ 5
Valor por hora: R$ 2
Quantidade de horas: 4
Cálculo: R$ 5 + (R$ 2 x 4)
Valor total a ser pago: R$ 13
Digite o valor pago:
13
Recibo:
Placa: ABC1234
Modelo: ...
Cor: ...
Ano: ...
Tempo: 4 hora(s)
Valor pago: 13
Obrigado por utilizar nosso estacionamento.
```

## Propósito do Treinamento
Este projeto foi realizado para consolidar os conhecimentos adquiridos na trilha do DIO Bootcamp Deal Group AI Centric .Net, proporcionando uma experiência prática e divertida.

## Agradecimentos
Projeto realizado por Karina Nascimento.

Meus sinceros agradecimentos ao professor Leonardo Buta, à equipe DIO e ao Deal Group por proporcionarem uma jornada de aprendizado transformadora, repleta de desafios, inspiração e crescimento profissional. Obrigada por acreditarem no potencial dos alunos, por compartilharem conhecimento com paixão e por abrirem portas para novas oportunidades. Este projeto é resultado do incentivo, dedicação e visão de todos vocês. Que venham muitos outros desafios e conquistas!

