// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Не указан размер массива, сделаем универсальную функцию, пусть пользователь
// задаёт размерность массива

// 1. Функция нахождения суммы элементов, стоящих на нечётных позициях.
// 2. Функция генерирования массива
// 3. Функция вывода массива в консоль
// 3. Ввод данных с проверкой
// 4. Демонстрация работы с выводом в консоль

// 1. Функция нахождения суммы элементов, стоящих на нечётных позициях.
int CountSumOddNumbers(int[] array){
    int result = 0;

    for(int i = 1; i < array.Length; i += 2) {
        result += array[i];
    }

    return result;
}

// 2. Функция генерирования массива
int[] GenerateArray(int array_Size) {
    int[] result = new int[array_Size];
    Random tmp = new Random();
    for(int i = 0; i < array_Size; i++) {
        result[i] = tmp.Next(-10, 11);   // так ограничил, чтобы легче было проверять
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
System.Console.WriteLine("Введите размерность массива, программа покажет сумму элементов, стоящих на нечётных позициях массиве.");
int array_Size;
while(!int.TryParse(Console.ReadLine(), out array_Size)) {
    System.Console.WriteLine("Введите число: ");
}

// 5. Демонстрация работы с выводом в консоль
int[] array = GenerateArray(array_Size);
System.Console.WriteLine("Сумма элементов, стоящих на нечётных позициях массиве " + ArrayToString(array) + " равна: " + CountSumOddNumbers(array));

// 6. Немного интерфейса))
System.Console.Write("Хотите сделать это ещё раз? y / n  ");
exit_condition = Console.ReadLine() ?? string.Empty;
}
System.Console.WriteLine("Благодарим за использование программы!!!");






