using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic31
{
    class Program
    {
        string Var = "테스트";

        static void Main(string[] args)
        {
            var name = "김" + "태" + "영";
            Console.Write("개행이 안되는 녀석");
            Console.WriteLine("개행이 되는 녀석");

            var alpha = "알파";
            //var 273alpha = "숫자이름";
            var 한글변수명 = "된당";
            //string 😊 = "이모지는 안된다";

            // 인라인 주석
            /*
             여러줄 주석
             */

            // 출력
            Console.Write("개행이 안되는 출력");
            Console.WriteLine("");
            Console.WriteLine("개행이 되는 출력");
        }
    }
}
