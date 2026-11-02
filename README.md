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
