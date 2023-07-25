using HomeWork1;
//создаем переменную для поддержания цікла.
bool loop = true;

while (loop)
{
    //создаем 2 переменніе для последующей записи результатов с преобразования inputNumer1, inputNumer2
    double number1, number2;

    Console.Write("Введите первое число(Для завершения напишите Close): ");
    string inputNumber1 = Console.ReadLine();

    //если пользователь ввел слово close программа завершится 
    if (inputNumber1.ToLower() == "close")
    {
        loop = false;
    }

    //проверка на успешное преобразование строки inputNumber1 в дабл. и сохранение результата в number1
    if (double.TryParse(inputNumber1, out number1))
    {
        Console.Write("Хотите ли вы ввести второе число? (yes/no)(Для завершения напишите Close): ");
        string response = Console.ReadLine();

        //если пользователь ввел слово close программа завершится 
        if (response.ToLower() == "close")
        {
            loop = false;
        }

        if (response.ToLower() == "yes")
        {
            Console.Write("Введите второе число(Для завершения напишите Close): ");
            string inputNumber2 = Console.ReadLine();

            //если пользователь ввел слово close программа завершится 
            if (inputNumber2.ToLower() == "close")
            {
                loop = false;
            }

            //проверка на успешное преобразование строки inputNumber2 в дабл. и сохранение результата в number2
            else if (double.TryParse(inputNumber2, out number2))
            {

                Console.WriteLine("Введены числа: " + number1 + " и " + number2);

                //выбор нужной операции
                Console.Write("Введите операцию (+, -, *, /, Для завершения напишите Close): ");
                string operation = Console.ReadLine();


                //создание объекста класса для использования его методов в switch/case.
                Calculator calculator = new Calculator();
                //определяем операцию с помощью switch/case.
                switch (operation.ToLower())
                {
                    case "+":
                        calculator.Add(number1, number2);
                        break;
                    case "-":
                        calculator.Subtract(number1, number2);
                        break;
                    case "*":
                        calculator.Multiply(number1, number2);
                        break;
                    case "/":
                        calculator.Divide(number1, number2);
                        break;
                    case "close":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Некорректная операция попробуйте снова.");
                        break;
                }
            }

            else
            {
                Console.WriteLine($"Некорректный ввод {inputNumber2} не является числом, попробуйте снова.");
            }
        }

        //Если пользователь ввел "no" произойдет вычесление кв. корня 1 числа.
        else if (response.ToLower() == "no")
        {
            Console.WriteLine("Введено только первое число, вычесляем квадратный корень: " + number1);
            Calculator calculator = new Calculator();
            calculator.Sqrt(number1);
        }
        //Если пользоатель ввел некорректный ответ программа начнется сначала.
        else
        {
            Console.WriteLine($"Ответ ({response}) некрректный. Ответ должен содержать слово yes or no. Попробуйте снова.");
        }

    }
    //проверяет является ли 1 ввод числом.
    else
    {
        Console.WriteLine($"Некорректный ввод {inputNumber1} не является числом, попробуйте снова.");
    }
}

