﻿int SetArraySize() {
    Console.WriteLine("Введите размер массива");
    int mySize = Int32.Parse(Console.ReadLine());
    return mySize;
}

int [] CreateArray(int mySize) {
    int [] myArray = new int [mySize];
    Random myRandom = new Random();
    for (int i = 0; i < mySize; i++) {
        myArray[i] = myRandom.Next(100, 1000);
    }
    return myArray;
}

void PrintArray(int[] arr) {
    Console.WriteLine("");
    foreach(int e in arr) {
        Console.Write($"{e}  ");
    }
}

void CountEven(int[] arr) {
    int sum = 0;
    foreach(int e in arr) {
        if (e % 2 == 0) sum++;
    }
    Console.WriteLine("");
    Console.WriteLine($"Сумма чётных элементов в массиве: {sum}");
}


int [] array = CreateArray(SetArraySize());
PrintArray(array);
CountEven(array);