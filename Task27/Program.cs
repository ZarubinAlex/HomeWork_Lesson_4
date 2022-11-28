// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string InputString(string letter){

    Console.Write($"Enter {letter}: ");
    return Console.ReadLine();
}

int Summ(string a){

    int sum = 0;

    for (int i=0; i < a.Length; i++){
        sum+= (a[i]-'0');
    }

    return sum;
}

Console.Clear();
string a = InputString("A");

Console.WriteLine($"{a} -> {Summ(a)}");
