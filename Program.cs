using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace IntroductionToProgramming//ProgrammingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction to Programming
            // Console.WriteLine("Running Introduction to Programming (Basic Syntax)...");
            // IntroductionToProgramming.VariablesAndDataTypes.RunExample();
            // IntroductionToProgramming.ControlStructures.RunExample();
            // IntroductionToProgramming.BasicSyntax.RunExample();

            // Data Structures
            // Console.WriteLine("Running Data Structures...");
            // DataStructures.Arrays.ArraysBasics.RunExample();
            // DataStructures.Strings.StringManipulation.RunExample();
            // DataStructures.Dictionaries.DictionaryOperations.RunExample();

            // Sorting Algorithms
            // Console.WriteLine("Running Sorting Algorithms...");
            // SortingAlgorithms.BubbleSort.RunExample();
            // SortingAlgorithms.QuickSort.RunExample();
            // SortingAlgorithms.MergeSort.RunExample();

            // Searching Algorithms
            // Console.WriteLine("Running Searching Algorithms...");
            // SearchingAlgorithms.BinarySearch.RunExample();
            // SearchingAlgorithms.LinearSearch.RunExample();
            // SearchingAlgorithms.SearchTimeComparison.RunExample();

            // Big O Notation
            // Console.WriteLine("Running Big O Notation Examples...");
            // BigOExamples.BigOExamples.RunExample();

            // Algorithms (Recursion, Divide and Conquer, Dynamic Programming)
            // Console.WriteLine("Running Algorithms...");
            // Algorithms.Recursion.Fibonacci.RunExample();
            // Algorithms.DivideAndConquer.MergeSort.RunExample();
            // Algorithms.DynamicProgramming.KnapsackProblem.RunExample();

            // Object-Oriented Programming (OOP)
            // Console.WriteLine("Running Object-Oriented Programming Examples...");
            // OOPs.ClassesAndObjects.ClassesAndObjectsExample.RunExample();
            // OOPs.Inheritance.InheritanceExample.RunExample();
            // OOPs.Polymorphism.PolymorphismExample.RunExample();
            // OOPs.Interfaces.InterfacesExample.RunExample();

            // Program execution completed
            // Console.WriteLine("\nProgram execution completed.");

            Console.WriteLine("RUNNING IN CLASS ACTIVITIES"); 

            //Declare a dictionary: 
            Dictionary<int, double> myDic = new Dictionary<int, double>();

            Random random = new Random();

            int minKey = 1; 
            int maxKey = 20;
            List<int> list = new List<int>();
            int num = 0;
            while (true){
                int key = random.Next(minKey, maxKey);
                Console.WriteLine($"The key {key} has been generated");
                if (list.Contains(key) == false){
                    list.Add(key);
                    num++;
                }
                if (num == 10) 
                {
                    Console.WriteLine("Lenght  = "+ list.Count);
                    break;
                }
            }
            foreach (int key in list)
            {
                
                Console.WriteLine("Key is " + key);
                myDic.Add(key, random.NextDouble());
            }

            foreach (var kvp in myDic)
            {
                Console.WriteLine($"The key {kvp.Key} has value of {kvp.Value}");
            }

            for (int i = 0; i < 10; i++){
                if (myDic.ContainsKey(i))
                    Console.WriteLine($"The value of the key {i} is {myDic[i]}");
                else
                    Console.WriteLine($"No value of the key {i}");
            }
        }
    }
}
