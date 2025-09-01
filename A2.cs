//Q1

using System;

class UserProfile
{
    // Private fields
    private string username;
    private string password;
    private string email;

    // Public getter and setter for Username
    public string Username
    {
        get { return username; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                username = value;
            else
                Console.WriteLine("Username cannot be empty.");
        }
    }

    // Public getter and setter for Password
    public string Password
    {
        get { return password; }
        set
        {
            if (value.Length >= 6)
                password = value;
            else
                Console.WriteLine("Password must be at least 6 characters long.");
        }
    }

    // Public getter and setter for Email
    public string Email
    {
        get { return email; }
        set
        {
            if (value.Contains("@"))
                email = value;
            else
                Console.WriteLine("Email must contain '@'.");
        }
    }

    // Method to display user details (excluding password for security)
    public void DisplayInfo()
    {
        Console.WriteLine($"Username: {username}");
        Console.WriteLine($"Email: {email}");
    }
}

class Program
{
    static void Main()
    {
        // Creating first user
        UserProfile user1 = new UserProfile();
        user1.Username = "Anurag";
        user1.Password = "pass123";
        user1.Email = "anurag@example.com";

        // Creating second user
        UserProfile user2 = new UserProfile();
        user2.Username = "Riya";
        user2.Password = "riya12";
        user2.Email = "riya@example.com";

        // Displaying user details
        Console.WriteLine("User 1 Details:");
        user1.DisplayInfo();

        Console.WriteLine("\nUser 2 Details:");
        user2.DisplayInfo();

        // Testing validation
        Console.WriteLine("\nTesting invalid data:");
        user2.Password = "123";       // Invalid password
        user2.Email = "riyaexample";  // Invalid email
    }
}


//Q2

using System;

// Base class
class Vehicle
{
    // Properties common to all vehicles
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Constructor
    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
}

// Derived class Truck
class Truck : Vehicle
{
    public int LoadCapacity { get; set; } // in tons

    public Truck(string make, string model, int year, int loadCapacity)
        : base(make, model, year)
    {
        LoadCapacity = loadCapacity;
    }

    // Display truck details
    public void DisplayDetails()
    {
        Console.WriteLine("Truck Details:");
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Load Capacity: {LoadCapacity} tons\n");
    }
}

// Derived class Bus
class Bus : Vehicle
{
    public int PassengerCapacity { get; set; }

    public Bus(string make, string model, int year, int passengerCapacity)
        : base(make, model, year)
    {
        PassengerCapacity = passengerCapacity;
    }

    // Display bus details
    public void DisplayDetails()
    {
        Console.WriteLine("Bus Details:");
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Passenger Capacity: {PassengerCapacity}\n");
    }
}

// Test program
class Program
{
    static void Main()
    {
        Truck truck1 = new Truck("Volvo", "FH16", 2020, 20);
        Bus bus1 = new Bus("Mercedes", "Sprinter", 2019, 30);

        truck1.DisplayDetails();
        bus1.DisplayDetails();
    }
}



//Q3
using System;

class Calculator
{
    // Add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Add three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Add two floats
    public float Add(float a, float b)
    {
        return a + b;
    }

    // Add two doubles
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Add three doubles
    public double Add(double a, double b, double c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        // Testing integer addition
        Console.WriteLine("Add(int, int): " + calc.Add(5, 10));
        Console.WriteLine("Add(int, int, int): " + calc.Add(1, 2, 3));

        // Testing float addition
        Console.WriteLine("Add(float, float): " + calc.Add(2.5f, 3.7f));

        // Testing double addition
        Console.WriteLine("Add(double, double): " + calc.Add(1.2, 3.4));
        Console.WriteLine("Add(double, double, double): " + calc.Add(1.1, 2.2, 3.3));
    }
}


//Q4

using System;

// Abstract base class
abstract class Employee
{
    public string Name { get; set; }
    public int ID { get; set; }

    public Employee(string name, int id)
    {
        Name = name;
        ID = id;
    }

    // Abstract method to calculate salary
    public abstract double CalculateSalary();
}

// Derived class for full-time employees
class FullTimeEmployee : Employee
{
    public double MonthlySalary { get; set; }

    public FullTimeEmployee(string name, int id, double monthlySalary)
        : base(name, id)
    {
        MonthlySalary = monthlySalary;
    }

    public override double CalculateSalary()
    {
        return MonthlySalary; // Full-time salary is fixed
    }
}

// Derived class for part-time employees
class PartTimeEmployee : Employee
{
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public PartTimeEmployee(string name, int id, double hourlyRate, int hoursWorked)
        : base(name, id)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override double CalculateSalary()
    {
        return HourlyRate * HoursWorked; // Part-time salary based on hours worked
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate FullTimeEmployee
        FullTimeEmployee ftEmployee = new FullTimeEmployee("Alice", 101, 50000);
        Console.WriteLine($"Full-time Employee: {ftEmployee.Name}, Salary: {ftEmployee.CalculateSalary()}");

        // Instantiate PartTimeEmployee
        PartTimeEmployee ptEmployee = new PartTimeEmployee("Bob", 102, 500, 80);
        Console.WriteLine($"Part-time Employee: {ptEmployee.Name}, Salary: {ptEmployee.CalculateSalary()}");
    }
}

//Q5
using System;

class Student
{
    // Properties
    public string Name { get; set; }
    public int RollNumber { get; set; }
    public double Marks { get; set; }

    // Default constructor
    public Student()
    {
        Name = "Unknown";
        RollNumber = 0;
        Marks = 0;
    }

    // Constructor with name and roll number
    public Student(string name, int rollNumber)
    {
        Name = name;
        RollNumber = rollNumber;
        Marks = 0; // default marks
    }

    // Constructor with name, roll number, and marks
    public Student(string name, int rollNumber, double marks)
    {
        Name = name;
        RollNumber = rollNumber;
        Marks = marks;
    }

    // Method to display student data
    public void DisplayStudent()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Roll Number: " + RollNumber);
        Console.WriteLine("Marks: " + Marks);
        Console.WriteLine("---------------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using default constructor
        Student student1 = new Student();
        student1.DisplayStudent();

        // Using constructor with name and roll number
        Student student2 = new Student("Alice", 101);
        student2.DisplayStudent();

        // Using constructor with name, roll number, and marks
        Student student3 = new Student("Bob", 102, 88.5);
        student3.DisplayStudent();
    }
}


//Q6
using System;

class Product
{
    // Auto-implemented properties with validation in setter
    private int productID;
    public int ProductID
    {
        get { return productID; }
        set
        {
            if (value > 0)
                productID = value;
            else
                Console.WriteLine("ProductID must be positive.");
        }
    }

    private string productName;
    public string ProductName
    {
        get { return productName; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                productName = value;
            else
                Console.WriteLine("ProductName cannot be empty.");
        }
    }

    private double price;
    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
                price = value;
            else
                Console.WriteLine("Price cannot be negative.");
        }
    }

    private int quantity;
    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (value >= 0)
                quantity = value;
            else
                Console.WriteLine("Quantity cannot be negative.");
        }
    }

    // Method to print product details
    public void PrintProductDetails()
    {
        Console.WriteLine("Product ID: " + ProductID);
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine("-----------------------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Valid product
        Product product1 = new Product();
        product1.ProductID = 101;
        product1.ProductName = "Laptop";
        product1.Price = 75000;
        product1.Quantity = 10;
        product1.PrintProductDetails();

        // Invalid product (negative price and quantity)
        Product product2 = new Product();
        product2.ProductID = 102;
        product2.ProductName = "Smartphone";
        product2.Price = -5000; // invalid
        product2.Quantity = -3; // invalid
        product2.PrintProductDetails();
    }
}


//Q7
using System;
using System.Collections.Generic;

// Base class for a person
class Person
{
    public string Name { get; set; }
    public int ID { get; set; }

    public Person(string name, int id)
    {
        Name = name;
        ID = id;
    }

    // Virtual method to display details (can be overridden)
    public virtual void Display()
    {
        Console.WriteLine($"ID: {ID}, Name: {Name}");
    }
}

// Member class inherits from Person
class Member : Person
{
    public List<Book> BorrowedBooks { get; private set; }

    public Member(string name, int id) : base(name, id)
    {
        BorrowedBooks = new List<Book>();
    }

    // Override display method
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Borrowed Books Count: " + BorrowedBooks.Count);
    }
}

// Book class
class Book
{
    public int BookID { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; } = true; // Book availability

    public Book(int bookID, string title, string author)
    {
        BookID = bookID;
        Title = title;
        Author = author;
    }

    public void DisplayBook()
    {
        Console.WriteLine($"BookID: {BookID}, Title: {Title}, Author: {Author}, Available: {IsAvailable}");
    }
}

// Library class
class Library
{
    private List<Book> books;
    private List<Member> members;

    public Library()
    {
        books = new List<Book>();
        members = new List<Member>();
    }

    // Add a book
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to library.");
    }

    // Register a member
    public void RegisterMember(Member member)
    {
        members.Add(member);
        Console.WriteLine($"Member '{member.Name}' registered successfully.");
    }

    // Lend a book to a member
    public void LendBook(int bookID, int memberID)
    {
        Book book = books.Find(b => b.BookID == bookID);
        Member member = members.Find(m => m.ID == memberID);

        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }
        if (member == null)
        {
            Console.WriteLine("Member not found.");
            return;
        }
        if (!book.IsAvailable)
        {
            Console.WriteLine($"Book '{book.Title}' is currently not available.");
            return;
        }

        book.IsAvailable = false;
        member.BorrowedBooks.Add(book);
        Console.WriteLine($"Book '{book.Title}' lent to member '{member.Name}'.");
    }

    // Display available books
    public void DisplayAvailableBooks()
    {
        Console.WriteLine("\nAvailable Books:");
        foreach (var book in books)
        {
            if (book.IsAvailable)
                book.DisplayBook();
        }
        Console.WriteLine();
    }

    // Display all members
    public void DisplayMembers()
    {
        Console.WriteLine("\nRegistered Members:");
        foreach (var member in members)
        {
            member.Display();
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create library
        Library library = new Library();

        // Add books
        library.AddBook(new Book(1, "C# Programming", "John Doe"));
        library.AddBook(new Book(2, "OOP Concepts", "Jane Smith"));
        library.AddBook(new Book(3, "Data Structures", "Alice Brown"));

        // Register members
        library.RegisterMember(new Member("Bob", 101));
        library.RegisterMember(new Member("Alice", 102));

        // Display available books
        library.DisplayAvailableBooks();

        // Lend a book
        library.LendBook(1, 101); // Lend "C# Programming" to Bob
        library.LendBook(2, 102); // Lend "OOP Concepts" to Alice

        // Display updated available books
        library.DisplayAvailableBooks();

        // Display members and their borrowed books
        library.DisplayMembers();
    }
}
