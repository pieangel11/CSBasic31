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
        //var something = "아하하";    // var 사용 불가

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

            Console.WriteLine(52);
            // Arithmetic Operator + - * /
            Console.WriteLine(52 + 273);
            // Operator Priority
            Console.WriteLine(5 + 3 * 2);

            Console.WriteLine(10 / 5);
            Console.WriteLine(10 % 5);
            Console.WriteLine(7 % 3);

            // Real Number
            Console.WriteLine(52.273);

            Console.WriteLine(0);
            Console.WriteLine(0.0);

            Console.WriteLine(1.0 + 2.0);
            Console.WriteLine(1.0 - 2.0);
            Console.WriteLine(1.0 * 2.0);

            Console.WriteLine(1.0 / 2.0);
            Console.WriteLine(1 / 2);
            Console.WriteLine(1.0 / 2);     //소수가 나온다.(double이 더 커서 double로 바뀜)
            Console.WriteLine(1 / 2.0);

            Console.WriteLine('A');
            Console.WriteLine('가');
            //Console.WriteLine('AB'); // 문자열 Error
            Console.WriteLine("AB"); // 문자열 ok

            // Escape Character
            Console.WriteLine("미\t림여자정보\t과학고");
            Console.WriteLine("미림\t여자정보\t과학고");
            Console.WriteLine("미림여\t자정보\t과학고");
            Console.WriteLine("미림여자정보과학고\t안녕");
            Console.WriteLine("\\ 역슬래시 \n 엔터문자 \" 큰따옴표");

            // 문자열 연결 연산자 Concatenation Operator
            Console.WriteLine("A" + "B");
            Console.WriteLine("A" + 1);
            Console.WriteLine(1 + "A");
            Console.WriteLine("1" + "1");
            Console.WriteLine('A' + 'B');       // char 정수타입
            Console.WriteLine('A' - 'B');
            //Console.WriteLine("A" - "B");
            Console.WriteLine("안녕하세요!" [0]);
            Console.WriteLine("안녕하세요!" [1]);
            Console.WriteLine("안녕하세요!" [2]);
            Console.WriteLine("안녕하세요!" [3]);
            // Console.WriteLine("안녕하세요!" [100]);
            //Console.WriteLine("안녕하세요!" [-1]);

            // bool / boolean
            Console.WriteLine(true);
            Console.WriteLine(false);

            // Comparison operator
            // == != > < >= <=
            // => =< <---- no
            Console.WriteLine(62 < 273);

            Console.WriteLine(DateTime.Now.Hour
                < 3 || 8 < DateTime.Now.Hour);
            Console.WriteLine(3 < DateTime.Now.Hour
               && DateTime.Now.Hour < 8);

            // integer overflow
            int a = 2147483647;
            int b = 1;
            Console.WriteLine(a + b);

            double c = 52.263;
            char d = '아';

            // sizeof 연산자
            Console.WriteLine("int:" + sizeof(int));
            Console.WriteLine("long:" + sizeof(long));
            Console.WriteLine("float:" + sizeof(float));
            Console.WriteLine("double:" + sizeof(double));
            Console.WriteLine("char:" + sizeof(char));
            Console.WriteLine("bool:" + sizeof(bool));

            bool TrueOrFalse = true;


            int output = 0;
            output += 52;       // output = output + 52;
            output += 273;
            output += 103;

            Console.WriteLine(output);
            output *= 2;
            Console.WriteLine(output);

            // 문자열 관련 복합 대입 연산자
            String output2 = "Hello ";
            output2 += "World";
            output2 += "!";
            Console.WriteLine(output2);

            // 증감 연산자
            int number = 10;                                // num 출력
            Console.WriteLine(number++); // 11      10
            Console.WriteLine(++number); // 12      12
            Console.WriteLine(number--);   // 11      12
            Console.WriteLine(--number);   // 10      10
            Console.WriteLine(number);     // 10

            number = 10;                                // num 출력
            number++;
            Console.WriteLine(number); // 11      10
            ++number;
            Console.WriteLine(number); // 12      12
            number--;
            Console.WriteLine(number--);   // 11      12
            --number;
            Console.WriteLine(number);   // 10      10
            Console.WriteLine(number);     // 10

            int _int = 273;
            long _long = 624235252342;
            float _float = 52.273F;
            double _double = 52.273;
            char _char = '글';
            string _string = "문자열";
            Console.WriteLine((273).GetType());
            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());
            Console.WriteLine((221111111L).GetType());

            var number3 = 100;
            var number4 = "뮻";        // var은 선언과 동시에 할당을 해야함
            var number5 = 100.0;
            var number6 = 100.0F;

            string input = Console.ReadLine();
            Console.WriteLine("input : " + input);
            /*while(true)
            {
                input = Console.ReadLine();
                if (input != "q")
                {
                    Console.WriteLine(input);
                }
                else
                {
                    break;
                }
            }*/

            // 강제 형변환
            //long longNumber = 2147483647L + 2147483647L;
            long longNumber = 100;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

            // 자동 형변환
            intNumber = 100;
            longNumber = intNumber;
            Console.WriteLine(longNumber);

            //int -> long, float, double;
            // long -> float, double;
            // char ->int, long, float, double

            //Widening Casting 자동 형변환
            // byte -> short -> char -> int -> long -> float -> double

            // Narrowing Casting 강제 형변환
            // double -> float -> long -> int -> char -> short -> byte

            // int.Parse() / long.Parse()
            // float.Parse() / double.Parse()
            string numberString = "52273";
            //intNumber = (int)numberString;
            intNumber = int.Parse(numberString);
            Console.WriteLine(intNumber);
            
            try
            {
                Console.WriteLine(int.Parse("52.273"));
                Console.WriteLine(int.Parse("오십일"));
                Console.WriteLine(int.Parse("Seven"));
            } catch(FormatException e)
            {
                Console.WriteLine("숫자로 변경할 수 없습니다.");

            } catch(Exception e)
            {
                Console.WriteLine("알 수 없는 오류:" + e.Message);
            }

            // 다른 자료형을 문자열로 변환
            Console.WriteLine((10).ToString());
            Console.WriteLine((52.237).ToString());
            Console.WriteLine(('a').ToString());
            Console.WriteLine((true).ToString());
            Console.WriteLine((false).ToString());

            double number2 = 52.273103;
            Console.WriteLine(number2.ToString("0.0"));
            Console.WriteLine(number2.ToString("0.00"));
            Console.WriteLine(number2.ToString("0.00"));
            Console.WriteLine(number2.ToString("0.000"));

            Console.WriteLine(52 + "");
            Console.WriteLine(52 + 3 + "");
            Console.WriteLine("" + 52 + 3);
            Console.WriteLine(52 + "" + 3);

            number = 273;
            string outputA = number + "";
            Console.WriteLine(number);

            char ch = 'a';
            string outputB = ch + "";
            //string outputC = ch;
            //string outputD = 3;
            Console.WriteLine(outputB);

            // string to bool 변환
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("trUe"));
            Console.WriteLine(bool.Parse("False"));
            Console.WriteLine(bool.Parse("false"));

            // 최댓값 최솟값은 상수로!
            Console.WriteLine(-1 * int.MaxValue);
            //Console.WriteLine(-1 * int.MinValue);
            Console.WriteLine(-1L * int.MinValue);

            

        }
    }
}
