# Projeto C# Microservices com Docker, Kubernetes e gRPC

Este projeto é uma implementação prática do curso "C# Microservices com Docker, Kubernetes e gRPC". Ele consiste em uma arquitetura de microsserviços desenvolvida em C#, que utiliza tecnologias como Docker, Kubernetes e gRPC para implementar uma solução escalável e distribuída.

## Visão Geral do Projeto

O projeto é uma plataforma de serviços distribuídos, composta por vários microsserviços interconectados, cada um responsável por uma parte específica da funcionalidade do sistema. A arquitetura do projeto segue os princípios de microsserviços, onde cada serviço é independente, modular e pode ser escalado individualmente.

## Componentes Principais

### Serviços
- **Platform Service**: O primeiro serviço construído no curso, responsável por gerenciar plataformas de serviços.
- **Commands Service**: Um serviço adicional que foi adicionado posteriormente, para lidar com comandos e operações relacionadas.
- **SQL Server**: Um componente de banco de dados SQL Server implantado em um ambiente Kubernetes, usado para armazenar dados persistentes.

### Tecnologias Utilizadas
- **C# (.NET Core 8)**: Linguagem de programação principal utilizada para desenvolver os microsserviços.
- **Docker**: Utilizado para criar contêineres isolados para cada serviço, garantindo portabilidade e consistência no ambiente de desenvolvimento e produção.
- **Kubernetes**: Utilizado como plataforma de orquestração de contêineres para implantar, gerenciar e escalar os microsserviços.
- **gRPC**: Utilizado para comunicação entre os serviços, fornecendo uma alternativa eficiente e de alto desempenho ao RESTful APIs.
- **RabbitMQ**: Utilizado para implementar mensagens assíncronas entre os microsserviços, garantindo comunicação confiável e escalável.
- **SQL Server**: Utilizado como banco de dados relacional para armazenar dados persistentes.

## Como Executar o Projeto

1. **Pré-requisitos**:
   - Instale o Docker e o Kubernetes em seu ambiente de desenvolvimento.
   - Certifique-se de ter o .NET Core SDK 8 instalado em sua máquina.
   
2. **Clonar o Repositório**:
    - git clone https://github.com/Raphael-Azevedo/microsservices-csharp


3. **Construir e Executar os Serviços**:
- Navegue até o diretório de cada serviço (`platform-service`, `commands-service`) e siga as instruções específicas de cada um para construir e executar o serviço localmente.
- Certifique-se de que o ambiente Kubernetes esteja configurado corretamente e que os serviços estejam implantados e funcionando corretamente.

4. **Testar a Funcionalidade**:
- Use ferramentas como Postman ou Swagger para testar os endpoints dos serviços e verificar se a funcionalidade está correta.

5. **Explorar e Contribuir**:
- Explore o código-fonte dos serviços, experimente fazer alterações e contribuir para o projeto. Esteja à vontade para abrir problemas (issues) ou enviar solicitações de recebimento (pull requests) conforme necessário.
