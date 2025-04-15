# 🏗️ Padrão Factory Method em C# com Docker

![C#](https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-2496ED?logo=docker&logoColor=white)
![Design Patterns](https://img.shields.io/badge/Design%20Patterns-Factory%20Method-orange)

Este projeto demonstra a implementação do **padrão Factory Method** em C#, utilizando Docker para criar um ambiente de desenvolvimento isolado e reproduzível.

## 📚 Descrição

O Factory Method é um padrão criacional que permite a criação de objetos sem especificar a classe exata do objeto que será criado. Neste projeto, simulamos uma sorveteria que produz diferentes combinações de sorvetes, onde cada tipo de sorvete é criado por um factory method específico.

## 🧱 Estrutura do Projeto

```
├── Factory/
│   ├── Creators/
│   │   ├── SorveteCreator.cs          # Classe abstrata criadora
│   │   ├── SorveteOneCreator.cs       # Criador concreto para sorvetes individuais
│   │   └── SorveteCollectionCreator.cs # Criador concreto para coleções
│   └── Sorveteria/
│       ├── ComboSegunda.cs            # Implementação concreta para segundas
│       └── ComboTerca.cs              # Implementação concreta para terças
├── Interfaces/
│   └── ISorvete.cs                    # Interface comum para todos os sorvetes
├── Program.cs                         # Ponto de entrada da aplicação
├── Aps_Leonardo.csproj                # Arquivo de projeto
├── Dockerfile                         # Configuração do container Docker
└── docker-compose.yml                 # Orquestração de containers
```

## 🚀 Como Executar

### Pré-requisitos
- [Docker](https://www.docker.com/get-started) instalado na sua máquina

### Passos para execução

1. **Construir o ambiente Docker**:
   ```bash
   docker compose build
   ```

2. **Iniciar o container e acessar o terminal**:
   ```bash
   docker compose --rm run dotnet_app bash
   ```

3. **Dentro do container, compile e execute o projeto**:
   ```bash
   dotnet build
   dotnet run
   ```

## 🧪 Exemplo de Saída Esperada

Ao executar o projeto, você verá uma saída semelhante a:

```
Sabor: baunilha, Cobertura: chocolate, Base: copo
Sabor: chocolate, Cobertura: morango, Base: casquinha
Sorvetes criados:
Sabor: baunilha, Cobertura: chocolate, Base: copo
Sabor: baunilha, Cobertura: chocolate, Base: copo
Sabor: baunilha, Cobertura: chocolate, Base: copo
```

## 🧠 Conceitos Abordados

- **Padrão Factory Method**: Permite a criação de objetos sem especificar a classe concreta
- **Programação Orientada a Objetos**: Uso de interfaces e classes abstratas
- **Docker**: Containerização do ambiente de desenvolvimento
- **SOLID Principles**: Especialmente o Princípio da Inversão de Dependência

## 👤 Autor

Iarley Ibiapina 
Antonio Gabriel
Bruno Teixeira
Richard Lima

[![GitHub](https://img.shields.io/badge/GitHub-100000?logo=github&logoColor=white)](https://github.com/iarleyibiapina)