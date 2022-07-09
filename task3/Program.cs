namespace HomeworkSeminar5
{
    class Task38 // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    {
        public static int[] FillArray(int[] array, int a, int b) // Метод заполняет массив (заданной с консоли длины) случайными числами в диапазоне введеном в консоли (a,b]
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(a, b);
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
        public static int DiffMinMax(int[] array) // Метод находит разницу между максимальным и минимальным элементов массива
        {
            int diff = 0;
            int min = array[1];
            int max = array[1];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }
            diff = max - min;
            return diff;
        }
        public static void Main(string[] args) // // Метод требует ввести в консоли длину массива и диапазон случайных чисел от А до B, обрабатывая исключения, затем задает массив указанной длины, заполняет массив случайными числами в указанном диапазоне, выводит этот массив в консоль, находит разницу между максимальным и минимальным элементов массива и выводит в консоль результат
        {
            try
            {
                Console.Write("Enter array length: ");
                int[] array = new int[Convert.ToInt32(Console.ReadLine())];
                Console.WriteLine("Enter a range of numbers in array from A to B: ");
                Console.Write("A = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("B = ");
                int b = Convert.ToInt32(Console.ReadLine());
                FillArray(array, a, b);
                Console.Write("Array : ");
                PrintArray(array);
                Console.WriteLine();
                Console.WriteLine($"Difference of max value and min value in array : {DiffMinMax(array)} ");
            }
            catch (System.Exception)
            {
                Console.WriteLine("INCORRECT DATA ! Please enter the positive number of array length or do not enter letters!");
            }
        }
    }
}
