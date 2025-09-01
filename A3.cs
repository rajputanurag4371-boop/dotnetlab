//Instance Class
//Q1
using System;
class Employee
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    // Constructor
    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    // Method to display employee details
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Salary: " + Salary);
        Console.WriteLine("---------------------------");
    }
}

//Q2
class BankAccount
{
    // Properties
    public string AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public double Balance { get; private set; }  // Balance is private set to control via deposit/withdrawal

    // Constructor
    public BankAccount(string accountNumber, string accountHolderName, double initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount} successfully. New balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Withdrawal method
    public void Withdraw(double amount)
    {
        if (amount > 0)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount} successfully. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        else
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
    }

    // Display account details
    public void DisplayAccountDetails()
    {
        Console.WriteLine("Bank Account Details:");
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Account Holder: " + AccountHolderName);
        Console.WriteLine("Balance: " + Balance);
        Console.WriteLine("---------------------------");
    }
}

// Test Program
class Program
{
    static void Main(string[] args)
    {
        // Test Employee
        Employee emp = new Employee("Alice", 28, 50000);
        emp.DisplayEmployeeDetails();

        // Test BankAccount
        BankAccount account = new BankAccount("1234567890", "Bob", 10000);
        account.DisplayAccountDetails();

        account.Deposit(5000);   // Deposit money
        account.Withdraw(3000);  // Withdraw money
        account.Withdraw(15000); // Try to withdraw more than balance
        account.DisplayAccountDetails();
    }
}
//Q3
using System;
static class MathHelper
{
    // Static method to calculate average of an integer array
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            Console.WriteLine("Array is empty or null.");
            return 0;
        }

        double sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return sum / numbers.Length;
    }
}

//Q4
static class Logger
{
    // Static method to log message on console
    public static void LogMessage(string message)
    {
        Console.WriteLine($"[LOG - {DateTime.Now}] {message}");
    }
}

// Test Program
class Program
{
    static void Main(string[] args)
    {
        // Test MathHelper
        int[] scores = { 85, 90, 78, 92, 88 };
        double average = MathHelper.CalculateAverage(scores);
        Console.WriteLine("Average Score: " + average);

        // Test Logger
        Logger.LogMessage("Application started.");
        Logger.LogMessage("Average calculated successfully.");
        Logger.LogMessage("Application ended.");
    }
}
//Q5
// This file contains the properties part of the partial class
public partial class Person
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
// This file contains the methods part of the partial class
public partial class Person
{
    // Method to print full name
    public void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Person object
        Person person = new Person("Alice", "Johnson");

        // Display full name using method
        person.PrintFullName();
    }
}
//Q6
// This file contains the properties part of the partial class
public partial class Employee
{
    // Properties
    public string Name { get; set; }
    public int ID { get; set; }
    public double BaseSalary { get; set; }
    public int HoursWorked { get; set; }
    public double Bonus { get; set; }

    // Constructor
    public Employee(string name, int id, double baseSalary, int hoursWorked, double bonus)
    {
        Name = name;
        ID = id;
        BaseSalary = baseSalary;
        HoursWorked = hoursWorked;
        Bonus = bonus;
    }
}
// This file contains the methods part of the partial class
public partial class Employee
{
    // Method to calculate total salary (Base + Bonus)
    public double CalculateTotalSalary()
    {
        return BaseSalary + Bonus;
    }

    // Method to calculate hourly wage (BaseSalary / HoursWorked)
    public double CalculateHourlyWage()
    {
        if (HoursWorked <= 0)
            return 0;
        return BaseSalary / HoursWorked;
    }

    // Method to display employee details
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"ID: {ID}, Name: {Name}");
        Console.WriteLine($"Base Salary: {BaseSalary}, Bonus: {Bonus}");
        Console.WriteLine($"Total Salary: {CalculateTotalSalary()}");
        Console.WriteLine($"Hourly Wage: {CalculateHourlyWage():F2}");
        Console.WriteLine("----------------------------");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object
        Employee emp = new Employee("Alice", 101, 50000, 160, 5000);

        // Display details and calculate salary
        emp.DisplayEmployeeDetails();
    }
}
//Q7
using System;

// Abstract base class
abstract class Shape
{
    // Abstract method to calculate area
    public abstract double CalculateArea();
}

// Derived class for Circle
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Override CalculateArea for circle
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Derived class for Rectangle
class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    // Override CalculateArea for rectangle
    public override double CalculateArea()
    {
        return Length * Width;
    }
}

// Test Program
class Program
{
    static void Main(string[] args)
    {
        // Circle with radius 5
        Shape circle = new Circle(5);
        Console.WriteLine("Circle Area: " + circle.CalculateArea());

        // Rectangle with length 10 and width 4
        Shape rectangle = new Rectangle(10, 4);
        Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
    }
}
//Q8
using System;

// Abstract base class
abstract class Animal
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Abstract method to make sound
    public abstract void MakeSound();

    // Method to display basic info
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Derived class Dog
class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {
    }

    // Implement abstract method
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Woof Woof!");
    }

    // Unique method for Dog
    public void Fetch()
    {
        Console.WriteLine($"{Name} is fetching the ball!");
    }
}

// Derived class Cat
class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {
    }

    // Implement abstract method
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow Meow!");
    }

    // Unique method for Cat
    public void Scratch()
    {
        Console.WriteLine($"{Name} is scratching the furniture!");
    }
}

// Test Program
class Program
{
    static void Main(string[] args)
    {
        // Dog object
        Dog dog = new Dog("Buddy", 3);
        dog.DisplayInfo();
        dog.MakeSound();
        dog.Fetch();
        Console.WriteLine();

        // Cat object
        Cat cat = new Cat("Whiskers", 2);
        cat.DisplayInfo();
        cat.MakeSound();
        cat.Scratch();
    }
}


//Q9
using System;

// Base class
class Vehicle
{
    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }
}

// Sealed derived class
sealed class Car : Vehicle
{
    public string Model { get; set; }

    public Car(string model)
    {
        Model = model;
    }

    public void DisplayModel()
    {
        Console.WriteLine("Car Model: " + Model);
    }
}

// Trying to inherit from sealed class (will cause a compile-time error)
/*
class SportsCar : Car
{
}
*/

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota Corolla");
        myCar.StartEngine();
        myCar.DisplayModel();
        myCar.StopEngine();

        // Uncommenting the SportsCar class above will cause a compilation error:
        // "Cannot derive from sealed type 'Car'"
    }
}


//Q10
using System;

// Base class
class BankAccount
{
    // Properties
    public string AccountNumber { get; set; }
    public double Balance { get; protected set; } // Protected setter to allow derived class to modify

    // Constructor
    public BankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount}. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }

    // Display account details
    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance}");
    }
}

// Sealed derived class
sealed class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; } // Annual interest rate in percentage

    public SavingsAccount(string accountNumber, double initialBalance, double interestRate)
        : base(accountNumber, initialBalance)
    {
        InterestRate = interestRate;
    }

    // Method to calculate interest
    public double CalculateInterest(int months)
    {
        double interest = Balance * (InterestRate / 100) * (months / 12.0);
        return interest;
    }

    // Method to add interest to balance
    public void AddInterest(int months)
    {
        double interest = CalculateInterest(months);
        Balance += interest;
        Console.WriteLine($"Interest of {interest} added for {months} months. New Balance: {Balance}");
    }
}

// Test Program
class Program
{
    static void Main(string[] args)
    {
        SavingsAccount savings = new SavingsAccount("SA12345", 10000, 5); // 5% annual interest
        savings.DisplayAccountDetails();

        savings.Deposit(2000);
        savings.Withdraw(1500);

        double interest = savings.CalculateInterest(6); // Calculate interest for 6 months
        Console.WriteLine($"Interest for 6 months: {interest}");

        savings.AddInterest(6); // Add interest to balance
        savings.DisplayAccountDetails();
    }
}
