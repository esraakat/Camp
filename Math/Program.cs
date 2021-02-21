using System;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortislem = new DortIslem();
            dortislem.Topla(4, 8);
            dortislem.Fark(8, 2);
            dortislem.Topla(-1, -6);
            dortislem.Fark(4, 9);
            dortislem.Carpim(4, 7);
            dortislem.Carpim(-5, 6);
            dortislem.Bolme(9, 2);
            dortislem.Bolme(5, 0);

        }
    }
}
