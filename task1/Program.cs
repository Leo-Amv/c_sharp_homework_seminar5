namespace HomeworkSeminar5
{                // (задаем кол-во чисел в консоли так как в условии не указано)
    class Task34 // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    {
        public static int[] FillArray(int[] array) // Метод заполняет массив (заданной с консоли длины) случайными положительными трехзначными числами [100-1000)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100, 1000);
            }
            return array;
        }
        public static void PrintArray(int[] array) // Метод печатает в консоли все значения массива 
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        public static int CountEvenNumbers(int[] array) // Метод считает кол-во четных чисел в массиве
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) count += 1;
            }
            return count;
        }
        public static void Main(string[] args) // Метод требует ввести в консоли длину массива, обрабатывая исключения, затем задает массив указанной длины, заполняет массив случайными трехзначными числами, выводит этот массив в консоль, подсчитывает кол-во четных чисел и выводит в консоль результат
        {
            try
            {
                Console.Write("Enter array length: ");
                int[] array = new int[Convert.ToInt32(Console.ReadLine())];
                FillArray(array);
                Console.Write("Array: ");
                PrintArray(array);
                Console.WriteLine();
                Console.Write($"Amount of even numbers: {CountEvenNumbers(array)}");
            }
            catch (System.Exception)
            {
                Console.WriteLine("INCORRECT DATA ! Please enter the positive number or do not enter letters!");
            }
        }
    }
}