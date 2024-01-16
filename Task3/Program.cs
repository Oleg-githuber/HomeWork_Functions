// В даной программе для наглядности ипользуются однозначные целые числа

// функция задания размера массива
int SetArraySize() {
    Console.WriteLine("Введите размер массива");
    int mySize = Int32.Parse(Console.ReadLine());
    return mySize;
}

// Функция зоздания массива
int [] CreateArray(int mySize) {
    int [] myArray = new int [mySize];
    Random myRandom = new Random();
    for (int i = 0; i < mySize; i++) {
        myArray[i] = myRandom.Next(1, 10);
    }
    return myArray;
}

// Функция вывода массива в консоль
void PrintArray(int[] arr) {
    foreach(int e in arr) {
        Console.Write($"{e}  ");
    }
}

// Функция разворота массива
int [] TurnArray(int [] arr) {
    for (int i = 0; i < (arr.Length / 2); i++) {
        arr[i] += arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i] - arr[arr.Length - 1 - i];
        arr[i] -= arr[arr.Length - 1 - i];
    }
    return arr;
}

int [] array = CreateArray(SetArraySize());
Console.WriteLine("\nМассив до разворота:");
PrintArray(array);
array = TurnArray(array);
Console.WriteLine("\nМассив после разворота:");
PrintArray(array);