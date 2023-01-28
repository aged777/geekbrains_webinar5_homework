// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 2 22 78] -> 76

// Не указан размер массива, сделаем универсальную функцию, пусть пользователь
// задаёт размерность массива

// 1. Функция нахождения разницы между максимальным и минимальным элементами массива.
// 2. Функция генерирования массива
// 3. Функция вывода массива в консоль
// 3. Ввод данных с проверкой
// 4. Демонстрация работы с выводом в консоль

// 1. Функция нахождения разницы между максимальным и минимальным элементами массива.
double CountDiffBetweenMaxAndMin(double[] array){
    double result = 0;
    result = Math.Round(max(array) - min(array), 2);
    return result;

    double max(double[] array) {
        double max = array[0];
        for(int i = 1; i < array.Length; i++) {
            if(max < array[i]) max = array[i];
        }
        return max;
    }

    double min(double[] array) {
        double min = array[0];
        for(int i = 1; i < array.Length; i++) {
            if(min > array[i]) min = array[i];
        }
        return min;
    }
}

// 2. Функция генерирования массива
double[] GenerateArray(int array_Size) {
    double[] result = new double[array_Size];
    Random tmp = new Random();
    for(int i = 0; i < array_Size; i++) {
        result[i] = Math.Round(tmp.NextDouble()*100, 2); // ограничил для удобства
    }

    return result;
}

// 3. Функция вывода массива в консоль (так сделал, чтобы с функциями разными поиграться)
string ArrayToString(double[] array) {
    string result = String.Empty;
    result = ($"[{array[0]}");
    for(int i = 1; i < array.Length; i++) {
        result += "  " + array[i];
    }
    result += ("]");
    return result;
}

// 4. Ввод данных с проверкой
string exit_condition = String.Empty;
while(exit_condition != "n") {
System.Console.WriteLine("Введите размерность массива, программа найдёт разницу между максимальным и минимальным элементами массива.");
int array_Size;
while(!int.TryParse(Console.ReadLine(), out array_Size)) {
    System.Console.WriteLine("Введите число: ");
}

// 5. Демонстрация работы с выводом в консоль
double[] array = GenerateArray(array_Size);
System.Console.WriteLine("Разница между максимальным и минимальным элементами массива " + ArrayToString(array) + " равна: " + CountDiffBetweenMaxAndMin(array));

// 6. Немного интерфейса))
System.Console.Write("Хотите сделать это ещё раз? y / n  ");
exit_condition = Console.ReadLine() ?? string.Empty;
}
System.Console.WriteLine("Благодарим за использование программы!!!");