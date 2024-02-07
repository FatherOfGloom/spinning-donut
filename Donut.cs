namespace Wierd;

public class Donut
{
    int K;
    double A, B = 0, i, j;
    double[] z = new double[1760];
    char[] b = new char[1760];
    public void Spin()
    {
        
        Console.CursorVisible = false;
        Console.Write("\u001b[2J");
        for (;;)
        {
            Array.Fill(b, ' ', 0, 1760);
            Array.Fill(z, 0, 0, 1760);
            for (var j = 0d; j < 6.28; j += 0.07)
            {
                for (var i = 0d; i < 6.28; i += 0.02)
                {
                    var c = Math.Sin(i);
                    var d = Math.Cos(j);
                    var e = Math.Sin(A);
                    var f = Math.Sin(j);
                    var g = Math.Cos(A);
                    var h = d + 2;
                    var D = 1 / (c * h * e + f * g + 5);
                    var l = Math.Cos(i);
                    var m = Math.Cos(B);
                    var n = Math.Sin(B);
                    var t = c * h * g - f * e;
                    var x = (int)(40 + 30 * D * (l * h * m - t * n));
                    var y = (int)(12 + 15 * D * (l * h * n + t * m));
                    var o = x + 80 * y;
                    var N = (int)(8 * ((f * e - c * d * g) * m - c * d * e - f * g - l * d * n));

                    if (22 > y && y > 0 && x > 0 && x < 80 && D > z[o])
                    {
                        z[o] = D;
                        b[o] = ".,-~:;=!*#$@"[N > 0 ? N : 0];
                    }
                }
            }
            Console.Write("\u001b[H");

            for (var k = 0; k < 1761; k++)
                Console.Write(k % 80 > 0 ? b[k] : (char)10);

            A += 0.04;
            B += 0.02;
        }
    }
}