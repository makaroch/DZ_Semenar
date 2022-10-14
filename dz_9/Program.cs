using MyLibrary;
void Task1(){

    /*Задача 64: Задайте значение N. Напишите программу, которая выведет все 
    натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    N = 5 -> "5, 4, 3, 2, 1"
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

    int n = library.MyReadCons();
    Rek1(n);
}
//Task1();
void Rek1(int n){

    if ( n == 0 ) return;
    if ( n == 1 ) Console.Write(n + ". "); // ввывод в конcоль через , в конце .
    else Console.Write(n + ", ");
    Rek1(--n);

}


void Task2(){
    /*
    Задача 66: Задайте значения M и N. Напишите программу, 
    которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30*/

    int max = library.MyReadCons("введите максимальное число");
    int min = library.MyReadCons("введите миниимальное число");

    if (min > max) (min, max) = (max,min);
    int x = Rek2(max,min);
    Console.WriteLine("сумма чисел от миниимального до максимального "+x);

}
 //Task2();
int Rek2(int max, int min){

    if (min == max) return max;
    return min + Rek2(max, ++min); 

} 


void Task3(){
    /*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
    Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29*/

    int m = library.MyReadCons("введите m число");
    int n = library.MyReadCons("введите n число");

    Console.WriteLine( Akkerman(m,n));
}
//Task3();

int Akkerman(int m, int n){// взял обрасцово показательную мат формулу из вики

    if ( m == 0) return n + 1;
    else if ( m != 0 && n == 0) return Akkerman(m-1,1);
    else return Akkerman(m-1,Akkerman(m,n-1));
}