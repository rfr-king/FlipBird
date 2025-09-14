using System;

namespace play
{
    class playerBall
    {
        static public int diametr = 15;

        static public int Yposition = 0;
        static float speed = 0;
        static int Jumpfor = 45;

        static public int MaxYposition = 0;
        static public void Fall(float time)
        {
            speed += 15 * time;
            if (Math.Abs(Yposition + Convert.ToInt32(speed)) < MaxYposition)
            {
                Yposition += Convert.ToInt32(speed);
            }
        }
        static public void Jump()
        {
            speed = -(Jumpfor);
        }
    }
}