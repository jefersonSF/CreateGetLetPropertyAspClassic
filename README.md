# GetLet Generator

Ferramenta auxiliar de linha de comando para geração automática de propriedades `Get` e `Let` em projetos **ASP Classic** e **VB6**, desenvolvida em **.NET 8**.

![.NET](https://img.shields.io/badge/.NET-8.0-purple)
![License](https://img.shields.io/badge/license-MIT-blue)

---

## 📌 Objetivo

Ao receber uma lista de atributos separados por vírgula, a ferramenta gera automaticamente:

- A declaração privada de cada atributo;
- As propriedades `Get` e `Let` correspondentes.

Isso reduz o trabalho repetitivo de escrever manualmente o boilerplate de propriedades em ASP Classic e VB6.

---

## ⚙️ Requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) (para executar via `dotnet run`) **ou** o binário publicado.
- Windows, Linux ou macOS (a ferramenta é multiplataforma).

---

## 🚀 Como usar

1. Execute a ferramenta:
   ```bash
   dotnet run

## 💡 Dicas de uso

Para facilitar o uso no dia a dia:

### Dica 1
1. **Gere o executável** com 
`dotnet publish`
:
   ```bash
   dotnet publish -c Release -r win-x64 --self-contained


2. **Crie um atalho** para o executável no local de sua preferência (Área de Trabalho, menu Iniciar, etc...).

3. (Opcional) Adicione a pasta do executável ao `PATH` para chamar a ferramenta de qualquer terminal.

   **Windows**: adicione o caminho em Variáveis de Ambiente → Path.

   **Linux/macOS**: adicione export PATH="$PATH:/caminho/para/a/pasta" ao ~/.bashrc ou ~/.zshrc

### Dica 2
No caso da execução via terminal, pode personalizar o nome do executável, de forma que o nome do comando fique mais simples de ser lembrado. Pra isso, basta alterar no arquivo .csproj a propriedaade `<AssemblyName>GetLetGen</AssemblyName>` para outro nome de sua preferência.

### Dica 3
Caso não tenha instalado [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0), é possível tentar a execução com outras versões, visto que o código C# utilizado nessa ferramenta, é comum nas diversas versões do dotnet. Então se necessário, altere a versão do `<TargetFramework>net8.0</TargetFramework>`
