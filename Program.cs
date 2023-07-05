Console.WriteLine("Выберите опцию:");
Console.WriteLine("1. Первое задание");//Напишите программу, которая из списка находит наибольшее значение.
Console.WriteLine("2. Второе задание");//Напишите программу, которая разделяет список чисел на три списка: положительные, отрицательные, нули

string choice = Console.ReadLine();
switch (choice)
{
    case "1":
        Console.WriteLine("Вы выбрали решение для первого задания");

        List<int> numbers = new List<int> { 1, 5, 2, 9, 3 };
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine(" ");

        int maxNumber = numbers[0];

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }

        Console.WriteLine("Наибольшее значение: " + maxNumber);
        break;
    case "2":
        Console.WriteLine("Вы выбрали решение для второго задания");
        List<int> digits = new List<int> { 1, -5, 0, 9, -3 };
        for (int i = 0; i < digits.Count; i++)
        {
            int number = digits[i];
            Console.Write(number + " ");
        }
        Console.WriteLine(" ");

        List<int> positiveNumbers = new List<int>();
        List<int> negativeNumbers = new List<int>();
        List<int> zeroNumbers = new List<int>();

        for (int i = 0; i < digits.Count; i++)
        {
            int number = digits[i];
            if (number > 0)
            {
                positiveNumbers.Add(number);
            }
            else
            {
                if (number < 0)
                {
                    negativeNumbers.Add(number);
                }
                else
                {
                    zeroNumbers.Add(number);
                }
            }
        }

        Console.Write("Положительные числа: ");
        for (int i = 0; i < positiveNumbers.Count; i++)
        {
            int number = positiveNumbers[i];
            Console.Write(number + " ");
        }
        Console.WriteLine();

        Console.Write("Отрицательные числа: ");
        for (int i = 0; i < negativeNumbers.Count; i++)
        {
            int number = negativeNumbers[i];
            Console.Write(number + " ");
        }
        Console.WriteLine();

        Console.Write("Нули: ");
        for (int i = 0; i < zeroNumbers.Count; i++)
        {
            int number = zeroNumbers[i];
            Console.Write(number + " ");
        }
        Console.WriteLine();

        Console.ReadLine();
        break;

    default:
        Console.WriteLine("Ошибка: неверный выбор");
        break;
}


