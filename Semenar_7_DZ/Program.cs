using MyLibrary;

void Task47(){
    /*Задача 47. Задайте двумерный массив размером m×n, 
    заполненный случайными вещественными числами.
    m = 3, n = 4.
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9*/
    Console.WriteLine("Задача 47. Задайте двумерный массив размером m на n, заполненный случайными вещественными числами.");
    double[,] arr = library.MyCreateTwoDimensionalArray(4,5,10.0); //создает 2-мерный массив принимает 3 значения int и 1 double ;
                                                                  // кол-во строк, кол-во столбцов  по умолчанию равны 5;
                                                                //  double коэф на который умножаем NextDouble() и степень округлеия после ","
    library.MyLookTwoDimensionalArray(arr); // вывод в консоль 2-мерный массив
    // закин сюда чтобы не искали по файлам 
    /*public static double[,] MyCreateTwoDimensionalArray(int row = 5, int col = 5, 
                                                            double fractionСoef = 10, int rounding = 2){
            double[,] arr = new double[row,col];
            Random random = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i,j] = Math.Round(random.NextDouble() * fractionСoef , rounding);
                }
            }
            return arr;
        } */

}
//Task47();

void Task50() {
    /*
    Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
    и возвращает значение этого элемента или же указание, что такого элемента нет.
    Например, задан массив: 
    **Решил искать введеное пользывателем число если есть в массиве написать что есть если нет то нписать что нет**
    1 4 7 2
    5 9 2 3
    8 4 2 4
    17 -> такого числа в массиве нет*/
        Console.WriteLine(" Задача 50. Напишите программу, которая на вход принимает число и ищет его в масиве если число есть вывести что оно есть иначе вывести что его нет");
    int[,] arr = library.MyCreateTwoDimensionalArray(maxValue:100); // создает 2-мерный массив принимает 4 значения int ;
                                                                  // кол-во строк, кол-во столбцов  по умолчанию равны 5;
                                                                //  минимальное и максимальное значение для рандома  по умолчанию равны 0 и 100;
    library.MyLookTwoDimensionalArray(arr); // вывод в консоль 2-мерный массив

    int x = library.MyReadCons("введите число которое ищем в массиве"); // выодит в косоль сообщение о вводе числа, конвертит и записывает  его в  int 
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    
    bool flag = false;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (arr[i,j] == x) {
                    flag = true;
                    j = col;  // при нахождении нужного элемента завершит прокрутку массива
                    i = row;
                }
            }
        }
    if (flag) Console.WriteLine("Указанное число есть");
    else Console.WriteLine("Указанного числа нет");
    
}
//Task50();

void Task52() {
    /*Задача 52. Задайте двумерный массив из целых чисел. 
    Найдите среднее арифметическое элементов в каждом столбце.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
    Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. айдите среднее арифметическое элементов в каждом столбце.");
    int[,] arr = library.MyCreateTwoDimensionalArray(row: 5, col: 7,maxValue:10); // создает 2-мерный массив принимает 4 значения int ;
                                                                  // кол-во строк, кол-во столбцов  по умолчанию равны 5;
                                                                //  минимальное и максимальное значение для рандома  по умолчанию равны 0 и 100;
    library.MyLookTwoDimensionalArray(arr); // вывод в консоль 2-мерный массив

    int row = arr.GetLength(0);
    int col = arr.GetLength(1);

    double sum = 0;
    double[] sumArray = new double[col]; // новый массив для записи результата 

    for (int i = 0; i < col; i++)
    {
        sum = 0;
        for (int j = 0; j < row; j++)
        {
           sum+=arr[j,i];
        }
        sumArray[i] = Math.Round((sum/row),2);
    }
    Console.WriteLine("ввывод среднего арифметического значения элементов в каждом столбце");
    library.MyLookArray(sumArray);// выводит одномерный массив в консоль
  
}
//Task52();

void Menu(){
    int num = library.MyReadCons("Выберите задачу, которую хотите решить:\n\t1 - Задача 47 \n\t2 - Задача 50 \n\t3 - Задача 52 \n\t0 - Выход");

    switch(num){
        case 1:
        Task47();
        Menu();
        break;

        case 2:
        Task50();
        Menu();
        break;

        case 3:
        Task52();
        Menu();
        break;

        case 0:
        Environment.Exit(0);
        break;

        default:
        Console.WriteLine("ошибка");
        break;
}


}
Menu();