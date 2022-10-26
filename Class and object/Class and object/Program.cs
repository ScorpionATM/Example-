Person tom = new Person();  // создание объекта класса Person

// определение класса Person
class Person
{
    public string name = "Undefined";
    public int age;

    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}