📦 Nome do Projeto — Infinite Fox Runner

🦊 Descrição do Jogo

Infinite Fox Runner é um jogo 3D estilo Infinite Runner, onde o jogador controla uma raposa em terceira pessoa que corre por uma trilha repleta de obstáculos. O objetivo é desviar de rochas que aparecem em três posições fixas e sobrevivem o máximo possível para alcançar uma pontuação alta.



🎮 Mecânica Principal

    A raposa corre automaticamente por um ambiente 3D contínuo.

    Obstáculos (rochas) aparecem em 3 posições fixas no caminho.

    O jogador deve desviar dos obstáculos para não perder.

    A raposa se move para lado direito, esquerdo e pula(tecla space)

    Cada vez que a raposa passa por um obstáculo (sem colidir), o score aumenta em 1 ponto.

    O jogo termina se a raposa colidir com uma rocha.

    Há uma tela de Game Over com opções de Reiniciar ou Sair do jogo.



🚀 Como Rodar o Jogo

    Requisitos

        Unity (versão recomendada: 2022.3 LTS ou compatível)

        Visual Studio (com suporte ao Unity e C#)

        Sistema operacional: Windows, macOS ou Linux


    Passos para rodar

        Clone ou baixe este repositório:

        git clone https://github.com/seu-usuario/infinite-fox-runner.git

        Abra o projeto no Unity:

            Abra o Unity Hub

            Clique em "Open"

            Selecione a pasta do projeto clonado

        Pressione Play dentro do Unity para iniciar o jogo.



🧠 Planejamento e Arquitetura

    Separação de responsabilidades por scripts:

        PlayerMovement.cs: controla o movimento da raposa
        PlayerCollision.cs: controla as colisões do player com os obstáculos e ao sair do tile

        DestroyTile.cs: responsável pela destruição do tile em definido ponto
        SpanwTile: responsável pela construção do tile em definido ponto

        ObstacleSpawn.cs: controla o aparecimento de obstáculos nas posições pré-definidas
        ObstacleTrigguer.cs: auxilia no polimento da contagem ao passar pelos obstáculos
        
        ScoreHandler.cs: lida com a contagem e exibição do score

        GameOverOverMenu.cs: controla o menu do game over, reiniciando o game ou saindo dele
        InicialMenuManager.cs: gerencia os botões de play, quit e configure do menu principal

        ButtonSound.cs: responsável por tocar os sons de click dos botões no jogo
        MusicConTinue.cs: responsável por fazer permanecer a música permanecer ao ir para a tela de game

        CameraFollower.cs: controla a câmera para que siga o player durante o jogo.

        
    Design baseado em componentes, utilizando prefabs para tiles, obstáculos e elementos de UI.


    Ciclo de jogo estruturado com:

        Menu Inicial

        Gameplay

        Game Over + Reset  



🎨 			Assets Utilizados  

rocha: https://opengameart.org/content/mossy-stone-rock  Author: mastahcez  

raposa: "Fmesh7 fbx" (https://skfb.ly/6zHYK) by keh is licensed under Creative Commons Attribution  

hits effects: 
	https://opengameart.org/content/75-cc0-breaking-falling-hit-sfx  
	License: https://creativecommons.org/publicdomain/zero/1.0/  

UI Soundpack:
	Created and distributed by Nathan Gibson (https://nathangibson.myportfolio.com)
	Creation date: 27/9/2021

	License: Attribution 4.0 International (CC BY 4.0)
	https://creativecommons.org/licenses/by/4.0/

	credit => Nathan Gibson - https://nathangibson.myportfolio.com   

Assets em geral retirados dos seguintes sites:(componentes da floresta, material do chão e animações)  
    https://quaternius.com/
    https://opengameart.org/
    https://www.mixamo.com/#/
    https://itch.io/

    Todos os assets usados são de fontes gratuitas ou com licenças compatíveis com uso não comercial.  


🤖 O que foi feito com auxílio de IA

    Auxílio na documentação e na divisão de responsabilidades dos scripts

    Revisão de lógica para menus, cenas e integração entre scripts

