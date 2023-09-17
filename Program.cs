
{
    bool showMenu = true;
    while (showMenu)
    {
        showMenu = MainMenu();
    }

    static bool MainMenu()
    {
        //*строчка для очищения программы которую я не могу понять как сделать /нормально/ и нераздражающе*
        Console.WriteLine("Выберите одно из возможных действий данного калькулятора."); //сделано
        Console.WriteLine("1) Сложение двух чисел"); //сделано
        Console.WriteLine("2) Вычитание одного числа из другого"); //сделано
        Console.WriteLine("3) Деление одного числа на другое"); //сделано
        Console.WriteLine("4) Умножение одного числа на другое"); //сделано
        Console.WriteLine("5) Возведение числа в степень"); //сделано
        Console.WriteLine("6) Нахождение квадратного корня из числа"); //сделано
        Console.WriteLine("7) нахождение одного процента из числа"); //сделано
        Console.WriteLine("8) Нахождение факториала из числа"); //сделано
        Console.WriteLine("9) Выход из программы"); //сделано
        Console.WriteLine("Введите цифровое значение операции для ее инициации:");

        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("Введите первое число");
                string snum1 = Console.ReadLine();
                Console.WriteLine("Введите второе число");
                string snum2 = Console.ReadLine();
                if (snum1==string.Empty || snum2 == string.Empty)
                {
                    Console.WriteLine("this is not possible you shite");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                else
                {
                    double num1 = Convert.ToDouble(snum1);
                    double num2 = Convert.ToDouble(snum2);
                    double result1 = num1 + num2;
                    Console.WriteLine("Результат сложения двух веденных чисел равен " + result1);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                return true;

            case "2":
                Console.WriteLine("Введите первое число (уменьшаемое)");
                string snum3 = Console.ReadLine();
                Console.WriteLine("Введите второе число (вычитаемое)");
                string snum4 = Console.ReadLine();
                if (snum3 == string.Empty || snum4 == string.Empty)
                {
                    Console.WriteLine("this is not possible you shite");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                else
                {
                    double num3 = Convert.ToDouble(snum3);
                    double num4 = Convert.ToDouble(snum4);
                    double result2 = num3 - num4;
                    Console.WriteLine("Результат вычитания равен " + result2);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                return true;

            case "3":
                Console.WriteLine("Введите первое число (делимое)");
                string snum5 = Console.ReadLine();
                Console.WriteLine("Введите второе число (делитель)");
                string snum6 = Console.ReadLine();
                if (snum5 == string.Empty || snum6 == string.Empty || snum6 == "0")
                {
                    Console.WriteLine("this is not possible you shite");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                else
                {
                    double num5 = Convert.ToDouble(snum5);
                    double num6 = Convert.ToDouble(snum6);
                    double result3 = num5 / num6;
                    Console.WriteLine("Результат деления равен " + result3);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                return true;

            case "4":
                Console.WriteLine("Введите первое число");
                string snum7 = Console.ReadLine();
                Console.WriteLine("Введите второе число");
                string snum8 = Console.ReadLine();
                if (snum7 == string.Empty || snum8 == string.Empty)
                {
                    Console.WriteLine("this is not possible you shite");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                else
                {
                    double num7 = Convert.ToDouble(snum7);
                    double num8 = Convert.ToDouble(snum8);
                    double result4 = num7 * num8;
                    Console.WriteLine("Результат умножения равен " + result4);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                return true;

            case "5":
                Console.WriteLine("Введите первое число");
                string snum9 = Console.ReadLine();
                Console.WriteLine("Введите второе число (степень)");
                string snum10 = Console.ReadLine();
                if (snum9 == string.Empty || snum10 == string.Empty)
                {
                    Console.WriteLine("this is not possible you shite");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                else
                {
                    double num9 = Convert.ToDouble(snum9);
                    double num10 = Convert.ToDouble(snum10);
                    double result5 = Math.Pow(num9, num10);
                    Console.WriteLine("Результат возведения числа" + num9 + "в" + num10 + "степень равно" + result5);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                return true;

            case "6":
                Console.WriteLine("Введите число под корнем");
                string snum11 = Console.ReadLine();
                
                if (snum11 == string.Empty)
                {
                    Console.WriteLine("this is not possible you shite");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                else
                {
                    double num11 = Convert.ToDouble(snum11);
                    
                    double result6 = Math.Sqrt(num11);
                    Console.WriteLine("Квадратный корень введенного числа равен " + result6);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                return true;

            case "7":
                Console.WriteLine("Введите число");
                string snum12 = Console.ReadLine();

                if (snum12 == string.Empty)
                {
                    Console.WriteLine("this is not possible you shite");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                else
                {
                    double num12 = Convert.ToDouble(snum12);

                    double result7 = num12 / 100;
                    Console.WriteLine("Один процент от введенного числа равен " + result7);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                return true;

            case "8":
                Console.WriteLine("Введите число");
                string snum13 = Console.ReadLine();

                if (snum13 == string.Empty)
                {
                    Console.WriteLine("this is not possible you shite");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

                else
                {
                    long num13 = Convert.ToInt64(snum13);
                    if (num13>20)
                    {
                        Console.WriteLine("Извините, данное число слишком большое для этой программы. ПРиносим свои извинения.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    else
                    {                        
                        long Factorial(long num13)
                        {
                            if (num13 == 1) return 1;
                            return num13 * Factorial(num13 - 1);

                        }
                        long fact13 = Factorial(num13);
                        Console.WriteLine("Факториал введенного числа равен " + fact13);
                        Console.WriteLine("");
                        Console.WriteLine("");

                    }

                }
                return true;

            case "9":
                return false;
                
            default:
                Console.WriteLine("Выберите одну из существующих операций.");
                Console.WriteLine("");
                Console.WriteLine("");
                return true;
        }
    }
}