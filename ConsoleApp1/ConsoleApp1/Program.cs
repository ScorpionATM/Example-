//  1 Metod
//void SayHelloRu()
//{
//    Console.WriteLine("Привет");
//}
//void SayHelloEn()
//{
//    Console.WriteLine("Hello");
//}
//void SayHelloFr()
//{
//    Console.WriteLine("Salut");
//}

//Console.WriteLine("Tilni tanlang en, ru, fr: ");
//string language = Console.ReadLine();

//switch (language)
//{
//    case "en":
//        SayHelloEn();
//        break;
//    case "ru":
//        SayHelloRu();
//        break;
//    case "fr":
//        SayHelloFr();
//        break;
//}

//void Sum(int x, int y)
//{
//    int resilt = x + y; 
//    Console.WriteLine(resilt);  
//}

//Sum(12, 13);

//void PrintPerson(string name, int age)
//{
//    if (age > 120 || age < 1)
//    {
//        Console.WriteLine("Недопустимый возраст");
//        return;
//    }
//    Console.WriteLine($"Имя: {name}  Возраст: {age}");
//}

//PrintPerson("Tom", 37);         
//PrintPerson("Dunkan", 1234);  

//void Compare(int[] numbers1, int[] numbers2)
//{
//    int numbers1Sum = 0;
//    int numbers2Sum = 0;

//    foreach (int number in numbers1)
//        numbers1Sum += number;

//    foreach (int number in numbers2)
//        numbers2Sum += number;

//    if (numbers1Sum > numbers2Sum)
//        Console.WriteLine("сумма чисел из массива numbers1 больше");
//    else
//        Console.WriteLine("сумма чисел из массива numbers2 больше");
//}

//int[] numbers1 = { 1, 2, 3 };
//int[] numbers2 = { 3, 4, 5, 6, 7 };

//Compare(numbers1, numbers2);

//void Compare(int[] numbers1, int[] numbers2)
//{
//    int numbers1Sum = Sum(numbers1);
//    int numbers2Sum = Sum(numbers2);

//    if (numbers1Sum > numbers2Sum)
//        Console.WriteLine("сумма чисел из массива numbers1 больше");
//    else
//        Console.WriteLine("сумма чисел из массива numbers2 больше");

//    int Sum(int[] numbers)
//    {
//        int result = 0;
//        foreach (int number in numbers)
//            result += number;
//        return result;
//    }
//}

//int[] numbers1 = { 1, 2, 3 };
//int[] numbers2 = { 3, 4, 5, 6, 7 };

//Compare(numbers1, numbers2);

//int Sum(int[] numbers)
//{
//    int limit = 0;
//    int result = 0;
//    foreach (int number in numbers)
//    {
//        if (IsPassed(number)) result += number;
//    }
//    return result;

//    bool IsPassed(int number)
//    {
//        return number > limit;
//    }
//}

//int[] numbers1 = { -3, -2, -1, 0, 1, 2, 3 };
//int[] numbers2 = { 3, -4, 5, -6, 7 };

//Console.WriteLine(Sum(numbers1));
//Console.WriteLine(Sum(numbers2));

//DayTime now = DayTime.Evening;

//PrintMessage(now);                   // Добрый вечер
//PrintMessage(DayTime.Afternoon);    // Добрый день
//PrintMessage(DayTime.Night);        // Доброй ночи

//void PrintMessage(DayTime dayTime)
//{
//    switch (dayTime)
//    {
//        case DayTime.Morning:
//            Console.WriteLine("Доброе утро");
//            break;
//        case DayTime.Afternoon:
//            Console.WriteLine("Добрый день");
//            break;
//        case DayTime.Evening:
//            Console.WriteLine("Добрый вечер");
//            break;
//        case DayTime.Night:
//            Console.WriteLine("Доброй ночи");
//            break;
//    }
//}
//enum DayTime
//{
//    Morning,
//    Afternoon,
//    Evening,
//    Night,
//}

DoOperation(10, 5, Operation.Add);          // 15
DoOperation(10, 5, Operation.Subtract);     // 5
DoOperation(10, 5, Operation.Multiply);     // 50
DoOperation(10, 5, Operation.Divide);       // 2

void DoOperation(double x, double y, Operation op)
{
    double result = op switch
    {
        Operation.Add => x + y,
        Operation.Subtract => x - y,
        Operation.Multiply => x * y,
        Operation.Divide => x / y
    };
    Console.WriteLine(result);
}
enum Operation
{
    Add,
    Subtract,
    Multiply,
    Divide
}