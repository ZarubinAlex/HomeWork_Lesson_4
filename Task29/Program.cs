// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputInt(string letter){

    Console.Write($"Enter {letter}: ");
    return int.Parse(Console.ReadLine());
}

int[] GetFillArray(int size){

    int[] arr = new int[size];

    for (int i=0; i < arr.Length; i++){

        arr[i] = new Random().Next(0,101);
    }
    return arr;
}

void PrintArray(int[] arr){

    Console.WriteLine(string.Join(", ", arr));
}

Console.Clear();
int a = InputInt("Size");
int[] arr = GetFillArray(a);

PrintArray(arr);

