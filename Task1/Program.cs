// Функция ввода числа из клавиатуры
string EnterString() {
    Console.WriteLine("\nВведите целое число: ");
    return Console.ReadLine();
}

// Функция преобразования строки в целое число
int StringToInteger(string myString) {
    return Int32.Parse(myString);
}

// Функция проверки на чётность суммы цифр
bool IsSumEven(int number) {
    int sum = 0;
    while (number > 0) {
        sum += number % 10;
        number /= 10;
    }
    return (sum % 2 == 0);
}

string numberStr = "a";
int numberInt = -1;
bool isEven = false;
while ((numberStr != "q") && (!isEven)) {
    numberStr = EnterString();
    if (numberStr != "q") {
        numberInt = StringToInteger(numberStr);
        isEven = IsSumEven(numberInt);
    }
}
Console.WriteLine("\nБесконечный цикл завершён!");