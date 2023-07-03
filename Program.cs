Console.WriteLine("Выберите опцию:");
Console.WriteLine("1. Первое задание");//Напишите программу, которая из списка находит наибольшее значение.
Console.WriteLine("2. Второе задание");//Напишите программу, которая разделяет список чисел на три списка: положительные, отрицательные, нули
Console.WriteLine("3. Третье задание");
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
    case "3":
        Console.WriteLine("Вы выбрали решение для третьего задания ");
        // TODO
        //Напишите программу на языке программирования, используя концепции ООП, для моделирования простого банка. Ваша программа должна поддерживать следующие операции:Создание нового банковского аккаунта с указанием имени владельца и начальным балансом.
        //Перевод денежных средств между двумя банковскими аккаунтами.
        //Получение баланса банковского аккаунта.
        //Вывод списка всех банковских аккаунтов.
        //Для выполнения этого задания необходимо создать следующие классы:
        //Класс BankAccount, который будет представлять банковский аккаунт, имеющий свойства имя владельца и баланс.
        //Класс Bank, который будет представлять банк, имеющий свойство список банковских аккаунтов.
        //Класс BankTransaction, который будет представлять транзакцию между двумя банковскими аккаунтами, имеющий свойства отправитель, получатель и сумма.
        //В программе должны быть реализованы методы для каждой из перечисленных выше операций, а также для добавления новых банковских аккаунтов и транзакций.
        break;
    default:
        Console.WriteLine("Ошибка: неверный выбор");
        break;
}


