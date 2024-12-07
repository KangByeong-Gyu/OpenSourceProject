using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("연산자 목록을 선택하세요 : ");
            Console.WriteLine("1. 산술 연산자");
            Console.WriteLine("2. 비교 연산자");
            Console.WriteLine("3. 논리 연산자");
            Console.WriteLine("4. 비트 연산자");
            Console.WriteLine("5. 산술 연산자");
            Console.WriteLine("번호를 입력하세요 (1-5):");

            string input = Console.ReadLine();

            if (ValidateInput(input, 1, 5, out int selectedOption))
            {
                Console.WriteLine($"너가 선택한 옵션은 {selectedOption}.");
                // Call appropriate method based on selectedOption
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다. 1~5 사이의 번호를 입력하세요.");
            }
        }

        static bool ValidateInput(string input, int min, int max, out int validatedNumber)
        {
            if (int.TryParse(input, out validatedNumber))
            {
                if (validatedNumber >= min && validatedNumber <= max)
                {
                    return true;
                }
            }
            return false;
        }


        static void ExplainLogicalOperators()
        {
            Console.WriteLine("논리 연산자 : ");
            Console.WriteLine("&& : 논리곱 (AND 조건), ex) true && false is false");
            Console.WriteLine("|| : 논리합 (OR 조건), ex) true || false is true");
            Console.WriteLine("!  : 논리 부정 (NOT 조건), ex) !true is false");
        }

        static void ExplainArithmeticOperators()
        {
            Console.WriteLine("산술 연산자:");
            Console.WriteLine("+ : 더하기, ex) 2 + 3 = 5");
            Console.WriteLine("- : 빼기, ex) 5 - 3 = 2");
            Console.WriteLine("* : 곱하기, ex) 2 * 3 = 6");
            Console.WriteLine("/ : 나누기, ex) 6 / 3 = 2");
            Console.WriteLine("% : 나머지, ex) 5 % 3 = 2");
        }

        static void ExplainBitwiseOperators()
        {
            Console.WriteLine("비트 연산자 : ");
            Console.WriteLine("&  : 논리곱 (AND), ex) 5 & 3 = 1");
            Console.WriteLine("|  : 논리합 (OR), ex) 5 | 3 = 7");
            Console.WriteLine("^  : 배타적 논리합 (XOR), ex) 5 ^ 3 = 6");
            Console.WriteLine("~  : NOT, ex) ~5 = -6");
            Console.WriteLine("<< : 왼쪽 시프트, ex) 5 << 1 = 10");
            Console.WriteLine(">> : 오른쪽 시프트, ex) 5 >> 1 = 2");
        }

        static void ExplainAssignmentOperators()
        {
            Console.WriteLine("할당 연산자 : ");
            Console.WriteLine("=  : 단순 할당, ex) x = 5 assigns 5 to x");
            Console.WriteLine("+= : 더하기 할당, ex) x += 3 is equivalent to x = x + 3");
            Console.WriteLine("-= : 빼기 할당, ex) x -= 2 is equivalent to x = x - 2");
            Console.WriteLine("*= : 곱하기 할당, ex) x *= 4 is equivalent to x = x * 4");
            Console.WriteLine("/= : 나누기 할당, ex) x /= 2 is equivalent to x = x / 2");
        }
    }
}
