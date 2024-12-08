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
            while (true)
            {
                Console.WriteLine("\n연산자 목록을 선택하세요:");
                Console.WriteLine("1. 산술 연산자");
                Console.WriteLine("2. 비교 연산자");
                Console.WriteLine("3. 논리 연산자");
                Console.WriteLine("4. 비트 연산자");
                Console.WriteLine("5. 할당 연산자");
                Console.WriteLine("0. 종료");
                Console.Write("번호를 입력하세요 (0-5): ");

                string input = Console.ReadLine();

                if (ValidateInput(input, 0, 5, out int selectedOption))
                {
                    if (selectedOption == 0)
                    {
                        Console.WriteLine("프로그램을 종료합니다.");
                        break;
                    }

                    ExecuteSelectedOption(selectedOption);
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 0~5 사이의 번호를 입력하세요.");
                }
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
            validatedNumber = 0;
            return false;
        }

        static void ExecuteSelectedOption(int option)
        {
            switch (option)
            {
                case 1:
                    ExplainArithmeticOperators();
                    break;
                case 2:
                    ExplainComparisonOperators();
                    break;
                case 3:
                    ExplainLogicalOperators();
                    break;
                case 4:
                    ExplainBitwiseOperators();
                    break;
                case 5:
                    ExplainAssignmentOperators();
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    break;
            }
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

        static void ExplainComparisonOperators()
        {
            Console.WriteLine("Comparison Operators:");
            Console.WriteLine("== : 같은지, ex) 5 == 5 is true");
            Console.WriteLine("!= : 다른지, ex) 5 != 3 is true");
            Console.WriteLine("<  : 작은지, ex) 3 < 5 is true");
            Console.WriteLine(">  : 큰지, ex) 5 > 3 is true");
            Console.WriteLine("<= : 작거나 같은지, ex) 5 <= 5 is true");
            Console.WriteLine(">= : 크거나 같은지, ex) 5 >= 3 is true");
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

        static void ExecuteArithmeticOperators()
        {
            int num1 = GetSafeInteger("첫 번째 숫자를 입력하세요: ");
            int num2 = GetSafeInteger("두 번째 숫자를 입력하세요: ");

            Console.WriteLine("\n산술 연산 결과:");
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
        }

        static void ExecuteComparisonOperators()
        {
            int num1 = GetSafeInteger("첫 번째 숫자를 입력하세요: ");
            int num2 = GetSafeInteger("두 번째 숫자를 입력하세요: ");

            Console.WriteLine("\n비교 연산 결과:");
            Console.WriteLine($"{num1} == {num2}: {num1 == num2}");
            Console.WriteLine($"{num1} != {num2}: {num1 != num2}");
            Console.WriteLine($"{num1} < {num2}: {num1 < num2}");
            Console.WriteLine($"{num1} > {num2}: {num1 > num2}");
            Console.WriteLine($"{num1} <= {num2}: {num1 <= num2}");
            Console.WriteLine($"{num1} >= {num2}: {num1 >= num2}");
        }

        static void ExecuteLogicalOperators()
        {
            bool val1 = GetSafeBoolean("첫 번째 논리값을 입력하세요 (true/false): ");
            bool val2 = GetSafeBoolean("두 번째 논리값을 입력하세요 (true/false): ");

            Console.WriteLine("\n논리 연산 결과:");
            Console.WriteLine($"{val1} && {val2}: {val1 && val2}");
            Console.WriteLine($"{val1} || {val2}: {val1 || val2}");
            Console.WriteLine($"!{val1}: {!val1}");
        }

        static int GetSafeInteger(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 숫자를 입력하세요.");
                }
            }
        }

        static bool GetSafeBoolean(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (bool.TryParse(input, out bool result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. true 또는 false를 입력하세요.");
                }
            }
        }
    }
}
