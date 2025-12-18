# 🎵 Screen Sound

<p align="center">
  <img src="https://github.com/BrennoBertolini/ScreenSound/blob/main/ScreenSound/image.png" alt="Screen Sound - Aplicação em execução">
</p>

Screen Sound é uma aplicação de console desenvolvida em **C# e .NET**, com o objetivo de simular um sistema de gerenciamento musical, permitindo o cadastro de bandas, álbuns, músicas e avaliações.


Screen Sound é uma aplicação de console desenvolvida em **C# e .NET**, com o objetivo de simular um sistema de gerenciamento musical, permitindo o cadastro de bandas, álbuns, músicas e avaliações.

O projeto foi criado com foco em **Programação Orientada a Objetos (POO)**, boas práticas de código e organização em camadas, sendo ideal para estudos e portfólio.

---

## 🚀 Funcionalidades

-  Registrar bandas
-  Registrar álbuns para bandas
-  Avaliar bandas
-  Avaliar álbuns
-  Exibir média de avaliações
-  Listar bandas registradas
-  Exibir detalhes completos de uma banda

---

## 🧠 Conceitos Aplicados

- Programação Orientada a Objetos (POO)
- Interfaces (`IAvaliavel`)
- Encapsulamento e responsabilidade única
- Coleções (`List`, `Dictionary`)
- Polimorfismo e herança
- Organização por namespaces
- Aplicação de menus interativos em console
- Boas práticas com `TryGetValue`, `LINQ` e validações

---

## 🗂️ Estrutura do Projeto

```bash
ScreenSound
│
├── Menus
│   ├── Menu.cs
│   ├── MenuRegistrarBanda.cs
│   ├── MenuRegistrarAlbum.cs
│   ├── MenuMostrarBandas.cs
│   ├── MenuAvaliarBanda.cs
│   ├── MenuAvaliarAlbum.cs
│   ├── MenuExibirDetalhes.cs
│   └── MenuSair.cs
│
├── Modelos
│   ├── Banda.cs
│   ├── Album.cs
│   ├── Musica.cs
│   ├── Avaliacao.cs
│   ├── AvaliacaoComSobrescrita.cs
│   └── IAvaliavel.cs
│
└── Program.cs

Pré-requisitos

.NET SDK instalado (versão 6.0 ou superior)

Passos
git clone https://github.com/seu-usuario/screen-sound.git
cd screen-sound
dotnet run

Exemplo de Uso

Escolha uma opção no menu

Cadastre bandas e álbuns

Avalie bandas e álbuns

Consulte médias e discografia

📌 Objetivo do Projeto

Este projeto foi desenvolvido com fins educacionais, para consolidar conhecimentos em C# e .NET, além de servir como parte do portfólio pessoal.

👨‍💻 Autor

Brenno Bertolini
Estudante de Engenharia de Software
💻 C# | .NET | Programação Orientada a Objetos

Licença

Este projeto está sob a licença MIT. Sinta-se livre para estudar, modificar e compartilhar.
