//////////////////////////////////////
// Task 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


// void ShowNums(int num)
// {
//     Console.Write(num + " ");
//     if (num > 1) ShowNums(num - 1);
// }

// Console.Write("Input the number <N>: ");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowNums(n);




//////////////////////////////////////
// Task 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


// int ShowNums(int m, int n)
// {
//     if (n != m)
//     {
//         if (n > m) return ShowNums(m, n - 1) + n;
//         else return ShowNums(m - 1, n) + m;
//     }

//     else return m;
// }

// Console.Write("Input the number <N>: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number <M>: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(ShowNums(m, n));



//////////////////////////////////////
// Task 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


// int Akkerman(int m, int n)
// {
//     if (m < 0 || n < 0) return -1;
//     else
//     {
//         if (m == 0) return n + 1;
//         else if (n == 0 && m != 0) return Akkerman(m - 1, 1);
//         else return Akkerman(m - 1, Akkerman(m, n - 1));
//     }
// }

// Console.Write("Input the number <m>: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number <n>: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int result = Akkerman(m, n);
// if (result < 0) Console.WriteLine("Negative value entered");
// else Console.WriteLine(result);