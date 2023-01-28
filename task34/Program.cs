// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Не указан размер массива, сделаем универсальную функцию, пусть пользователь
// задаёт размерность массива

// 1. Функция определения количества чётных чисел в массиве
// 2. Функция генерирования массива
// 3. Функция вывода массива в консоль
// 3. Ввод данных с проверкой
// 4. Демонстрация работы с выводом в консоль

// 1. Функция определения количества чётных чисел в массиве
int CountOddNumbers(int[] array){
    int result = 0;

    for(int i = 0; i < array.Length; i++) {
        if(array[i] % 2 == 0) result++;
    }

    return result;
}

// 2. Функция генерирования массива
int[] GenerateArray(int array_Size) {
    int[] result = new int[array_Size];
    Random tmp = new Random();
    for(int i = 0; i < array_Size; i++) {
        result[i] = tmp.Next(100, 1000);
    }

    return result;
}

// 3. Функция вывода массива в консоль (так сделал, чтобы с функциями разными поиграться)
string ArrayToString(int[] array) {
    string result = String.Empty;
    result = ($"[{array[0]}");
    for(int i = 1; i < array.Length; i++) {
        result += ", " + array[i];
    }
    result += ("]");
    return result;
}

// 4. Ввод данных с проверкой
string exit_condition = String.Empty;
while(exit_condition != "n") {
System.Console.WriteLine("Введите размерность массива, программа покажет количество чётных чисел в массиве.");
int array_Size;
while(!int.TryParse(Console.ReadLine(), out array_Size)) {
    System.Console.WriteLine("Введите число: ");
}

// 5. Демонстрация работы с выводом в консоль
int[] array = GenerateArray(array_Size);
System.Console.WriteLine("Количество чётных элементов в массиве " + ArrayToString(array) + " равно: " + CountOddNumbers(array));

// 6. Немного интерфейса))
System.Console.Write("Хотите сделать это ещё раз? y / n  ");
exit_condition = Console.ReadLine() ?? string.Empty;
}
System.Console.WriteLine("Благодарим за использование программы!!!");




