while (true)
{
    Console.WriteLine("Що саме ви хочете зробити:\n віднімання '-' чи додавання '+'\n або ділення '/' або '*' ");

    string symbol = Console.ReadLine();

    if (symbol == "+")
    {
        Console.WriteLine("Введи перше число");


        int number1 = Convert.ToInt32(Console.ReadLine());
        //Конвертируем число ля возмодности использования ред лайна 

        Console.WriteLine("Введи друге число");


        int number2 = Convert.ToInt32(Console.ReadLine());
        // такойже принцып как и в первом


        Console.WriteLine("Ответ:" + (number1 + number2));
    }
    else if (symbol == "-")
    {
        Console.WriteLine("Введи перше число");


        int number1 = Convert.ToInt32(Console.ReadLine());
        //Конвертируем число ля возмодности использования ред лайна


        Console.WriteLine("Введи друге число");


        int number2 = Convert.ToInt32(Console.ReadLine());
        // такойже принцып как и в первом


        Console.WriteLine("Ответ:" + (number1 - number2));
    }

    else if (symbol == "*")
    {
        Console.WriteLine("Введи перше число");


        int number1 = Convert.ToInt32(Console.ReadLine());
        //Конвертируем число ля возмодности использования ред лайна 

        Console.WriteLine("Введи друге число");


        int number2 = Convert.ToInt32(Console.ReadLine());
        // такойже принцып как и в первом


        Console.WriteLine("Ответ:" + (number1 * number2));
    }
    else if (symbol == "/")
    {
        Console.WriteLine("Введи перше число");


        int number1 = Convert.ToInt32(Console.ReadLine());
        //Конвертируем число ля возмодности использования ред лайна 

        Console.WriteLine("Введи друге число");


        int number2 = Convert.ToInt32(Console.ReadLine());
        // такойже принцып как и в первом


        Console.WriteLine("Ответ:" + (number1 / number2));
    }

}

