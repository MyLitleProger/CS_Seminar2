Console.Clear();
restart:
Console.Write("Что бы запустить какую то конкретную задау введите номер этой задачи то 9 до 16 и доп задание под номером 17: ");
int Task = int.Parse(Console.ReadLine());

switch(Task){
    case 9:
    /*  Задача 9: Напишите программу, которая выводит случайное число 
        из отрезка [10, 99] и показывает наибольшую цифру числа.
                        78 -> 8
                        12 -> 2
                        85 -> 8                                               */

        int n9 = new Random().Next(10, 100);
        Console.WriteLine($"Случайное число: {n9}");

        int nn1 = n9 / 10;
        int nn3 = n9 % 10;
        Console.WriteLine(nn1 * 10 + nn3);
    break;
    case 10:                                                                        
        /*  Задача 10: Напишите программу, которая принимает на вход               <==========
            трёхзначное число и на выходе показывает вторую цифру этого
            числа.
                        456 -> 5
                        782 -> 8
                        918 -> 1                                              */

        quest10:
        Console.Write("Введите любое трехзначное число: ");
        int n10 = int.Parse(Console.ReadLine());
        if (n10 > 99 && n10 < 1000){
            int num10 = (n10 / 10) % 10;
            Console.WriteLine($"Вторая цифра этого числа: {num10}");
        }
        else{
            Console.WriteLine("Введите корректное значение от 100 до 999");
            goto quest10;
        }
    break;
    case 11:
        /*  Задача 11: Напишите программу, которая выводит случайное
            трехзначное число и удаляет вторую цифру этого числа
                        456 -> 46
                        782 -> 72
                        918 -> 98                                             */

        int n11 = new Random().Next(100, 1000);
        Console.WriteLine($"Случайное число: {n11}");
        int nn11 = n11 / 100;
        int nn13 = n11 % 10;
        Console.WriteLine((nn11*10) + nn13);
    break;
    case 12:
        /*Задача 12: Напишите программу, которая будет принимать 
        на вход два числа и выводить, является ли второе число 
        кратным первому. Если число 2 не кратно числу 1, то 
        программа выводит остаток от деления
                        34, 5 -> не кратно, остаток 4
                        16, 4 -> кратно                                       */

        Console.WriteLine("Введите первое число:");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int n2 = int.Parse(Console.ReadLine());

        if (n2 % n1 == 0) Console.WriteLine($"{n1}, {n2} -> кратно");
        else Console.WriteLine($"{n1}, {n2} -> не кратно, остаток {n1%n2}");
    break;
    case 13:
        /*  Задача 13: Напишите программу, которая выводит третью цифру         <=========
            заданного числа или сообщает, что третьей цифры нет.
            (НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК И МАССИВЫ)

                    645 -> 5
                    78 -> третьей цифры нет
                    326791 -> 6                                              */

        Console.Write("Введите любое число: ");
        int n13 = int.Parse(Console.ReadLine());
        int number = Math.Abs(n13);
        if (n13 < 100 && n13 > -100){
            Console.WriteLine($"В числе нет третьей цифры!");
            break;
        }
        while (number > 1000){
            number = number / 10;
            Console.WriteLine($"число = {number}");
        }
        Console.WriteLine($"Третья цифра числа = {number % 10}");
    break;
    case 14:
        /*  Задача 14: Напишите программу, которая принимает на вход 
            число и проверяет, кратно ли оно одновременно 7 и 23
                    14 -> нет
                    46 -> нет
                    161 -> да                                                 */

        Console.WriteLine("Введите любое число:");
        int m1 = int.Parse(Console.ReadLine());

        if (m1%7==0 && m1%23==0) Console.WriteLine($"{m1}-> Да");
         else Console.WriteLine($"{m1}-> Нет");
    break;
    case 15:
        /*  Задача 15: Напишите программу, которая принимает на вход            <========
            цифру, обозначающую день недели, и проверяет, является
            ли этот день выходным.

                    6 -> да
                    7 -> да
                    1 -> нет                                                  */

        quest15:
        Console.Write("Введите любое число обозначающее день недели: ");
        int num_day = int.Parse(Console.ReadLine());
        if (num_day >= 1 && num_day <= 7){
            switch(num_day){
            case 1:
            Console.Write("1 -> Нет");
            break;
            case 2:
            Console.Write("2 -> Нет");
            break;
            case 3:
            Console.Write("3 -> Нет");
            break;
            case 4:
            Console.Write("4 -> Нет");
            break;
            case 5:
            Console.Write("5 -> Нет");
            break;
            case 6:
            Console.Write("6 -> Да");
            break;
            case 7:
            Console.Write("7 -> Да");
            break;
        }
        }
        else {
            Console.Write("Введите коректное значение"); 
            goto quest15;
        }
    break;
    case 16:
        /*Задача 16: Напишите программу, которая принимает на вход
         два числа и проверяет, является ли одно число квадратом другого.
                    5, 25 -> да 
                    -4, 16 -> да 
                    25, 5 -> да 
                    8, 9 -> нет                                */

        Console.WriteLine("Введите первое число:");
        int g1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int g2 = int.Parse(Console.ReadLine());

        if (g1 == g2*g2 || g2 == g1*g1) Console.WriteLine($"{g1}, {g2} -> Да");
        else Console.WriteLine($"{g1}, {g2} -> Нет");

    break;
    case 17:
    /*Задана последовательность натуральных чисел, завершающаяся              <========
      числом 0. Требуется определить значение второго по величине
      элемента в этой последовательности, то есть элемента, который
      будет наибольшим, если из последовательности удалить
      наибольший элемент.*/
        Console.Write("Введите ваше число: ");
        int n17 = Convert.ToInt32(Console.ReadLine());
        int first = int.MinValue;
        int second = int.MinValue;
        while (n17 != 0)
        {
            n17 = Convert.ToInt32(Console.ReadLine());
            if (n17 > second){
                second = first;
                first = n17;
            }
        }
        Console.Write($"Второе по величине число = {second}");
    break;
    default:
        Console.WriteLine("Введите корректное значение от 9 до 17");
    goto restart;
}