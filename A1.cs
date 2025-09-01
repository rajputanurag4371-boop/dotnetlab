//A1 Q1

class FinancialCalculator
{
    static void Main()
    {
        // Input: Array of daily transactions
        int[] transactions = { 200, -150, 340, 500, -100 };

        int totalSum = 0;

        // Loop through each transaction and add to totalSum
        for (int i = 0; i < transactions.Length; i++)
        {
            totalSum += transactions[i];
        }

        Console.WriteLine("Total sum of transactions: " + totalSum);
    }
}


//Q2
using System;

class AnalyticsTool
{
    static void Main()
    {
        // Input: Array of scores
        float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };

        float sum = 0;

        // Loop to calculate the sum of all scores
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }

        // Calculate average
        float average = sum / scores.Length;

        Console.WriteLine("Average score of the class: " + average);
    }
}


//Q3
using System;

class InventoryManagement
{
    static void Main()
    {
        // Input: Array of item prices
        int[] prices = { 1500, 2300, 999, 3200, 1750 };

        // Assume the first item is the most expensive initially
        int maxPrice = prices[0];

        // Loop to check each price
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > maxPrice)
            {
                maxPrice = prices[i]; // Update if a higher price is found
            }
            else
            {
                // Do nothing, keep current maxPrice
            }
        }

        Console.WriteLine("Most expensive item price: " + maxPrice);
    }
}


//Q4
using System;

class SurveyReport
{
    static void Main()
    {
        // Input: Participant codes
        int[] participantCodes = { 102, 215, 324, 453, 536 };

        int maleCount = 0;   // Even numbers
        int femaleCount = 0; // Odd numbers

        // Loop through all participant codes
        for (int i = 0; i < participantCodes.Length; i++)
        {
            if (participantCodes[i] % 2 == 0)
            {
                maleCount++; // Even → Male
            }
            else
            {
                femaleCount++; // Odd → Female
            }
        }

        Console.WriteLine("Number of male participants: " + maleCount);
        Console.WriteLine("Number of female participants: " + femaleCount);
    }
}


//Q5

using System;

class SearchHistoryApp
{
    static void Main()
    {
        // Input: Recent search history
        int[] searchHistory = { 101, 202, 303, 404, 505 };

        Console.WriteLine("Original Search History:");
        for (int i = 0; i < searchHistory.Length; i++)
        {
            Console.Write(searchHistory[i] + " ");
        }

        // Reverse the array using loop
        int n = searchHistory.Length;
        for (int i = 0; i < n / 2; i++)
        {
            int temp = searchHistory[i];
            searchHistory[i] = searchHistory[n - 1 - i];
            searchHistory[n - 1 - i] = temp;
        }

        Console.WriteLine("\nReversed Search History:");
        for (int i = 0; i < searchHistory.Length; i++)
        {
            Console.Write(searchHistory[i] + " ");
        }
    }
}


//Q6
using System;

class Program
{
    static void Main()
    {
        int[] measurements = { 2, 4, 6, 8 };
        int factor = 3;

        Console.WriteLine("Original measurements:");
        foreach (int value in measurements)
        {
            Console.Write(value + " ");
        }

        // Multiply each element by factor
        for (int i = 0; i < measurements.Length; i++)
        {
            measurements[i] = measurements[i] * factor;
        }

        Console.WriteLine("\nAdjusted measurements:");
        foreach (int value in measurements)
        {
            Console.Write(value + " ");
        }
    }
}



//Q7
using System;

class Program
{
    static void Main()
    {
        int[] bookCodes = { 101, 203, 304, 405, 506 };
        int searchCode = 304;
        int index = -1; // Default if not found

        // Search for the book code
        for (int i = 0; i < bookCodes.Length; i++)
        {
            if (bookCodes[i] == searchCode)
            {
                index = i;
                break; // Stop loop once found
            }
        }

        if (index != -1)
        {
            Console.WriteLine($"Book code {searchCode} found at index {index}.");
        }
        else
        {
            Console.WriteLine($"Book code {searchCode} not found in the library system.");
        }
    }
}


//Q8

using System;

class Program
{
    static void Main()
    {
        int[] grades = { 56, 78, 89, 45, 67 };

        // Sort the array using a simple loop-based Bubble Sort
        for (int i = 0; i < grades.Length - 1; i++)
        {
            for (int j = 0; j < grades.Length - i - 1; j++)
            {
                if (grades[j] > grades[j + 1])
                {
                    // Swap
                    int temp = grades[j];
                    grades[j] = grades[j + 1];
                    grades[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted grades:");
        foreach (int grade in grades)
        {
            Console.Write(grade + " ");
        }

        // The second smallest will be at index 1 after sorting
        Console.WriteLine($"\nSecond smallest grade: {grades[1]}");
    }
}


//Q9
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] ids = { 102, 215, 102, 324, 215 };
        List<int> uniqueIds = new List<int>();

        // Loop through ids and add only unique values
        for (int i = 0; i < ids.Length; i++)
        {
            if (!uniqueIds.Contains(ids[i]))
            {
                uniqueIds.Add(ids[i]);
            }
        }

        Console.WriteLine("Original IDs:");
        foreach (int id in ids)
        {
            Console.Write(id + " ");
        }

        Console.WriteLine("\nUnique IDs (duplicates removed):");
        foreach (int id in uniqueIds)
        {
            Console.Write(id + " ");
        }
    }
}


//Q10
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] dataset1 = { 1, 2, 3, 4, 5 };
        int[] dataset2 = { 3, 4, 5, 6, 7 };
        List<int> commonElements = new List<int>();

        // Loop through first dataset
        for (int i = 0; i < dataset1.Length; i++)
        {
            // Check if element exists in dataset2
            for (int j = 0; j < dataset2.Length; j++)
            {
                if (dataset1[i] == dataset2[j])
                {
                    // Avoid duplicates in the commonElements list
                    if (!commonElements.Contains(dataset1[i]))
                    {
                        commonElements.Add(dataset1[i]);
                    }
                }
            }
        }

        Console.WriteLine("Common elements between the datasets:");
        foreach (int elem in commonElements)
        {
            Console.Write(elem + " ");
        }
    }
}
