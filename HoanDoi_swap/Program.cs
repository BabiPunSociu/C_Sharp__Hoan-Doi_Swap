using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoanDoi_swap
{
    class HoanDoi
    {
        
        public static void Main(string[] args)
        {
            int a1 = 5, b1 = 10;
            Console.WriteLine("Ban đầu: a = " + a1 + "\tb = " + b1);

            // Swap sử dụng biến trung gian
            
            Swap_Fake_Real.SwapFake(a1, b1);
            Console.WriteLine("SwapFake: a = " + a1 + "\tb = " + b1);
            Swap_Fake_Real.SwapReally(ref a1, ref b1);                      // Dùng ref hoặc out để truyền tham chiếu
            // Kết thúc...
            Console.WriteLine("SwapReally: a = " + a1 + "\tb = " + b1);

            

            int a2 = 5, b2 = 10;
            Console.WriteLine("Ban đầu: a = " + a2 + "\tb = " + b2);

            // Swap "không" dùng biến trung gian
            a2 = a2 + b2;   // a2 = 5 + 10 = 15
            b2 = a2 - b2;   // b2 = 15 - 10 = 5
            a2 = a2 - b2;   // a2 = 15 - 5 = 10
            // Kết thúc ...
            //  Làm tương tự với *,/ nếu a*b != 0;
            Console.WriteLine("Sau đó: a = " + a2 + "\tb = " + b2);


                /*  CHUỖI Stringgggg    */

            String s1 = "BabiPun", s2 = "Cutesociu";
            Console.WriteLine("Bắt đầu: s1 = "+ s1 +",\ts2 = "+ s2);
            // Bắt đầu
            s1 = s1 + s2;
            s2 = s1.Substring(0, s1.Length - s2.Length);
            s1 = s1.Substring(s2.Length);
            // Kết thúc ...
            Console.WriteLine("Sau đó: s1 = " + s1 + ",\ts2 = " + s2);
        }
    }
}