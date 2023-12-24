// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. Использовать рекурсию, 
// не использовать циклы.

// int startEl = 3;
// int endEl = 10;
// System.Console.WriteLine("Наши числа"+ " "+ startEl+ " " + endEl);


// Printlens(startEl,endEl);

// void Printlens(int startEl, int endEl)
// {
//     System.Console.Write($"{startEl}  ");

//     if(startEl== endEl)
//     {
//         return;
//     }

//     Printlens(startEl+1, endEl);
// }   //готова


// Задача 2: Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.

// int m=3;
// int n =5;

// int Akkerman=Ack(m,n);
// Console.WriteLine($"m равно - {m}");
// Console.WriteLine($"n равно - {n}");
// Console.WriteLine($"Функция Аккермана равна {Akkerman}");
// int Ack(int m, int n)
// {
//     if(m==0) return n+1;
//     else if(n==0) return Ack(m-1,1);
//     else return Ack(m-1, Ack(m, n-1));
// }






// Задача 3: Задайте произвольный массив. Выведите его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

// int[] array = new int[6];

// void PrintArray(int[]arr,int index)
// {
//     if(index== arr.Length)
//     {
//         return;
//     }
//     array[index]=new Random().Next(1,10);
//     Console.Write(arr[index]+ " ");
//     PrintArray(arr,index+1);
// }
// void ReverseArray(int[]arr,int index)
// {
//     if(index==arr.Length)
//     {
//         return;
//     }
//     Console.Write(arr[arr.Length-1-index]+ " ");
//     ReverseArray(arr,index+1);
// }

// PrintArray(array,0);
// Console.WriteLine();
// ReverseArray(array,0);


