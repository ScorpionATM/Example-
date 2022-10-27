//Person tom = new Person();
//tom.name = "tom";
//tom.Print();

//Person tom = new Person();

//tom.Print();

//class Person
//{
//    public string Name; 
//    public int Age;

//    public Person()
//    {
//        Name = "Ahrorbek";
//        Age = 20;
//    }
//    public void Print()
//    {
//        Console.WriteLine($"{Name} {Age}");
//    }
//}


//Person tom = new Person();
//Person sam = new Person("sam");
//Person jeck = new Person("jeck", 88);

//tom.Print();
//sam.Print();
//jeck.Print();

//class Person
//{
//    public string name;
//    public int age;
//    public Person() { name = "tom"; age = 20; }
//    public Person(string n) { name = n; age = 25; }
//    public Person(string n , int a) { name = n; age = a ; }

//    public void Print()
//    {
//        Console.WriteLine($"{name}  {age}" );
//    }
//}

//Person sam = new("Sam", 25);
//sam.Print();          // Имя: Sam  Возраст: 25

//class Person
//{
//    public string name;
//    public int age;
//    public Person() { name = "Неизвестно"; age = 18; }
//    public Person(string name) { this.name = name; age = 18; }
//    public Person(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }
//    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
//}

//class Person
//{
//    public string name;
//    public int age;
//    public Person() : this("Неизвестно")    // первый конструктор
//    { }
//    public Person(string name) : this(name, 18) // второй конструктор
//    { }
//    public Person(string name, int age)     // третий конструктор
//    {
//        this.name = name;
//        this.age = age;
//    }
//    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
//}


