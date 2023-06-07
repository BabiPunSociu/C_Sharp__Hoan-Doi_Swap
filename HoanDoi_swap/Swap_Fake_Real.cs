using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoanDoi_swap
{
    internal class Swap_Fake_Real
    {
        //Không sử dụng ref
        public static void SwapFake(int a, int b)
        {
            int tg = a;
            a = b;
            b = tg;
        }
        //Sử dụng ref cho tham số
        public static void SwapReally(ref int a, ref int b)
        {
            int tg = a;
            a = b;
            b = tg;
        }
    }
}
