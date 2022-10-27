// Object and Class 

//class Person
//{
//    public string name = "Undefined";   // имя
//    public int age;                     // возраст

//    public void Print()
//    {
//        Console.WriteLine($"Имя: {name}  Возраст: {age}");
//    }
//}

//Person tom = new Person();  

//string personName = tom.name;
//int personAge = tom.age;
//Console.WriteLine($"Имя: {personName}  Возраст {personAge}");   

//tom.name = "Tom";
//tom.age = 37;
//tom.Print();    

//class Person
//{
//    public string name = "Undefined";
//    public int age;

//    public void Print()
//    {
//        Console.WriteLine($"Имя: {name}  Возраст: {age}");
//    }
//}

//Person tom = new Person();  // создание объекта класса Person
//tom.age = 21;
//tom.name = "Tom";

//tom.Print();

//class Person
//{
//    public string? name;
//    public int age ;

//    public void Print()
//    {
//        Console.WriteLine($"Имя: {name}  Возраст: {age}");
//    }
//}

//Person tom = new Person();
//tom.name = "Tom";
//tom.age = 37;
//tom.Print();    // Person: Tom - 37

//Console.WriteLine(Person.type); // Person
//                                // Person.type = "User";    // !Ошибка: изменить константу нельзя

//class Person
//{
//    public const string type = "Person";
//    public string name = "Undefined";
//    public int age;
//    public void Print() => Console.WriteLine($"{type}: {name} - {age}");
//}