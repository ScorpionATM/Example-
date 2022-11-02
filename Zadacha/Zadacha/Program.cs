//Person Ahrorbek = new Person();

//Ahrorbek.Name = "Ahrorbek";
//Ahrorbek.Description = "Ahrorbek";
//Ahrorbek.Address = "Chilonzor";
//Ahrorbek.City = "Tashkent City";
//Ahrorbek.Region = "Tashkent";
//Ahrorbek.PostalCode = "Ahrorbek@gmail.com";
//Ahrorbek.Country = "Uzbekiston";

//Ahrorbek.Print();



//class Person
//{
//    public int Id { get; set; } 
//    public string? Name { get; set; }    
//    public string? Description { get; set; } 
//    public string? Address { get; set; } 
//    public string? City { get; set; }    
//    public string? Region { get; set; }  
//    public string? PostalCode { get; set; }  
//    public string? Country { get; set; } 
//    public void Print()
//    {
//        Console.WriteLine();
//    }
//}


//List<Person> people = new List<Person>()
//{
//    new Person("Tom"),
//    new Person("Bob"),
//    new Person("Sam")
//};

//class Person
//{
//    public string Name { get; }
//    public Person(string name) => Name = name;
//}



//var people = new List<string>() { "Tom", "Bob", "Sam" };

//people[0] = "Mike";     // изменяем первый элемент
//foreach(var person in people)
//{
//    Console.WriteLine(person);
//}

//var people = new List<string>() { "Tom", "Bob", "Sam" };

//for (int i = 0; i < people.Count; i++)
//{
//    Console.WriteLine(people[i]);
//}


//List<string> people = new List<string>() {"Tom"};
//people.Add("Abdulla");
//people.AddRange(people);
//people.Insert(0, "Najm");
//people.InsertRange(0, people);

//foreach(var item in people)
//{
//    Console.WriteLine(item);
//}

//var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };

//people.RemoveAt(0);

//people.Remove("Tom"); 

//people.RemoveAll(person => person.Length == 3);

//people.RemoveRange(1, 2);

//people.Clear();

//foreach (var person in people)
//{
//    Console.WriteLine(person);  
//}

//var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam" };


//Console.WriteLine(people.Find(p => p.Length == 3));

//var containsBob = people.Contains("Bob");     //  true
//var containsBill = people.Contains("Bill");    // false

//var existsLength3 = people.Exists(p => p.Length == 3);  // true

//var existsLength7 = people.Exists(p => p.Length == 7);  // false

//var firstWithLength3 = people.Find(p => p.Length == 3); // Tom

//var lastWithLength3 = people.FindLast(p => p.Length == 3);  // Sam

//List<string> peopleWithLength3 = people.FindAll(p => p.Length == 3);


//List<string> people = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };

//people.Reverse();

//Console.WriteLine(people);

// Shuni organish  ////////////

//var employees = new List<string> { "Tom", "Sam", "Bob" };

//LinkedList<string> people = new LinkedList<string>(employees);
//foreach (string person in people)
//{
//    Console.WriteLine(person);
//}

//var employees = new List<string> { "Tom", "Sam", "Bob" };

//LinkedList<string> people = new LinkedList<string>(employees);
//Console.WriteLine(people.Count);         
//Console.WriteLine(people.First?.Value);    
//Console.WriteLine(people.Last?.Value);

//LinkedList<string> people = new LinkedList<string>(new[] { "Tom", "Sam", "Bob" });

//// от начала до конца списка
//var currentNode = people.First;
//while (currentNode != null)
//{
//    Console.WriteLine(currentNode.Value);
//    currentNode = currentNode.Next;
//}

//// с конца до начала списка
//currentNode = people.Last;
//while (currentNode != null)
//{
//    Console.WriteLine(currentNode.Value);
//    currentNode = currentNode.Previous;
//}

//int[] array = new int[10] { 5, 3, 7, 7, 5, 4, 3, 3, 7, 7 };

//var max = (array.GroupBy(x => x)
//    .Select(x => new { num = x, cnt = x.Count() })
//    .OrderByDescending(g => g.cnt)
//    .Select(g => g.num).First());


//Console.WriteLine("The most frequent number in this array is {0} has been repeated {1} times.",
//    max.Key, max.Count());

//public class GenericList<T>
//{
//    public void Add(T input) { }
//}
//class TestGenericList
//{
//    private class ExampleClass { }
//    static void Main()
//    {
//        GenericList<int> list1 = new GenericList<int>();
//        list1.Add(1);

//        GenericList<string> list2 = new GenericList<string>();
//        list2.Add("");

//        GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
//        list3.Add(new ExampleClass());

//        Console.WriteLine($"{list1} {list2} {list3}");
//    }
//}


//using System;
//using System.Collections.Generic;

//class Geeks
//{

//    // Main Method
//    public static void Main(String[] args)
//    {

//        // Creating a List of integers
//        List<int> mylist = new List<int>();

//        // adding items in mylist
//        for (int j = 5; j < 10; j++)
//        {
//            mylist.Add(j * 3);
//        }

//        // Displaying items of mylist
//        // by using foreach loop
//        foreach (int items in mylist)
//        {
//            Console.WriteLine(items);
//        }
//    }
//}

//using System;
//using System.Collections;

//class GFG
//{

//    // Driver code
//    public static void Main()
//    {

//        // Creating a Queue
//        Queue myQueue = new Queue();

//        // Inserting the elements into the Queue
//        myQueue.Enqueue("C#");
//        myQueue.Enqueue("PHP");
//        myQueue.Enqueue("Perl");
//        myQueue.Enqueue("Java");
//        myQueue.Enqueue("C");

//        // Displaying the count of elements
//        // contained in the Queue
//        Console.Write("Total number of elements present in the Queue are: ");

//        Console.WriteLine(myQueue.Count);

//        // Displaying the beginning element of Queue
//        Console.WriteLine("Beginning Item is: " + myQueue.Peek());
//    }
//}


//using System.Collections;

//ArrayList arlist = new ArrayList();

//// Or 

//var arlist1 = new ArrayList();

//using System.Collections;

//var arlist1 = new ArrayList();
//arlist1.Add(1);
//arlist1.Add("Bill");
//arlist1.Add(" ");
//arlist1.Add(true);
//arlist1.Add(4.5);
//arlist1.Add(null);

//var arlist2 = new ArrayList()
//                {
//                    2, "Steve", " ", true, 4.5, null
//                };
//foreach(var ar in arlist1)
//{
//    Console.WriteLine(ar);
//}

//using System;
//using System.Collections;

//public class Program
//{
//    public static void Main()
//    {
//        var arlist1 = new ArrayList();

//        var arlist2 = new ArrayList()
//                            {
//                                1, "Bill", " ", true, 4.5, null
//                            };

//        int[] arr = { 100, 200, 300, 400 };

//        Queue myQ = new Queue();
//        myQ.Enqueue("Hello");
//        myQ.Enqueue("World!");

//        arlist1.AddRange(arlist2); //adding arraylist in arraylist 
//        arlist1.AddRange(arr); //adding array in arraylist 
//        arlist1.AddRange(myQ); //adding Queue in arraylist 

//        Console.WriteLine("ArrayList Elements");

//        for (int i = 0; i < arlist1.Count; i++)
//            Console.WriteLine(arlist1[i]);

//    }
//}

//using System.Collections;

//ArrayList arlist = new ArrayList()
//                {
//                    1,
//                    "Bill",
//                    300,
//                    4.5f
//                };

//arlist.Insert(1, "Second Item");

//foreach (var val in arlist)
//    Console.WriteLine(val);

//using System.Collections;

//ArrayList arlist1 = new ArrayList()
//                {
//                    100, 200, 600
//                };

//ArrayList arlist2 = new ArrayList()
//                {
//                    300, 400, 500
//                };
//arlist1.InsertRange(2, arlist2);

//foreach (var item in arlist1)
//    Console.Write(item + ", "); 


//using System.Collections;

//ArrayList arList = new ArrayList()
//                {
//                    1,
//                    null,
//                    "Bill",
//                    300,
//                    " ",
//                    4.5f,
//                    300,
//                };

//arList.Remove(null); //Removes first occurance of null
//arList.RemoveAt(4); //Removes element at index 4
//arList.RemoveRange(0, 2);

//foreach(var arr in arList)
//{
//    Console.WriteLine(arr); 
//}

//List<int> primeNumbers = new List<int>();
//primeNumbers.Add(1); // adding elements using add() method
//primeNumbers.Add(3);
//primeNumbers.Add(5);
//primeNumbers.Add(7);

//var cities = new List<string>();
//cities.Add("New York");
//cities.Add("London");
//cities.Add("Mumbai");
//cities.Add("Chicago");
//cities.Add(null);// nulls are allowed for reference type list

////adding elements using collection-initializer syntax
//var bigCities = new List<string>()
//                    {
//                        "New York",
//                        "London",
//                        "Mumbai",
//                        "Chicago"
//                    };

//SortedList<int, string> numberNames = new SortedList<int, string>();
//numberNames.Add(3,"Three");
//numberNames.Add(1, "One");
//numberNames.Add(2, "Two");
//numberNames.Add(4, null);
//numberNames.Add(10, "Ten");
//numberNames.Add(5, "Five");

//foreach(var number in numberNames)
//{
//    Console.WriteLine(number);  
//}

class DataStore1<T>
{
    public T Data { get; set; }
}

class KeyValuePair<TKey, TValue>
{
    public TKey Key { get; set; }
    public TValue Value { get; set; }
}