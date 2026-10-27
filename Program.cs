using static Raylib_cs.Raylib;

class Program
{
    static void Main()
    {
        //tamanho e posição tela
        const int tamanho_telaHorizontal = 800;
        const int tamanho_telaVertical = 600;
        const int telaPosicaoX = 600;
        const int telaPosicaoY = 300;

        //tamanho posição da bola e velocidade 
        int bolaTamanho = 30;
        int bolaPosicaoX = 400;
        int bolaPosicaoY = 300;
        int fps = 100;//variavel de fps
        int velocidadeX = 5;
        int velocidadeY = 3;

        //raquete jogador tamanho e posição
        int raquetePosicaoX = 0;
        int raquetePosicaoY = 200;
        int raqueteTamanhoX = 50;
        int raqueteTamanhoY = 200;

        //raquete cpu
        int raquetePosicaoCPU_X = 750;
        int raquetePosicaoCPU_Y = 200;
        int raqueteTamanhoCPU_X = 50;
        int raqueteTamanhoCPU_Y = 200;

        //janela com nome e setar posição na tela do windows 
        InitWindow(tamanho_telaHorizontal, tamanho_telaVertical, "Jogo Ping Pong");
        SetWindowPosition(telaPosicaoX, telaPosicaoY);

        //chamar o fps
        SetTargetFPS(fps);


        while (!WindowShouldClose())
        {
            BeginDrawing();

            //adicionar fundo preto tela
            ClearBackground(Raylib_cs.Color.Black);

            //desenhar bola
            DrawCircle(bolaPosicaoX, bolaPosicaoY, bolaTamanho, Raylib_cs.Color.Green);

            //desenhar raquete jogador
            DrawRectangle(raquetePosicaoX, raquetePosicaoY, raqueteTamanhoX, raqueteTamanhoY, Raylib_cs.Color.Red);

            //desenhar raquete CPU
            DrawRectangle(raquetePosicaoCPU_X, raquetePosicaoCPU_Y, raqueteTamanhoCPU_X, raqueteTamanhoCPU_Y, Raylib_cs.Color.Blue);

            //bola bater na borda da tela e voltar
            bolaPosicaoX += velocidadeX;
            bolaPosicaoY += velocidadeY;

            if (bolaPosicaoX >= tamanho_telaHorizontal || bolaPosicaoX <= 0) velocidadeX = -velocidadeX;
            if (bolaPosicaoY >= tamanho_telaVertical || bolaPosicaoY <= 0) velocidadeY = -velocidadeY;

            //mover raquete
            if (IsKeyDown(Raylib_cs.KeyboardKey.W)) raquetePosicaoY -= 5;
            if (IsKeyDown(Raylib_cs.KeyboardKey.S)) raquetePosicaoY += 5;

            //raquete ficar presa no limite da tela
            if (raquetePosicaoY < 0)
            {
                raquetePosicaoY = 0;
            }

            if (raquetePosicaoY + raqueteTamanhoY > tamanho_telaVertical)
            {
                raquetePosicaoY = tamanho_telaVertical - raqueteTamanhoY;
            }

            //colisão bola e raquete do jogador
            if (bolaPosicaoX - bolaTamanho / 2 <= raquetePosicaoX + raqueteTamanhoX)
            {
                if (bolaPosicaoY + bolaTamanho / 2 >= raquetePosicaoY &&
                    bolaPosicaoY - bolaTamanho / 2 <= raquetePosicaoY + raqueteTamanhoY)
                {
                    velocidadeX = -velocidadeX;
                }
            }

            //raquete CPU seguir a bola
            int centroRaquete = raquetePosicaoCPU_Y + (raqueteTamanhoCPU_Y / 2);

            if (centroRaquete > bolaPosicaoY)
            {
                raquetePosicaoCPU_Y -= 3;
            }
            if (centroRaquete < bolaPosicaoY)
            {
                raquetePosicaoCPU_Y += 3;
            }

            //colisão bola e raquete do CPU
            if (bolaPosicaoX + bolaTamanho / 2 >= raquetePosicaoCPU_X)
            {
                if (bolaPosicaoY + bolaTamanho / 2 >= raquetePosicaoCPU_Y &&
                    bolaPosicaoY - bolaTamanho / 2 <= raquetePosicaoCPU_Y + raqueteTamanhoCPU_Y)
                {
                    velocidadeX = -velocidadeX;
                }
            }

            EndDrawing();

        }

        CloseWindow();
    }
}