// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputInt(string letter){

    Console.Write($"Enter {letter}: ");
    return int.Parse(Console.ReadLine());
}

int Degree(int a, int b){

    int c = 1;
    for(int i=1; i <= b; i++){

        c *= a;
    }
    return c; 
}

Console.Clear();
int a = InputInt("A");
int b = InputInt("B");

Console.WriteLine($"{a} в степени {b} = {Degree(a,b)}");