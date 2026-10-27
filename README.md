# Jogo Ping Pong 2D | C# + Raylib

**Jogo 2D inspirado no clássico Pong, desenvolvido em C# utilizando .NET 10 e Raylib.**

**Desenvolvido por Fabio FJA | C# | .NET 10 | Raylib | Visual Studio**

## Sobre o projeto

Jogo Ping Pong 2D é um projeto de desenvolvimento de jogos criado em C# com a biblioteca gráfica Raylib, inspirado na mecânica clássica do Pong.

O jogo apresenta uma partida entre um jogador humano e um adversário controlado pelo computador, utilizando movimentação vertical das raquetes, física básica de deslocamento da bola, detecção de colisões e atualização contínua dos elementos gráficos.

O projeto foi desenvolvido com foco no aprendizado de programação de jogos 2D, abordando conceitos fundamentais como game loop, renderização gráfica, entrada pelo teclado, movimentação de objetos, colisões e lógica de comportamento de adversários.

## Funcionalidades

### 1. Sistema de movimentação do jogador

- Controle de uma raquete pela entrada do teclado.
- Movimentação vertical utilizando as teclas W e S.
- Velocidade de deslocamento configurada no código.
- Limitação da movimentação aos limites da janela.
- Atualização da posição durante a execução do jogo.

**Controles:**
- W: mover a raquete para cima.
- S: mover a raquete para baixo.

### 2. Adversário controlado pelo computador

O jogo possui uma raquete adversária com movimentação automática.

- A CPU acompanha a posição vertical da bola.
- Identifica se a bola está acima ou abaixo do centro da raquete.
- Ajusta sua posição automaticamente.
- Utiliza uma velocidade de movimentação de 3 unidades por atualização.
- Não necessita de controles adicionais.

O sistema utiliza uma lógica simples de perseguição da bola, demonstrando princípios básicos de inteligência artificial aplicada a jogos.

### 3. Sistema de movimentação da bola

- Movimentação automática nos eixos horizontal e vertical.
- Velocidade inicial horizontal de 5 unidades por atualização.
- Velocidade inicial vertical de 3 unidades por atualização.
- Inversão da direção ao alcançar os limites da janela.
- Deslocamento contínuo durante a partida.

### 4. Sistema de colisões

- Detecção de contato entre bola e raquete do jogador.
- Detecção de contato entre bola e raquete da CPU.
- Inversão da velocidade horizontal após colisões.
- Verificação dos limites verticais e horizontais da janela.
- Implementação de colisões utilizando comparações de posições e dimensões.

### 5. Renderização gráfica 2D

Todos os elementos do jogo são desenhados por meio de funções da biblioteca Raylib.

**Elementos visuais:**
- Fundo preto.
- Bola circular verde.
- Raquete vermelha controlada pelo jogador.
- Raquete azul controlada pelo computador.

O sistema utiliza as funções `DrawCircle`, `DrawRectangle` e `ClearBackground` para desenhar os elementos durante cada atualização.

### 6. Janela e desempenho

- Resolução da janela: 800 × 600 pixels.
- Limite configurado de 100 FPS.
- Posição inicial da janela definida no código.
- Loop principal executado continuamente até o fechamento.
- Renderização e atualização da lógica durante a execução.

## Tecnologias utilizadas

| Tecnologia | Finalidade |
|---|---|
| C# | Linguagem de programação |
| .NET 10 | Plataforma de execução |
| Raylib-cs 7.0.2 | Biblioteca gráfica e de entrada |
| Visual Studio | Ambiente de desenvolvimento |
| Raylib | Renderização 2D e gerenciamento da janela |

## Estrutura do projeto

```text
Jogo Ping Pong 2D/
│
├── Program.cs
├── Jogo Pong.csproj
├── Jogo Pong.slnx
│
├── bin/
│   └── Debug/
│       └── net10.0/
│           ├── Jogo Pong.exe
│           ├── Jogo Pong.dll
│           └── Raylib-cs.dll
│
└── obj/
```

### Arquivos principais

**Program.cs:** código-fonte principal contendo movimentação, colisões, controles, lógica do adversário e renderização.

**Jogo Pong.csproj:** configurações do projeto, versão do .NET e referência à biblioteca Raylib-cs.

**Jogo Pong.slnx:** arquivo de solução utilizado pelo Visual Studio.

**Jogo Pong.exe:** executável gerado na compilação de desenvolvimento.

## Como executar

### Requisitos

- .NET 10 SDK.
- Visual Studio com suporte ao desenvolvimento C# ou outro editor compatível.
- Pacote Raylib-cs 7.0.2, restaurado automaticamente pelo NuGet.

### Execução

1. Extraia os arquivos do projeto.
2. Abra `Jogo Pong.slnx` no Visual Studio.
3. Aguarde a restauração dos pacotes NuGet.
4. Execute o projeto pelo Visual Studio.

Também é possível executar pelo terminal, na pasta que contém o arquivo `.csproj`:

```bash
dotnet restore
dotnet run
```

## Conceitos de programação utilizados

O projeto demonstra a utilização de:

- Estruturas condicionais.
- Variáveis e constantes.
- Laços de repetição.
- Entrada de dados pelo teclado.
- Coordenadas cartesianas 2D.
- Movimentação de objetos.
- Detecção de colisões.
- Renderização de primitivas gráficas.
- Atualização de lógica em tempo real.
- Inteligência artificial simples baseada na posição da bola.

## Limitações da versão atual

O projeto representa uma implementação inicial da mecânica de Pong.

Funcionalidades ainda não implementadas:

- Placar de pontos.
- Sistema de vitória e derrota.
- Menu principal.
- Menu de pausa.
- Efeitos sonoros.
- Seleção de dificuldade.
- Controle por joystick.
- Reinício automático de rodadas após pontuação.

Atualmente, a bola rebate nas extremidades horizontais mesmo quando ultrapassa uma raquete. Portanto, ainda não existe um sistema completo de pontuação.

## Objetivo

Demonstrar os fundamentos do desenvolvimento de jogos 2D com C# e Raylib, utilizando um exemplo prático de movimentação, renderização, colisões e comportamento automatizado de um adversário.

## Créditos

**Desenvolvimento:** Fabio FJA

**Linguagem:** C#

**Framework:** .NET 10

**Biblioteca gráfica:** Raylib-cs 7.0.2

**Plataforma:** Desktop

**Categoria:** Jogo 2D / Arcade

Projeto desenvolvido para estudo, prática e aperfeiçoamento de conhecimentos em programação e desenvolvimento de jogos.
