# .NET Sistema Básico de Estacionamento - Fundamentos

## Desafio de projeto
Este desafio de projeto foi proposto na trilha .Net da plataforma DIO.

## Proposta
Foi proposta a implementação de um sistema simples para um estacionamento através da classe denominada "Estacionamento", com métodos para:

**Cadastrar Veiculo**: Recebe uma placa digitada pelo usuário e guarda na variável (lista) **veiculos**.
 
**Remover Veiculo**: Verifica se um determinado veículo está estacionado, e caso positivo, pede a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **preço inicial** + **preço por hora** * **horas estacionadas**, exibindo para o usuário o preço final.

**Listar Veiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibe a mensagem "Não há veículos estacionados".

O sistema apresenta o seguinte menu para a realização das interações:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar

Indo além do desafio, foram adicionados:

**Validação de placa**: verifica se a placa digitada pelo usuário segue o padrão tradicional brasileiro (XXX-0000) ou o padrão MercoSul (XXX0X00), utilizando **Regex**.
**Cadastro e pesquisa de placas em letras maiúsculas**: transforma a entrada do usuário em maíusculas, para não haver diferenças no momento da pesquisa de placas.
