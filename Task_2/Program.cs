//Sarcina: 1) craate masiv bidimensiomal din int Random,  
//2) de gasit numere "interesante" suma cifrelor carora este para

// int[,] CreateMatrix(int rowsCount, int columnsCount)
// {
//     int[,] matrix = new int[rowsCount, columnsCount];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 1000);
//         }
//     }
//     return matrix;
// }

// void ShowMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] matrix = CreateMatrix(3, 4);
// ShowMatrix(matrix);
// Console.WriteLine();

// foreach (int e in matrix)
// {
//     if (Isiteresting(e) == true)
//     {
//         Console.Write($"{e} ");
//     }
// }
// bool Isiteresting(int value)
// {
//     int sumOfDigits = GetSumOfGigit(value);
//     if (sumOfDigits % 2 == 0)
//     {
//         return true;
//     }
//     return false;
// }

// int GetSumOfGigit(int value)
// {
//     int sum = 0;
//     while (value > 0)
//     {
//         sum = sum + value % 10;
//         value = value / 10;
//     }
//     return sum;
// }



// Console.WriteLine("Hello, World!");
