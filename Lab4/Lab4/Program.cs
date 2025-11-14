//Лабораторная работа 4, Одномерные массивы, 29 Вариант, Средний уровень
//int[] mas = new int[10];
//Random r = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = r.Next(1, 100);
//}
//int sum = 0;
//foreach (int item in mas)
//{
//    sum += item;
//}
//int average = sum / mas.Length;
//int moreAverage = 0;
//foreach (int item in mas)
//{
//    if (item > average)
//    {
//        moreAverage++;
//    }
//}
//double procent = (double)moreAverage / mas.Length * 100;
//Console.WriteLine($"Процент чисел, превышающих среднее: {procent:F2} %");

//Двумерные массивы, 9 Вариант, Базовый уровень
//     int[,] array = new int[5, 6];   
//     Random rand = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rand.Next(10);
//             Console.Write(array[i, j] + " ");
//         }

//         int rows = array.GetLength(0);
//     int cols = array.GetLength(1);

//     // Вычисление среднего арифметического каждого столбца
//     Console.WriteLine("Среднее арифметическое каждого столбца:");
//     for (int col = 0; col < cols; col++)
//     {
//         double sum = 0;
//         for (int row = 0; row < rows; row++)
//         {
//             sum += array[row, col];
//         }
//         double average = sum / rows;
//         Console.WriteLine($"Столбец {col + 1}: {average:F2}");
//     }

//     Console.WriteLine();

//     // Поиск максимума и минимума в каждой строке
//     for (int row = 0; row < rows; row++)
//     {
//         int max = array[row, 0];
//         int min = array[row, 0];
//         for (int col = 1; col < cols; col++)
//         {
//             if (array[row, col] > max)
//                 max = array[row, col];
//             if (array[row, col] < min)
//                 min = array[row, col];
//         }
//         Console.WriteLine($"Строка {row + 1} - Максимум: {max}, Минимум: {min}");
//     }
// }
