using System;
using System.Runtime.CompilerServices;
using Raylib_cs;

namespace Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int winWidth = 1550;
            int winHeigth = 1300;
            Raylib.InitWindow(winWidth, winHeigth, "Wor");

            play.playerBall.Yposition = winHeigth / 2 - play.playerBall.diametr / 2;
            int pos = winWidth / 2 - play.playerBall.diametr / 2;

            float deltaTime = 0;
            if (!Raylib.WindowShouldClose())
            {

                Raylib.BeginDrawing();
                deltaTime = Raylib.GetFrameTime();
                Raylib.DrawCircle(pos, play.playerBall.Yposition, play.playerBall.diametr, Color.RED);
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                {
                    play.playerBall.Jump();
                }
                play.playerBall.Fall(deltaTime);
                Raylib.EndDrawing();
            }
        }
    }
}
