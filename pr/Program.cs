using MyLibrary;

void Task1(){
    /*Задача 54: Задайте двумерный массив. Напишите программу, 
    которая упорядочит по убыванию элементы каждой строки двумерного массива.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    В итоге получается вот такой массив:
    7 4 2 1
    9 5 3 2
    8 4 4 2*/

    Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу,которая упорядочит по убыванию элементы каждой строки двумерного массива.");

    int[,] array = library.MyCreateTwoDimensionalArray(row: 7, maxValue:50);

    library.MyLookTwoDimensionalArray(array);

    OrderArrayTask1(array);// чуть ниже по коду

    library.MyLookTwoDimensionalArray(array);
    
}

void OrderArrayTask1(int[,] arr){

    int row = arr.GetLength(0);
    int col = arr.GetLength(1);


    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < col-1; k++)
            {
                if (arr[i,k] > arr[i,k+1]) (arr[i,k], arr[i,k+1]) = (arr[i,k+1], arr[i,k]);
            }
        }
    }
}

void Task2(){
    /*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
    которая будет находить строку с наименьшей суммой элементов.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Программа считает сумму элементов в каждой строке и выдаёт номер 
    строки с наименьшей суммой элементов: 1 строка*/

    Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");

    int[,] array = library.MyCreateTwoDimensionalArray(row:7, maxValue:10);
    library.MyLookTwoDimensionalArray(array);

    int row = array.GetLength(0);
    int col = array.GetLength(1);

    int sum = 0;
    int sumTemp = 0;

    int numberRow = -1;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            sumTemp += array[i,j];
        }
        if ( sumTemp < sum | sum == 0) {sum = sumTemp; numberRow = i;}
        sumTemp = 0;
    } 

    Console.WriteLine($"строка с наименьшей суммой элемнтов: {numberRow}, сумма элементов равна {sum}");
    
}

void Task3()
{
    /*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

    Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");

    int[,] array1 = library.MyCreateTwoDimensionalArray(row: 5, col: 4, -9, 9);
    int[,] array2 = library.MyCreateTwoDimensionalArray(row: 4, col: 8, -9, 9);

    int colArray1 = array1.GetLength(1);
    int rowArray2 = array2.GetLength(0);

    if (colArray1 == rowArray2)
    {
        Console.WriteLine("первая матрица:");
        library.MyLookTwoDimensionalArray(array1);
        Console.WriteLine();
        Console.WriteLine("вторая матрица:");
        library.MyLookTwoDimensionalArray(array2);

        int[,] array3 = new int[colArray1, colArray1]; 

        for (int i = 0; i < colArray1; i++)
        {
            for (int j = 0; j < colArray1; j++)
            {
                array3[i, j] = array1[i, j] * array2[j, i];
            }
        }
        Console.WriteLine("результат перемножения матриц:");
        library.MyLookTwoDimensionalArray(array3);
    }
    else Console.WriteLine("ошибка, произведение матриц не определено");
}

void Task4(){
    /*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
    Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    Массив размером 2 x 2 x 2
    66(0,0,0) 25(0,1,0)
    34(1,0,0) 41(1,1,0)
    27(0,0,1) 90(0,1,1)
    26(1,0,1) 55(1,1,1)*/

    Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");

    int[,,] array = new int[3,3,3];

    int length0 = array.GetLength(0);
    int length1 = array.GetLength(1);
    int length2 = array.GetLength(2);

    int krakazyabra = 10; //не смог придумать название лучше, в цикле буду евеличивать на 1 тем самым получу неповторяющиеся двузначные чисела

    for (int i = 0; i < length0; i++)
    {
        for (int j = 0; j < length1; j++)
        {
            for (int k = 0; k < length2; k++)
            {
                array[i,j,k] = krakazyabra++;
            }
        }
    }

    for (int i = 0; i < length0; i++)
    {
        for (int j = 0; j < length1; j++)
        {
            for (int k = 0; k < length2; k++)
            {
                Console.WriteLine($"{array[i,j,k]}  ({i},{j},{k})");
            }
            
        }
    }


}

void Task5(){
    /*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07*/

    Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");

    int[,] arr = new int[4,4];

    int row = arr.GetLength(0);
    int col = arr.GetLength(1);

    int i = 0;
    int j = 0;

    int quantityElement = row * col;

    int temp = 1;

    while (temp <= quantityElement)
    {
        arr[i,j] = temp;
        temp++;

        if (i <= j + 1 && i + j < col - 1) j++;
        else if (i < j && i + j >= row - 1) i++;
        else if (j <= i && i + j > col - 1) j--;
        else i-- ;
    }
    library.MyLookTwoDimensionalArray(arr);

}


void Menu(){

    int num = library.MyReadCons("Выберите задачу, которую хотите решить:\n\t1 - Задача 54 \n\t2 - Задача 56 \n\t3 - Задача 58 \n\t4 - Задача 60\n\t5 - Задача 62 \n\t0 - Выход");

    switch(num){
        case 1:
        Task1();
        Menu();
        break;

        case 2:
        Task2();
        Menu();
        break;

        case 3:
        Task3();
        Menu();
        break;

        case 4:
        Task4();
        Menu();
        break;

        case 5:
        Task5();
        Menu();
        break;

        case 0:
        break;

        default:
        Console.WriteLine("eror");
        break;
    }


}
Menu();