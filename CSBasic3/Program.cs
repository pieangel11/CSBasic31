using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSBasic3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 52, 172, 13, 13, 103 };
            intArray[2] = 0;
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
            Console.WriteLine(intArray[4]);
            Console.WriteLine(intArray.Length);

            int[] intArray2 = new int[1000];
            Console.WriteLine(intArray2[0]);
            Console.WriteLine(intArray2[999]);

            int i = 0;
            int[] intArray3 = { 52, 273, 32, 65, 103 };
            while (i < intArray3.Length)
            {
                Console.WriteLine(i + "번째 출력:" + intArray3[i]);
                i++;
            }

            string input;
            do
            {
                Console.Write("입력(exit를 입력하면 종료):");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("go 공지사항");
                        break;
                    case "2":
                        Console.WriteLine("go 오늘의 점심");
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다");
                        break;
                }
            } while (input != "exit");

            for (int i2 = '가'; i2 <= '힣'; i2++)
            {
                Console.Write((char)i2);
            }

            for (i = intArray3.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }

            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

            for (i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write('*');
                Console.WriteLine("");
                //Console.Write("\n");
            }
            for (i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                    Console.Write(' ');
                for (int j = 0; j < i + 1; j++)
                    Console.Write('*');
                Console.Write('\n');
            }

            string inputString = "Fontato Tomato";
            inputString.ToUpper();                  // return POTATO TOMATO
            Console.WriteLine(inputString);     //Fotato Tomato
            Console.WriteLine(inputString.ToLower());       // potato tomato
            Console.WriteLine(inputString);             //Fotato Tomato

            string foodString = "감자 고구마 토마토 치킨";
            string[] foods = foodString.Split(new char[] { ' ' });
            foreach (var food in foods)
            {
                Console.WriteLine(food);
            }

            string pathString = "C:\\oraclexe\\app\\oracle\\product\\11.2.0\\server\\bin;;C:\\Program Files (x86)\\Common Files\\Oracle\\Java\\javapath;C:\\Program Files\\MySQL\\MySQL Server 5.7\\bin;%SystemRoot%\\system32;%SystemRoot%;%SystemRoot%\\System32\\Wbem;%SYSTEMROOT%\\System32\\WindowsPowerShell\\v1.0\\;%SYSTEMROOT%\\System32\\OpenSSH\\;C:\\Program Files\\MySQL\\MySQL Server 5.6\\bin;C:\\Program Files\\Java\\jdk1.8.0_201;%JAVA_HOME%\\bin;C:\\Program Files\\nodejs\\;C:\\Program Files\\Git\\cmd;C:\\Program Files\\Microsoft SQL Server\\130\\Tools\\Binn\\;C:\\Program Files\\dotnet\\;C:\\Program Files\\Microsoft SQL Server\\Client SDK\\ODBC\\170\\Tools\\Binn\\";
            string[] paths = pathString.Split(new char[] { ';' });
            foreach (var path in paths)
                Console.WriteLine(path);

            string StrangeInput = " test \n         \n";
            Console.WriteLine("[" + StrangeInput + "]");
            Console.WriteLine("[" + StrangeInput.Trim() + "]");

            string[] foodsArray = { "감자", "고구마", "토마토" };
            Console.WriteLine(string.Join(",", foodsArray));

            
         }
    }
}
