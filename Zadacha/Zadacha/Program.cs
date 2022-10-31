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